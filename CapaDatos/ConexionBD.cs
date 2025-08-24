using MySql.Data.MySqlClient;
using System.Configuration;

namespace CapaDatos
{
    public class ConexionBD
    {
        public static readonly string Cadena = ConfigurationManager.ConnectionStrings["BDNutrisys"].ConnectionString;
        public static bool ProbarConexion()
        {
            using(MySqlConnection con = new MySqlConnection(Cadena))
            {
                try
                {
                    con.Open();
                    return true;
                }
                catch(MySqlException)
                {
                    throw new Exception("Hubo un error al conectarse a la base de datos. Revise su configuración de red o de internet.");
                }
            }
        }
    }
}
