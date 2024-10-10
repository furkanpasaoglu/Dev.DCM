using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Dev.DCM.Services.IdentityTypes;

public interface IIdentityTypeAppService :
    ICrudAppService<
        IdentityTypeDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateIdentityTypeDto>
{
    
}