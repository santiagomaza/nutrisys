namespace CapaPresentación.Utils
{
    public static class CodigosPais
    {
        public static readonly string[] Lista = new string[]
        {
            "1",     // EE.UU., Canadá
            "34",    // España
            "51",    // Perú
            "52",    // México
            "53",    // Cuba
            "54",    // Argentina
            "549",   // Argentina celulares
            "55",    // Brasil
            "56",    // Chile
            "57",    // Colombia
            "58",    // Venezuela
            "591",   // Bolivia
            "595",   // Paraguay
            "598",   // Uruguay
            "593",   // Ecuador
            "500",   // Islas Malvinas
            "597",   // Surinam
            "33",    // Francia
            "39",    // Italia
            "7",     // Rusia
            "31",    // Paises Bajos
            "380",   // Ucrania
            "44",    //Reino Unido
            "49",    //Alemania
            "48"     //Polonia
        };
        public static string? DetectarCodigoPais(string telefono)
        {
            return Lista
                .OrderByDescending(codigo => codigo.Length)
                .FirstOrDefault(codigo => telefono.StartsWith(codigo));
        }
    }
}
