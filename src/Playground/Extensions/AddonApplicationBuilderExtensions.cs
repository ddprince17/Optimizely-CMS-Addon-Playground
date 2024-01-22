// ReSharper disable CheckNamespace

using EPiServer.Security;
using Microsoft.Extensions.DependencyInjection;
using Playground.Permissions;

namespace Microsoft.AspNetCore.Builder;

public static class AddonApplicationBuilderExtensions
{
    public static IApplicationBuilder UseMyAddon(this IApplicationBuilder app)
    {
        var virtualRoleRepository = app.ApplicationServices.GetRequiredService<IVirtualRoleRepository>();

        virtualRoleRepository.Register($"{AddonPermissions.GroupName}{nameof(AddonPermissions.EditSettings)}Role",
            new PermissionRole { Permission = AddonPermissions.EditSettings });

        return app;
    }
}
