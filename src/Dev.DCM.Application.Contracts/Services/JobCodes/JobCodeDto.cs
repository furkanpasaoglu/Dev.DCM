using System;
using Volo.Abp.Application.Dtos;

namespace Dev.DCM.Services.JobCodes;

/// <summary>
///  Meslek Kodları
/// </summary>
public class JobCodeDto : EntityDto<Guid>
{
    public int No { get; set; }
    public string Code { get; set; } = default!;
    public string Name { get; set; } = default!;
}