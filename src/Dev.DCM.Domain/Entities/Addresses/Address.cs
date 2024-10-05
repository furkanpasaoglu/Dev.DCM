
namespace Dev.DCM.Entities.Addresses;

/// <summary>
/// ABONE_ADRES
/// </summary>
public class Address : FullAuditedEntity<Guid>
{
    /// <summary>
    /// ABONE_ADRES_E_MAIL
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// ABONE_ID
    /// </summary>
    public Guid SubscriberId { get; set; }

    /// <summary>
    /// ABONE
    /// </summary>
    public Subscriber? Subscriber { get; set; }

    /// <summary>
    /// IRTIBAT
    /// </summary>
    public ContactInfo? ContactInfo { get; set; }

    /// <summary>
    /// YERLESIM
    /// </summary>
    public ResidentialAddress? ResidentialAddress { get; set; } 
}
