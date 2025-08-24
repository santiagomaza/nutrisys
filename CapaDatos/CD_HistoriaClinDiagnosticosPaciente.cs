using MySql.Data.MySqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_HistoriaClinDiagnosticosPaciente
    {
        MySqlDataReader lector;
        public DataTable ObtenerDiagnosticoPorPacienteHC(Guid? idPaciente)
        {
            DataTable listaPacientesPorDiagnostico = new();

            using MySqlConnection conexion = new(ConexionBD.Cadena);

            try
            {
                conexion.Open();

                string query = "SELECT GROUP_CONCAT(DISTINCT HCLDP.ID_HistClGeneral SEPARATOR ',') AS 'Id_HistClGeneral', GROUP_CONCAT(HCLDP.Id_Diagnostico SEPARATOR ',') AS 'Ids_diagnosticos', GROUP_CONCAT(UPPER(D.NombreDiagnostico) SEPARATOR ', ') AS Diagnosticos, GROUP_CONCAT(DISTINCT HCLDP.Id_Paciente SEPARATOR ',') AS 'Id_Paciente' FROM HistoriaClDiagnosticosPaciente HCLDP JOIN Diagnosticos D ON D.ID_Diagnostico = HCLDP.Id_Diagnostico JOIN Pacientes P ON P.ID_Paciente = HCLDP.Id_Paciente WHERE HCLDP.Id_Paciente = @idPaciente;";

                MySqlCommand cmd = new(query, conexion);

                cmd.Parameters.AddWithValue("@idPaciente", idPaciente);

                lector = cmd.ExecuteReader();

                listaPacientesPorDiagnostico.Load(lector);
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error al cargar los diagnosticos del paciente", ex);
            }
            return listaPacientesPorDiagnostico;
        }
        public DataTable DiagnosticosMarcados(Guid? idPaciente)
        {
            DataTable listaDiagnosticosMarcados = new();

            using MySqlConnection conn = new(ConexionBD.Cadena);

            try
            {
                conn.Open();

                string query = "SELECT D.ID_Diagnostico, UPPER(D.NombreDiagnostico) AS 'Diagnostico' FROM HistoriaClDiagnosticosPaciente HCLDP LEFT JOIN Diagnosticos D ON HCLDP.Id_Diagnostico = D.ID_Diagnostico JOIN Pacientes P ON HCLDP.Id_Paciente = P.ID_Paciente WHERE P.ID_Paciente = @idPaciente;";

                MySqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@idPaciente", idPaciente);

                lector = cmd.ExecuteReader();

                listaDiagnosticosMarcados.Load(lector);
            }
            catch (MySqlException ex)
            {
                throw new Exception("No fue posible filtrar los diagnosticos", ex);
            }
            return listaDiagnosticosMarcados;
        }
        public Guid ObtenerIdHistoriaClinicaGeneralPorPaciente(Guid idPaciente)
        {
            using MySqlConnection conn = new MySqlConnection(ConexionBD.Cadena);
            conn.Open();

            string query = "SELECT DISTINCT ID_HistClGeneral FROM HistoriaClDiagnosticosPaciente WHERE Id_Paciente = @idPaciente LIMIT 1";

            using MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idPaciente", idPaciente);

            object resultado = cmd.ExecuteScalar();

            if (resultado != null && Guid.TryParse(resultado.ToString(), out Guid id))
            {
                return id;
            }

            return Guid.Empty;
        }
        public void InsertarDiagnosticoAPacienteHistClinica(Guid idHistClGeneral, Guid idPaciente, string nombreDiagnostico)
        {
            using MySqlConnection conn = new(ConexionBD.Cadena);

            try
            {
                conn.Open();

                string query = "InsertarDiagnosticoEnHistoria";

                MySqlCommand cmd = new(query, conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_IdHistClGeneral", idHistClGeneral.ToString());
                cmd.Parameters.AddWithValue("@p_IdPaciente", idPaciente);
                cmd.Parameters.AddWithValue("@p_NombreDiagnostico", nombreDiagnostico);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error al insertar un nuevo diagnostico para la historia clinica", ex);
            }
        }
        public void EliminarDiagnosticoPacienteDeHC(Guid idHistoriaClinica, string nombreDiagnostico)
        {
            using MySqlConnection conn = new(ConexionBD.Cadena);

            try
            {
                conn.Open();

                string query = "DELETE FROM HistoriaClDiagnosticosPaciente WHERE ID_HistClGeneral = @idHistClGeneral AND Id_Diagnostico = (SELECT ID_Diagnostico FROM Diagnosticos WHERE NombreDiagnostico = @nombreDiagnostico)";

                MySqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@idHistClGeneral", idHistoriaClinica);
                cmd.Parameters.AddWithValue("@nombreDiagnostico", nombreDiagnostico);

                int rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error al borrar el diagnostico de la historia clinica", ex);
            }
        }
    }
}
