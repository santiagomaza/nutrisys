using System;
using CapaNegocios;
using CapaEntidades;

class Program
{
    static void Main()
    {
        var negocio = new CN_Pacientes();

        var paciente = new Paciente(
            DNI: 12345678,
            nombre: "emiliano",
            apellido: "martinez",
            fechaNacimiento: DateTime.Now.AddYears(-32),
            sexo: "Masculino",
            telefono: 3874293238918219281,
            idDomicilio: Guid.Empty,
            idPais:Guid.Empty,
            n_Afiliado: "",
            obraSocial: "Ninguna",
            email: "eldibujomartinez@gmail.com",
            estadoCivil: "Casado/a",
            ocupacion: "Campeón del mundo"
        );

        try
        {
            bool prueba = negocio.InsertarPaciente(paciente, out string mensaje);

            if (prueba) Console.WriteLine(mensaje);
            else
                Console.WriteLine(mensaje);
        }
        catch(ArgumentException argEx)
        {
            Console.WriteLine(argEx.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message} \n\n {ex.InnerException}");
        }

        Console.ReadLine();
    }
}
