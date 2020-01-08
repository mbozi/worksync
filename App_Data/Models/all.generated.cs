using  System;
using  System.Collections.Generic;
using  System.Linq.Expressions;
using  System.Web;
using  Umbraco.Core.Models;
using  Umbraco.Core.Models.PublishedContent;
using  Umbraco.Web;
using  Umbraco.ModelsBuilder;
using  Umbraco.ModelsBuilder.Umbraco;
[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "f082980e9734a2be")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.1")]


// FILE: models.generated.cs

//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------















namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Home</summary>
	[PublishedContentModel("home")]
	public partial class Home : PublishedContentModel, ITitleControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// subTitle
		///</summary>
		[ImplementPropertyType("subTitle")]
		public string SubTitle
		{
			get { return Umbraco.Web.PublishedContentModels.TitleControls.GetSubTitle(this); }
		}

		///<summary>
		/// Title: Page Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return Umbraco.Web.PublishedContentModels.TitleControls.GetTitle(this); }
		}
	}

	/// <summary>Blog</summary>
	[PublishedContentModel("blog")]
	public partial class Blog : PublishedContentModel, ITopNavigationControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "blog";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Blog(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Blog, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Exclude from Top Navigation: tick if you do not want to include in top menu
		///</summary>
		[ImplementPropertyType("excludeFromTopNavigation")]
		public bool ExcludeFromTopNavigation
		{
			get { return Umbraco.Web.PublishedContentModels.TopNavigationControls.GetExcludeFromTopNavigation(this); }
		}
	}

	/// <summary>Content</summary>
	[PublishedContentModel("content")]
	public partial class Content : PublishedContentModel, IBasicContentControls, ITitleControls, ITopNavigationControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "content";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Content(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Content, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content Grid: page content
		///</summary>
		[ImplementPropertyType("contentGrid")]
		public Newtonsoft.Json.Linq.JToken ContentGrid
		{
			get { return Umbraco.Web.PublishedContentModels.BasicContentControls.GetContentGrid(this); }
		}

		///<summary>
		/// subTitle
		///</summary>
		[ImplementPropertyType("subTitle")]
		public string SubTitle
		{
			get { return Umbraco.Web.PublishedContentModels.TitleControls.GetSubTitle(this); }
		}

		///<summary>
		/// Title: Page Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return Umbraco.Web.PublishedContentModels.TitleControls.GetTitle(this); }
		}

		///<summary>
		/// Exclude from Top Navigation: tick if you do not want to include in top menu
		///</summary>
		[ImplementPropertyType("excludeFromTopNavigation")]
		public bool ExcludeFromTopNavigation
		{
			get { return Umbraco.Web.PublishedContentModels.TopNavigationControls.GetExcludeFromTopNavigation(this); }
		}
	}

	// Mixin content Type 1083 with alias "topNavigationControls"
	/// <summary>Top Navigation Controls</summary>
	public partial interface ITopNavigationControls : IPublishedContent
	{
		/// <summary>Exclude from Top Navigation</summary>
		bool ExcludeFromTopNavigation { get; }
	}

	/// <summary>Top Navigation Controls</summary>
	[PublishedContentModel("topNavigationControls")]
	public partial class TopNavigationControls : PublishedContentModel, ITopNavigationControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "topNavigationControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public TopNavigationControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TopNavigationControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Exclude from Top Navigation: tick if you do not want to include in top menu
		///</summary>
		[ImplementPropertyType("excludeFromTopNavigation")]
		public bool ExcludeFromTopNavigation
		{
			get { return GetExcludeFromTopNavigation(this); }
		}

		/// <summary>Static getter for Exclude from Top Navigation</summary>
		public static bool GetExcludeFromTopNavigation(ITopNavigationControls that) { return that.GetPropertyValue<bool>("excludeFromTopNavigation"); }
	}

	/// <summary>Gallery</summary>
	[PublishedContentModel("gallery")]
	public partial class Gallery : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "gallery";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Gallery(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Gallery, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// FolderName: The name of the folder comnnatining the photos
		///</summary>
		[ImplementPropertyType("folderName")]
		public string FolderName
		{
			get { return this.GetPropertyValue<string>("folderName"); }
		}
	}

	/// <summary>MenuPage</summary>
	[PublishedContentModel("menuPage")]
	public partial class MenuPage : PublishedContentModel, ITitleControls, ITopNavigationControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "menuPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public MenuPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<MenuPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// subTitle
		///</summary>
		[ImplementPropertyType("subTitle")]
		public string SubTitle
		{
			get { return Umbraco.Web.PublishedContentModels.TitleControls.GetSubTitle(this); }
		}

		///<summary>
		/// Title: Page Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return Umbraco.Web.PublishedContentModels.TitleControls.GetTitle(this); }
		}

		///<summary>
		/// Exclude from Top Navigation: tick if you do not want to include in top menu
		///</summary>
		[ImplementPropertyType("excludeFromTopNavigation")]
		public bool ExcludeFromTopNavigation
		{
			get { return Umbraco.Web.PublishedContentModels.TopNavigationControls.GetExcludeFromTopNavigation(this); }
		}
	}

	// Mixin content Type 1100 with alias "titleControls"
	/// <summary>Title Controls</summary>
	public partial interface ITitleControls : IPublishedContent
	{
		/// <summary>subTitle</summary>
		string SubTitle { get; }

		/// <summary>Title</summary>
		string Title { get; }
	}

	/// <summary>Title Controls</summary>
	[PublishedContentModel("titleControls")]
	public partial class TitleControls : PublishedContentModel, ITitleControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "titleControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public TitleControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TitleControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// subTitle
		///</summary>
		[ImplementPropertyType("subTitle")]
		public string SubTitle
		{
			get { return GetSubTitle(this); }
		}

		/// <summary>Static getter for subTitle</summary>
		public static string GetSubTitle(ITitleControls that) { return that.GetPropertyValue<string>("subTitle"); }

		///<summary>
		/// Title: Page Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return GetTitle(this); }
		}

		/// <summary>Static getter for Title</summary>
		public static string GetTitle(ITitleControls that) { return that.GetPropertyValue<string>("title"); }
	}

	// Mixin content Type 1101 with alias "articleControls"
	/// <summary>Article Controls</summary>
	public partial interface IArticleControls : IPublishedContent
	{
		/// <summary>Article Date</summary>
		DateTime ArticleDate { get; }

		/// <summary>Article Image</summary>
		IPublishedContent ArticleImage { get; }

		/// <summary>Image Folder</summary>
		string ImageFolder { get; }
	}

	/// <summary>Article Controls</summary>
	[PublishedContentModel("articleControls")]
	public partial class ArticleControls : PublishedContentModel, IArticleControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "articleControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ArticleControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ArticleControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Article Date: Date of Article
		///</summary>
		[ImplementPropertyType("articleDate")]
		public DateTime ArticleDate
		{
			get { return GetArticleDate(this); }
		}

		/// <summary>Static getter for Article Date</summary>
		public static DateTime GetArticleDate(IArticleControls that) { return that.GetPropertyValue<DateTime>("articleDate"); }

		///<summary>
		/// Article Image: Menu Picture
		///</summary>
		[ImplementPropertyType("articleImage")]
		public IPublishedContent ArticleImage
		{
			get { return GetArticleImage(this); }
		}

		/// <summary>Static getter for Article Image</summary>
		public static IPublishedContent GetArticleImage(IArticleControls that) { return that.GetPropertyValue<IPublishedContent>("articleImage"); }

		///<summary>
		/// Image Folder: Used in Photo Galleries
		///</summary>
		[ImplementPropertyType("imageFolder")]
		public string ImageFolder
		{
			get { return GetImageFolder(this); }
		}

		/// <summary>Static getter for Image Folder</summary>
		public static string GetImageFolder(IArticleControls that) { return that.GetPropertyValue<string>("imageFolder"); }
	}

	// Mixin content Type 1102 with alias "basicContentControls"
	/// <summary>Basic Content Controls</summary>
	public partial interface IBasicContentControls : IPublishedContent
	{
		/// <summary>Content Grid</summary>
		Newtonsoft.Json.Linq.JToken ContentGrid { get; }
	}

	/// <summary>Basic Content Controls</summary>
	[PublishedContentModel("basicContentControls")]
	public partial class BasicContentControls : PublishedContentModel, IBasicContentControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "basicContentControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BasicContentControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BasicContentControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content Grid: page content
		///</summary>
		[ImplementPropertyType("contentGrid")]
		public Newtonsoft.Json.Linq.JToken ContentGrid
		{
			get { return GetContentGrid(this); }
		}

		/// <summary>Static getter for Content Grid</summary>
		public static Newtonsoft.Json.Linq.JToken GetContentGrid(IBasicContentControls that) { return that.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("contentGrid"); }
	}

	/// <summary>Blog Post</summary>
	[PublishedContentModel("blogPost")]
	public partial class BlogPost : PublishedContentModel, IArticleControls, IBasicContentControls, ITitleControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "blogPost";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BlogPost(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BlogPost, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Article Date: Date of Article
		///</summary>
		[ImplementPropertyType("articleDate")]
		public DateTime ArticleDate
		{
			get { return Umbraco.Web.PublishedContentModels.ArticleControls.GetArticleDate(this); }
		}

		///<summary>
		/// Article Image: Menu Picture
		///</summary>
		[ImplementPropertyType("articleImage")]
		public IPublishedContent ArticleImage
		{
			get { return Umbraco.Web.PublishedContentModels.ArticleControls.GetArticleImage(this); }
		}

		///<summary>
		/// Image Folder: Used in Photo Galleries
		///</summary>
		[ImplementPropertyType("imageFolder")]
		public string ImageFolder
		{
			get { return Umbraco.Web.PublishedContentModels.ArticleControls.GetImageFolder(this); }
		}

		///<summary>
		/// Content Grid: page content
		///</summary>
		[ImplementPropertyType("contentGrid")]
		public Newtonsoft.Json.Linq.JToken ContentGrid
		{
			get { return Umbraco.Web.PublishedContentModels.BasicContentControls.GetContentGrid(this); }
		}

		///<summary>
		/// subTitle
		///</summary>
		[ImplementPropertyType("subTitle")]
		public string SubTitle
		{
			get { return Umbraco.Web.PublishedContentModels.TitleControls.GetSubTitle(this); }
		}

		///<summary>
		/// Title: Page Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return Umbraco.Web.PublishedContentModels.TitleControls.GetTitle(this); }
		}
	}

	/// <summary>Table</summary>
	[PublishedContentModel("table")]
	public partial class Table : PublishedContentModel, IBasicContentControls, ITopNavigationControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "table";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Table(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Table, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content Grid: page content
		///</summary>
		[ImplementPropertyType("contentGrid")]
		public Newtonsoft.Json.Linq.JToken ContentGrid
		{
			get { return Umbraco.Web.PublishedContentModels.BasicContentControls.GetContentGrid(this); }
		}

		///<summary>
		/// Exclude from Top Navigation: tick if you do not want to include in top menu
		///</summary>
		[ImplementPropertyType("excludeFromTopNavigation")]
		public bool ExcludeFromTopNavigation
		{
			get { return Umbraco.Web.PublishedContentModels.TopNavigationControls.GetExcludeFromTopNavigation(this); }
		}
	}

	/// <summary>PollTable</summary>
	[PublishedContentModel("pollTable")]
	public partial class PollTable : PublishedContentModel, ITopNavigationControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "pollTable";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public PollTable(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PollTable, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Exclude from Top Navigation: tick if you do not want to include in top menu
		///</summary>
		[ImplementPropertyType("excludeFromTopNavigation")]
		public bool ExcludeFromTopNavigation
		{
			get { return Umbraco.Web.PublishedContentModels.TopNavigationControls.GetExcludeFromTopNavigation(this); }
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile
		{
			get { return this.GetPropertyValue<string>("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}



// EOF
