using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore81.Core.Glass
{
    /// <summary>
    /// Generic Container
    /// </summary>
    [SitecoreType(TemplateId = IGeneric_Container_Rendering_ParamsConstants.TemplateIdString)]
    public partial interface IGeneric_Container_Rendering_Params : IGlassBase
    {
        [SitecoreField(IGeneric_Container_Rendering_ParamsConstants.CssClassesFieldName)]
        IEnumerable<Guid> CssClasses { get; set; }

        [SitecoreField(IGeneric_Container_Rendering_ParamsConstants.DesktopImageFieldName)]
        Image DesktopImage { get; set; }

        [SitecoreField(IGeneric_Container_Rendering_ParamsConstants.FullWidthContainerFieldName)]
        bool FullWidthContainer { get; set; }

        [SitecoreField(IGeneric_Container_Rendering_ParamsConstants.ForceHeightToMatchBgImageFieldName)]
        bool ForceHeightToMatchBgImage { get; set; }

        [SitecoreField(IGeneric_Container_Rendering_ParamsConstants.InLineCssStylingFieldName)]
        string InLineCssStyling { get; set; }

        [SitecoreField(IGeneric_Container_Rendering_ParamsConstants.MobileImageFieldName)]
        Image MobileImage { get; set; }

        [SitecoreField(IGeneric_Container_Rendering_ParamsConstants.New_Placeholder_Container_NameFieldName)]
        string New_Placeholder_Container_Name { get; set; }

        [SitecoreField(IGeneric_Container_Rendering_ParamsConstants.TabletImageFieldName)]
        Image TabletImage { get; set; }
    }
    public static partial class IGeneric_Container_Rendering_ParamsConstants
    {
        public const string TemplateIdString = "9d6224ee-f960-438f-bab2-61094219cc38";
        public static readonly ID TemplateId = new ID(TemplateIdString);
        public const string TemplateName = "Generic Container Rendering Params";

        public const string CssClassesFieldName = "CssClasses";
        public const string ForceHeightToMatchBgImageFieldName = "ForceHeightToMatchBgImage";
        public const string DesktopImageFieldName = "DesktopImage";
        public const string FullWidthContainerFieldName = "FullWidthContainer";
        public const string InLineCssStylingFieldName = "InLineCssStyling";
        public const string MobileImageFieldName = "MobileImage";
        public const string New_Placeholder_Container_NameFieldName = "New Placeholder Container Name";
        public const string TabletImageFieldName = "TabletImage";
        public const string PlaceholderFieldName = "Placeholder";
    }

    /// <summary>
    /// Generic Tile Row
    /// </summary>
    [SitecoreType(TemplateId = IGeneric_Tile_Row_Rendering_ParamsConstants.TemplateIdString)]
    public partial interface IGeneric_Tile_Row_Rendering_Params : IGlassBase
    {
        [SitecoreField(IGeneric_Tile_Row_Rendering_ParamsConstants.Breakpoint_OverridesFieldName)]
        IEnumerable<Guid> Breakpoint_Overrides { get; set; }

        [SitecoreField(IGeneric_Tile_Row_Rendering_ParamsConstants.ForceHeightToMatchBgImageFieldName)]
        bool ForceHeightToMatchBgImage { get; set; }

        [SitecoreField(IGeneric_Tile_Row_Rendering_ParamsConstants.CssClassesFieldName)]
        IEnumerable<Guid> CssClasses { get; set; }

        [SitecoreField(IGeneric_Tile_Row_Rendering_ParamsConstants.DesktopImageFieldName)]
        Image DesktopImage { get; set; }

        [SitecoreField(IGeneric_Tile_Row_Rendering_ParamsConstants.FullWidthContainerFieldName)]
        bool FullWidthContainer { get; set; }

        [SitecoreField(IGeneric_Tile_Row_Rendering_ParamsConstants.PaddingBetweenCellsFieldName)]
        bool PaddingBetweenCells { get; set; }

        [SitecoreField(IGeneric_Tile_Row_Rendering_ParamsConstants.InLineCssStylingFieldName)]
        string InLineCssStyling { get; set; }

        [SitecoreField(IGeneric_Tile_Row_Rendering_ParamsConstants.MobileImageFieldName)]
        Image MobileImage { get; set; }

        [SitecoreField(IGeneric_Tile_Row_Rendering_ParamsConstants.OverrideFlexBreakpointsFieldName)]
        bool OverrideFlexBreakpoints { get; set; }

        [SitecoreField(IGeneric_Tile_Row_Rendering_ParamsConstants.RowTypeFieldName)]
        Guid RowType { get; set; }

        [SitecoreField(IGeneric_Tile_Row_Rendering_ParamsConstants.TabletImageFieldName)]
        Image TabletImage { get; set; }

        [SitecoreField(IGeneric_Tile_Row_Rendering_ParamsConstants.TilesFieldName)]
        IEnumerable<Guid> Tiles { get; set; }

    }


    public static partial class IGeneric_Tile_Row_Rendering_ParamsConstants
    {

        public const string TemplateIdString = "689953ba-c90c-4091-8db9-dbe0febdc0aa";
        public static readonly ID TemplateId = new ID(TemplateIdString);
        public const string TemplateName = "Generic Tile Row Rendering Params";

        public static readonly ID Breakpoint_OverridesFieldId = new ID("95d5ed54-97f1-4966-9e7b-cde8e0872a91");
        public const string Breakpoint_OverridesFieldName = "Breakpoint Overrides";
        public const string ForceHeightToMatchBgImageFieldName = "ForceHeightToMatchBgImage";
        public const string CssClassesFieldName = "CssClasses";
        public const string DesktopImageFieldName = "DesktopImage";
        public const string FullWidthContainerFieldName = "FullWidthContainer";
        public const string PaddingBetweenCellsFieldName = "PaddingBetweenCells";
        public const string InLineCssStylingFieldName = "InLineCssStyling";
        public const string MobileImageFieldName = "MobileImage";
        public const string OverrideFlexBreakpointsFieldName = "OverrideFlexBreakpoints";
        public const string RowTypeFieldName = "RowType";
        public const string TabletImageFieldName = "TabletImage";
        public const string TilesFieldName = "Tiles";
    }

    /// <summary>
    /// CTA Image Slider
    /// </summary>
    [SitecoreType(TemplateId = ICTA_Image_SliderConstants.TemplateIdString)]
    public partial interface ICTA_Image_Slider : IGlassBase
    {
        [SitecoreField(ICTA_Image_SliderConstants.TitleFieldName)]
        string Title { get; set; }

        [SitecoreField(ICTA_Image_SliderConstants.BlurbFieldName)]
        string Blurb { get; set; }

        [SitecoreField(ICTA_Image_SliderConstants.CTA_TextFieldName)]
        string CTA_Text { get; set; }

        [SitecoreField(ICTA_Image_SliderConstants.CTA_DestinationFieldName)]
        Link CTA_Destination { get; set; }

        [SitecoreField(ICTA_Image_SliderConstants.ImageFieldName)]
        Image Image { get; set; }
    }
    public static partial class ICTA_Image_SliderConstants
    {
        public const string TemplateIdString = "B56FEEB0-0C52-49AF-8F15-01E1B3849D5A";
        public static readonly ID TemplateId = new ID(TemplateIdString);
        public const string TemplateName = "CTA Image Slider";

        public const string TitleFieldName = "Title";
        public const string BlurbFieldName = "Blurb";
        public const string CTA_TextFieldName = "CTA Text";
        public const string CTA_DestinationFieldName = "CTA Destination";
        public const string ImageFieldName = "Image";
    }

    /// <summary>
    /// CTA Image Slider Group
    /// </summary>
    [SitecoreType(TemplateId = ICTA_Image_Slider_GroupConstants.TemplateIdString)]
    public partial interface ICTA_Image_Slider_Group : IGlassBase
    {
        [SitecoreField(ICTA_Image_Slider_GroupConstants.SlidesFieldName)]
        IEnumerable<ICTA_Image_Slider> Slides { get; set; }
    }
    public static partial class ICTA_Image_Slider_GroupConstants
    {
        public const string TemplateIdString = "A49EEC61-F5A5-4C59-B7FB-D3FEF142F4D3";
        public static readonly ID TemplateId = new ID(TemplateIdString);
        public const string TemplateName = "CTA Image Slider Group";

        public const string SlidesFieldName = "Slides";
    }

    /// <summary>
    /// Css Class item
    /// </summary>
    [SitecoreType(TemplateId = ICssClassConstants.TemplateIdString)]
    public partial interface ICssClass : IGlassBase
    {
        [SitecoreField(ICssClassConstants.ClassFieldName)]
        string Class { get; set; }
    }
    public static partial class ICssClassConstants
    {

        public const string TemplateIdString = "75b1ec7b-be0b-41d0-93f9-1fea340f96f9";
        public static readonly ID TemplateId = new ID(TemplateIdString);
        public const string TemplateName = "CssClass";

        public const string ClassFieldName = "Class";
    }

    /// <summary>
    /// Media Type selection for generic tile
    /// </summary>
    [SitecoreType(TemplateId = IMedia_TypeConstants.TemplateIdString)] //, Cachable = true
    public partial interface IMedia_Type : IGlassBase
    {
        [SitecoreField(IMedia_TypeConstants.MediaNameFieldName)]
        string MediaName { get; set; }
    }
    public static partial class IMedia_TypeConstants
    {
        public const string TemplateIdString = "df26e02c-feda-4911-94c5-69a7cf89bdbf";
        public static readonly ID TemplateId = new ID(TemplateIdString);
        public const string TemplateName = "Media Type";

        public static readonly ID MediaNameFieldId = new ID("462c5967-d386-48fa-af46-b45d70a073db");
        public const string MediaNameFieldName = "MediaName";
    }

    /// <summary>
    /// Generic Row Definition
    /// </summary>
    [SitecoreType(TemplateId = IGeneric_Row_DefinitionConstants.TemplateIdString)]
    public partial interface IGeneric_Row_Definition : IGlassBase
    {
        [SitecoreField(IGeneric_Row_DefinitionConstants.AdditionalCssFieldName)]
        string AdditionalCss { get; set; }

        [SitecoreField(IGeneric_Row_DefinitionConstants.ColumnsFieldName)]
        IEnumerable<IGeneric_Column_Definition> Columns { get; set; }

        [SitecoreField(IGeneric_Row_DefinitionConstants.FlexBreakpointsFieldName)]
        IEnumerable<IGeneric_Row_Flex_Breakpoint> FlexBreakpoints { get; set; }

        [SitecoreField(IGeneric_Row_DefinitionConstants.LayoutNameFieldName)]
        string LayoutName { get; set; }

        [SitecoreField(IGeneric_Row_DefinitionConstants.CssClassesFieldName)]
        IEnumerable<ICssClass> CssClasses { get; set; }
    }
    public static partial class IGeneric_Row_DefinitionConstants
    {
        public const string TemplateIdString = "0fc50f9f-c6a9-4896-8eec-ec16d7956033";
        public static readonly ID TemplateId = new ID(TemplateIdString);
        public const string TemplateName = "Generic Row Defnition";

        public static readonly ID AdditionalCssFieldId = new ID("72fb5ab9-f0c6-4a55-8d70-8ce315d24c65");
        public const string AdditionalCssFieldName = "AdditionalCss";

        public static readonly ID ColumnsFieldId = new ID("875438c6-bf28-4f66-934e-88d9ac79e28f");
        public const string ColumnsFieldName = "Columns";

        public static readonly ID CssClassesFieldId = new ID("bc8770be-ffff-4e0d-b34e-e1f31dab0931");
        public const string CssClassesFieldName = "CssClasses";

        public static readonly ID FlexBreakpointsFieldId = new ID("2f07c0f7-5e02-44a9-b745-509d126a7f07");
        public const string FlexBreakpointsFieldName = "FlexBreakpoints";

        public static readonly ID LayoutNameFieldId = new ID("f1f2e0c5-3971-4f9f-8862-c2e27625cb10");
        public const string LayoutNameFieldName = "LayoutName";
    }

    /// <summary>
    /// Generic Column Definition
    /// </summary>
    [SitecoreType(TemplateId = IGeneric_Column_DefinitionConstants.TemplateIdString)]
    public partial interface IGeneric_Column_Definition : IGlassBase
    {
        [SitecoreField(IGeneric_Column_DefinitionConstants.ColumnDefinitionFieldName)]
        string ColumnDefinition { get; set; }
    }
    public static partial class IGeneric_Column_DefinitionConstants
    {
        public const string TemplateIdString = "28ef579e-e0c6-47c3-ad6d-ca7ab3b5bf9c";
        public static readonly ID TemplateId = new ID(TemplateIdString);
        public const string TemplateName = "Generic Column Definition";

        public static readonly ID ColumnDefinitionFieldId = new ID("1b44c6d4-ce13-4044-a42d-f6e46460e353");
        public const string ColumnDefinitionFieldName = "ColumnDefinition";
    }

    /// <summary>
    /// Generic Row Flex Breakpoint
    /// </summary>
    [SitecoreType(TemplateId = IGeneric_Row_Flex_BreakpointConstants.TemplateIdString)]
    public partial interface IGeneric_Row_Flex_Breakpoint : IGlassBase
    {
        [SitecoreField(IGeneric_Row_Flex_BreakpointConstants.BreakpointCssClassNameFieldName)]
        string BreakpointCssClassName { get; set; }

    }
    public static partial class IGeneric_Row_Flex_BreakpointConstants
    {
        public const string TemplateIdString = "4968cd57-5811-44c8-a19c-3b5ea214ae2a";
        public static readonly ID TemplateId = new ID(TemplateIdString);
        public const string TemplateName = "Generic Row Flex Breakpoint";

        public static readonly ID BreakpointCssClassNameFieldId = new ID("fd798ae2-97c8-40be-a629-daf51a7bbb84");
        public const string BreakpointCssClassNameFieldName = "BreakpointCssClassName";
    }

    /// <summary>
    /// Generic Rich Text Tile
    /// </summary>
    [SitecoreType(TemplateId = IGeneric_Rich_Text_TileConstants.TemplateIdString)] //, Cachable = true
    public partial interface IGeneric_Rich_Text_Tile : IGlassBase
    {
        [SitecoreField(IGeneric_Rich_Text_TileConstants.CopyFieldName)]
        string Copy { get; set; }

        [SitecoreField(IGeneric_Rich_Text_TileConstants.CssClassesFieldName)]
        IEnumerable<ICssClass> CssClasses { get; set; }

        [SitecoreField(IGeneric_Rich_Text_TileConstants.InLineCssStylingFieldName)]
        string InLineCssStyling { get; set; }
    }
    public static partial class IGeneric_Rich_Text_TileConstants
    {
        public const string TemplateIdString = "3a519353-829b-4209-9ce2-3b6978773868";
        public static readonly ID TemplateId = new ID(TemplateIdString);
        public const string TemplateName = "Generic Rich Text Tile";

        public static readonly ID CopyFieldId = new ID("d6bd67d0-8d2f-4aa0-a32b-ab1209a63c55");
        public const string CopyFieldName = "Copy";

        public static readonly ID CssClassesFieldId = new ID("ac0ff878-d76a-45ef-9fd2-8b9efca90799");
        public const string CssClassesFieldName = "CssClasses";

        public static readonly ID InLineCssStylingFieldId = new ID("11e97a7f-5ae6-43c8-ba40-0557ba9226d1");
        public const string InLineCssStylingFieldName = "InLineCssStyling";
    }

    /// <summary>
    /// Generic Media Tile
    /// </summary>
    [SitecoreType(TemplateId = IGeneric_Media_TileConstants.TemplateIdString)] //, Cachable = true
    public partial interface IGeneric_Media_Tile : IGlassBase
    {
        [SitecoreField(IGeneric_Media_TileConstants.CssClassesFieldName)]
        IEnumerable<ICssClass> CssClasses { get; set; }

        [SitecoreField(IGeneric_Media_TileConstants.DesktopImageFieldName)]
        Image DesktopImage { get; set; }

        [SitecoreField(IGeneric_Media_TileConstants.InLineCssStylingFieldName)]
        string InLineCssStyling { get; set; }

        [SitecoreField(IGeneric_Media_TileConstants.MediaTypeFieldName)]
        IMedia_Type MediaType { get; set; }

        [SitecoreField(IGeneric_Media_TileConstants.MobileImageFieldName)]
        Image MobileImage { get; set; }

        [SitecoreField(IGeneric_Media_TileConstants.TabletImageFieldName)]
        Image TabletImage { get; set; }

        [SitecoreField(IGeneric_Media_TileConstants.VideoEmbedUrlFieldName)]
        string VideoEmbedUrl { get; set; }
    }
    public static partial class IGeneric_Media_TileConstants
    {
        public const string TemplateIdString = "38a9aca7-25f8-42cf-b1ca-8c9726928cbf";
        public static readonly ID TemplateId = new ID(TemplateIdString);
        public const string TemplateName = "Generic Media Tile";

        public static readonly ID CssClassesFieldId = new ID("4fc441f1-9122-4474-a136-7129f4f6cac4");
        public const string CssClassesFieldName = "CssClasses";

        public static readonly ID DesktopImageFieldId = new ID("45eb3e19-561d-4f64-ad32-4bf5bbce0b72");
        public const string DesktopImageFieldName = "DesktopImage";

        public static readonly ID InLineCssStylingFieldId = new ID("78c5ee3f-1f7b-48b2-bb17-85f3d71e55a2");
        public const string InLineCssStylingFieldName = "InLineCssStyling";

        public static readonly ID MediaTypeFieldId = new ID("ed105176-b1c0-4715-9b83-ae17f700b64b");
        public const string MediaTypeFieldName = "MediaType";

        public static readonly ID MobileImageFieldId = new ID("abbdd519-12ca-4731-9cf2-415678554182");
        public const string MobileImageFieldName = "MobileImage";

        public static readonly ID TabletImageFieldId = new ID("8a6b2c75-f3ca-464f-b891-c69d65d9ffbc");
        public const string TabletImageFieldName = "TabletImage";

        public static readonly ID VideoEmbedUrlFieldId = new ID("45d20699-e12c-42af-aeca-080db4e5549f");
        public const string VideoEmbedUrlFieldName = "VideoEmbedUrl";
    }
}
