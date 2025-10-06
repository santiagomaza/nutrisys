using System.Data;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class CD_HistoriasClinicas
    {
        MySqlDataReader lector;
        public DataTable MostrarHistoriasClinicas(Guid paciente)
        {
            DataTable listaHistoriasClinicas = new();

            using MySqlConnection conexion = new MySqlConnection(ConexionBD.Cadena);

            try
            {
                conexion.Open();

                string query = "ListarHistoriasClinicas;";

                MySqlCommand cmd = new(query, conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idPaciente", paciente);

                lector = cmd.ExecuteReader();

                listaHistoriasClinicas.Load(lector);
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error al recuperar los datos de historia clinica", ex);
            }
            return listaHistoriasClinicas;
        }
        public DataTable FiltrarHistoriaClinicaPorFecha(Guid idPaciente, DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable listaHistoriaClinicaFiltrada = new();

            using MySqlConnection conn = new(ConexionBD.Cadena);

            try
            {
                conn.Open();

                string query = "SELECT UPPER(CONCAT(P.Apellido, ', ', P.Nombre)) AS Paciente, DATE_FORMAT(HC.FechaConsulta, '%d/%m/%Y') AS 'Fecha de Consulta', HC.ObservacionPlano AS 'Observación', HC.ObservacionFormateada, HC.Id_Paciente, HC.ID_HistCl, HC.FechaUltimaModificacion, HC.Ruta, CASE WHEN HC.HayArchivo IS NOT NULL AND HC.HayArchivo != 'No' THEN 'Hay archivo adjunto' ELSE 'No hay archivo adjunto' END AS Archivo FROM nutrisys.HistoriasClinicas AS HC JOIN nutrisys.Pacientes AS P ON HC.Id_Paciente = P.ID_Paciente WHERE P.ID_Paciente = @idPaciente AND HC.FechaConsulta BETWEEN @fechaInicio AND @fechaFin ORDER BY HC.FechaConsulta ASC;";

                MySqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@idPaciente", idPaciente);
                cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@fechaFin", fechaFin);

                lector = cmd.ExecuteReader();

                listaHistoriaClinicaFiltrada.Columns.Add("Paciente");
                listaHistoriaClinicaFiltrada.Columns.Add("Fecha de Consulta");
                listaHistoriaClinicaFiltrada.Columns.Add("Observación");
                listaHistoriaClinicaFiltrada.Columns.Add("ObservacionFormateada");
                listaHistoriaClinicaFiltrada.Columns.Add("Id_Paciente");
                listaHistoriaClinicaFiltrada.Columns.Add("ID_HistCl");
                listaHistoriaClinicaFiltrada.Columns.Add("FechaUltimaModificacion");
                listaHistoriaClinicaFiltrada.Columns.Add("Ruta");
                listaHistoriaClinicaFiltrada.Columns.Add("Archivo");

                while (lector.Read())
                {
                    DataRow fila = listaHistoriaClinicaFiltrada.NewRow();

                    fila["Paciente"] = lector["Paciente"].ToString();
                    fila["Fecha de Consulta"] = lector["Fecha de Consulta"];
                    fila["Observación"] = lector["Observación"].ToString();
                    fila["ObservacionFormateada"] = lector["ObservacionFormateada"];
                    fila["Id_Paciente"] = lector["Id_Paciente"].ToString();
                    fila["ID_HistCl"] = lector["ID_HistCl"].ToString();
                    fila["FechaUltimaModificacion"] = lector["FechaUltimaModificacion"];
                    fila["Ruta"] = lector["Ruta"].ToString();
                    fila["Archivo"] = lector["Archivo"].ToString();

                    listaHistoriaClinicaFiltrada.Rows.Add(fila);
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No fue posible recuperar los datos de la historia clinica en las fechas establecidas", ex);
            }
            return listaHistoriaClinicaFiltrada;
        }
        public string RetornarDescripcionRTF(Guid idHistCl)
        {
            string rtf = string.Empty;

            using MySqlConnection conn = new MySqlConnection(ConexionBD.Cadena);

            try
            {
                conn.Open();

                string query = "SELECT ObservacionFormateada FROM nutrisys.HistoriasClinicas WHERE ID_HistCl = @idHistCl";

                MySqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@idHistCl", idHistCl);

                lector = cmd.ExecuteReader();

                if (lector.Read())
                    rtf = lector["ObservacionFormateada"].ToString();
            }
            catch (MySqlException ex)
            {
                throw new Exception("No fue posible retornar la descripción en formato RTF", ex);
            }
            return rtf;
        }
        public void NuevaHistoriaClinica(Guid idHistoriaClinica, Guid id_Paciente, string observacionPlano, string observacionFormateada, DateTime fechaConsulta, DateTime fechaUltimaModificacion, string ruta_imagen)
        {
            using MySqlConnection conexion = new MySqlConnection(ConexionBD.Cadena);

            try
            {
                conexion.Open();

                string query = "InsertarHistoriaClinica";

                MySqlCommand cmd = new(query, conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_ID_HistCl", idHistoriaClinica);
                cmd.Parameters.AddWithValue("@p_Id_Paciente", id_Paciente);
                cmd.Parameters.AddWithValue("@p_ObservacionPlano", observacionPlano);
                cmd.Parameters.AddWithValue("@p_ObservacionFormateada", observacionFormateada);
                cmd.Parameters.AddWithValue("@p_FechaConsulta", fechaConsulta);
                cmd.Parameters.AddWithValue("@p_FechaUltimaModificacion", fechaUltimaModificacion);
                cmd.Parameters.AddWithValue("@p_Ruta", ruta_imagen);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error al ingresar una nueva historia clinica", ex);
            }
        }
        public void EditarHistoriaClinica(Guid idHistCl, Guid id_Paciente, string observacionPlano, string observacionRTF, DateTime fechaConsulta, DateTime fechaUltimaModificacion, string ruta_imagen)
        {
            using MySqlConnection conn = new(ConexionBD.Cadena);

            try
            {
                conn.Open();

                string query = "UPDATE nutrisys.HistoriasClinicas SET Id_Paciente = @idPaciente, ObservacionPlano = @observacionPlano, ObservacionFormateada = @observacionRTF, FechaConsulta = @fechaConsulta, FechaUltimaModificacion = @fechaUM, Ruta = @rutaArchivo, HayArchivo = CASE WHEN @rutaArchivo IS NOT NULL AND @rutaArchivo != '' THEN 'Si' ELSE 'No' END WHERE ID_HistCl = @idHistCl;";

                MySqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@idPaciente", id_Paciente);
                cmd.Parameters.AddWithValue("@observacionPlano", observacionPlano);
                cmd.Parameters.AddWithValue("@observacionRTF", observacionRTF);
                cmd.Parameters.AddWithValue("@fechaConsulta", fechaConsulta);
                cmd.Parameters.AddWithValue("@fechaUM", fechaUltimaModificacion);
                cmd.Parameters.AddWithValue("@rutaArchivo", ruta_imagen);
                cmd.Parameters.AddWithValue("@idHistCl", idHistCl);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error al editar la historia clinica", ex);
            }
        }
        public void BorrarArchivoDeHistoriaClinica(Guid idHistoriaClinica)
        {
            using MySqlConnection conn = new(ConexionBD.Cadena);

            try
            {
                conn.Open();

                string query = "UPDATE nutrisys.HistoriasClinicas SET Ruta = '', HayArchivo = 'No' WHERE ID_HistCl = @idHistCl;";

                MySqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@idHistCl", idHistoriaClinica);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error al borrar el archivo adjunto", ex);
            }
        }
    }
}