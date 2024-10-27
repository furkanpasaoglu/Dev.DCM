using Dev.DCM.Entities.Sales;

namespace Dev.DCM.Entities.Phones;

/// <summary>
/// Telefon
/// </summary>
public class Phone : FullAuditedEntity<Guid>
{
    public string Number { get; set; } = null!;
    public bool? IsActive { get; set; }
    
    public Guid SubscriberId { get; set; }
    public Subscriber Subscriber { get; set; } = null!;
    
    public Sale Sale { get; set; } = null!;
}