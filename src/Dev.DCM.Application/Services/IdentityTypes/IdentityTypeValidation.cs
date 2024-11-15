using Dev.DCM.Entities.IdentityTypes;
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

namespace Dev.DCM.Services.IdentityTypes
{
    public class IdentityTypeValidation(IRepository<IdentityType, Guid> repository, IStringLocalizer<DCMResource> L) : ITransientDependency
    {



        public async Task IsIdentityTypeExists(int no)
        {
            var existing = await repository.FirstOrDefaultAsync(c => c.No == no);
            if (existing != null)
            {
                throw new UserFriendlyException(message: L["AlreadyExists"]);
            }
        }
    }
}
