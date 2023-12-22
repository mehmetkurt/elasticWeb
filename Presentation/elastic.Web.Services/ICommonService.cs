using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common;

namespace elastic.Web.Services;
public interface ICommonService
{
    UmbracoHelper? UmbracoHelper  { get; }
    IUmbracoContext UmbracoContext { get; }
    IPublishedContent? CurrentContent { get;}
    IPublishedContentQuery ContentQuery { get; }
}
