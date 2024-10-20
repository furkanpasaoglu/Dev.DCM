namespace Dev.DCM.Entities.Phones;

/// <summary>
/// Telefon
/// </summary>
public class Phone : FullAuditedEntity<Guid>
{
    /// <summary>
    /// Abone Id
    /// </summary>
    public Guid? SubscriberId { get; set; }
    public Subscriber? Subscriber { get; set; }

    public string Numbers { get; set; }  = null!;
}