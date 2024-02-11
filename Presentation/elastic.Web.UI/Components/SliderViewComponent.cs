using Microsoft.AspNetCore.Mvc;

namespace elastic.Web.UI.Components;

public class SliderViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return await Task.FromResult(View());
    }
}
