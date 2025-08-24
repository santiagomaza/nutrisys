using CapaPresentación.Utils;

namespace CapaPresentación
{
    public partial class FrmDetalleHistoriaClinica : Form
    {
        public FrmDetalleHistoriaClinica(DetallesHistoriaClinica detalleRecibido)
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;
            InitializeComponent();

            lblPaciente.Text = detalleRecibido.Paciente;
            lblDiagnostico.Text = detalleRecibido.Diagnostico;
            rtfObservaciones.Rtf = detalleRecibido.DescripcionHC;
        }
    }
}
