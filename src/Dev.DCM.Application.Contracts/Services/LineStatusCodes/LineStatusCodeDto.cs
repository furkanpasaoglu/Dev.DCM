using System;
using Volo.Abp.Application.Dtos;

namespace Dev.DCM.Services.LineStatusCodes;

/// <summary>
/// Hat Durum Kodu Dto
/// </summary>
public class LineStatusCodeDto : EntityDto<Guid>
{
    public string Code { get; set; } = default!;
    public string Status { get; set; } = default!;
    public string StatusDescription { get; set; } = default!;
}