namespace Dev.DCM.Entities.IdentityTypes;

/// <summary>
/// Kimlik Tipleri
/// </summary>
public class IdentityType : Entity<Guid>
{
    /// <summary>
    /// Kimlik Tipi No
    /// </summary>
    public int No { get; set; }

    /// <summary>
    /// Belge Adı
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Belge Ait Olduğu Ülke Kodu
    /// </summary>
    public string CountryCode { get; set; } = null!;

    /// <summary>
    /// Belge Tip Kodu
    /// </summary>
    public string TypeCode { get; set; } = null!;

    /// <summary>
    /// Kimlik Seri No
    /// </summary>
    public string SerialNo { get; set; } = null!;

    /// <summary>
    /// Kişi Kimlik No
    /// </summary>
    public string IdentityNo { get; set; } = null!;
}
