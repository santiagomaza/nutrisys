using System.Data;
using CapaEntidades;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class CD_Usuarios
    {
        public (bool existe, Usuario usuarioDTO) ValidarInicioSesion(string nombreUsuario)
        {
            Usuario? usuarioDTO = null;

            using (MySqlConnection conexion = new MySqlConnection(ConexionBD.Cadena))
            {
                try
                {
                    conexion.Open();

                    string query = "SELECT NombreUsuario, Contraseña FROM Usuarios WHERE NombreUsuario = @nombreUsuario;";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);

                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                    using var reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        usuarioDTO = new Usuario
                        {
                            NombreUsuario = reader.GetString("NombreUsuario"),
                            ContraseñaEncriptada = reader.GetString("Contraseña")
                        };

                        return (true, usuarioDTO);
                    }

                    return (false, null);
                }
                catch (MySqlException ex)
                {
                    throw new Exception("Error al validar el usuario", ex);
                }
            }
        }
    }
}
