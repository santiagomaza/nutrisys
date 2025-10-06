namespace CapaEntidades
{
    public class DatoAntropometrico
    {
        public Guid IdDatoAntropometrico { get; set; }
        public Guid IdPaciente { get; set; }
        public decimal? Peso {  get; set; }
        public decimal? Talla { get; set; }
        public decimal? IMC { get; set; }
        public decimal? MusculoEsqueletico { get; set; }
        public decimal? PorcentajeGC { get; set; }
        public decimal? NivelGV {  get; set; }
        public int? EdadCorporal { get; set; }
        public DateTime FechaEvolucion { get; set; }
        public DateTime FechaUltimaModificacion { get; set; }

        public DatoAntropometrico(Guid idPaciente, decimal? peso, decimal? talla, decimal? imc, decimal? musculoEsqueletico, decimal? porcentajeGC, decimal? nivelGV, int? edadCorporal, DateTime fechaEvolucion)
        {
            IdDatoAntropometrico = Guid.NewGuid();
            IdPaciente = idPaciente;
            Peso = peso;
            Talla = talla;
            IMC = imc;
            MusculoEsqueletico = musculoEsqueletico;
            PorcentajeGC = porcentajeGC;
            NivelGV = nivelGV;
            EdadCorporal = edadCorporal;
            FechaEvolucion = fechaEvolucion;
            FechaUltimaModificacion = DateTime.Now;
        }
        public DatoAntropometrico(Guid idDatoAntropometrico, Guid idPaciente, decimal? peso, decimal? talla, decimal? imc, decimal? musculoEsqueletico, decimal? porcentajeGC, decimal? nivelGV, int? edadCorporal, DateTime fechaEvolucion)
        {
            IdDatoAntropometrico = idDatoAntropometrico;
            IdPaciente = idPaciente;
            Peso = peso;
            Talla = talla;
            IMC = imc;
            MusculoEsqueletico = musculoEsqueletico;
            PorcentajeGC = porcentajeGC;
            NivelGV = nivelGV;
            EdadCorporal = edadCorporal;
            FechaEvolucion = fechaEvolucion;
            FechaUltimaModificacion = DateTime.Now;
        }
    }
}
