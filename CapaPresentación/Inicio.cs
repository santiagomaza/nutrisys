using CapaEntidades;
using CapaPresentación.Utils;

namespace CapaPresentación
{
    public partial class frmInicio : Form
    {
        private readonly Usuario _usuarioLogueado;
        public frmInicio()
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;
            InitializeComponent();
        }

        public frmInicio(Usuario usuario)
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;
            InitializeComponent();

            _usuarioLogueado = usuario; 
        }
        private void frmInicio_Load(object sender, EventArgs e)
        {
            lblTxtBienvenida.Text = _usuarioLogueado.NombreUsuario;
        }
        private void tsrPacientes_Click(object sender, EventArgs e)
        {
            ResetearEstiloMenu();

            var pacientes = new frmPacientes();

            pacientes.Show();
        }
        private void tsrHistoriasClinicas_Click(object sender, EventArgs e)
        {
            frmHistoriasClinicas hc = new();

            hc.Show();
        }
        private void tsrAntropometria_Click(object sender, EventArgs e)
        {
            frmAntropometria frmAntropometria = new();

            frmAntropometria.Show();
        }
        private void tsrPami_Click(object sender, EventArgs e)
        {
            frmPAMI pami = new();
            pami.Show();
        }
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe acercaDe = new();

            acercaDe.ShowDialog();
        }
        private void tsrMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void tsrSalir_Click(object sender, EventArgs e)
        {
            frmInicioSesion formInicioSesion = new();

            formInicioSesion.Show();

            this.DialogResult = DialogResult.Retry;

            this.Hide();
        }
        private void ResetearEstiloMenu()
        {
            foreach (ToolStripMenuItem item in mnsNavegación.Items)
            {
                item.Font = new Font(item.Font, FontStyle.Regular);
                item.ForeColor = Color.Black;
            }
        }
    }
}
