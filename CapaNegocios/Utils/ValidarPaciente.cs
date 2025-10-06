using CapaEntidades;
using System.Linq.Expressions;

namespace CapaNegocios.Utils
{
    public class ValidarPaciente
    {
        internal static void Validar(Paciente paciente)
        {
            const long maxCantDigitosTelefono = 999999999999999;

            if (paciente.NuevoDNI < 1 || paciente.NuevoDNI > 99999999)
                throw new ArgumentException("El DNI debe ser valido. No puede contener mas de 8 dígitos y no puede ser negativo.");

            if (string.IsNullOrEmpty(paciente.Nombre))
                throw new ArgumentException("El nombre es obligatorio.");

            if(paciente.Nombre.Length > 30) throw new ArgumentException("El nombre no puede tener más de 30 caracteres.");

            if (string.IsNullOrEmpty(paciente.Apellido)) throw new ArgumentException("El apellido es obligatorio.");

            if (paciente.Apellido.Length > 40) throw new ArgumentException("El apellido no puede contener más de 40 caracteres.");

            if (string.IsNullOrEmpty(paciente.Telefono.ToString())) throw new ArgumentException("El número de telefono es obligatorio.");

            if (paciente.Telefono > maxCantDigitosTelefono)
                throw new ArgumentException("El número de teléfono no puede contener más de 15 dígitos incluyendo el código de país.");

            if (paciente.FechaNacimiento > DateTime.Now) throw new ArgumentException("La fecha de nacimiento no puede ser mayor a la fecha actual.");

            char[] caracteresEspeciales = { '$', '%', '&', '#', '!', '"', '(', ')', '=', '?', '¡', '¿', ';', ':', ',', };

            char[] letras = Enumerable.Range('A', 26)
                .Select(x => (char)x)
                .Concat(Enumerable.Range('a', 26)
                .Select(x => (char)x))
                .ToArray();

            List<string> obrasSociales = new List<string> { "PAMI", "Ninguna" };

            if (!obrasSociales.Contains(paciente.ObraSocial)) throw new ArgumentException("La obra social ingresada no es valida.");

            if (!string.IsNullOrEmpty(paciente?.N_Afiliado) && paciente.N_Afiliado.Length > 17) throw new ArgumentException("El número de afiliado no puede tener más de 17 caracteres.");

            if (!string.IsNullOrEmpty(paciente.N_Afiliado) && paciente.N_Afiliado.Any(c => caracteresEspeciales.Contains(c))) throw new ArgumentException("El número de afiliado no puede contener ninguno de los siguientes caracteres: $ % & # ! ( ) = ? ¡ ¿ ; , : \".");

            if (!string.IsNullOrEmpty(paciente.N_Afiliado) && paciente.N_Afiliado.Any(c => letras.Contains(c))) throw new ArgumentException("El número de afiliado no puede contener letras.");

            List<string> sexos = new List<string> { "Masculino", "Femenino" };

            if (!sexos.Contains(paciente.Sexo)) throw new ArgumentException("El sexo ingresado no es valido.");

            if (!string.IsNullOrEmpty(paciente.Email) && paciente?.Email?.Length > 45) throw new ArgumentException("El email no puede tener más de 45 caracteres.");

            if (!string.IsNullOrEmpty(paciente.Email) &&!paciente.Email.Contains("@")) throw new ArgumentException("El email debe contener el @ para que sea valido");

            if (paciente?.Ocupacion?.Length > 130)
                throw new ArgumentException("La ocupación no puede tener una descripción mayor a 130 caracteres.");

            List<string> estadosCiviles = new List<string> { "Sin Especificar", "Soltero/a", "En Pareja", "Casado/a", "Divorciado/a", "Viudo/a" };

            if (!estadosCiviles.Contains(paciente.EstadoCivil)) throw new ArgumentException("El estado civil ingresado no es valido");

            foreach (char c in paciente.Nombre)
            {
                if (!char.IsLetter(c) && c != ' ')
                    throw new ArgumentException("El nombre solo puede contener letras y espacios.");
            }

            foreach (char c in paciente.Apellido)
            {
                if (!char.IsLetter(c) && c != ' ')
                    throw new ArgumentException("El apellido solo puede contener letras y espacios.");
            }
        }
    }
}
