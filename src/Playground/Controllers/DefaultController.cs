using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Playground.Mvc;
using Playground.Permissions;

namespace Playground.Controllers;
    
[AuthorizePermission(AddonPermissions.GroupName, nameof(AddonPermissions.EditSettings))]
[Area("Playground")]
public class DefaultController : Controller
{
    [HttpGet]
    [ModuleRoute("Default", "Index")]
    public IActionResult Index()
    {
        return View();
    }
    
    [HttpGet]
    [ModuleRoute("Default", "SecondAction")]
    public IActionResult SecondAction()
    {
        return View();
    }
}