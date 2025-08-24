using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class CN_Provincias
    {
        private CD_Provincias provincias = new();
        public DataTable ListarProvincias(string pais)
        {
            return provincias.ListarProvincias(pais);
        }
    }
}
