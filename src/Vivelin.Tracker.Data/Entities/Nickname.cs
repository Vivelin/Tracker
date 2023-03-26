namespace Vivelin.Tracker.Data.Entities;

public class Nickname
{
    public Nickname(Guid humanId, string displayName)
    {
        HumanId = humanId;
        DisplayName = displayName ?? throw new ArgumentNullException(nameof(displayName));
    }

    public Guid HumanId { get; init; }

    public Human? Human { get; set; }

    public string DisplayName { get; set; }
}
