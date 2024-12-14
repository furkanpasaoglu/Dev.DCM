using System.ComponentModel.DataAnnotations.Schema;
using Dev.DCM.Entities.Lines;
using Dev.DCM.Entities.ServiceTypes;

namespace Dev.DCM.Entities.Services;

/// <summary>
/// Hizmet
/// </summary>
public class Service : FullAuditedEntity<Guid>
{
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    
    [ForeignKey(nameof(ServiceType))]
    public Guid ServiceTypeId { get; set; }
    public ServiceType? ServiceType { get; set; } 
    
    [ForeignKey(nameof(Line))]
    public Guid LineId { get; set; }
    public Line? Line { get; set; } 
}