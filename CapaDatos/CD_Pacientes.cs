using System.Data;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class CD_Pacientes
    {
        MySqlDataReader lector;
        public DataTable ListarPacientes()
        {
            DataTable tabla = new DataTable();
            using (MySqlConnection conexion = new MySqlConnection(ConexionBD.Cadena))
            {
                try
                {
                    conexion.Open();

                    string storedProcedure = "ListarPacientes";

                    MySqlCommand cmd = new MySqlCommand(storedProcedure, conexion);

                    cmd.CommandType = CommandType.StoredProcedure;

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

                string query = "SELECT ID_Paciente, UPPER(CONCAT(Apellido, ', ', Nombre, ' ', '(', FORMAT(DNI,0,'es_AR'), ')')) AS Paciente FROM Pacientes WHERE (UPPER(Apellido) LIKE UPPER(@paciente) OR UPPER(Nombre) LIKE UPPER(@paciente));";

                MySqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@paciente", "%" + paciente + "%");

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

                string query = "SELECT FORMAT(P.DNI, 0, 'es_AR') AS DNI, UPPER(CONCAT(P.Apellido, ', ', P.Nombre)) AS Paciente, DATE_FORMAT(HC.FechaConsulta, '%d/%m/%Y') AS Consulta FROM Pacientes P JOIN HistoriasClinicas HC ON HC.Id_Paciente = P.ID_Paciente WHERE P.Obra_Social = 'PAMI' AND HC.FechaConsulta BETWEEN @fechaInicio AND @fechaFin ORDER BY HC.FechaConsulta ASC;";

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
        public void InsertarPaciente(Guid id, Int64 dni, string nombre, string apellido, DateTime fechaNacimiento, long telefono, DateTime fechaRegistro, Guid id_domicilio, Guid id_Pais, string? n_afiliado,string obraSocial, string email, string sexo, string estadoCivil, string ocupacion)
        {
            using (MySqlConnection conexion = new MySqlConnection(ConexionBD.Cadena))
            {
                try
                {
                    conexion.Open();

                    string storedProcedure = "AgregarPaciente";

                    MySqlCommand cmd = new MySqlCommand(storedProcedure, conexion);
                    
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID_Paciente", id.ToString());
                    cmd.Parameters.AddWithValue("@DNI", dni);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellido", apellido);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                    cmd.Parameters.AddWithValue("@Telefono", telefono);
                    cmd.Parameters.AddWithValue("@FechaRegistro", fechaRegistro);

                    if (id_domicilio == Guid.Empty)
                        cmd.Parameters.AddWithValue("@Id_Domicilio", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@Id_Domicilio", id_domicilio);

                    if (id_Pais == Guid.Empty)
                        cmd.Parameters.AddWithValue("@Id_Pais", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@Id_Pais", id_Pais);

                    cmd.Parameters.AddWithValue("@N_Afiliado", n_afiliado);
                    cmd.Parameters.AddWithValue("@Obra_Social", obraSocial);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Sexo", sexo);
                    cmd.Parameters.AddWithValue("@EstadoCivil", estadoCivil);
                    cmd.Parameters.AddWithValue("@Ocupacion", ocupacion);

                    cmd.ExecuteNonQuery();
                }
                catch(MySqlException ex)
                {
                    throw new Exception("Error al insertar un nuevo paciente", ex);
                }
            }
        }
        public void EditarPaciente(Int64 dni_nuevo, Int64 dni_actual, string nombre, string apellido, DateTime fechaNacimiento, long telefono, Guid id_Pais, Guid? idDomicilio, string? n_afiliado, string obraSocial,string email, string sexo, string estadoCivil, string ocupacion)
        {
            using(MySqlConnection conn = new MySqlConnection(ConexionBD.Cadena))
            {
                try
                {
                    conn.Open();

                    string storedProcedure = "EditarPaciente";

                    MySqlCommand cmd = new MySqlCommand(storedProcedure, conn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_DNI_nuevo", dni_nuevo);
                    cmd.Parameters.AddWithValue("@p_dni_actual", dni_actual);
                    cmd.Parameters.AddWithValue("@p_Nombre", nombre);
                    cmd.Parameters.AddWithValue("@p_Apellido", apellido);
                    cmd.Parameters.AddWithValue("@p_FechaNacimiento", fechaNacimiento);
                    cmd.Parameters.AddWithValue("@p_Telefono", telefono);

                    if (idDomicilio == Guid.Empty)
                        cmd.Parameters.AddWithValue("@p_Id_Domicilio", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@p_Id_Domicilio", idDomicilio);

                    if (id_Pais == Guid.Empty)
                        cmd.Parameters.AddWithValue("@p_Id_Pais", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@p_Id_Pais", id_Pais);

                    cmd.Parameters.AddWithValue("@p_N_Afiliado", n_afiliado);
                    cmd.Parameters.AddWithValue("@p_Obra_Social", obraSocial);
                    cmd.Parameters.AddWithValue("@p_Email", email);
                    cmd.Parameters.AddWithValue("@p_Sexo", sexo);
                    cmd.Parameters.AddWithValue("@p_EstadoCivil", estadoCivil);
                    cmd.Parameters.AddWithValue("@p_Ocupacion", ocupacion);

                    cmd.ExecuteNonQuery();
                }
                catch(MySqlException ex)
                {
                    throw new Exception(ex.ToString());
                }
            }
        }
        public bool PacienteRegistrado(Int64 dni)
        {
            using MySqlConnection conexion = new(ConexionBD.Cadena);
            try
            {
                conexion.Open();

                string query = "SELECT COUNT(*) FROM Pacientes WHERE DNI = @DNI";

                MySqlCommand cmd = new MySqlCommand(query, conexion);

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@DNI", dni);

                long count = (long)cmd.ExecuteScalar();

                return count > 0;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error al validar el paciente ingresado", ex);
            }
        }
    }
}