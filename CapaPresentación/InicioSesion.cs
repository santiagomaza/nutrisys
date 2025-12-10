using CapaEntidades;
using CapaNegocios;
using CapaPresentación.Utils;
using System.Diagnostics;
using System.Reflection;

namespace CapaPresentación
{
    internal partial class frmInicioSesion : Form
    {
        private CN_Usuarios usuariosCN = new CN_Usuarios();
        public frmInicioSesion()
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;
            InitializeComponent();

            this.ActiveControl = lblTitulo;
            this.MaximizeBox = false;

            Version appVersion = Assembly.GetExecutingAssembly().GetName().Version;

            lblVersion.Text = "v" + appVersion.Major + "." + appVersion.Minor + "." + appVersion.Build;
        }
        private void btnIniciarSesión_Click(object sender, EventArgs e)
        {
            bool validarNombreUsuario = Validaciones.ValidacionCampos(txtNombreUsuario, errValidarIS, obligatorio: true);
            bool validarContraseña = Validaciones.ValidacionCampos(txtContraseña, errValidarIS, obligatorio: true);

            if (!validarNombreUsuario || !validarContraseña)
            {
                return;
            }

            string nombreUsuario = txtNombreUsuario.Text.Trim().ToLower(), contraseña = txtContraseña.Text.Trim().ToLower();

            try
            {
                bool validacion = usuariosCN.ValidarInicioSesion(nombreUsuario, contraseña);

                if (validacion)
                {
                    Usuario usuario = new();

                    usuario = new Usuario
                    {
                        NombreUsuario = nombreUsuario
                    };

                    frmInicio Inicio = new frmInicio(usuario);

                    Inicio.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario ingresado " + nombreUsuario + " es incorrecto o no se encuentra en la base de datos", "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\n\nEn caso de persistir el error comuníquese con su proveedor.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtNombreUsuario_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombreUsuario.Text))
            {
                errValidarIS.SetError(txtNombreUsuario, "");
            }
        }
        private void txtContraseña_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtContraseña.Text))
            {
                errValidarIS.SetError(txtContraseña, "");
            }
        }
        private void BtnSalirSistema_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}