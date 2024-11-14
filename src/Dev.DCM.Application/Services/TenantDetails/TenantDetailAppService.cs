using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dev.DCM.Entities.TenantDetails;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dev.DCM.Services.TenantDetails;

public class TenantDetailAppService :
    CrudAppService<
        TenantDetail,
        TenantDetailDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateTenantDetailDto>,
    ITenantDetailAppService
{
    public TenantDetailAppService(IRepository<TenantDetail, Guid> repository) : base(repository)
    {
        GetPolicyName = Permissions.DCMPermissions.TenantDetails.Default;
        GetListPolicyName = Permissions.DCMPermissions.TenantDetails.Default;
        CreatePolicyName = Permissions.DCMPermissions.TenantDetails.Create;
        UpdatePolicyName = Permissions.DCMPermissions.TenantDetails.Edit;
        DeletePolicyName = Permissions.DCMPermissions.TenantDetails.Delete;
    }
    
    public override async Task<PagedResultDto<TenantDetailDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        var queryable = await Repository.WithDetailsAsync(c => c.Tenant);
        var totalCount = await AsyncExecuter.CountAsync(queryable);
        var items = await AsyncExecuter.ToListAsync(queryable.PageBy(input));
        
        return new PagedResultDto<TenantDetailDto>(
            totalCount,
            ObjectMapper.Map<List<TenantDetail>, List<TenantDetailDto>>(items)
        );
    }
}
   