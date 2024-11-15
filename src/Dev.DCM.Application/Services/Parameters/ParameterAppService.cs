using System;
using System.Threading.Tasks;
using Dev.DCM.Entities.Parameters;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dev.DCM.Services.Parameters;

public class ParameterAppService(IRepository<Parameter, Guid> repository, ParameterValidationService parameterValidationService) :
    CrudAppService<
        Parameter,
        ParameterDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateParameterDto>(repository),
    IParameterAppService
{
    protected override string? GetPolicyName { get; set; } = Permissions.DCMPermissions.Parameters.Default;
    protected override string? GetListPolicyName { get; set; } = Permissions.DCMPermissions.Parameters.Default;
    protected override string? CreatePolicyName { get; set; } = Permissions.DCMPermissions.Parameters.Create;
    protected override string? UpdatePolicyName { get; set; } = Permissions.DCMPermissions.Parameters.Edit;
    protected override string? DeletePolicyName { get; set; } = Permissions.DCMPermissions.Parameters.Delete;

    public override async Task<ParameterDto> CreateAsync(CreateUpdateParameterDto input)
    {
        await ValidateDtoAsync(input);
        return await base.CreateAsync(input);
    }
    
    private async Task ValidateDtoAsync(CreateUpdateParameterDto input)
    {
        await parameterValidationService.IsParameterExists(input.Name);
    }
    
    public override async Task<ParameterDto> UpdateAsync(Guid id, CreateUpdateParameterDto input)
    {
        await ValidateDtoAsync(input);
        return await base.UpdateAsync(id, input);
    }
}