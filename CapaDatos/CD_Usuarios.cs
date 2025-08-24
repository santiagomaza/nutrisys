using System.Data;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class CD_Usuarios
    {
        public bool ValidarInicioSesion(string nombreUsuario, string contraseña)
        {
            using (MySqlConnection conexion = new MySqlConnection(ConexionBD.Cadena))
            {
                try
                {
                    conexion.Open();

                    string query = "SELECT COUNT(1) FROM Usuarios WHERE NombreUsuario = @nombreUsuario AND Contraseña = @contraseña";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);

                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);

                    Int64 count = (Int64)cmd.ExecuteScalar();

                    return count > 0;
                }
                catch (MySqlException ex)
                {
                    throw new Exception("Error al validar el usuario", ex);
                }
            }
        }
    }
}
