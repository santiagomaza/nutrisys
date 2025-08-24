namespace CapaNegocios.Utils
{
    public class ValidarPaciente
    {
        internal static void Validar(string nombre, Int64 dni, string email, string n_afiliado)
        {
            if (dni < 1 || dni > 99999999)
                throw new ArgumentException("El DNI debe ser valido. No puede contener mas de 8 digitos");

            if (string.IsNullOrEmpty(nombre))
                throw new ArgumentException("El nombre es obligatorio");

            if(nombre.Length > 30) throw new ArgumentException("El nombre no puede tener más de 30 caracteres");

            if (n_afiliado.Length > 17) throw new ArgumentException("El número de afiliado no puede tener más de 17 caracteres");

            if(email.Length > 45) throw new ArgumentException("El email no puede tener más de 45 caracteres");

            foreach (char c in nombre)
            {
                if (!char.IsLetter(c) && c != ' ')
                    throw new ArgumentException("El nombre solo puede contener letras y espacios");
            }
        }
    }
}
