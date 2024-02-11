using elastic.Web.Models;
using elastic.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace elastic.Web.UI.Components;

public class TopNavigationViewComponent(ICommonService commonService) : ViewComponent
{
    private readonly ICommonService _commonService = commonService;

    public IViewComponentResult Invoke()
    {

        var navigationModel = _commonService.ContentQuery.ContentAtRoot().OfType<HeaderNavigation>().FirstOrDefault();

        if (navigationModel is null)
            return Content("");

        var rootItems = navigationModel.HeaderNavigationItems.Select(p => p.Content as RootMenuItemBlock)?.ToList();
            

        return View(rootItems);
    }
}
