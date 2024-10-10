namespace Dev.DCM.Entities.CustomerMovementCodes;

/// <summary>
/// Müşteri Hareket Kodları
/// </summary>
public class CustomerMovementCode : Entity<Guid>
{
    /// <summary>
    /// Hareket Kodu
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// Hareket Açıklaması
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// Ne Şekilde İşleneceği (Processing Method)
    /// </summary>
    public string ProcessingMethod { get; set; } = null!;
}
