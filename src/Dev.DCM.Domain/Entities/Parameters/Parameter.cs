namespace Dev.DCM.Entities.Parameters;

public class Parameter : Entity<Guid>
{
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string Value { get; set; } = default!;
}