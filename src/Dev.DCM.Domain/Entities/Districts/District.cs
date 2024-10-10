namespace Dev.DCM.Entities.Districts;

/// <summary>
/// İlçe
/// </summary>
public class District : Entity<Guid>
{
    /// <summary>
    /// İlçe Adı
    /// </summary>
    public string? Code { get; set; } 
    
    /// <summary>
    /// İlçe Adı
    /// </summary>
    public string Name { get; set; } = null!;


    /// <summary>
    /// Foreign key to City (İl)
    /// </summary>
    public Guid CityId { get; set; }
    public City City { get; set; } = default!;
}
