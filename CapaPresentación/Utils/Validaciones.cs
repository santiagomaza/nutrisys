namespace CapaPresentación.Utils
{
    internal static class Validaciones
    {
        internal static bool ValidacionCampos(System.Windows.Forms.TextBox txtBox, ErrorProvider err, bool obligatorio = false, bool numerico = false, bool soloTexto = false)
        {
            string texto = txtBox.Text.Trim();

            if (obligatorio && string.IsNullOrEmpty(texto))
            {
                err.SetError(txtBox, "Este campo es obligatorio");
                return false;
            }

            if (!obligatorio && string.IsNullOrEmpty(texto))
            {
                err.SetError(txtBox, "");
                return true;
            }

            if (numerico && !decimal.TryParse(texto, out _))
            {
                err.SetError(txtBox, "Este campo solo admite números");
                return false;
            }

            foreach (char letra in texto)
            {
                if (soloTexto && !char.IsLetter(letra) && letra != ' ')
                {
                    err.SetError(txtBox, "Este campo solo admite letras");
                    return false;
                }
            }

            err.SetError(txtBox, "");
            return true;
        }
    }
}
