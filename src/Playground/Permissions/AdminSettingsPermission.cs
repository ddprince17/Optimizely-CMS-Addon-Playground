using EPiServer.DataAnnotations;
using EPiServer.Security;

namespace Playground.Permissions;

[PermissionTypes]
public static class AddonPermissions
{
    public const string GroupName = nameof(AddonPermissions);

    public static PermissionType EditSettings { get; private set; }

    static AddonPermissions()
    {
        EditSettings = new PermissionType(GroupName, nameof(EditSettings));
    }
}
