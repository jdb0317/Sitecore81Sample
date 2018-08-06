using System;
using System.Linq;
using Glass.Mapper.Sc;
using Sitecore81.Core.RenderingParameters;
using Sitecore81.Core.Helper;
using Sitecore81.Core.Glass;

namespace Sitecore81Sample.ViewModels
{
    public class GenericContainerViewModel
    {
        //Properties
        public string GuidId { get; set; }
        public string Placeholder { get; set; }
        public bool FullWidthContainer { get; set; }
        public string ContainerClass { get; set; }
        public string Margins { get; set; }
        public string CssClasses { get; set; }
        public string InLineCss { get; set; }
        public string DesktopBgImageSrc { get; set; }
        public string DesktopBgImageHeight { get; set; }
        public string TabletBgImageSrc { get; set; }
        public string TabletBgImageHeight { get; set; }
        public string MobileBgImageSrc { get; set; }
        public string MobileBgImageHeight { get; set; }
        public bool ForceHeightToMatchBgImage { get; set; }

        public bool HasBackgroundImage
        {
            get
            {
                return !string.IsNullOrEmpty(DesktopBgImageSrc)
                    || !string.IsNullOrEmpty(TabletBgImageSrc)
                    || !string.IsNullOrEmpty(MobileBgImageSrc);
            }
        }

        //Data organized within constructor
        public GenericContainerViewModel(GenericContainerRenderingModel containerParamsModel, SitecoreContext context = null)
        {
            var classRefs = containerParamsModel.CssClasses
                .Select(guid => context.GetItem<ICssClass>(guid))
                .Select(c => c.Class);

            //Rendering params
            context = context ?? new SitecoreContext();
            GuidId = "container-" + Guid.NewGuid().ToString().Replace("-", "");
            Placeholder = containerParamsModel.New_Placeholder_Container_Name;
            FullWidthContainer = containerParamsModel.FullWidthContainer;
            ContainerClass = FullWidthContainer ? "container-fluid" : "container";
            Margins = FullWidthContainer ? "" : "no-margin";
            CssClasses = string.Join(" ", classRefs);
            InLineCss = containerParamsModel.InLineCssStyling;

            DesktopBgImageSrc = containerParamsModel.DesktopImage.GetSrc();
            TabletBgImageSrc = containerParamsModel.TabletImage.GetSrc();
            MobileBgImageSrc = containerParamsModel.MobileImage.GetSrc();

            ForceHeightToMatchBgImage = containerParamsModel.ForceHeightToMatchBgImageFieldName;
            DesktopBgImageHeight = (containerParamsModel.DesktopImage?.Height.ToString() ?? string.Empty) + "px";
            TabletBgImageHeight = (containerParamsModel.TabletImage?.Height.ToString() ?? string.Empty) + "px";
            MobileBgImageHeight = (containerParamsModel.MobileImage?.Height.ToString() ?? string.Empty) + "px";
        }
    }
}
