namespace CapaPresentación.Utils
{
    internal class AplicarEstilos
    {
        internal static void AplicarEstilosTextbox(RichTextBox rtf, FontStyle estilo)
        {
            if (rtf.SelectionFont == null)
                return;

            Font fuenteActual = rtf.SelectionFont;
            FontStyle nuevoEstilo;

            if ((fuenteActual.Style & estilo) == estilo)
                nuevoEstilo = fuenteActual.Style & ~estilo;
            else
                nuevoEstilo = fuenteActual.Style | estilo;

            rtf.SelectionFont = new Font(fuenteActual, nuevoEstilo);
        }
    }
}
