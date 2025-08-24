using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class CN_HistoriasClinicas
    {
        private readonly CD_HistoriasClinicas historiaClinica;
        public CN_HistoriasClinicas()
        {
            historiaClinica = new CD_HistoriasClinicas();
        }
        public DataTable MostrarHistoriasClinicas(Guid paciente)
        {
            return historiaClinica.MostrarHistoriasClinicas(paciente);
        }
        public DataTable FiltrarHistoriaClinicaPorFecha(Guid idPaciente, DateTime fechaInicio, DateTime fechaFin)
        {
            return historiaClinica.FiltrarHistoriaClinicaPorFecha(idPaciente, fechaInicio, fechaFin);
        }
        public string RetornarObservacionFormateada(Guid idHistCl)
        {
            return historiaClinica.RetornarDescripcionRTF(idHistCl);
        }
        public void NuevaHistoriaClinica(Guid id_Paciente, string observacionPlano, string observacionFormateada, DateTime fechaConsulta, string ruta_archivo)
        {
            Guid idHistoriaClinica = Guid.NewGuid();
            DateTime fechaUltimaModificacion = DateTime.Now;

            historiaClinica.NuevaHistoriaClinica(idHistoriaClinica,id_Paciente, observacionPlano, observacionFormateada, fechaConsulta, fechaUltimaModificacion, ruta_archivo);
        }
        public void EditarHistoriaClinica(Guid idHistClinica, Guid id_Paciente, string observacionPlano, string observacionRTF, DateTime fechaConsulta, string ruta_archivo)
        {
            DateTime fechaUltimaModificacion = DateTime.Now;

            historiaClinica.EditarHistoriaClinica(idHistClinica, id_Paciente, observacionPlano, observacionRTF, fechaConsulta, fechaUltimaModificacion, ruta_archivo);
        }
        public void EliminarArchivoDeHistoriaClinica(Guid idHistCl)
        {
            if(idHistCl == Guid.Empty)
            {
                return;
            }

            historiaClinica.BorrarArchivoDeHistoriaClinica(idHistCl);
        }
    }
}
