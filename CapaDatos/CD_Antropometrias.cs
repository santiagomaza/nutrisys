using System.Data;
using CapaDatos.Enums;
using MySql.Data.MySqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class CD_Antropometrias
    {
        MySqlDataReader lector;
        public DataTable MostrarDatosAntropometricosPaciente(Guid pacienteID)
        {
            DataTable tabla = new();

            using(MySqlConnection conexion = new(ConexionBD.Cadena))
            {
                try
                {
                    conexion.Open();

                    string query = "ListarDatosAntropometricos;";

                    MySqlCommand cmd = new(query, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idPaciente", pacienteID);

                    lector = cmd.ExecuteReader();

                    tabla.Load(lector);
                }
                catch (MySqlException ex)
                {
                    throw new Exception("Error al recuperar los datos antropométricos del paciente", ex);
                }
                return tabla;
            }
        }
        public DataTable FiltrarDatosAntropometricos(Guid idPaciente, DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable datosAntropometricosFiltrados = new();

            using MySqlConnection conexion = new(ConexionBD.Cadena);

            try
            {
                conexion.Open();

                string query = "FiltrarDatosAntropometricos;";

                MySqlCommand cmd = new(query, conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idPaciente", idPaciente);
                cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@fechaFin", fechaFin);

                lector = cmd.ExecuteReader();

                datosAntropometricosFiltrados.Columns.Add("Peso");
                datosAntropometricosFiltrados.Columns.Add("Talla");
                datosAntropometricosFiltrados.Columns.Add("IMC");
                datosAntropometricosFiltrados.Columns.Add("MusculoEsqueletico");
                datosAntropometricosFiltrados.Columns.Add("PorcentajeGC");
                datosAntropometricosFiltrados.Columns.Add("NivelGV");
                datosAntropometricosFiltrados.Columns.Add("EdadCorporal");
                datosAntropometricosFiltrados.Columns.Add("Evolucion");
                datosAntropometricosFiltrados.Columns.Add("Paciente");
                datosAntropometricosFiltrados.Columns.Add("ID_Paciente");
                datosAntropometricosFiltrados.Columns.Add("ID_Antropometria");
                datosAntropometricosFiltrados.Columns.Add("FechaUltimaModificacion");

                while (lector.Read())
                {
                    DataRow fila = datosAntropometricosFiltrados.NewRow();

                    fila["Peso"] = lector["Peso"].ToString();
                    fila["Talla"] = lector["Talla"].ToString();
                    fila["IMC"] = lector["IMC"].ToString();
                    fila["MusculoEsqueletico"] = lector["MusculoEsqueletico"].ToString();
                    fila["PorcentajeGC"] = lector["PorcentajeGC"].ToString();
                    fila["NivelGV"] = lector["NivelGV"].ToString();
                    fila["EdadCorporal"] = lector["EdadCorporal"].ToString();
                    fila["Evolucion"] = lector["Evolucion"];
                    fila["Paciente"] = lector["Paciente"].ToString();
                    fila["ID_Paciente"] = lector["ID_Paciente"].ToString();
                    fila["ID_Antropometria"] = lector["ID_Antropometria"].ToString();
                    fila["FechaUltimaModificacion"] = lector["FechaUltimaModificacion"];

                    datosAntropometricosFiltrados.Rows.Add(fila);
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error al filtrar los datos antropometricos del paciente", ex);
            }
            return datosAntropometricosFiltrados;
        }
        public DateTime? ObtenerUltimaFechaModificacion(Guid idPaciente)
        {
            using MySqlConnection conn = new(ConexionBD.Cadena);

            try
            {
                conn.Open();

                string query = "SELECT MAX(FechaUltimaModificacion) FROM nutrisys.Antropometrias WHERE ID_Paciente = @idPaciente;";

                MySqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@idPaciente", idPaciente);

                var resultado = cmd.ExecuteScalar();

                if(resultado != null && resultado != DBNull.Value)
                    return Convert.ToDateTime(resultado);
                else return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public CodigosStatus AgregarDatosAntropometricos(DatoAntropometrico DA)
        {
            using MySqlConnection conexion = new(ConexionBD.Cadena);

            try
            {
                conexion.Open();

                string query = "AgregarDatoAntropometrico";

                MySqlCommand cmd = new(query, conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_ID_Antropometria", DA.IdDatoAntropometrico);
                cmd.Parameters.AddWithValue("@p_Peso", DA.Peso);
                cmd.Parameters.AddWithValue("@p_Talla", DA.Talla);
                cmd.Parameters.AddWithValue("@p_IMC", DA.IMC);
                cmd.Parameters.AddWithValue("@p_MusculoEsqueletico", DA.MusculoEsqueletico);
                cmd.Parameters.AddWithValue("@p_PorcentajeGC", DA.MusculoEsqueletico);
                cmd.Parameters.AddWithValue("@p_NivelGV", DA.NivelGV);
                cmd.Parameters.AddWithValue("@p_EdadCorporal", DA.EdadCorporal);
                cmd.Parameters.AddWithValue("@p_Evolucion", DA.FechaEvolucion);
                cmd.Parameters.AddWithValue("@p_FechaUltimaModificacion", DA.FechaUltimaModificacion);
                cmd.Parameters.AddWithValue("@p_ID_Paciente", DA.IdPaciente);  

                int resultado = cmd.ExecuteNonQuery();

                return resultado > 0 ? CodigosStatus.Ok : CodigosStatus.Error;
            }
            catch (MySqlException ex)
            {
                if(ex.Number == 10031)
                {
                    return CodigosStatus.Duplicado;
                }
                return CodigosStatus.Error;
            }
        }
        public CodigosStatus EditarDatoAntropometrico(DatoAntropometrico DA)
        {
            using MySqlConnection conexion = new(ConexionBD.Cadena);

            try
            {
                conexion.Open();

                string query = "UPDATE nutrisys.Antropometrias SET Peso = @peso, Talla = @talla, IMC = @imc, MusculoEsqueletico = @me, PorcentajeGC = @porcGC, NivelGV = @nivelGV, EdadCorporal = @edadCorp, Evolucion = @evolucion, FechaUltimaModificacion = @fechaUM, id_Paciente = @id_Paciente WHERE ID_Antropometria = @id_Ant;";

                MySqlCommand cmd = new(query, conexion);

                cmd.Parameters.AddWithValue("@peso", DA.Peso);
                cmd.Parameters.AddWithValue("@talla", DA.Talla);
                cmd.Parameters.AddWithValue("@imc", DA.IMC);
                cmd.Parameters.AddWithValue("@me", DA.MusculoEsqueletico);
                cmd.Parameters.AddWithValue("@porcGC", DA.PorcentajeGC);
                cmd.Parameters.AddWithValue("@nivelGV", DA.NivelGV);
                cmd.Parameters.AddWithValue("@edadCorp", DA.EdadCorporal);
                cmd.Parameters.AddWithValue("@evolucion", DA.FechaEvolucion);
                cmd.Parameters.AddWithValue("@fechaUM", DA.FechaUltimaModificacion);
                cmd.Parameters.AddWithValue("@id_Paciente", DA.IdPaciente);
                cmd.Parameters.AddWithValue("@id_Ant", DA.IdDatoAntropometrico);

                int resultado = cmd.ExecuteNonQuery();

                return resultado > 0 ? CodigosStatus.Ok : CodigosStatus.Error;
            }
            catch (MySqlException ex)
            {
                if(ex.Number == 1062)
                {
                    return CodigosStatus.Duplicado;
                }
                return CodigosStatus.Error;
            }
        }
    }
}