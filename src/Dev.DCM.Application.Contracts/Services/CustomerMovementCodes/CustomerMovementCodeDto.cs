using System;
using Volo.Abp.Application.Dtos;

namespace Dev.DCM.Services.CustomerMovementCodes;

/// <summary>
/// Hareket kodu için kullanılacak DTO
/// </summary>
public class CustomerMovementCodeDto : EntityDto<Guid>
{
    public string Code { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string ProcessingMethod { get; set; } = default!;
}