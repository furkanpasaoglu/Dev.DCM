using Dev.DCM.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Dev.DCM.Permissions;

public class DCMPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(DCMPermissions.GroupName, L("Permission:DCM"));
        var locationGroup = context.AddGroup(DCMPermissions.LocationPermission, L("Permission:Locations"));
        var parameterGroup = context.AddGroup(DCMPermissions.ParameterPermission, L("Permission:Parameters"));
        var tenantDetailGroup = context.AddGroup(DCMPermissions.TenantDetailPermission, L("Permission:TenantDetails"));

        // Tenant Detayları İzinleri
        var tenantDetails = tenantDetailGroup.AddPermission(DCMPermissions.TenantDetails.Default, L("Permission:TenantDetails"));
        tenantDetails.AddChild(DCMPermissions.TenantDetails.Create, L("Permission:TenantDetails.Create"));
        tenantDetails.AddChild(DCMPermissions.TenantDetails.Edit, L("Permission:TenantDetails.Edit"));
        tenantDetails.AddChild(DCMPermissions.TenantDetails.Delete, L("Permission:TenantDetails.Delete"));

        // Parametreler İzinleri
        var parameters = parameterGroup.AddPermission(DCMPermissions.Parameters.Default, L("Permission:Parameters"));
        parameters.AddChild(DCMPermissions.Parameters.Create, L("Permission:Parameters.Create"));
        parameters.AddChild(DCMPermissions.Parameters.Edit, L("Permission:Parameters.Edit"));
        parameters.AddChild(DCMPermissions.Parameters.Delete, L("Permission:Parameters.Delete"));

        //Kullanıcı Detayları İzinleri
        var userDetail = myGroup.AddPermission(DCMPermissions.UserDetails.Default, L("Permission:UserDetails"));
        userDetail.AddChild(DCMPermissions.UserDetails.Create, L("Permission:UserDetails.Create"));
        userDetail.AddChild(DCMPermissions.UserDetails.Edit, L("Permission:UserDetails.Edit"));
        userDetail.AddChild(DCMPermissions.UserDetails.Delete, L("Permission:UserDetails.Delete"));

        // Türler İzinleri
        var serviceTypes = myGroup.AddPermission(DCMPermissions.Types.ServiceTypes.Default, L("Permission:ServiceTypes"));
        serviceTypes.AddChild(DCMPermissions.Types.ServiceTypes.Create, L("Permission:ServiceTypes.Create"));
        serviceTypes.AddChild(DCMPermissions.Types.ServiceTypes.Edit, L("Permission:ServiceTypes.Edit"));
        serviceTypes.AddChild(DCMPermissions.Types.ServiceTypes.Delete, L("Permission:ServiceTypes.Delete"));

        var lineStatusCodes = myGroup.AddPermission(DCMPermissions.Types.LineStatusCodes.Default, L("Permission:LineStatusCodes"));
        lineStatusCodes.AddChild(DCMPermissions.Types.LineStatusCodes.Create, L("Permission:LineStatusCodes.Create"));
        lineStatusCodes.AddChild(DCMPermissions.Types.LineStatusCodes.Edit, L("Permission:LineStatusCodes.Edit"));
        lineStatusCodes.AddChild(DCMPermissions.Types.LineStatusCodes.Delete, L("Permission:LineStatusCodes.Delete"));

        var jobCodes = myGroup.AddPermission(DCMPermissions.Types.JobCodes.Default, L("Permission:JobCodes"));
        jobCodes.AddChild(DCMPermissions.Types.JobCodes.Create, L("Permission:JobCodes.Create"));
        jobCodes.AddChild(DCMPermissions.Types.JobCodes.Edit, L("Permission:JobCodes.Edit"));
        jobCodes.AddChild(DCMPermissions.Types.JobCodes.Delete, L("Permission:JobCodes.Delete"));

        var identityTypes = myGroup.AddPermission(DCMPermissions.Types.IdentityTypes.Default, L("Permission:IdentityTypes"));
        identityTypes.AddChild(DCMPermissions.Types.IdentityTypes.Create, L("Permission:IdentityTypes.Create"));
        identityTypes.AddChild(DCMPermissions.Types.IdentityTypes.Edit, L("Permission:IdentityTypes.Edit"));
        identityTypes.AddChild(DCMPermissions.Types.IdentityTypes.Delete, L("Permission:IdentityTypes.Delete"));

        var customerMovementCodes = myGroup.AddPermission(DCMPermissions.Types.CustomerMovementCodes.Default, L("Permission:CustomerMovementCodes"));
        customerMovementCodes.AddChild(DCMPermissions.Types.CustomerMovementCodes.Create, L("Permission:CustomerMovementCodes.Create"));
        customerMovementCodes.AddChild(DCMPermissions.Types.CustomerMovementCodes.Edit, L("Permission:CustomerMovementCodes.Edit"));
        customerMovementCodes.AddChild(DCMPermissions.Types.CustomerMovementCodes.Delete, L("Permission:CustomerMovementCodes.Delete"));

        // Lokasyon İzinleri
        var countries = locationGroup.AddPermission(DCMPermissions.Locations.Countries.Default, L("Permission:Countries"));
        countries.AddChild(DCMPermissions.Locations.Countries.Create, L("Permission:Countries.Create"));
        countries.AddChild(DCMPermissions.Locations.Countries.Edit, L("Permission:Countries.Edit"));
        countries.AddChild(DCMPermissions.Locations.Countries.Delete, L("Permission:Countries.Delete"));

        var cities = locationGroup.AddPermission(DCMPermissions.Locations.Cities.Default, L("Permission:Cities"));
        cities.AddChild(DCMPermissions.Locations.Cities.Create, L("Permission:Cities.Create"));
        cities.AddChild(DCMPermissions.Locations.Cities.Edit, L("Permission:Cities.Edit"));
        cities.AddChild(DCMPermissions.Locations.Cities.Delete, L("Permission:Cities.Delete"));

        var districts = locationGroup.AddPermission(DCMPermissions.Locations.Districts.Default, L("Permission:Districts"));
        districts.AddChild(DCMPermissions.Locations.Districts.Create, L("Permission:Districts.Create"));
        districts.AddChild(DCMPermissions.Locations.Districts.Edit, L("Permission:Districts.Edit"));
        districts.AddChild(DCMPermissions.Locations.Districts.Delete, L("Permission:Districts.Delete"));
    }


    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<DCMResource>(name);
    }
}
