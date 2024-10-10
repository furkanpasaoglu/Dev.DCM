using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Dev.DCM.Services.ServiceTypes;

public interface IServiceTypeAppService : 
    ICrudAppService<
        ServiceTypeDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateServiceTypeDto>
{
    
}