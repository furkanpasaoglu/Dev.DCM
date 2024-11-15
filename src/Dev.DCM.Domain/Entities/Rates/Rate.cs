using System.ComponentModel.DataAnnotations.Schema;

namespace Dev.DCM.Entities.Rates;

/// <summary>
/// Tarife
/// </summary>
public class Rate : FullAuditedEntity<Guid>
{
    public string Name { get; set; }
    
    public DateTime StartDate { get; set; }  
    public DateTime EndDate { get; set; } 
    
    [ForeignKey(nameof(Subscriber))]
    public Guid SubscriberId { get; set; }
    public Subscriber Subscriber { get; set; }
}