using System;
using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Sitecore81.Core.Glass;

namespace Sitecore81.Core.RenderingParameters
{
    [SitecoreType(TemplateId = IGeneric_Container_Rendering_ParamsConstants.TemplateIdString, AutoMap = true)]
    public class GenericContainerRenderingModel
    {
        [SitecoreField(IGeneric_Container_Rendering_ParamsConstants.New_Placeholder_Container_NameFieldName)]
        public string New_Placeholder_Container_Name { get; set; }
        [SitecoreField(IGeneric_Container_Rendering_ParamsConstants.FullWidthContainerFieldName)]
        public bool FullWidthContainer { get; set; }
        [SitecoreField(IGeneric_Container_Rendering_ParamsConstants.CssClassesFieldName)]
        public IEnumerable<Guid> CssClasses { get; set; }
        [SitecoreField(IGeneric_Container_Rendering_ParamsConstants.InLineCssStylingFieldName)]
        public string InLineCssStyling { get; set; }
        [SitecoreField(IGeneric_Container_Rendering_ParamsConstants.ForceHeightToMatchBgImageFieldName)]
        public bool ForceHeightToMatchBgImageFieldName { get; set; }

        [SitecoreField(IGeneric_Container_Rendering_ParamsConstants.DesktopImageFieldName)]
        public Image DesktopImage { get; set; }
        [SitecoreField(IGeneric_Container_Rendering_ParamsConstants.TabletImageFieldName)]
        public Image TabletImage { get; set; }
        [SitecoreField(IGeneric_Container_Rendering_ParamsConstants.MobileImageFieldName)]
        public Image MobileImage { get; set; }
    }
}
