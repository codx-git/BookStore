using BookModule.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace BookModule.Permissions;

public class BookModulePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BookModulePermissions.GroupName, L("Permission:BookModule"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BookModuleResource>(name);
    }
}
