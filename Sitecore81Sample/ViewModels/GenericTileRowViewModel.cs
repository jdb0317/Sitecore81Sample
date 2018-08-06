using System;
using System.Collections.Generic;
using System.Linq;
using Glass.Mapper.Sc;
using Sitecore.Data.Items;
using Glass.Mapper.Sc.Fields;
using Sitecore81.Core.Helper;
using Sitecore81.Core.Glass;
using Sitecore81.Core.RenderingParameters;

namespace Sitecore81Sample.ViewModels
{
    public class GenericTileRowViewModel
    {
        //Properties
        public string GuidId { get; set; }
        public IGeneric_Row_Definition RowDefinition { get; set; }
        public List<IGeneric_Column_Definition> Columns { get; set; }
        public bool FullWidthContainer { get; set; }
        public string PaddingClass { get; set; }
        public List<object> Tiles { get; set; }
        public List<string> TileCshtmlViews { get; set; }
        public IEnumerable<IGeneric_Row_Flex_Breakpoint> BreakpointOverrides { get; set; }
        public string ContainerClass { get; set; }
        public string Margins { get; set; }
        public string FlexPoints { get; set; }
        public string CssClasses { get; set; }
        public string InLineCss { get; set; }
        public Image DesktopBgImage { get; set; }
        public Image TabletBgImage { get; set; }
        public Image MobileBgImage { get; set; }
        public string DesktopBgImageHeight { get; set; }
        public string TabletBgImageHeight { get; set; }
        public string MobileBgImageHeight { get; set; }
        public bool ForceHeightToMatchBgImage { get; set; }

        public bool HasBackgroundImage
        {
            get
            {
                return !string.IsNullOrEmpty(DesktopBgImage.GetSrc())
                    || !string.IsNullOrEmpty(TabletBgImage.GetSrc())
                    || !string.IsNullOrEmpty(MobileBgImage.GetSrc());
            }
        }

        //View paths for each generic tile type
        private const string RichTextView = "~/Views/Components/RichText.cshtml";
        private const string MediaTileView = "~/Views/Components/Media.cshtml";

        //Data organized within constructor
        public GenericTileRowViewModel(GenericTileRowParametersRenderingModel rowParamsModel, SitecoreContext context = null)
        {
            context = context ?? new SitecoreContext();
            GuidId = "row-" + Guid.NewGuid().ToString().Replace("-", "");
            FullWidthContainer = rowParamsModel.FullWidthContainer;
            PaddingClass = !rowParamsModel.PaddingBetweenCells ? "nopadding" : string.Empty;
            RowDefinition = context.GetItem<IGeneric_Row_Definition>(rowParamsModel.RowType);

            //Pull the tile objects into a collection
            Tiles = new List<object>();
            TileCshtmlViews = new List<string>();
            foreach (var tGuid in rowParamsModel.Tiles)
            {
                var item = context.GetItem<Item>(tGuid);
                switch (item.TemplateID.Guid.ToString())
                {
                    case IGeneric_Rich_Text_TileConstants.TemplateIdString:
                        Tiles.Add(context.CreateType<IGeneric_Rich_Text_Tile>(item));
                        TileCshtmlViews.Add(RichTextView);
                        break;
                    case IGeneric_Media_TileConstants.TemplateIdString:
                        Tiles.Add(context.CreateType<IGeneric_Media_Tile>(item));
                        TileCshtmlViews.Add(MediaTileView);
                        break;
                    default:
                        break;
                }
            }

            //Other rendering params
            ContainerClass = FullWidthContainer ? "container-fluid" : "container";
            Margins = FullWidthContainer ? "" : "no-margin";
            Columns = RowDefinition.Columns.ToList();

            CssClasses = string.Join(" ", rowParamsModel.CssClasses.Select(g => context.GetItem<ICssClass>(g)).Select(c => c.Class));
            CssClasses += " " + string.Join(" ", RowDefinition.CssClasses.Select(c => c.Class));
            InLineCss = rowParamsModel.InLineCssStyling;
            BreakpointOverrides = rowParamsModel.Breakpoint_Overrides?.Select(gid => context.GetItem<IGeneric_Row_Flex_Breakpoint>(gid));

            
            DesktopBgImage = GetAvailableImage(new List<Image>() { rowParamsModel.DesktopImage, rowParamsModel.TabletImage, rowParamsModel.MobileImage });
            TabletBgImage = GetAvailableImage(new List<Image>() { rowParamsModel.TabletImage, rowParamsModel.DesktopImage, rowParamsModel.MobileImage });
            MobileBgImage = GetAvailableImage(new List<Image>() { rowParamsModel.MobileImage, rowParamsModel.TabletImage, rowParamsModel.DesktopImage });

            if (HasBackgroundImage)
            {
                ForceHeightToMatchBgImage = rowParamsModel.ForceHeightToMatchBgImageFieldName;
                DesktopBgImageHeight = (rowParamsModel.DesktopImage?.Height.ToString() ?? string.Empty) + "px";
                TabletBgImageHeight = (rowParamsModel.TabletImage?.Height.ToString() ?? string.Empty) + "px";
                MobileBgImageHeight = (rowParamsModel.MobileImage?.Height.ToString() ?? string.Empty) + "px";
            }
            
            FlexPoints = rowParamsModel.OverrideFlexBreakpoints
                ? BreakpointOverrides != null
                    ? string.Join(" ", BreakpointOverrides.Select(f => f.BreakpointCssClassName))
                    : string.Empty
                : string.Join(" ", RowDefinition.FlexBreakpoints.Select(f => f.BreakpointCssClassName));
        }

        private Image GetAvailableImage(IEnumerable<Image> images)
        {
            foreach (Image img in images)
            {
                if (img != null && !string.IsNullOrEmpty(img.Src))
                    return img;
            }

            return null;
        }

    }
}
