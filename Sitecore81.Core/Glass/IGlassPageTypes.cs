using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore81.Core.Glass
{
    /// <summary>
    /// Basic Page
    /// </summary>
    [SitecoreType(TemplateId = IBasicPagePageConstants.TemplateIdString)]
    public partial interface IBasicPagePage : IBasePage
    {
    }
    public static partial class IBasicPagePageConstants
    {
        public const string TemplateIdString = "66F65C58-1A05-4616-8434-F5D9D24FE6A3";
        public static readonly ID TemplateId = new ID(TemplateIdString);
        public const string TemplateName = "Basic Page";
    }

    /// <summary>
    /// Homepage
    /// </summary>
    [SitecoreType(TemplateId = IHomepageConstants.TemplateIdString)]
    public partial interface IHomepagePage : IBasePage
    {
    }
    public static partial class IHomepageConstants
    {
        public const string TemplateIdString = "C31A44F2-3CC3-445C-BA45-83411A806ED5";
        public static readonly ID TemplateId = new ID(TemplateIdString);
        public const string TemplateName = "Homepage";
    }
}
