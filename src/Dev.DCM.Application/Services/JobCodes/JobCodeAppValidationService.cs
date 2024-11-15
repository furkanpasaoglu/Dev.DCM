using Dev.DCM.Entities.JobCodes;
using Dev.DCM.Localization;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Dev.DCM.Services.JobCodes
{
    public class JobCodeAppValidationService(IRepository<JobCode, Guid> repository, IStringLocalizer<DCMResource> L) : ITransientDependency
    {

        public async Task IsJobCodeExists(int no, string? code)
        {
            var existing = await repository.FirstOrDefaultAsync(c => c.No == no || c.Code == code);
            if (existing != null)
            {
                throw new UserFriendlyException(message: L["AlreadyExists"]);
            }
        }
    }
}
