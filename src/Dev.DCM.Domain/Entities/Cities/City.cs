namespace Dev.DCM.Entities.Cities;

/// <summary>
/// İl
/// </summary>
public class City : Entity<int>
{
    /// <summary>
    /// İlçe Plaka Kodu
    /// </summary>
    public int PlateCode { get; set; }  

    /// <summary>
    /// İlçe Adı
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Şehirdeki İlçeler
    /// </summary>
    public ICollection<District> Districts { get; private set; } = new List<District>();
}
