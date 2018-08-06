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
    /// Base Page
    /// </summary>
    [SitecoreType(TemplateId = IBasePageConstants.TemplateIdString)]
    public partial interface IBasePage : IBasePageState
    {
        [SitecoreField(IBasePageConstants.TitleFieldName)]
        string Title { get; set; }

        [SitecoreField(IBasePageConstants.BodyTextFieldName)]
        string BodyText { get; set; }
    }
    public static partial class IBasePageConstants
    {
        public const string TemplateIdString = "0557651C-37B5-4AFF-BEF6-E1C004CD36A5";
        public static readonly ID TemplateId = new ID(TemplateIdString);
        public const string TemplateName = "Base Page";

        public const string TitleFieldName = "Title";
        public const string BodyTextFieldName = "BodyText";
    }

    /// <summary>
    /// Base Page State
    /// </summary>
    [SitecoreType(TemplateId = IBasePageStateConstants.TemplateIdString)]
    public partial interface IBasePageState : IGlassBase
    {
        [SitecoreField(IBasePageStateConstants.ActiveFieldName)]
        bool Active { get; set; }

        [SitecoreField(IBasePageStateConstants.Display_In_Menu_TextFieldName)]
        bool Display_In_Menu { get; set; }
    }
    public static partial class IBasePageStateConstants
    {
        public const string TemplateIdString = "FDC8FA06-529B-46B9-920A-643FD3C529BC";
        public static readonly ID TemplateId = new ID(TemplateIdString);
        public const string TemplateName = "Base Page State";

        public const string ActiveFieldName = "Active";
        public const string Display_In_Menu_TextFieldName = "Display In Menu";
    }
}
