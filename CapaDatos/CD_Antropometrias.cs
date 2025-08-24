using System.Data;
using CapaDatos.Enums;
using MySql.Data.MySqlClient;

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

                string query = "SELECT MAX(FechaUltimaModificacion) FROM Antropometrias WHERE ID_Paciente = @idPaciente;";

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
        public CodigosStatus AgregarDatosAntropometricos(Guid id, decimal? peso, decimal? talla, decimal? IMC, decimal? musculoEsqueletico, decimal? porcentajeGC, decimal? nivelGV, int? edadCorporal, DateTime fechaEvolucion, DateTime fechaUltimaModificacion, Guid id_Paciente)
        {
            using MySqlConnection conexion = new(ConexionBD.Cadena);

            try
            {
                conexion.Open();

                string query = "AgregarDatoAntropometrico";

                MySqlCommand cmd = new(query, conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_ID_Antropometria", id);
                cmd.Parameters.AddWithValue("@p_Peso", peso);
                cmd.Parameters.AddWithValue("@p_Talla", talla);
                cmd.Parameters.AddWithValue("@p_IMC", IMC);
                cmd.Parameters.AddWithValue("@p_MusculoEsqueletico", musculoEsqueletico);
                cmd.Parameters.AddWithValue("@p_PorcentajeGC", porcentajeGC);
                cmd.Parameters.AddWithValue("@p_NivelGV", nivelGV);
                cmd.Parameters.AddWithValue("@p_EdadCorporal", edadCorporal);
                cmd.Parameters.AddWithValue("@p_Evolucion", fechaEvolucion);
                cmd.Parameters.AddWithValue("@p_FechaUltimaModificacion", fechaUltimaModificacion);
                cmd.Parameters.AddWithValue("@p_ID_Paciente", id_Paciente);  

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
        public CodigosStatus EditarDatoAntropometrico(Guid idAntropometria, decimal? peso, decimal? talla, decimal? IMC, decimal? musculoEsqueletico, decimal? porcentajeGC, decimal? nivelGV, int? edadCorporal, DateTime fechaEvolucion, DateTime ultimaFechaModificacion, Guid id_Paciente)
        {
            using MySqlConnection conexion = new(ConexionBD.Cadena);

            try
            {
                conexion.Open();

                string query = "UPDATE Antropometrias SET Peso = @peso, Talla = @talla, IMC = @imc, MusculoEsqueletico = @me, PorcentajeGC = @porcGC, NivelGV = @nivelGV, EdadCorporal = @edadCorp, Evolucion = @evolucion, FechaUltimaModificacion = @fechaUM, id_Paciente = @id_Paciente WHERE ID_Antropometria = @id_Ant;";

                MySqlCommand cmd = new(query, conexion);

                cmd.Parameters.AddWithValue("@peso", peso);
                cmd.Parameters.AddWithValue("@talla", talla);
                cmd.Parameters.AddWithValue("@imc", IMC);
                cmd.Parameters.AddWithValue("@me", musculoEsqueletico);
                cmd.Parameters.AddWithValue("@porcGC", porcentajeGC);
                cmd.Parameters.AddWithValue("@nivelGV", nivelGV);
                cmd.Parameters.AddWithValue("@edadCorp", edadCorporal);
                cmd.Parameters.AddWithValue("@evolucion", fechaEvolucion);
                cmd.Parameters.AddWithValue("@fechaUM", ultimaFechaModificacion);
                cmd.Parameters.AddWithValue("@id_Paciente", id_Paciente);
                cmd.Parameters.AddWithValue("@id_Ant", idAntropometria);

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