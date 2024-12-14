using System.ComponentModel.DataAnnotations.Schema;

namespace Dev.DCM.Entities.IdentityDocuments;

/// <summary>
/// ABONE_KIMLIK Entity
/// </summary>
public class IdentityDocument : FullAuditedEntity<Guid>
{
    /// <summary>
    /// ABONE_KIMLIK_CILT_NO
    /// </summary>
    public string? VolumeNumber { get; set; }

    /// <summary>
    /// ABONE_KIMLIK_KUTUK_NO
    /// </summary>
    public string? FamilyRegistryNumber { get; set; }

    /// <summary>
    /// ABONE_KIMLIK_SAYFA_NO
    /// </summary>
    public string? PageNumber { get; set; }

    /// <summary>
    /// ABONE_KIMLIK_IL
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// ABONE_KIMLIK_ILCE
    /// </summary>
    public string? District { get; set; }

    /// <summary>
    /// ABONE_KIMLIK_MAHALLE_KOY
    /// </summary>
    public string? NeighborhoodVillage { get; set; }

    /// <summary>
    /// ABONE_KIMLIK_TIPI
    /// </summary>
    public string? IdentityType { get; set; }

    /// <summary>
    /// ABONE_KIMLIK_SERI_NO
    /// </summary>
    public string? SerialNumber { get; set; }

    /// <summary>
    /// ABONE_KIMLIK_VERILDIGI_YER
    /// </summary>
    public string? IssuedPlace { get; set; }

    /// <summary>
    /// ABONE_KIMLIK_VERILDIGI_TARIH
    /// </summary>
    public DateTime? IssuedDate { get; set; }

    /// <summary>
    /// ABONE_KIMLIK_AIDIYETI
    /// </summary>
    public string? Affiliation { get; set; }

    /// <summary>
    /// ABONE_ID
    /// </summary>
    public Guid SubscriberId { get; set; }

    /// <summary>
    /// ABONE
    /// </summary>
    public Subscriber Subscriber { get; set; } = default!;
}
