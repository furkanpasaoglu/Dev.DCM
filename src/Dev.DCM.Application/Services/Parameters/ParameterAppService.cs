using System;
using Dev.DCM.Entities.Parameters;
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
}