using System.ComponentModel.DataAnnotations;

namespace Dev.DCM.Services.CustomerMovementCodes;

public class CreateUpdateCustomerMovementCodeDto
{
    [Required]
    public string Code { get; set; } = default!;
    [Required]
    public string Description { get; set; } = default!;
    [Required]
    public string ProcessingMethod { get; set; } = default!;
}