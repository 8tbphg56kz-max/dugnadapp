namespace DugnadApp.Models;

public class LoginToken
{
    public int Id { get; set; }

    public int BeboerId { get; set; }

    public string Token { get; set; } = "";

    public DateTime Opprettet { get; set; }

    public DateTime Utloper { get; set; }

    public bool Brukt { get; set; }

    public Beboer? Beboer { get; set; }
}