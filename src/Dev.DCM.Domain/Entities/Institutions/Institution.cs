
namespace Dev.DCM.Entities.Institutions;

/// <summary>
/// KURUM
/// </summary>
public class Institution : FullAuditedEntity<Guid>
{
    /// <summary>
    /// Kurum Adresi (KURUM_ADRES)
    /// </summary>
    public string? InstitutionAddress { get; set; }

    /// <summary>
    /// Kuruma bağlı yetkililer
    /// </summary>
    public ICollection<AuthorizedPerson>? AuthorizedPersons { get; set; } = new List<AuthorizedPerson>();

}
