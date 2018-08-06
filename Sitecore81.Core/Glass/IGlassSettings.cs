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
    /// Footer Settings
    /// </summary>
    [SitecoreType(TemplateId = IFooterSettingsConstants.TemplateIdString)]
    public partial interface IFooterSettings : IGlassBase
    {
        [SitecoreField(IFooterSettingsConstants.Footer_TextFieldName)]
        string Footer_Text { get; set; }

        [SitecoreField(IFooterSettingsConstants.Disclaimer_1FieldName)]
        string Disclaimer_1 { get; set; }

        [SitecoreField(IFooterSettingsConstants.Disclaimer_2FieldName)]
        string Disclaimer_2 { get; set; }

        [SitecoreField(IFooterSettingsConstants.Show_Navigation_LinksFieldName)]
        bool Show_Navigation_Links { get; set; }
    }
    public static partial class IFooterSettingsConstants
    {
        public const string TemplateIdString = "45F421AC-721B-44F5-BF15-193EBA282BBE";
        public static readonly ID TemplateId = new ID(TemplateIdString);
        public const string TemplateName = "Footer Settings";

        public const string Footer_TextFieldName = "Footer Text";
        public const string Disclaimer_1FieldName = "Disclaimer 1";
        public const string Disclaimer_2FieldName = "Disclaimer 2";
        public const string Show_Navigation_LinksFieldName = "Show Navigation Links";
    }
}
