using System.Data;
using MySql.Data.MySqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class CD_Pacientes
    {
        MySqlDataReader lector;
        public DataTable ListarPacientes()
        {
            DataTable tabla = new();
            using (MySqlConnection conexion = new(ConexionBD.Cadena))
            {
                try
                {
                    conexion.Open();

                    string storedProcedure = "SELECT * FROM nutrisys.ListarPacientes;";

                    MySqlCommand cmd = new MySqlCommand(storedProcedure, conexion);

                    cmd.CommandType = CommandType.Text;

                    lector = cmd.ExecuteReader();

                    tabla.Load(lector);
                }
                catch (MySqlException ex)
                {
                    throw new Exception("Error al recuperar los pacientes", ex);
                }
                finally
                {
                    conexion.Close();
                }
                return tabla;
            }
        }
        public DataTable BuscarPaciente(string caracteres)
        {
            DataTable pacientesFiltro = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(ConexionBD.Cadena))
            {
                try
                {
                    conn.Open();

                    string query = "FiltrarPaciente";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@caracteres", $"%{caracteres}%");

                    lector = cmd.ExecuteReader();

                    pacientesFiltro.Load(lector);
                }
                catch (MySqlException ex)
                {
                    throw new Exception("Error al ejecutar la consulta en la base datos", ex);
                }
                finally
                {
                    conn.Close();
                }
                return pacientesFiltro;
            }
        }
        public DataTable FiltrarPaciente(string paciente)
        {
            DataTable nuevoPaciente = new();

            using MySqlConnection conn = new(ConexionBD.Cadena);

            try
            {
                conn.Open();

                string query = "SELECT ID_Paciente, UPPER(CONCAT(Apellido, ', ', Nombre, ' ', '(', FORMAT(DNI,0,'es_AR'), ')')) AS Paciente FROM nutrisys.Pacientes WHERE (UPPER(Apellido) LIKE UPPER(@paciente) OR UPPER(Nombre) LIKE UPPER(@paciente));";

                MySqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@paciente", paciente + "%");

                lector = cmd.ExecuteReader();

                nuevoPaciente.Load(lector);
            }
            catch (MySqlException ex)
            {
                throw new Exception("No fue posible encontrar el paciente ingresado", ex);
            }
            return nuevoPaciente;
        }
        public DataTable FiltrarFechasPacientesPAMI(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable pacientePAMI = new();

            using MySqlConnection conn = new(ConexionBD.Cadena);

            try
            {
                conn.Open();

                string query = "SELECT FORMAT(P.DNI, 0, 'es_AR') AS DNI, UPPER(CONCAT(P.Apellido, ', ', P.Nombre)) AS Paciente, DATE_FORMAT(HC.FechaConsulta, '%d/%m/%Y') AS Consulta FROM nutrisys.Pacientes P JOIN nutrisys.HistoriasClinicas HC ON HC.Id_Paciente = P.ID_Paciente WHERE P.Obra_Social = 'PAMI' AND HC.FechaConsulta BETWEEN @fechaInicio AND @fechaFin ORDER BY HC.FechaConsulta ASC;";

                MySqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@fechaFin", fechaFin);

                lector = cmd.ExecuteReader();

                pacientePAMI.Columns.Add("DNI");
                pacientePAMI.Columns.Add("Paciente");
                pacientePAMI.Columns.Add("Consulta");

                while (lector.Read())
                {
                    DataRow fila = pacientePAMI.NewRow();
                    fila["DNI"] = lector["DNI"].ToString();
                    fila["Paciente"] = lector["Paciente"].ToString();
                    fila["Consulta"] = lector["Consulta"];
                    pacientePAMI.Rows.Add(fila);
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No fue posible encontrar el paciente indicado con la obra social PAMI en las fechas indicadas", ex);
            }
            return pacientePAMI;
        }
        public (bool exito, string mensaje) InsertarPaciente(Paciente paciente)
        {
            using (MySqlConnection conexion = new MySqlConnection(ConexionBD.Cadena))
            {
                try
                {
                    conexion.Open();

                    string storedProcedure = "AgregarPaciente";

                    MySqlCommand cmd = new MySqlCommand(storedProcedure, conexion);
                    
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID_Paciente", paciente.IdPaciente.ToString());
                    cmd.Parameters.AddWithValue("@DNI", paciente.NuevoDNI);
                    cmd.Parameters.AddWithValue("@Nombre", paciente.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", paciente.Apellido);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", paciente.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@Telefono", paciente.Telefono);
                    cmd.Parameters.AddWithValue("@FechaRegistro", paciente.FechaRegistro);

                    if (paciente.IdDomicilio == Guid.Empty)
                        cmd.Parameters.AddWithValue("@Id_Domicilio", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@Id_Domicilio", paciente.IdDomicilio);

                    if (paciente.IdPais == Guid.Empty)
                        cmd.Parameters.AddWithValue("@Id_Pais", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@Id_Pais", paciente.IdPais);

                    cmd.Parameters.AddWithValue("@N_Afiliado", paciente.N_Afiliado);
                    cmd.Parameters.AddWithValue("@Obra_Social", paciente.ObraSocial);
                    cmd.Parameters.AddWithValue("@Email", paciente.Email);
                    cmd.Parameters.AddWithValue("@Sexo", paciente.Sexo);
                    cmd.Parameters.AddWithValue("@EstadoCivil", paciente.EstadoCivil);
                    cmd.Parameters.AddWithValue("@Ocupacion", paciente.Ocupacion);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    
                    if(filasAfectadas > 0)
                    {
                        return (true, $"El paciente {paciente.Nombre} {paciente.Apellido} fue dado de alta correctamente en la base de datos");
                    }

                    return (false, null);
                }
                catch(MySqlException ex)
                {
                    throw new Exception("Error al insertar un nuevo paciente", ex);
                }
            }
        }
        public void EditarPaciente(Paciente paciente)
        {
            using(MySqlConnection conn = new MySqlConnection(ConexionBD.Cadena))
            {
                try
                {
                    conn.Open();

                    string storedProcedure = "EditarPaciente";

                    MySqlCommand cmd = new MySqlCommand(storedProcedure, conn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_DNI_nuevo", paciente.NuevoDNI);
                    cmd.Parameters.AddWithValue("@p_dni_actual", paciente.DNIActual);
                    cmd.Parameters.AddWithValue("@p_Nombre", paciente.Nombre);
                    cmd.Parameters.AddWithValue("@p_Apellido", paciente.Apellido);
                    cmd.Parameters.AddWithValue("@p_FechaNacimiento", paciente.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@p_Telefono", paciente.Telefono);

                    if (paciente.IdDomicilio == Guid.Empty)
                        cmd.Parameters.AddWithValue("@p_Id_Domicilio", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@p_Id_Domicilio", paciente.IdDomicilio);

                    if (paciente.IdPais == Guid.Empty)
                        cmd.Parameters.AddWithValue("@p_Id_Pais", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@p_Id_Pais", paciente.IdPais);

                    cmd.Parameters.AddWithValue("@p_N_Afiliado", paciente.N_Afiliado);
                    cmd.Parameters.AddWithValue("@p_Obra_Social", paciente.ObraSocial);
                    cmd.Parameters.AddWithValue("@p_Email", paciente.Email);
                    cmd.Parameters.AddWithValue("@p_Sexo", paciente.Sexo);
                    cmd.Parameters.AddWithValue("@p_EstadoCivil", paciente.EstadoCivil);
                    cmd.Parameters.AddWithValue("@p_Ocupacion", paciente.Ocupacion);

                    cmd.ExecuteNonQuery();
                }
                catch(MySqlException ex)
                {
                    if (ex.Number == 1265 || ex.Number == 1406)
                    {
                        if (ex.Message.Contains("Email"))
                        {
                            throw new Exception("El valor ingresado para el campo Email excede los 30 caracteres permitidos.");
                        }
                    }
                    else
                    {
                        throw new Exception("Ocurrió un error al editar el paciente", ex);
                    }
                }
            }
        }
        public (bool existe, string? nombrePaciente) PacienteRegistrado(Int64 dni)
        {
            using MySqlConnection conexion = new(ConexionBD.Cadena);

            try
            {
                conexion.Open();

                string query = "SELECT CONCAT(Apellido, ' ', Nombre) AS Paciente FROM nutrisys.Pacientes WHERE DNI = @DNI LIMIT 1   ;";

                MySqlCommand cmd = new MySqlCommand(query, conexion);

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@DNI", dni);

                object resultado = cmd.ExecuteScalar();

                if (resultado != null)
                {
                    string? nombrePaciente = resultado.ToString();
                    return (true, nombrePaciente);
                }

                return (false, string.Empty);
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error al validar el paciente ingresado", ex);
            }
        }
    }
}