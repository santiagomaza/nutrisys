using MySql.Data.MySqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Provincias
    {
        public DataTable ListarProvincias(string nombrePais)
        {
            DataTable tablaProvincias = new();
            MySqlDataReader lector = null;

            using MySqlConnection conn = new(ConexionBD.Cadena);

            try
            {
                conn.Open();

                string query = "SELECT pr.ID_Provincia, pr.Nombre FROM Provincias AS pr JOIN Paises AS pa ON pr.Id_Pais = pa.ID_Pais WHERE pa.Nombre = @pais ORDER BY pr.Nombre;";

                MySqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@pais", nombrePais);

                lector = cmd.ExecuteReader();

                tablaProvincias.Load(lector);
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error al listar las provincias", ex);
            }
            return tablaProvincias;
        }
    }
}
