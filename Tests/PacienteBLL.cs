using CapaNegocios;
using CapaEntidades;
class PacienteBLL
{
    static void Main()
    {
        var negocio = new CN_Pacientes();

        var paciente = new Paciente(
            DNI: 12345678,
            nombre: "santiago",
            apellido: "maza",
            fechaNacimiento: DateTime.Now.AddYears(-25),
            sexo: "Masculino",
            telefono: 5491123456789,
            idDomicilio: null,
            idPais: Guid.Parse("b648d0ff-302d-11f0-83ab-14cb19bb717a"),
            n_Afiliado: null,
            obraSocial: "Ninguna",
            email: "fhsofjs@gmail.com",
            estadoCivil: "Soltero/a",
            ocupacion: "Técnico en Programación"
        );

        try
        {
            var (insertado, mensaje) = negocio.InsertarPaciente(paciente);

            if (insertado)
                Console.WriteLine(mensaje);
            Console.WriteLine(mensaje);

            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Mensaje: " + ex.Message);
            if (ex.InnerException != null)
            {
                Console.WriteLine("\nInnerException: " + ex.InnerException);
                Console.WriteLine("Tipo: " + ex.InnerException.GetType().Name);
            }
            Console.ReadKey();
        }
    }
}