using EPiServer.Framework.Localization;
using EPiServer.Shell;
using EPiServer.Shell.Navigation;
using Playground.Controllers;

namespace Playground.Optimizely;

[MenuProvider]
public class AddonMenuProvider : IMenuProvider
{
    private readonly LocalizationService _localizationService;

    public AddonMenuProvider(LocalizationService localizationService)
    {
        _localizationService = localizationService;
    }

    public IEnumerable<MenuItem> GetMenuItems()
    {
        yield return new UrlMenuItem(_localizationService.GetString("/myaddon/gadget/title", "My Plugin Title"), "/global/cms/myaddon",
            Paths.ToResource(GetType(), $"Default/{nameof(DefaultController.Index)}"))
        {
            SortIndex = 0,
            Alignment = 0,
            IsAvailable = _ => true
        };

        yield return new UrlMenuItem(_localizationService.GetString("/myaddon/index/menu", "Home"), "/global/cms/myaddon/index",
            Paths.ToResource(GetType(), $"Default/{nameof(DefaultController.Index)}"))
        {
            SortIndex = 10,
            Alignment = 0,
            IsAvailable = _ => true
        };

        yield return new UrlMenuItem(_localizationService.GetString("/myaddon/secondaction/menu", "Second Action"), "/global/cms/myaddon/secondaction",
            Paths.ToResource(GetType(), $"Default/{nameof(DefaultController.SecondAction)}"))
        {
            SortIndex = 20,
            Alignment = 0,
            IsAvailable = _ => true
        };
    }
}