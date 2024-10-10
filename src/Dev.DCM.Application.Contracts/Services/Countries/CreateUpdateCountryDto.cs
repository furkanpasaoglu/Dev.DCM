using System.ComponentModel.DataAnnotations;

namespace Dev.DCM.Services.Countries;

public class CreateUpdateCountryDto
{
    public string? Code { get; set; }
    [Required] public string Name { get; set; } = default!;
}