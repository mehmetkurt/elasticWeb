namespace elastic.Web.Models.ViewModels;
public record HeaderLogoViewModel
{
    public string DesktopLogoPath { get; set; }
    public string MobileLogoPath { get; set; }
    public string AlternateText { get; set; }
    public string Link { get; set; }
    public string Title { get; set; }
    public string Target { get; set; }
}
