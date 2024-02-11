using elastic.Web.Models;
using elastic.Web.Models.ViewModels;
using elastic.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace elastic.Web.UI.Components;

public class TitleViewComponent
    (ICommonService commonService)
    : ViewComponent
{
    private readonly ICommonService _commonService = commonService;

    public IViewComponentResult Invoke()
    {
        var settingsModel = _commonService.ContentQuery.ContentAtRoot().DescendantsOrSelf<SeoSettingsModel>()?.FirstOrDefault();

        if (settingsModel is null)
            return Content("");


        if (_commonService.CurrentContent is not IMetaInformationComposition)
            return Content("");

        var content = _commonService.CurrentContent as IMetaInformationComposition;
        var model = new TitleViewModel
        {
            Title = content.PageTitleCompositionTitle,
            Seperator = settingsModel.SeoSettingsTitleSeperator,
            DefaultTitle = settingsModel.SeoSettingsDefaultTitle
        };

        return View(model);
    }
}
