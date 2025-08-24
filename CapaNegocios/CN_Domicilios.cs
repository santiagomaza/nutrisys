using CapaDatos;

namespace CapaNegocios
{
    public class CN_Domicilios
    {
        private CD_Domicilios domicilios = new();

        public CapaNegocios.Enums.CodigosStatus InsertarDomicilio(Guid idDomicilio, string calle, int? numeracion, Guid idPais, Guid idProvincia, string? localidad)
        {
            var resultado = domicilios.InsertarDomicilio(idDomicilio, calle, numeracion, idPais, idProvincia, localidad);

            return Mapeo(resultado);
        }
        public Guid? BuscarDomicilio(string? calle, int? numeracion, Guid idPais, Guid idProvincia, string? localidad)
        {
            return domicilios.BuscarDomicilio(calle, numeracion, idPais, idProvincia, localidad);
        }
        public CapaNegocios.Enums.CodigosStatus EditarDomicilio(Guid idDomicilio, string? calle, int? numeracion, Guid idPais, Guid idProvincia, string? localidad)
        {
            var resultado = domicilios.EditarDomicilio(idDomicilio, calle, numeracion, idPais, idProvincia, localidad);

            return Mapeo(resultado);
        }
        private static CapaNegocios.Enums.CodigosStatus Mapeo(CapaDatos.Enums.CodigosStatus codigos)
        {
            if (codigos == CapaDatos.Enums.CodigosStatus.Ok)
            {
                return CapaNegocios.Enums.CodigosStatus.Ok;
            }
            else if (codigos == CapaDatos.Enums.CodigosStatus.Duplicado)
            {
                return CapaNegocios.Enums.CodigosStatus.Duplicado;
            }
            else
            {
                return CapaNegocios.Enums.CodigosStatus.Error;
            }
        }
    }
}
