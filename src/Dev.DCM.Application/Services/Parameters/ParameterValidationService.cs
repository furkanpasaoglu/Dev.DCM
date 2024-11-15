using System;
using System.Threading.Tasks;
using Dev.DCM.Entities.Parameters;
using Dev.DCM.Localization;
using Microsoft.Extensions.Localization;
using Volo.Abp;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Dev.DCM.Services.Parameters;

public class ParameterValidationService(IRepository<Parameter, Guid> parameterRepository, IStringLocalizer<DCMResource> l) : ITransientDependency
{
    public async Task IsParameterExists(string name)
    {
        var existing = await parameterRepository.AnyAsync(c => c.Name == name);
        if (existing)
        {
            throw new UserFriendlyException(message: l["ParameterAlreadyExists"]);
        }
    }
}