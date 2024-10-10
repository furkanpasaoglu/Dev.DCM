namespace Dev.DCM.Entities.Countries;

public class Country : Entity<Guid>
{

    /// <summary>
    /// Ülke Kodu
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Ülke Adı
    /// </summary>
    public string Name { get; set; } = null!;

    public ICollection<City> Cities { get; private set; } = new List<City>();
}
