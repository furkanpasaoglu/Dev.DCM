namespace Dev.DCM.Entities.ServiceTypes;

/// <summary>
/// Hizmet Tipleri
/// </summary>
public class ServiceType : Entity<int>
{
    /// <summary>
    /// İşletme Tipi
    /// </summary>
    public string? BusinessType { get; set; }

    /// <summary>
    /// Altyapı Türü
    /// </summary>
    public string? InfrastructureType { get; set; }

    /// <summary>
    /// Hizmet Türü
    /// </summary>
    public string? ServiceTypeValue { get; set; }

    /// <summary>
    /// Değer Açıklama
    /// </summary>
    public string? ValueDescription { get; set; }
}
