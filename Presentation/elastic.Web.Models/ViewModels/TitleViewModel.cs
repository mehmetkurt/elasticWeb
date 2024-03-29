﻿using Umbraco.Cms.Core.Models.PublishedContent;

namespace elastic.Web.Models.ViewModels;
public record TitleViewModel
{ 
    public string Title { get; set; }
    public string Seperator { get; set; }
    public string DefaultTitle { get; set; }
}
