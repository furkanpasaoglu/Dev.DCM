using System.Threading.Tasks;
using Dev.DCM.Localization;
using Dev.DCM.MultiTenancy;
using Dev.DCM.Permissions;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Dev.DCM.Web.Menus;

public class DCMMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<DCMResource>();

        // Home
        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                DCMMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );
        
        //Locations
        context.Menu.Items.Insert(
            1, new ApplicationMenuItem(
                DCMMenus.Locations,
                l["Menu:Locations"],
                "~/",
                icon: "fas fa-map-marker-alt",
                order: 1,
                groupName: DCMMenus.Locations
                ).RequirePermissions(requiresAll:false, 
                    DCMPermissions.Districts.Default, 
                    DCMPermissions.Cities.Default, 
                    DCMPermissions.Countries.Default)
                .AddItem(new ApplicationMenuItem(
                    DCMMenus.Countries,
                    l["Menu:Countries"],
                    "/Countries",
                    icon: "fas fa-flag",
                    order: 1,
                    requiredPermissionName: DCMPermissions.Countries.Default
                ))
                .AddItem(new ApplicationMenuItem(
                    DCMMenus.Cities,
                    l["Menu:Cities"],
                    "/Cities",
                    icon: "fas fa-city",
                    order: 2,
                    requiredPermissionName: DCMPermissions.Cities.Default
                ))
                .AddItem(new ApplicationMenuItem(
                    DCMMenus.Districts,
                    l["Menu:Districts"],
                    "/Districts",
                    icon: "fas fa-map-marked-alt",
                    order: 3,
                    requiredPermissionName: DCMPermissions.Districts.Default
                ))
            );
        
        // Types
        context.Menu.Items.Insert(
            1,new ApplicationMenuItem(
                DCMMenus.Types,
                l["Menu:Types"],
                "~/",
                icon: "fas fa-list",
                order: 1,
                groupName: DCMMenus.Types
            ).RequirePermissions(requiresAll:false, 
                DCMPermissions.ServiceTypes.Default, 
                DCMPermissions.LineStatusCodes.Default, 
                DCMPermissions.CustomerMovementCodes.Default, 
                DCMPermissions.IdentityTypes.Default, 
                DCMPermissions.JobCodes.Default)
            .AddItem(new ApplicationMenuItem(
                DCMMenus.ServiceTypes,
                l["Menu:ServiceTypes"],
                "/ServiceTypes",
                icon: "fas fa-concierge-bell",
                order: 1,
                requiredPermissionName: DCMPermissions.ServiceTypes.Default
            ))
            .AddItem( new ApplicationMenuItem(
                DCMMenus.LineStatusCodes,
                l["Menu:LineStatusCodes"],
                "/LineStatusCodes",
                icon: "fas fa-signal",
                order: 2,
                requiredPermissionName: DCMPermissions.LineStatusCodes.Default
            ))
            .AddItem( new ApplicationMenuItem(
                DCMMenus.CustomerMovementCodes,
                l["Menu:CustomerMovementCodes"],
                "/CustomerMovementCodes",
                icon: "fas fa-exchange-alt",
                order: 3,
                requiredPermissionName: DCMPermissions.CustomerMovementCodes.Default
            ))
            .AddItem(new ApplicationMenuItem(
                DCMMenus.IdentityTypes,
                l["Menu:IdentityTypes"],
                "/IdentityTypes",
                icon: "fas fa-id-card",
                order: 4,
                requiredPermissionName: DCMPermissions.IdentityTypes.Default
            ))
            .AddItem(new ApplicationMenuItem(
                DCMMenus.JobCodes,
                l["Menu:JobCodes"],
                "/JobCodes",
                icon: "fas fa-briefcase",
                order: 5,
                requiredPermissionName: DCMPermissions.JobCodes.Default
            ))
        );
        
        context.Menu.Groups.Add(new ApplicationMenuGroup(DCMMenus.Locations, l["Menu:Locations"]));
        context.Menu.Groups.Add(new ApplicationMenuGroup(DCMMenus.Types, l["Menu:Types"]));
       

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);

        return Task.CompletedTask;
    }
}
