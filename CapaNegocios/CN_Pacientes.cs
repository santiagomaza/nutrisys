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
        public bool InsertarPaciente(Paciente paciente, out string mensaje)
        {
            ValidarPaciente.Validar(paciente);

            Guid idPaciente = Guid.NewGuid();
            DateTime fechaRegistro = DateTime.Now;

            if (opacientes.PacienteRegistrado(paciente.NuevoDNI))
            {
                mensaje = $"El paciente con DNI {paciente.NuevoDNI} ya esta registrado en la base de datos";
                return false;
            }

            opacientes.InsertarPaciente(paciente);

            mensaje = $"El paciente {paciente.Nombre.ToUpper()} {paciente.Apellido.ToUpper()} ha sido dado de alta exitosamente en la base de datos";
            return true;
        }
        public void EditarPaciente(Paciente paciente)
        {
            ValidarPaciente.Validar(paciente);

            string dniStr = paciente.DNIActual.ToString();

            string dniSinPuntos = dniStr.Replace(".", "");

            paciente.DNIActual = Convert.ToInt64(dniSinPuntos);

            opacientes.EditarPaciente(paciente);
        }
    }
}