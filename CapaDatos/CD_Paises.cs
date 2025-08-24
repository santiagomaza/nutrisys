using MySql.Data.MySqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Paises
    {
        public DataTable ListarPaises()
        {
            DataTable tablaPaises = new();
            MySqlDataReader lector = null;

            using MySqlConnection conn = new(ConexionBD.Cadena);

            try
            {
                conn.Open();

                string query = "SELECT * FROM Paises ORDER BY Nombre";

                MySqlCommand cmd = new(query, conn);

                lector = cmd.ExecuteReader();

                tablaPaises.Load(lector);
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error al listar los paises", ex);
            }
            return tablaPaises;
        }
    }
}
