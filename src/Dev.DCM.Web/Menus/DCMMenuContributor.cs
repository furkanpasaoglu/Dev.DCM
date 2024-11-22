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
        var administrationMenu = context.Menu.GetAdministration();
        var localizer = context.GetLocalizer<DCMResource>();

        // Ana Sayfa
        context.Menu.Items.Add(
            new ApplicationMenuItem(
                DCMMenus.Home,
                localizer["Menu:Home"],
                url: "~/",
                icon: "fas fa-home",
                order: 0
            )
        );

        // Parametreler        
        context.Menu.Items.Add(
            new ApplicationMenuItem(
                DCMMenus.Parameters,
                localizer["Menu:Parameters"],
                url: "/Parameters",
                icon: "fas fa-cogs"
            ).RequirePermissions(requiresAll: false, DCMPermissions.Parameters.Default)
        );

        // Kullanıcı Detayları
        context.Menu.Items.Add(
            new ApplicationMenuItem(
                DCMMenus.UserDetails,
                localizer["Menu:UserDetails"],
                url: "/UserDetails",
                icon: "fas fa-user"
            ).RequirePermissions(requiresAll: false, DCMPermissions.UserDetails.Default)
        );

        // Kiracı Detayları
        context.Menu.Items.Add(
            new ApplicationMenuItem(
                DCMMenus.TenantDetails,
                localizer["Menu:TenantDetails"],
                url: "/TenantDetails",
                icon: "fas fa-building"
            ).RequirePermissions(requiresAll: false, DCMPermissions.TenantDetails.Default)
        );

        // Lokasyonlar Menüsü
        var locationsMenu = new ApplicationMenuItem(
            DCMMenus.LocationMenu,
            localizer["Menu:Locations"],
            icon: "fas fa-map-marker-alt"
        ).RequirePermissions(requiresAll: false,
            DCMPermissions.Locations.Countries.Default,
            DCMPermissions.Locations.Cities.Default,
            DCMPermissions.Locations.Districts.Default
        );

        locationsMenu.AddItem(
            new ApplicationMenuItem(
                DCMMenus.Countries,
                localizer["Menu:Countries"],
                url: "/Countries",
                icon: "fas fa-flag",
                requiredPermissionName: DCMPermissions.Locations.Countries.Default
            )
        );
        locationsMenu.AddItem(
            new ApplicationMenuItem(
                DCMMenus.Cities,
                localizer["Menu:Cities"],
                url: "/Cities",
                icon: "fas fa-city",
                requiredPermissionName: DCMPermissions.Locations.Cities.Default
            )
        );
        locationsMenu.AddItem(
            new ApplicationMenuItem(
                DCMMenus.Districts,
                localizer["Menu:Districts"],
                url: "/Districts",
                icon: "fas fa-map-marked-alt",
                requiredPermissionName: DCMPermissions.Locations.Districts.Default
            )
        );

        context.Menu.Items.Add(locationsMenu);

        // Türler Menüsü
        var typesMenu = new ApplicationMenuItem(
            DCMMenus.Types,
            localizer["Menu:Types"],
            icon: "fas fa-list"
        ).RequirePermissions(requiresAll: false,
            DCMPermissions.Types.ServiceTypes.Default,
            DCMPermissions.Types.LineStatusCodes.Default,
            DCMPermissions.Types.CustomerMovementCodes.Default,
            DCMPermissions.Types.IdentityTypes.Default,
            DCMPermissions.Types.JobCodes.Default
        );

        typesMenu.AddItem(
            new ApplicationMenuItem(
                DCMMenus.ServiceTypes,
                localizer["Menu:ServiceTypes"],
                url: "/ServiceTypes",
                icon: "fas fa-concierge-bell",
                requiredPermissionName: DCMPermissions.Types.ServiceTypes.Default
            )
        );
        typesMenu.AddItem(
            new ApplicationMenuItem(
                DCMMenus.LineStatusCodes,
                localizer["Menu:LineStatusCodes"],
                url: "/LineStatusCodes",
                icon: "fas fa-signal",
                requiredPermissionName: DCMPermissions.Types.LineStatusCodes.Default
            )
        );
        typesMenu.AddItem(
            new ApplicationMenuItem(
                DCMMenus.CustomerMovementCodes,
                localizer["Menu:CustomerMovementCodes"],
                url: "/CustomerMovementCodes",
                icon: "fas fa-exchange-alt",
                requiredPermissionName: DCMPermissions.Types.CustomerMovementCodes.Default
            )
        );
        typesMenu.AddItem(
            new ApplicationMenuItem(
                DCMMenus.IdentityTypes,
                localizer["Menu:IdentityTypes"],
                url: "/IdentityTypes",
                icon: "fas fa-id-card",
                requiredPermissionName: DCMPermissions.Types.IdentityTypes.Default
            )
        );
        typesMenu.AddItem(
            new ApplicationMenuItem(
                DCMMenus.JobCodes,
                localizer["Menu:JobCodes"],
                url: "/JobCodes",
                icon: "fas fa-briefcase",
                requiredPermissionName: DCMPermissions.Types.JobCodes.Default
            )
        );

        context.Menu.Items.Add(typesMenu);

        // Menü Grupları Ekleme
        context.Menu.Groups.Add(new ApplicationMenuGroup(DCMMenus.LocationMenu, localizer["Menu:Locations"]));
        context.Menu.Groups.Add(new ApplicationMenuGroup(DCMMenus.Types, localizer["Menu:Types"]));
        context.Menu.Groups.Add(new ApplicationMenuGroup(DCMMenus.Parameters, localizer["Menu:Parameters"]));

        // Çok Kiracılı Yapılandırma
        if (MultiTenancyConsts.IsEnabled)
        {
            administrationMenu.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administrationMenu.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        // Yönetim Menü Sıralamaları
        administrationMenu.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administrationMenu.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);

        return Task.CompletedTask;
    }
}