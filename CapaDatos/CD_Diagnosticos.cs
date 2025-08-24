using MySql.Data.MySqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Diagnosticos
    {
        MySqlDataReader lector;
        public DataTable ListarDiagnosticos()
        {
            DataTable listarDiagnosticos = new();
            using MySqlConnection conn = new(ConexionBD.Cadena);

            try
            {
                conn.Open();

                string query = "SELECT ID_Diagnostico, UPPER(NombreDiagnostico) AS 'Diagnostico' FROM Diagnosticos ORDER BY (CASE WHEN NombreDiagnostico = 'Sin Diagnóstico' THEN 0 ELSE 1 END), NombreDiagnostico";

                MySqlCommand cmd = new(query, conn);

                lector = cmd.ExecuteReader();

                listarDiagnosticos.Load(lector);
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error al recuperar los diagnosticos", ex);
            }
            return listarDiagnosticos;
        }
        public DataTable ListarDiagnosticoFiltro(string diagnostico)
        {
            DataTable listarDiagnosticoFiltro = new();

            using MySqlConnection conn = new(ConexionBD.Cadena);

            try
            {
                conn.Open();

                string query = "SELECT ID_Diagnostico, UPPER(NombreDiagnostico) AS 'Diagnostico' FROM Diagnosticos WHERE UPPER(NombreDiagnostico) LIKE UPPER(@nombreDiagnostico) ORDER BY (CASE WHEN NombreDiagnostico = 'Sin Diagnóstico' THEN 0 ELSE 1 END), NombreDiagnostico";

                MySqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@nombreDiagnostico", "%" + diagnostico + "%");

                lector = cmd.ExecuteReader();

                listarDiagnosticoFiltro.Load(lector);
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error al filtrar los diagnosticos", ex);
            }
            return listarDiagnosticoFiltro;
        }
        public void InsertarDiagnostico(Guid idDiagnostico, string nombreDiagnostico)
        {
            using MySqlConnection conn = new(ConexionBD.Cadena);

            try
            {
                conn.Open();

                string query = "InsertarDiagnostico;";

                MySqlCommand cmd = new(query, conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_ID_Diagnostico", idDiagnostico);
                cmd.Parameters.AddWithValue("@p_NombreDiagnostico", nombreDiagnostico);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error al insertar un nuevo diagnostico", ex);
            }
        }
    }
}
