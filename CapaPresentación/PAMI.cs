using CapaNegocios;
using System.Data;

namespace CapaPresentación
{
    public partial class frmPAMI : Form
    {
        private CN_Pacientes pacientes = new();
        public frmPAMI()
        {
            InitializeComponent();
        }
        private void frmPAMI_Load(object sender, EventArgs e)
        {
            tsrPami.Enabled = false;
            btnQuitarFiltro.Visible = false;

            DateTime hoy = DateTime.Today;

            DateTime primerDiaDelMes = new(hoy.Year, hoy.Month, 1);
            DateTime ultimoDiaDelMes = primerDiaDelMes.AddMonths(1).AddDays(-1);

            dtpDesde.Value = primerDiaDelMes;
            dtpHasta.Value = ultimoDiaDelMes;
        }
        private void btnFiltrarFechas_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Value > DateTime.Now)
            {
                MessageBox.Show("No se puede seleccionar una fecha mayor a la actual", "NutrisysInfo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                DateTime desde = dtpDesde.Value;
                DateTime hasta = dtpHasta.Value;

                DataTable listaPacientesPAMI = pacientes.FiltrarFechasPacientesPAMI(desde, hasta);

                if (listaPacientesPAMI.Rows.Count >= 0)
                {
                    BindingSource bs = new();
                    bs.DataSource = listaPacientesPAMI;

                    dgvPacientesPAMI.DataSource = bs;

                    dgvPacientesPAMI.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    btnQuitarFiltro.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NutrisysError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            dgvPacientesPAMI.DataSource = null;

            DateTime hoy = DateTime.Today;

            DateTime primerDiaDelMes = new(hoy.Year, hoy.Month, 1);
            DateTime ultimoDiaDelMes = primerDiaDelMes.AddMonths(1).AddDays(-1);

            dtpDesde.Value = primerDiaDelMes;
            dtpHasta.Value = ultimoDiaDelMes;

            btnQuitarFiltro.Visible = false;
        }
        private void tsrPacientes_Click(object sender, EventArgs e)
        {
            frmPacientes pacientes = new();
            pacientes.Show();
        }
        private void tsrHistoriasClinicas_Click(object sender, EventArgs e)
        {
            frmHistoriasClinicas hc = new();
            hc.Show();
        }
        private void tsrAntropometria_Click(object sender, EventArgs e)
        {
            frmAntropometria antropometria = new();
        
            antropometria.Show();
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
            this.Close();
        }
        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDesde.Value > DateTime.Now)
            {
                MessageBox.Show("No se puede establecer una fecha mayor a la actual", "NutrisysInfo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
    }
}
