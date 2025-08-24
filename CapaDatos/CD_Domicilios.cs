using CapaDatos.Enums;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class CD_Domicilios
    {
        public CodigosStatus InsertarDomicilio(Guid idDomicilio, string? calle, int? numeracion, Guid idPais, Guid IdProvincia, string? localidad)
        {
            using MySqlConnection conn = new(ConexionBD.Cadena);

            try
            {
                conn.Open();

                string query = "INSERT INTO Domicilios VALUES (@ID_Domicilio, @calle, @numeracion, @idPais, @idProvincia, @localidad);";

                MySqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@ID_Domicilio", idDomicilio);

                if (!string.IsNullOrEmpty(calle))
                {
                    cmd.Parameters.AddWithValue("@calle", calle);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@calle", DBNull.Value);
                }

                if (numeracion == null)
                {
                    cmd.Parameters.AddWithValue("@numeracion", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@numeracion", numeracion);
                }
               
                cmd.Parameters.AddWithValue("@idPais", idPais);
                cmd.Parameters.AddWithValue("@idProvincia", IdProvincia);

                if(!string.IsNullOrEmpty(localidad))
                {
                    cmd.Parameters.AddWithValue("@localidad", localidad);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@localidad", DBNull.Value);
                }

                int resultado = cmd.ExecuteNonQuery();

                return resultado > 0 ? CodigosStatus.Ok : CodigosStatus.Error;
            }
            catch (MySqlException ex)
            {
                if(ex.Number == 10012)
                    return CodigosStatus.Duplicado;
                return CodigosStatus.Error;
            }
        }
        public Guid? BuscarDomicilio(string? calle, int? numeracion, Guid idPais, Guid idProvincia, string? localidad)
        {
            using MySqlConnection conn = new(ConexionBD.Cadena);

            try
            {
                conn.Open();

                string query = "SELECT ID_Domicilio FROM Domicilios WHERE Calle = @calle AND ((Numero IS NULL AND @numero IS NULL) OR Numero = @numero) AND Id_Provincia = @idProvincia AND Id_Pais = @idPais AND Localidad = @localidad LIMIT 1;";

                MySqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@calle", calle ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@numero", numeracion.HasValue ? numeracion : (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@idProvincia", idProvincia);
                cmd.Parameters.AddWithValue("@idPais", idPais);
                cmd.Parameters.AddWithValue("@localidad", localidad ?? (object)DBNull.Value);

                var resultado = cmd.ExecuteScalar();

                if (resultado != null && resultado != DBNull.Value)
                {
                    return Guid.Parse(resultado.ToString());
                }
                else
                {
                    return (Guid?)null;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Hubo un error al buscar el domicilio", ex);
            }
        }
        public CodigosStatus EditarDomicilio(Guid idDomicilio, string? calle, int? numeracion, Guid idPais, Guid idProvincia, string? localidad)
        {
            using MySqlConnection conn = new (ConexionBD.Cadena);

            try
            {
                conn.Open();

                string query = "UPDATE Domicilios SET Calle = @calle, Numero = @altura, Id_Pais = @idPais, Id_Provincia = @id_Provincia, Localidad = @localidad WHERE ID_Domicilio = @idDomicilio;";

                MySqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@idDomicilio", idDomicilio);
                cmd.Parameters.AddWithValue("@calle", calle);
                cmd.Parameters.AddWithValue("@altura", numeracion);
                cmd.Parameters.AddWithValue("@idPais", idPais);
                cmd.Parameters.AddWithValue("@id_Provincia", idProvincia);
                cmd.Parameters.AddWithValue("@localidad", localidad);

                int resultado = cmd.ExecuteNonQuery();

                return resultado > 0 ? CodigosStatus.Ok : CodigosStatus.Error;
            }
            catch (MySqlException ex)
            {
                throw new Exception("No fue posible editar el domicilio del paciente", ex);
            }
        }
    }
}
