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
        GetPolicyName = Permissions.DCMPermissions.TenantDetail.Default;
        GetListPolicyName = Permissions.DCMPermissions.TenantDetail.Default;
        CreatePolicyName = Permissions.DCMPermissions.TenantDetail.Create;
        UpdatePolicyName = Permissions.DCMPermissions.TenantDetail.Edit;
        DeletePolicyName = Permissions.DCMPermissions.TenantDetail.Delete;
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
   