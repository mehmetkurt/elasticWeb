using elastic.Web.Models;
using elastic.Web.Models.ViewModels;
using elastic.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace elastic.Web.UI.Components;

public class HeaderLogoViewComponent
    (ICommonService commonService) 
    : ViewComponent
{
    private readonly ICommonService _commonService = commonService;

    public IViewComponentResult Invoke()
    {
        var settingsModel = _commonService.ContentQuery.ContentAtRoot().DescendantsOrSelf<LogoSettingsModel>()?.FirstOrDefault();

        if (settingsModel is null)
            return Content("");

        var model = new HeaderLogoViewModel
        {
            DesktopLogoPath = settingsModel.LogoSettingsDesktop.Url(),
            MobileLogoPath = settingsModel.LogoSettingsMobile.Url(),
            AlternateText = settingsModel.LogoSettingsAlternateText,
            Link = settingsModel.LogoSettingsLink?.Url,
            Target = settingsModel.LogoSettingsLink?.Target,
            Title = settingsModel.LogoSettingsLink?.Name ?? settingsModel.LogoSettingsAlternateText
        };

        return View(model);
    }
}
