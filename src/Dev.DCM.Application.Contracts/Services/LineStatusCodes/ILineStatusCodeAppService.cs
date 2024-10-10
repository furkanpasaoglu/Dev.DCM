using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Dev.DCM.Services.LineStatusCodes;

public interface ILineStatusCodeAppService :
    ICrudAppService<
        LineStatusCodeDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateLineStatusCodeDto>
{
    
}