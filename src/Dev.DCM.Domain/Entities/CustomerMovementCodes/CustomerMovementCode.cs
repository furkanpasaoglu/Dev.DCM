namespace Dev.DCM.Entities.CustomerMovementCodes;

/// <summary>
/// Müşteri Hareket Kodları
/// </summary>
public class CustomerMovementCode : Entity<int>
{
    /// <summary>
    /// Hareket Kodu
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Hareket Açıklaması
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Ne Şekilde İşleneceği (Processing Method)
    /// </summary>
    public string ProcessingMethod { get; set; }
}
