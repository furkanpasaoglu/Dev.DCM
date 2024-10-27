using System;
using System.ComponentModel.DataAnnotations;

namespace Dev.DCM.Services.TenantDetails;

public class CreateUpdateTenantDetailDto
{
    [Required]
    public string OperatorCode { get; set; } = null!;
    
    [Required]
    public string TaxNumber { get; set; }= null!;
    
    [Required]
    public string Name { get; set; } = null!;
    
    [Required]
    public Guid TenantId { get; set; }

}