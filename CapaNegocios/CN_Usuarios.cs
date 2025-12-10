using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class CN_Usuarios
    {
        private readonly CD_Usuarios usuarios = new();
        public bool ValidarInicioSesion(string nombreUsuario, string contraseña)
        {
            if (!ConexionBD.ProbarConexion())
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contraseña))
                return false;

            var (existe, usuarioDTO) = usuarios.ValidarInicioSesion(nombreUsuario);

            if (!existe || usuarioDTO == null)
                return false;

            bool usuarioValido = BCrypt.Net.BCrypt.Verify(contraseña, usuarioDTO.ContraseñaEncriptada);

            return usuarioValido;
        }
    }
}
