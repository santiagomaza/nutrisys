using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class CN_Paises
    {
        private CD_Paises paises = new();
        public DataTable ListarPaises()
        {
            DataTable tablaPaises = paises.ListarPaises();
            return tablaPaises;
        }
    }
}
