namespace CapaEntidades
{
    public class Paciente
    {
        public Guid IdPaciente {  get; set; }
        public Int64 NuevoDNI { get; set; }
        public Int64 DNIActual { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string? Sexo { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public long Telefono { get; set; }
        public Guid? IdDomicilio { get; set; }
        public Guid? IdPais { get; set; }
        public string? N_Afiliado { get; set; }
        public string? ObraSocial { get; set; }
        public string? Email { get; set; }
        public string? EstadoCivil {  get; set; }
        public string? Ocupacion {  get; set; }

        public Paciente(Int64 DNI, string nombre, string apellido, DateTime? fechaNacimiento, string? sexo, long telefono, Guid? idDomicilio, Guid? idPais, string? n_Afiliado, string? obraSocial, string? email, string? estadoCivil, string? ocupacion)
        {
            IdPaciente = Guid.NewGuid();
            NuevoDNI = DNI;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Sexo = sexo;
            FechaRegistro = DateTime.Now;
            Telefono = telefono;
            IdDomicilio = idDomicilio;
            IdPais = idPais;
            N_Afiliado = n_Afiliado;
            ObraSocial = obraSocial;
            Email = email;
            EstadoCivil = estadoCivil;
            Ocupacion = ocupacion;
        }

        public Paciente(Int64 nuevoDNI, Int64 DNI_Actual, string nombre, string apellido, DateTime? fechaNacimiento, string? sexo, long telefono, Guid? idDomicilio, Guid? idPais, string? n_Afiliado, string? obraSocial, string? email, string? estadoCivil, string? ocupacion)
        {
            NuevoDNI = nuevoDNI;
            DNIActual = DNI_Actual;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Sexo = sexo;
            Telefono = telefono;
            IdDomicilio = idDomicilio;
            IdPais = idPais;
            N_Afiliado = n_Afiliado;
            ObraSocial = obraSocial;
            Email = email;
            EstadoCivil = estadoCivil;
            Ocupacion = ocupacion;
        }
    }
}
