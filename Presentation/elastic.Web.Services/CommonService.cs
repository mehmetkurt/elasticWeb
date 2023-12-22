using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common;
using Umbraco.Extensions;

namespace elastic.Web.Services;
public class CommonService(IUmbracoHelperAccessor umbracoHelperAccessor, 
    IPublishedContentQuery publishedContentQuery, 
    IUmbracoContextAccessor umbracoContextAccessor) : ICommonService
{
    private readonly IUmbracoHelperAccessor _umbracoHelperAccessor = umbracoHelperAccessor;
    private readonly IPublishedContentQuery _publishedContentQuery = publishedContentQuery;
    private readonly IUmbracoContextAccessor _umbracoContextAccessor = umbracoContextAccessor;

    public UmbracoHelper? UmbracoHelper
    {
        get
        {
            
            var success = _umbracoHelperAccessor.TryGetUmbracoHelper(out var umbracoHelper);
            if (success is false)
            {
                return null;
            }

            return umbracoHelper;
        }
    }

    public IPublishedContent? CurrentContent => UmbracoContext?.PublishedRequest?.PublishedContent;
    public IPublishedContentQuery ContentQuery => _publishedContentQuery;
    public IUmbracoContext UmbracoContext => _umbracoContextAccessor.GetRequiredUmbracoContext();
}
