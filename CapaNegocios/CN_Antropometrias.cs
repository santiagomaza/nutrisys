using System.Data;
using CapaDatos;
using CapaEntidades;

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
        public CapaNegocios.Enums.CodigosStatus AgregarDatoAntropometrico(DatoAntropometrico DA)
        {
            if(DA.Peso == null || (DA.Peso > 0 && DA.Peso <= 9999.99m && Maximo2Decimales(DA.Peso)))
            {
                DA.IMC = DA.Peso / (DA.Talla * DA.Talla);

                var resultado = antropometria.AgregarDatosAntropometricos(DA);

                return Mapeo(resultado);
            }
            else
            {
                throw new ArgumentException("El peso ingresado no es el correcto, debe tener 4 números enteros y 2 decimales");
            }
        }
        public CapaNegocios.Enums.CodigosStatus EditarDatoAntropometrico(DatoAntropometrico DA)
        {
            DA.IMC =  DA.Peso / (DA.Talla * DA.Talla);

            var resultado = antropometria.EditarDatoAntropometrico(DA);

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
