using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Dev.DCM.Services.Parameters;

public interface IParameterAppService :
    ICrudAppService<
        ParameterDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateParameterDto>
{
    
}