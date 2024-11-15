using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dev.DCM.Entities.TenantDetails;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dev.DCM.Services.TenantDetails;

public class TenantDetailAppService(
    IRepository<TenantDetail, Guid> repository,
    TenantDetailValidationService tenantDetailValidationService)
    :
        CrudAppService<
            TenantDetail,
            TenantDetailDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateTenantDetailDto>(repository),
        ITenantDetailAppService
{
    protected override string? GetPolicyName { get; set; } = Permissions.DCMPermissions.TenantDetails.Default;
    protected override string? GetListPolicyName { get; set; } = Permissions.DCMPermissions.TenantDetails.Default;
    protected override string? CreatePolicyName { get; set; } = Permissions.DCMPermissions.TenantDetails.Create;
    protected override string? UpdatePolicyName { get; set; } = Permissions.DCMPermissions.TenantDetails.Edit;
    protected override string? DeletePolicyName { get; set; } = Permissions.DCMPermissions.TenantDetails.Delete;

    public override async Task<PagedResultDto<TenantDetailDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        var queryable = await Repository.WithDetailsAsync(c => c.Tenant);
        var totalCount = await AsyncExecuter.CountAsync(queryable);
        var items = await AsyncExecuter
            .ToListAsync(queryable.PageBy(input)
                .OrderBy(c => c.Name)
            );
        
        return new PagedResultDto<TenantDetailDto>(
            totalCount,
            ObjectMapper.Map<List<TenantDetail>, List<TenantDetailDto>>(items)
        );
    }
    private async Task ValidateDtoAsync(CreateUpdateTenantDetailDto input, Guid? existingId = null)
    {
        await tenantDetailValidationService.IsTenantDetailNameUniqueAsync(input.Name, existingId);
    }
    
    public override async Task<TenantDetailDto> CreateAsync(CreateUpdateTenantDetailDto input)
    {
        await ValidateDtoAsync(input);
        return await base.CreateAsync(input);
    }
    
    public override async Task<TenantDetailDto> UpdateAsync(Guid id, CreateUpdateTenantDetailDto input)
    {
        await ValidateDtoAsync(input);
        return await base.UpdateAsync(id, input);
    }
}
   