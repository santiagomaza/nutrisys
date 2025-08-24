namespace CapaPresentación
{
    public partial class frmAcercaDe : Form
    {
        public frmAcercaDe()
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;
            InitializeComponent();
        }

        private void AcercaDe_Load(object sender, EventArgs e)
        {
            lblVersion.Text = Application.ProductVersion;
            lblDesarrollador.Text = "SMDev";
        }

        private void tsrSalir_Click(object sender, EventArgs e)
        {
            frmInicio inicio = new();

            inicio.Show();

            this.Hide();
        }
    }
}
