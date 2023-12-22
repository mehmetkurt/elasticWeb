using System.Globalization;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.Views;

namespace elastic.Umbraco.Framework.Mvc.Razor;


public abstract class ElasticRazorPage : ElasticRazorPage<IPublishedContent>
{
}

public abstract class ElasticRazorPage<TPublishedContent> : UmbracoViewPage<TPublishedContent>
{
    public CultureInfo CurrentLanguage => Thread.CurrentThread.CurrentUICulture;
    public string CurrentLanguageCode => Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
}
