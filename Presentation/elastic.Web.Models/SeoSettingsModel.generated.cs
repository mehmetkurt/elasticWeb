//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v13.0.3+a0f3c15
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace elastic.Web.Models
{
	/// <summary>Seo Settings</summary>
	[PublishedModel("SeoSettingsModel")]
	public partial class SeoSettingsModel : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.0.3+a0f3c15")]
		public new const string ModelTypeAlias = "SeoSettingsModel";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.0.3+a0f3c15")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.0.3+a0f3c15")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.0.3+a0f3c15")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<SeoSettingsModel, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public SeoSettingsModel(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Address
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.0.3+a0f3c15")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("seoSettingsCompanyAddress")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString SeoSettingsCompanyAddress => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "seoSettingsCompanyAddress");

		///<summary>
		/// City
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.0.3+a0f3c15")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("seoSettingsCompanyCity")]
		public virtual string SeoSettingsCompanyCity => this.Value<string>(_publishedValueFallback, "seoSettingsCompanyCity");

		///<summary>
		/// Country
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.0.3+a0f3c15")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("seoSettingsCompanyCountry")]
		public virtual string SeoSettingsCompanyCountry => this.Value<string>(_publishedValueFallback, "seoSettingsCompanyCountry");

		///<summary>
		/// County
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.0.3+a0f3c15")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("seoSettingsCompanyCounty")]
		public virtual string SeoSettingsCompanyCounty => this.Value<string>(_publishedValueFallback, "seoSettingsCompanyCounty");

		///<summary>
		/// District
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.0.3+a0f3c15")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("seoSettingsCompanyDistrict")]
		public virtual string SeoSettingsCompanyDistrict => this.Value<string>(_publishedValueFallback, "seoSettingsCompanyDistrict");

		///<summary>
		/// Email
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.0.3+a0f3c15")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("seoSettingsCompanyEmail")]
		public virtual string SeoSettingsCompanyEmail => this.Value<string>(_publishedValueFallback, "seoSettingsCompanyEmail");

		///<summary>
		/// Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.0.3+a0f3c15")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("seoSettingsCompanyName")]
		public virtual string SeoSettingsCompanyName => this.Value<string>(_publishedValueFallback, "seoSettingsCompanyName");

		///<summary>
		/// Phone
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.0.3+a0f3c15")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("seoSettingsCompanyPhone")]
		public virtual string SeoSettingsCompanyPhone => this.Value<string>(_publishedValueFallback, "seoSettingsCompanyPhone");

		///<summary>
		/// #BackOffice.Settings.SeoSettings.DefaultTitle: #BackOffice.Settings.SeoSettings.DefaultTitle.Hint
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.0.3+a0f3c15")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("SeoSettingsDefaultTitle")]
		public virtual string SeoSettingsDefaultTitle => this.Value<string>(_publishedValueFallback, "SeoSettingsDefaultTitle");

		///<summary>
		/// #BackOffice.Settings.SeoSettings.TitleSeperator: #BackOffice.Settings.SeoSettings.TitleSeperator.Hint
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.0.3+a0f3c15")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("SeoSettingsTitleSeperator")]
		public virtual string SeoSettingsTitleSeperator => this.Value<string>(_publishedValueFallback, "SeoSettingsTitleSeperator");
	}
}