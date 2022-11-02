using AventHub.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AventHub.Permissions;

public class AventHubPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AventHubPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AventHubPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AventHubResource>(name);
    }
}
