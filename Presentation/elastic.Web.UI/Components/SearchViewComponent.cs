using elastic.Web.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace elastic.Web.UI.Components;

public class SearchViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var model = new SearchViewModel();
        return View(model);
    }
}
