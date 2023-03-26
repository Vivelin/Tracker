namespace Vivelin.Tracker.Data.Entities;

public class Human
{
    public Guid Id { get; set; }

    public virtual ICollection<Identity> Identities { get; set; }
        = new List<Identity>();

    public virtual ICollection<Nickname> Nicknames { get; set; }
        = new List<Nickname>();

    public int Opinion { get; set; }
}
