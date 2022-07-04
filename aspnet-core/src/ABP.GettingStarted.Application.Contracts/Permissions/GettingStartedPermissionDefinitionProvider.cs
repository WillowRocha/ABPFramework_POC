using ABP.GettingStarted.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ABP.GettingStarted.Permissions;

public class GettingStartedPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(GettingStartedPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(GettingStartedPermissions.MyPermission1, L("Permission:MyPermission1"));

            var productPermission = myGroup.AddPermission(GettingStartedPermissions.Product.Default, L("Permission:Product"));
            productPermission.AddChild(GettingStartedPermissions.Product.Create, L("Permission:Create"));
            productPermission.AddChild(GettingStartedPermissions.Product.Update, L("Permission:Update"));
            productPermission.AddChild(GettingStartedPermissions.Product.Delete, L("Permission:Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<GettingStartedResource>(name);
    }
}
