using CapaDatos;
using CapaEntidades;
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
        public (bool exito, string mensaje) InsertarPaciente(Paciente paciente)
        {
            ValidarPaciente.Validar(paciente);

            var (existe, mensajeValidacion, nombrePaciente) = PacienteRegistrado(paciente.NuevoDNI);

            if (existe)
            {
                return (false, mensajeValidacion);
            }

            var (exitoInsercion, mensajeInsercion) = opacientes.InsertarPaciente(paciente);

            if (exitoInsercion)
            {
                string mensaje = $"El paciente {paciente.Nombre.ToUpper()} {paciente.Apellido.ToUpper()} fue dado de alta correctamente";
                return (true, mensaje);
            }

            return (false, mensajeInsercion);
        }
        public void EditarPaciente(Paciente paciente)
        {
            ValidarPaciente.Validar(paciente);

            string dniStr = paciente.DNIActual.ToString();

            string dniSinPuntos = dniStr.Replace(".", "");

            paciente.DNIActual = Convert.ToInt64(dniSinPuntos);

            opacientes.EditarPaciente(paciente);
        }
        public (bool existe, string mensaje, string nomnbrePaciente) PacienteRegistrado(Int64 DNI)
        {
            var (existe, nombrePacienteDAL) = opacientes.PacienteRegistrado(DNI);

            if (existe)
            {
                string mensaje = $"El paciente con DNI {DNI} ya esta registrado en la base de datos y le corresponde al paciente {nombrePacienteDAL.ToUpper()}";
                return (true, mensaje, nombrePacienteDAL);
            }

            return (false, string.Empty, string.Empty);
        }
    }
}