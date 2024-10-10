namespace Dev.DCM.Entities.Cities;

/// <summary>
/// İl
/// </summary>
public class City : Entity<Guid>
{
    /// <summary>
    /// İlçe Plaka Kodu
    /// </summary>
    public string? Code { get; set; }  

    /// <summary>
    /// İlçe Adı
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Şehirdeki İlçeler
    /// </summary>
    public ICollection<District> Districts { get; private set; } = new List<District>();

    public Guid CountryId { get; set; }
    public Country Country { get; set; } = default!;
}
