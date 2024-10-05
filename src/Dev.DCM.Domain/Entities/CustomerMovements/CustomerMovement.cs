namespace Dev.DCM.Entities.CustomerMovements;

/// <summary>
/// MUSTERI_HAREKET Entity
/// </summary>
public class CustomerMovement : FullAuditedEntity<Guid>
{
    /// <summary>
    /// MUSTERI_HAREKET_KODU
    /// </summary>
    public int? MovementCode { get; set; }

    /// <summary>
    /// MUSTERI_HAREKET_ACIKLAMA
    /// </summary>
    public string? MovementDescription { get; set; }

    /// <summary>
    /// MUSTERI_HAREKET_ZAMANI
    /// </summary>
    public DateTime? MovementTime { get; set; }
}
