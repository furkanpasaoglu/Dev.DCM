using AutoMapper;
using Dev.DCM.Entities.Cities;
using Dev.DCM.Entities.Countries;
using Dev.DCM.Entities.CustomerMovementCodes;
using Dev.DCM.Entities.Districts;
using Dev.DCM.Entities.IdentityTypes;
using Dev.DCM.Entities.JobCodes;
using Dev.DCM.Entities.LineStatusCodes;
using Dev.DCM.Entities.Parameters;
using Dev.DCM.Entities.ServiceTypes;
using Dev.DCM.Services.Cities;
using Dev.DCM.Services.Countries;
using Dev.DCM.Services.CustomerMovementCodes;
using Dev.DCM.Services.Districts;
using Dev.DCM.Services.IdentityTypes;
using Dev.DCM.Services.JobCodes;
using Dev.DCM.Services.LineStatusCodes;
using Dev.DCM.Services.Parameters;
using Dev.DCM.Services.ServiceTypes;

namespace Dev.DCM;

public class DCMApplicationAutoMapperProfile : Profile
{
    public DCMApplicationAutoMapperProfile()
    {
        CreateMap<ServiceType, ServiceTypeDto>();
        CreateMap<CreateUpdateServiceTypeDto, ServiceType>();
        CreateMap<ServiceTypeDto, CreateUpdateServiceTypeDto>();
        
        CreateMap<LineStatusCode, LineStatusCodeDto>();
        CreateMap<CreateUpdateLineStatusCodeDto, LineStatusCode>();
        CreateMap<LineStatusCodeDto, CreateUpdateLineStatusCodeDto>();
        
        CreateMap<JobCode, JobCodeDto>();
        CreateMap<CreateUpdateJobCodeDto, JobCode>();
        CreateMap<JobCodeDto, CreateUpdateJobCodeDto>();
        
        CreateMap<IdentityType, IdentityTypeDto>();
        CreateMap<CreateUpdateIdentityTypeDto, IdentityType>();
        CreateMap<IdentityTypeDto, CreateUpdateIdentityTypeDto>();
        
        CreateMap<CustomerMovementCode, CustomerMovementCodeDto>();
        CreateMap<CreateUpdateCustomerMovementCodeDto, CustomerMovementCode>();
        CreateMap<CustomerMovementCodeDto, CreateUpdateCustomerMovementCodeDto>();
        
        CreateMap<District, DistrictDto>();
        CreateMap<CreateUpdateDistrictDto, District>();
        CreateMap<DistrictDto, CreateUpdateDistrictDto>();
        
        CreateMap<City, CityDto>();
        CreateMap<CreateUpdateCityDto, City>();
        CreateMap<CityDto, CreateUpdateCityDto>();
        
        CreateMap<Country, CountryDto>();
        CreateMap<CreateUpdateCountryDto, Country>();
        CreateMap<CountryDto, CreateUpdateCountryDto>();

        CreateMap<Parameter, ParameterDto>();
        CreateMap<CreateUpdateParameterDto, Parameter>();
        CreateMap<ParameterDto, CreateUpdateParameterDto>();
    }
}
