using System;
using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Sitecore81.Core.Glass;

namespace Sitecore81.Core.RenderingParameters
{
    [SitecoreType(TemplateId = IGeneric_Tile_Row_Rendering_ParamsConstants.TemplateIdString, AutoMap = true)]
    public class GenericTileRowParametersRenderingModel
    {
        //IGeneric_Tile_Row_Rendering_Params
        public Guid RowType { get; set; }
        public IEnumerable<Guid> Tiles { get; set; }
        public bool FullWidthContainer { get; set; }
        public bool PaddingBetweenCells { get; set; }
        [SitecoreField(IGeneric_Tile_Row_Rendering_ParamsConstants.CssClassesFieldName)]
        public IEnumerable<Guid> CssClasses { get; set; }
        [SitecoreField(IGeneric_Tile_Row_Rendering_ParamsConstants.InLineCssStylingFieldName)]
        public string InLineCssStyling { get; set; }
        [SitecoreField(IGeneric_Tile_Row_Rendering_ParamsConstants.ForceHeightToMatchBgImageFieldName)]
        public bool ForceHeightToMatchBgImageFieldName { get; set; }

        [SitecoreField(IGeneric_Tile_Row_Rendering_ParamsConstants.DesktopImageFieldName)]
        public Image DesktopImage { get; set; }
        [SitecoreField(IGeneric_Tile_Row_Rendering_ParamsConstants.TabletImageFieldName)]
        public Image TabletImage { get; set; }
        [SitecoreField(IGeneric_Tile_Row_Rendering_ParamsConstants.MobileImageFieldName)]
        public Image MobileImage { get; set; }

        [SitecoreField(IGeneric_Tile_Row_Rendering_ParamsConstants.OverrideFlexBreakpointsFieldName)]
        public bool OverrideFlexBreakpoints { get; set; }
        [SitecoreField(IGeneric_Tile_Row_Rendering_ParamsConstants.Breakpoint_OverridesFieldName)]
        public IEnumerable<Guid> Breakpoint_Overrides { get; set; }
    }
}
