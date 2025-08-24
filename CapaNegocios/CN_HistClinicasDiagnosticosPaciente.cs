using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class CN_HistClinicasDiagnosticosPaciente
    {
        private CD_HistoriaClinDiagnosticosPaciente intermedia = new();
        public DataTable ObtenerDiagnosticosPorPacienteHC(Guid? paciente)
        {
            return intermedia.ObtenerDiagnosticoPorPacienteHC(paciente);
        }
        public DataTable FiltrarDiagnosticosMarcados(Guid? paciente)
        {
            return intermedia.DiagnosticosMarcados(paciente);
        }
        public Guid ObtenerIdHistoriaClinicaGeneralPorPaciente(Guid idPaciente)
        {
            Guid idHistCl = intermedia.ObtenerIdHistoriaClinicaGeneralPorPaciente(idPaciente);

            if (idHistCl == Guid.Empty)
            {
                idHistCl = Guid.NewGuid();
            }

            return idHistCl;
        }
        public void InsertarDiagnosticoAPacienteHistClinica(Guid idHistoriaClinicaGeneral, Guid idPaciente, string nombreDiagnostico)
        {
            intermedia.InsertarDiagnosticoAPacienteHistClinica(idHistoriaClinicaGeneral, idPaciente, nombreDiagnostico);
        }
        public void EliminarDiagnosticoPacienteDeHC(Guid idHistCl, string nombreDiagnostico)
        {
            intermedia.EliminarDiagnosticoPacienteDeHC(idHistCl, nombreDiagnostico);
        }
    }
}
