using System;
using System.Threading.Tasks;
using Dev.DCM.Entities.Parameters;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dev.DCM.Services.Parameters;

public class ParameterAppService :
    CrudAppService<
        Parameter,
        ParameterDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateParameterDto>,
    IParameterAppService
{
    public ParameterAppService(IRepository<Parameter, Guid> repository) : base(repository)
    {
        GetPolicyName = Permissions.DCMPermissions.Parameters.Default;
        GetListPolicyName = Permissions.DCMPermissions.Parameters.Default;
        CreatePolicyName = Permissions.DCMPermissions.Parameters.Create;
        UpdatePolicyName = Permissions.DCMPermissions.Parameters.Edit;
        DeletePolicyName = Permissions.DCMPermissions.Parameters.Delete;
    }

    public override async Task<ParameterDto> CreateAsync(CreateUpdateParameterDto input)
    {
        await IsParameterExists(input.Name);
        return await base.CreateAsync(input);
    }
    
    #region Validation

    private async Task IsParameterExists(string name)
    {
        var existing = await Repository.AnyAsync(c => c.Name == name);
        if (existing)
        {
            throw new UserFriendlyException(message: L["AlreadyExists"]);
        }
    }
   
    #endregion

}