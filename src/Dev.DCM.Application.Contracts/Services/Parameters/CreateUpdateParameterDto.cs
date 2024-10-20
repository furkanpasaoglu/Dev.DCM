using System.ComponentModel.DataAnnotations;

namespace Dev.DCM.Services.Parameters;

public class CreateUpdateParameterDto
{
    [Required]
    public string Name { get; set; } = default!;
    [Required]
    public string Description { get; set; } = default!;
    [Required]
    public string Value { get; set; } = default!;
}