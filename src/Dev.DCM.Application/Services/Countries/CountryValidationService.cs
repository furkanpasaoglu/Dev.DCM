using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp;
using Dev.DCM.Entities.Countries;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using Dev.DCM.Localization;

namespace Dev.DCM.Services.Countries
{
    public class CountryValidationService(IRepository<Country, Guid> repository, IStringLocalizer<DCMResource> L): ITransientDependency
    {



        public async Task IsCountryNameUniqueAsync(string name, Guid? existingId = null)
        {
            var existingCountry = await repository.FirstOrDefaultAsync(c => c.Name == name);
            if (existingCountry != null && existingCountry.Id != existingId)
            {
                throw new UserFriendlyException(L["AlreadyExists"]);
            }
        }
        
    }
}
