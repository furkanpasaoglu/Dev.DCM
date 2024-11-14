using System;
using System.Threading.Tasks;
using Dev.DCM.Entities.Cities;
using Dev.DCM.Localization;
using Microsoft.Extensions.Localization;
using Volo.Abp;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Dev.DCM.Services.Cities;

public class CityValidationService(IRepository<City, Guid> cityRepository, IStringLocalizer<DCMResource> l) : ITransientDependency
{
    /// <summary>
    /// Şehir isminin benzersiz olup olmadığını kontrol eder.
    /// </summary>
    /// <param name="name"> Şehir adı</param>
    /// <param name="existingId"> Mevcut şehir id'si</param>
    /// <returns> Şehir adı benzersiz ise true, değilse false döner.</returns>
    public async Task IsCityNameUniqueAsync(string name, Guid? existingId = null)
    {
        var existingCity = await cityRepository.FirstOrDefaultAsync(c => c.Name == name);
        if (existingCity != null && existingCity.Id != existingId)
        {
            throw new UserFriendlyException(l["CityNameMustBeUnique"]);
        }
    }
}