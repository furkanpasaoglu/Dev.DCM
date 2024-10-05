namespace Dev.DCM.Entities.IdentityTypes;

/// <summary>
/// Kimlik Tipleri
/// </summary>
public class IdentityType : Entity<int>
{
    /// <summary>
    /// Belge Adı
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Belge Ait Olduğu Ülke Kodu
    /// </summary>
    public string? CountryCode { get; set; }

    /// <summary>
    /// Belge Tip Kodu
    /// </summary>
    public string? TypeCode { get; set; }

    /// <summary>
    /// Kimlik Seri No
    /// </summary>
    public string? SerialNo { get; set; }

    /// <summary>
    /// Kişi Kimlik No
    /// </summary>
    public string? IdentityNo { get; set; }
}
