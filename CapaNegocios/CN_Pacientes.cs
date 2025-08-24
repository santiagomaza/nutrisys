using CapaDatos;
using CapaNegocios.Utils;
using System.Data;
using System.Net;

namespace CapaNegocios
{
    public class CN_Pacientes
    {
        private CD_Pacientes opacientes = new();
        public DataTable ListarPacientes()
        {
            DataTable tabla = new DataTable();
            tabla = opacientes.ListarPacientes();

            return tabla;
        }
        public DataTable BuscarPaciente(string caracteres)
        {
            DataTable tabla = opacientes.BuscarPaciente(caracteres);

            return tabla;
        }
        public DataTable FiltrarFechasPacientesPAMI(DateTime fechaInicio, DateTime fechaFin)
        {
            return opacientes.FiltrarFechasPacientesPAMI(fechaInicio, fechaFin);
        }
        public DataTable FiltrarPaciente(string paciente)
        {
            return opacientes.FiltrarPaciente(paciente);
        }
        public bool InsertarPaciente(Int64 dni, string nombre, string apellido, DateTime fechaNacimiento, long telefono, Guid domicilio, Guid pais, string? n_afiliado, string obraSocial, string email, out string mensaje, string sexo, string estadoCivil, string ocupacion)
        {
            ValidarPaciente.Validar(nombre, dni, email, n_afiliado);

            Guid idPaciente = Guid.NewGuid();
            DateTime fechaRegistro = DateTime.Now;

            if (opacientes.PacienteRegistrado(dni))
            {
                mensaje = $"El paciente con DNI {dni} ya esta registrado en la base de datos";
                return false;
            }

            opacientes.InsertarPaciente(idPaciente, dni, nombre, apellido, fechaNacimiento, telefono, fechaRegistro, domicilio, pais, n_afiliado , obraSocial, email, sexo, estadoCivil, ocupacion);

            mensaje = "Paciente registrado correctamente";
            return true;
        }
        public void EditarPaciente(int dni_nuevo, string dni_actual, string nombre, string apellido, DateTime fechaNacimiento, long telefono, Guid id_Pais, Guid? idDomicilio, string? n_afiliado, string obraSocial, string email, string sexo, string estadoCivil, string ocupacion)
        {
            ValidarPaciente.Validar(nombre, dni_nuevo, email, n_afiliado);

            string dniSinPuntos = dni_actual.Replace(".", "");

            opacientes.EditarPaciente(dni_nuevo, int.Parse(dniSinPuntos), nombre, apellido, fechaNacimiento, telefono, id_Pais, idDomicilio, n_afiliado, obraSocial, email, sexo, estadoCivil, ocupacion);
        }
    }
}