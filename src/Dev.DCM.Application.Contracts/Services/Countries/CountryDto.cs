using System;
using Volo.Abp.Application.Dtos;

namespace Dev.DCM.Services.Countries;

public class CountryDto : EntityDto<Guid>
{
    public string? Code { get; set; }
    public string Name { get; set; } = null!;
}