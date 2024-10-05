using Dev.DCM.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Dev.DCM.Permissions;

public class DCMPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(DCMPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(DCMPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<DCMResource>(name);
    }
}
