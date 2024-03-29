//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v12.3.5+c2c1285
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

namespace KeaPulss.Models
{
	/// <summary>Root</summary>
	[PublishedModel("root")]
	public partial class Root : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.5+c2c1285")]
		public new const string ModelTypeAlias = "root";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.5+c2c1285")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.5+c2c1285")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.5+c2c1285")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<Root, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public Root(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Address
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.5+c2c1285")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("address")]
		public virtual string Address => this.Value<string>(_publishedValueFallback, "address");

		///<summary>
		/// Application Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.5+c2c1285")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("applicationLink")]
		public virtual global::Umbraco.Cms.Core.Models.Link ApplicationLink => this.Value<global::Umbraco.Cms.Core.Models.Link>(_publishedValueFallback, "applicationLink");

		///<summary>
		/// Contact Us
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.5+c2c1285")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactUs")]
		public virtual string ContactUs => this.Value<string>(_publishedValueFallback, "contactUs");

		///<summary>
		/// Event Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.5+c2c1285")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("eventLink")]
		public virtual global::Umbraco.Cms.Core.Models.Link EventLink => this.Value<global::Umbraco.Cms.Core.Models.Link>(_publishedValueFallback, "eventLink");

		///<summary>
		/// Fredagsbar Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.5+c2c1285")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("fredagsbarlink")]
		public virtual global::Umbraco.Cms.Core.Models.Link Fredagsbarlink => this.Value<global::Umbraco.Cms.Core.Models.Link>(_publishedValueFallback, "fredagsbarlink");

		///<summary>
		/// Frontpage
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.5+c2c1285")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("frontpage")]
		public virtual global::Umbraco.Cms.Core.Models.Link Frontpage => this.Value<global::Umbraco.Cms.Core.Models.Link>(_publishedValueFallback, "frontpage");

		///<summary>
		/// Language Change
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.5+c2c1285")]
		[ImplementPropertyType("languageChange")]
		public virtual bool LanguageChange => this.Value<bool>(_publishedValueFallback, "languageChange");

		///<summary>
		/// Login Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.5+c2c1285")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("loginLink")]
		public virtual global::Umbraco.Cms.Core.Models.Link LoginLink => this.Value<global::Umbraco.Cms.Core.Models.Link>(_publishedValueFallback, "loginLink");

		///<summary>
		/// Logo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.5+c2c1285")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("logo")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops Logo => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "logo");

		///<summary>
		/// LogoFooter
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.5+c2c1285")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("logoFooter")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops LogoFooter => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "logoFooter");

		///<summary>
		/// News Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.5+c2c1285")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("newsLink")]
		public virtual global::Umbraco.Cms.Core.Models.Link NewsLink => this.Value<global::Umbraco.Cms.Core.Models.Link>(_publishedValueFallback, "newsLink");

		///<summary>
		/// Opening Hours
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.5+c2c1285")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("openingHours")]
		public virtual string OpeningHours => this.Value<string>(_publishedValueFallback, "openingHours");

		///<summary>
		/// Paris Aftale Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.5+c2c1285")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("parisAftaleLink")]
		public virtual global::Umbraco.Cms.Core.Models.Link ParisAftaleLink => this.Value<global::Umbraco.Cms.Core.Models.Link>(_publishedValueFallback, "parisAftaleLink");

		///<summary>
		/// Slogan
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.5+c2c1285")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("slogan")]
		public virtual string Slogan => this.Value<string>(_publishedValueFallback, "slogan");

		///<summary>
		/// SoMe Links
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.5+c2c1285")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("soMeLinks")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel SoMeLinks => this.Value<global::Umbraco.Cms.Core.Models.Blocks.BlockListModel>(_publishedValueFallback, "soMeLinks");

		///<summary>
		/// Studieliv Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.3.5+c2c1285")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("studielivLink")]
		public virtual global::Umbraco.Cms.Core.Models.Link StudielivLink => this.Value<global::Umbraco.Cms.Core.Models.Link>(_publishedValueFallback, "studielivLink");
	}
}
