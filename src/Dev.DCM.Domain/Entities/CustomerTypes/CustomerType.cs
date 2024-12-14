namespace Dev.DCM.Entities.CustomerTypes;

/// <summary>
/// Müşteri Tipi Entity
/// </summary>
public class CustomerType : Entity<Guid>
{
    public string Name { get; set; }
    public string Value { get; set; }
    
    public Subscriber Subscriber { get; set; }
    public Guid SubscriberId { get; set; }
}