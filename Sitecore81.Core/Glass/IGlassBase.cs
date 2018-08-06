using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore81.Core.Glass
{
    public partial interface IGlassBase
    {
        #region Base Members
        [SitecoreInfo(SitecoreInfoType.Version)]
        int Version { get; set; }

        [SitecoreId]
        ID Id { get; set; }

        [SitecoreInfo(SitecoreInfoType.Language)]
        string Language { get; set; }

        [SitecoreInfo(SitecoreInfoType.DisplayName)]
        string DisplayName { get; set; }

        [SitecoreInfo(SitecoreInfoType.Path)]
        string Path { get; set; }

        [SitecoreInfo(SitecoreInfoType.Name)]
        string Name { get; set; }

        [SitecoreInfo(SitecoreInfoType.Url, UrlOptions = SitecoreInfoUrlOptions.LanguageEmbeddingNever)]
        string Url { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        ID TemplateId { get; set; }

        //[SitecoreInfo(SitecoreInfoType.TemplateName)]
        //string TemplateName { get; set; }

        [SitecoreChildren(IsLazy = false)]
        IEnumerable<GlassBase> BaseChildren { get; set; }

        [SitecoreField]
        DateTime Publish { get; set; }

        [SitecoreField]
        DateTime Unpublish { get; set; }

        [SitecoreField("__Sortorder"),]
        string Sortorder { get; set; }

        [SitecoreParent(InferType = true)]
        IGlassBase Parent { get; set; }
        #endregion
    }

    [SitecoreType]
    public partial class GlassBase : IGlassBase
    {
        #region Base Members
        [SitecoreInfo(SitecoreInfoType.Version)]
        public virtual int Version { get; set; }

        [SitecoreId]
        public virtual ID Id { get; set; }

        [SitecoreInfo(SitecoreInfoType.Language)]
        public virtual string Language { get; set; }

        [SitecoreInfo(SitecoreInfoType.DisplayName)]
        public virtual string DisplayName { get; set; }

        [SitecoreInfo(SitecoreInfoType.Path)]
        public virtual string Path { get; set; }

        [SitecoreInfo(SitecoreInfoType.Name)]
        public virtual string Name { get; set; }

        [SitecoreInfo(SitecoreInfoType.Url, UrlOptions = SitecoreInfoUrlOptions.LanguageEmbeddingNever)]
        public virtual string Url { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        public virtual ID TemplateId { get; set; }

        //[SitecoreInfo(SitecoreInfoType.TemplateName),]
        //public virtual string TemplateName { get; set; }

        [SitecoreChildren(IsLazy = false)]
        public virtual IEnumerable<GlassBase> BaseChildren { get; set; }

        [SitecoreField]
        public virtual DateTime Publish { get; set; }

        [SitecoreField]
        public virtual DateTime Unpublish { get; set; }

        [SitecoreField("__Sortorder"),]
        public virtual string Sortorder { get; set; }

        [SitecoreParent(InferType = true)]
        public virtual IGlassBase Parent { get; set; }
        #endregion
    }
}
