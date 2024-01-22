// ReSharper disable CheckNamespace

using EPiServer.Shell.Modules;

namespace Microsoft.Extensions.DependencyInjection;

public static class AddonServiceCollectionExtensions
{
    private const string ModuleName = "Playground";
    
    public static IServiceCollection AddMyAddon(this IServiceCollection services)
    {
        // Add services here.
        return services
                // Super required, otherwise your addon won't load when the site loads.
            .Configure<ProtectedModuleOptions>(
            pm =>
            {
                if (!pm.Items.Any(i => i.Name.Equals(ModuleName, StringComparison.OrdinalIgnoreCase)))
                {
                    pm.Items.Add(new ModuleDetails { Name = ModuleName });
                }
            });
    }
}