namespace Dev.DCM.Entities.ServiceTypes;

/// <summary>
/// Hizmet Tipleri (HIZMET_TIPI)
/// </summary>
public class ServiceType : Entity<Guid>
{
    /// <summary>
    /// No
    /// </summary>
    public int No { get; set; }

    /// <summary>
    /// İşletme Tipi
    /// </summary>
    public string BusinessType { get; set; } = null!;

    /// <summary>
    /// Altyapı Türü
    /// </summary>
    public string InfrastructureType { get; set; } = null!;

    /// <summary>
    /// Hizmet Türü
    /// </summary>
    public string ServiceTypeValue { get; set; } = null!;

    /// <summary>
    /// Değer Açıklama
    /// </summary>
    public string ValueDescription { get; set; } = null!;

    /// <summary>
    /// Hizmet Tipi Aktif Mi?
    ///  </summary>
    public bool IsActive { get; set; } = false;
}
