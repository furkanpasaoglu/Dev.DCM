using Dev.DCM.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Dev.DCM.Permissions;

public class DCMPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(DCMPermissions.GroupName, L("Permission:Types"));
        var locationGroup  =context.AddGroup(DCMPermissions.Locations, L("Permission:Locations"));

        var serviceTypes = myGroup.AddPermission(DCMPermissions.ServiceTypes.Default, L("Permission:ServiceTypes"));
        serviceTypes.AddChild(DCMPermissions.ServiceTypes.Create, L("Permission:ServiceType.Create"));
        serviceTypes.AddChild(DCMPermissions.ServiceTypes.Edit, L("Permission:ServiceType.Edit"));
        serviceTypes.AddChild(DCMPermissions.ServiceTypes.Delete, L("Permission:ServiceType.Delete"));
        
        var lineStatusCodes = myGroup.AddPermission(DCMPermissions.LineStatusCodes.Default, L("Permission:LineStatusCodes"));
        lineStatusCodes.AddChild(DCMPermissions.LineStatusCodes.Create, L("Permission:LineStatusCode.Create"));
        lineStatusCodes.AddChild(DCMPermissions.LineStatusCodes.Edit, L("Permission:LineStatusCode.Edit"));
        lineStatusCodes.AddChild(DCMPermissions.LineStatusCodes.Delete, L("Permission:LineStatusCode.Delete"));
        
        var jobCodes = myGroup.AddPermission(DCMPermissions.JobCodes.Default, L("Permission:JobCodes"));
        jobCodes.AddChild(DCMPermissions.JobCodes.Create, L("Permission:JobCode.Create"));
        jobCodes.AddChild(DCMPermissions.JobCodes.Edit, L("Permission:JobCode.Edit"));
        jobCodes.AddChild(DCMPermissions.JobCodes.Delete, L("Permission:JobCode.Delete"));
        
        var identityTypes = myGroup.AddPermission(DCMPermissions.IdentityTypes.Default, L("Permission:IdentityTypes"));
        identityTypes.AddChild(DCMPermissions.IdentityTypes.Create, L("Permission:IdentityType.Create"));
        identityTypes.AddChild(DCMPermissions.IdentityTypes.Edit, L("Permission:IdentityType.Edit"));
        identityTypes.AddChild(DCMPermissions.IdentityTypes.Delete, L("Permission:IdentityType.Delete"));
        
        var customerMovementCodes = myGroup.AddPermission(DCMPermissions.CustomerMovementCodes.Default, L("Permission:CustomerMovementCodes"));
        customerMovementCodes.AddChild(DCMPermissions.CustomerMovementCodes.Create, L("Permission:CustomerMovementCode.Create"));
        customerMovementCodes.AddChild(DCMPermissions.CustomerMovementCodes.Edit, L("Permission:CustomerMovementCode.Edit"));
        customerMovementCodes.AddChild(DCMPermissions.CustomerMovementCodes.Delete, L("Permission:CustomerMovementCode.Delete"));

        var countries = locationGroup.AddPermission(DCMPermissions.Countries.Default, L("Permission:Countries"));
        countries.AddChild(DCMPermissions.Countries.Create, L("Permission:Country.Create"));
        countries.AddChild(DCMPermissions.Countries.Edit, L("Permission:Country.Edit"));
        countries.AddChild(DCMPermissions.Countries.Delete, L("Permission:Country.Delete"));
        
        var cities = locationGroup.AddPermission(DCMPermissions.Cities.Default, L("Permission:Cities"));
        cities.AddChild(DCMPermissions.Cities.Create, L("Permission:City.Create"));
        cities.AddChild(DCMPermissions.Cities.Edit, L("Permission:City.Edit"));
        cities.AddChild(DCMPermissions.Cities.Delete, L("Permission:City.Delete"));
        
        var districts = locationGroup.AddPermission(DCMPermissions.Districts.Default, L("Permission:Districts"));
        districts.AddChild(DCMPermissions.Districts.Create, L("Permission:District.Create"));
        districts.AddChild(DCMPermissions.Districts.Edit, L("Permission:District.Edit"));
        districts.AddChild(DCMPermissions.Districts.Delete, L("Permission:District.Delete"));
        
        
       
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<DCMResource>(name);
    }
}
