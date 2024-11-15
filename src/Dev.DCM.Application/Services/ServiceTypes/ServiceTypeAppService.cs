using Dev.DCM.Entities.ServiceTypes;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dev.DCM.Services.ServiceTypes;

public class ServiceTypeAppService(
    IRepository<ServiceType, Guid> repository,
    ServiceTypeValidationService serviceTypeValidationService)
    :
        CrudAppService<
            ServiceType,
            ServiceTypeDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateServiceTypeDto>(repository),
        IServiceTypeAppService
{
    protected override string? GetPolicyName { get; set; } = Permissions.DCMPermissions.Types.ServiceTypes.Default;
    protected override string? GetListPolicyName { get; set; } = Permissions.DCMPermissions.Types.ServiceTypes.Default;
    protected override string? CreatePolicyName { get; set; } = Permissions.DCMPermissions.Types.ServiceTypes.Create;
    protected override string? UpdatePolicyName { get; set; } = Permissions.DCMPermissions.Types.ServiceTypes.Edit;
    protected override string? DeletePolicyName { get; set; } = Permissions.DCMPermissions.Types.ServiceTypes.Delete;

    private async Task ValidateDtoAsync(CreateUpdateServiceTypeDto input, Guid? existingId = null)
    {
        await serviceTypeValidationService.IsServiceTypeExistsAsync(input.No, input.ServiceTypeValue, existingId);
    }
    
    public override async Task<ServiceTypeDto> CreateAsync(CreateUpdateServiceTypeDto input)
    {
        await ValidateDtoAsync(input);
        return await base.CreateAsync(input);
    }
    
    public override async Task<ServiceTypeDto> UpdateAsync(Guid id, CreateUpdateServiceTypeDto input)
    {
        await ValidateDtoAsync(input, id);
        return await base.UpdateAsync(id, input);
    }
    
}
