//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.6.1
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace YuzuDelivery.UmbracoModels
{
	/// <summary>BlogDetailPage</summary>
	[PublishedModel("blogDetailPage")]
	public partial class BlogDetailPage : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public new const string ModelTypeAlias = "blogDetailPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BlogDetailPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public BlogDetailPage(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("content")]
		public global::Skybrud.Umbraco.GridData.GridDataModel Content => this.Value<global::Skybrud.Umbraco.GridData.GridDataModel>("content");

		///<summary>
		/// Cta
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("cta")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent Cta => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("cta");

		///<summary>
		/// Footer Categories
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("footerCategories")]
		public global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.Models.Link> FooterCategories => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.Models.Link>>("footerCategories");

		///<summary>
		/// Header Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("headerTitle")]
		public string HeaderTitle => this.Value<string>("headerTitle");

		///<summary>
		/// RelatedArticles Items
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("relatedArticlesItems")]
		public global::YuzuDelivery.UmbracoModels.BlogList RelatedArticlesItems => this.Value<global::YuzuDelivery.UmbracoModels.BlogList>("relatedArticlesItems");

		///<summary>
		/// RelatedArticles Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("relatedArticlesTitle")]
		public string RelatedArticlesTitle => this.Value<string>("relatedArticlesTitle");

		///<summary>
		/// Social Links
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("socialLinks")]
		public global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.Models.Link> SocialLinks => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.Models.Link>>("socialLinks");

		///<summary>
		/// Social Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("socialTitle")]
		public string SocialTitle => this.Value<string>("socialTitle");

		///<summary>
		/// Summary Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("summaryImage")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent SummaryImage => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("summaryImage");

		///<summary>
		/// Summary Summary
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("summarySummary")]
		public string SummarySummary => this.Value<string>("summarySummary");

		///<summary>
		/// Summary Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("summaryTitle")]
		public string SummaryTitle => this.Value<string>("summaryTitle");
	}
}
