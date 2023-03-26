namespace Vivelin.Tracker.Data.Entities;

public class Human
{
    public Guid Id { get; set; }

    public virtual ICollection<Identity> Identities { get; set; }
        = new List<Identity>();

    public int Opinion { get; set; }
}
