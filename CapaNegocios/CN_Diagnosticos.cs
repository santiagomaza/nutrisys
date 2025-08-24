using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class CN_Diagnosticos
    {
        private CD_Diagnosticos diagnosticos = new();
        public DataTable ListarDiagnosticos()
        {
            return diagnosticos.ListarDiagnosticos();
        }
        public DataTable FiltrarDiagnostico(string diagnostico)
        {
            return diagnosticos.ListarDiagnosticoFiltro(diagnostico);
        }
        public void InsertarDiagnostico(string nombreDiagnostico)
        {
            string diagnosticoCapitalizado = CapitalizarPalabras(nombreDiagnostico);
            Guid idDiagnostico = Guid.NewGuid();

            diagnosticos.InsertarDiagnostico(idDiagnostico, diagnosticoCapitalizado);
        }
        public string CapitalizarPalabras(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input;

            var palabras = input.Split(' ');
            for (int i = 0; i < palabras.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(palabras[i]))
                    palabras[i] = char.ToUpper(palabras[i][0]) + palabras[i].Substring(1).ToLower();
            }

            return string.Join(" ", palabras);
        }
    }
}
