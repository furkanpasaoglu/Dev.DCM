using System;
using Volo.Abp.Application.Dtos;

namespace Dev.DCM.Services.Parameters;

public class ParameterDto : EntityDto<Guid>
{
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string Value { get; set; } = default!;
}