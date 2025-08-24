using CapaDatos;

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

            if(!string.IsNullOrWhiteSpace(nombreUsuario) || !string.IsNullOrWhiteSpace(contraseña)) {
                return usuarios.ValidarInicioSesion(nombreUsuario, contraseña);
            }
            return false;
        }
    }
}
