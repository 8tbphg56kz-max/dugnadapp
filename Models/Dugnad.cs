namespace DugnadApp.Models
{
    public class Dugnad
    {
        public int Id { get; set; }
        public string Navn { get; set; } = "";
        public bool Aktiv { get; set; } = true;
        public bool KreverBeskrivelse { get; set; }
    }
}
