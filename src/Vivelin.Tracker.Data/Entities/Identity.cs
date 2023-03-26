namespace Vivelin.Tracker.Data.Entities;

/// <summary>
/// Represents a human's identity on a platform.
/// </summary>
public class Identity
{
    public Identity(Guid humanId, Platform platform, string externalId)
    {
        HumanId = humanId;
        Platform = platform;
        ExternalId = externalId ?? throw new ArgumentNullException(nameof(externalId));
    }

    /// <summary>
    /// Gets or sets a unique ID for the identity.
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    /// Gets or sets the ID of the human associated with the identity.
    /// </summary>
    public Guid HumanId { get; set; }

    /// <summary>
    /// Gets or sets the human associated with the identity.
    /// </summary>
    public Human? Human { get; set; }

    /// <summary>
    /// Gets or sets the platform on which the human is found.
    /// </summary>
    public Platform Platform { get; set; }

    /// <summary>
    /// Gets or sets the ID of the human on the platform.
    /// </summary>
    public string ExternalId { get; set; }

    /// <summary>
    /// Gets or sets the name of the human as it is displayed on the
    /// platform.
    /// </summary>
    public string? DisplayName { get; set; }
}
