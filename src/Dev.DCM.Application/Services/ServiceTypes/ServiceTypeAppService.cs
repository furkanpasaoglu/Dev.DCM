using Dev.DCM.Entities.ServiceTypes;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dev.DCM.Services.ServiceTypes;

public class ServiceTypeAppService :
    CrudAppService<
        ServiceType,
        ServiceTypeDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateServiceTypeDto>,
    IServiceTypeAppService
{
    public ServiceTypeAppService(IRepository<ServiceType, Guid> repository) : base(repository)
    {
        GetPolicyName = Permissions.DCMPermissions.Types.ServiceTypes.Default;
        GetListPolicyName = Permissions.DCMPermissions.Types.ServiceTypes.Default;
        CreatePolicyName = Permissions.DCMPermissions.Types.ServiceTypes.Create;
        UpdatePolicyName = Permissions.DCMPermissions.Types.ServiceTypes.Edit;
        DeletePolicyName = Permissions.DCMPermissions.Types.ServiceTypes.Delete;
    }

    public override async Task<ServiceTypeDto> CreateAsync(CreateUpdateServiceTypeDto input)
    {
        await IsServiceTypeExists(input.No, input.ServiceTypeValue);
        return await base.CreateAsync(input);
    }

    #region Validation

    private async Task IsServiceTypeExists(int no, string serviceTypeValue)
    {
        var existing = await Repository.AnyAsync(c =>c.No == no || c.ServiceTypeValue == serviceTypeValue);
        if (existing)
        {
            throw new UserFriendlyException(message: L["AlreadyExists"]);
        }
    }

    #endregion
    
}
