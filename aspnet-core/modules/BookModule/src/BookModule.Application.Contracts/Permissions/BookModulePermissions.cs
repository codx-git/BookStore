using Volo.Abp.Reflection;

namespace BookModule.Permissions;

public class BookModulePermissions
{
    public const string GroupName = "BookModule";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(BookModulePermissions));
    }
}
