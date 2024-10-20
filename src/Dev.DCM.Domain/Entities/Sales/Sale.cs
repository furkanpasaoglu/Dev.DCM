using Dev.DCM.Entities.ServiceTypes;

namespace Dev.DCM.Entities.Sales;

/// <summary>
/// Satış
/// </summary>
public class Sale  : FullAuditedEntity<Guid>
{
    /// <summary>
    /// Abone Id - Satışın bağlı olduğu abone
    /// </summary>
    public Guid SubscriberId { get; set; }

    /// <summary>
    /// Abone - Relation
    /// </summary>
    public Subscriber Subscriber { get; set; } = null!;
    
    /// <summary>
    /// Hizmet Tipi Id - Hizmet tipinin seçileceği alan (Foreign Key)
    /// </summary>
    public Guid ServiceTypeId { get; set; }

    /// <summary>
    /// Hizmet Tipi - Relation
    /// </summary>
    public ServiceType ServiceType { get; set; } = null!;
}