namespace DugnadApp.Models
{
    public class Deltakelse
    {
        public int Id { get; set; }
        public int BeboerId { get; set; }
        public Beboer? Beboer { get; set; }
        public int DugnadId { get; set; }
        public Dugnad? Dugnad { get; set; }
        public decimal  Timer { get; set; }
        public string? Beskrivelse { get; set; }
        public DateTime RegistrertDato { get; set; } = DateTime.UtcNow;
    }
}
