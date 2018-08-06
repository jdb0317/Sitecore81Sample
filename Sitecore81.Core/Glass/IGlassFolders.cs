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
    /// Settings Folder
    /// </summary>
    [SitecoreType(TemplateId = ISettingsFolderConstants.TemplateIdString)]
    public partial interface ISettingsFolder : IGlassBase
    {
    }
    public static partial class ISettingsFolderConstants
    {
        public const string TemplateIdString = "E8A1CA01-BF7A-474F-B4BF-33C9E1E8C858";
        public static readonly ID TemplateId = new ID(TemplateIdString);
        public const string TemplateName = "Settings Folder";
    }

    /// <summary>
    /// Site Data Folder
    /// </summary>
    [SitecoreType(TemplateId = ISiteDataFolderConstants.TemplateIdString)]
    public partial interface ISiteDataFolder : IGlassBase
    {
    }
    public static partial class ISiteDataFolderConstants
    {
        public const string TemplateIdString = "56DADC98-0D3A-451A-837F-8FA7F253AE09";
        public static readonly ID TemplateId = new ID(TemplateIdString);
        public const string TemplateName = "Site Data Folder";
    }
}
