using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class CN_Antropometrias
    {
        private CD_Antropometrias antropometria = new();
        public DataTable MostrarDatosAntropometricosPaciente(Guid pacienteID)
        {
            DataTable dt = antropometria.MostrarDatosAntropometricosPaciente(pacienteID);

            return dt; 
        }
        public DataTable FiltrarDatosAntropometricos(Guid idPaciente, DateTime fechaInicio, DateTime fechaFin)
        {
            return antropometria.FiltrarDatosAntropometricos(idPaciente, fechaInicio, fechaFin);
        }
        public DateTime? ObtenerUltimaFechaModificacion(Guid pacienteID)
        {
            return antropometria.ObtenerUltimaFechaModificacion(pacienteID);
        }
        public CapaNegocios.Enums.CodigosStatus AgregarDatoAntropometrico(Guid id, decimal? peso, decimal? talla, decimal? musculoEsqueletico, decimal? porcentajeGC, decimal? nivelGV, int? edadCorporal, DateTime fechaEvolucion, DateTime fechaUltimaModificacion, Guid id_Paciente)
        {
            if(peso == null || (peso > 0 && peso <= 9999.99m && Maximo2Decimales(peso)))
            {
                decimal? IMC = peso / (talla * talla);

                var resultado = antropometria.AgregarDatosAntropometricos(id, peso, talla, IMC, musculoEsqueletico, porcentajeGC, nivelGV, edadCorporal, fechaEvolucion, fechaUltimaModificacion, id_Paciente);

                return Mapeo(resultado);
            }
            else
            {
                throw new ArgumentException("El peso ingresado no es el correcto, debe tener 4 números enteros y 2 decimales");
            }
        }
        public CapaNegocios.Enums.CodigosStatus EditarDatoAntropometrico(Guid idAntropometria, decimal? peso, decimal? talla, decimal? musculoEsqueletico, decimal? porcentajeGC, decimal? nivelGV, int? edadCorporal, DateTime fechaEvolucion, DateTime ultimaFechaModificacion, Guid id_Paciente)
        {
            decimal? imc = peso / (talla * talla);

            var resultado = antropometria.EditarDatoAntropometrico(idAntropometria, peso, talla, imc, musculoEsqueletico, porcentajeGC, nivelGV, edadCorporal, fechaEvolucion, ultimaFechaModificacion, id_Paciente);

            return Mapeo(resultado);
        }
        private static CapaNegocios.Enums.CodigosStatus Mapeo(CapaDatos.Enums.CodigosStatus codigos)
        {
            if (codigos == CapaDatos.Enums.CodigosStatus.Ok)
            {
                return CapaNegocios.Enums.CodigosStatus.Ok;
            }
            else if(codigos == CapaDatos.Enums.CodigosStatus.Duplicado)
            {
                return CapaNegocios.Enums.CodigosStatus.Duplicado;
            }
            else
            {
                return CapaNegocios.Enums.CodigosStatus.Error;
            }
        }
        private bool Maximo2Decimales(decimal? valor)
        {
            if (valor == null)
                return false;

            return valor == Math.Round(valor.Value, 2);
        }
    }
}
