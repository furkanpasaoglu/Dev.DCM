using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace Dev.DCM.Services.Districts;

public class DistrictDto : EntityDto<Guid>
{
    public string? Code { get; set; }
    [Required] public string Name { get; set; } = default!;
}