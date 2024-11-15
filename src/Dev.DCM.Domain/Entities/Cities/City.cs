using System.ComponentModel.DataAnnotations.Schema;
using Dev.DCM.Entities.Aihs;

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
    public string Name { get; set; } = string.Empty;


    [ForeignKey(nameof(Country))]
    public Guid CountryId { get; set; }
    public Country Country { get; set; } = default!;
    public ICollection<ResidentialAddress> ResidentialAddresses { get; private set; } = new List<ResidentialAddress>();
    public ICollection<Aih> Aihs { get; private set; } = new List<Aih>();
    public ICollection<District> Districts { get; private set; } = new List<District>();
}
