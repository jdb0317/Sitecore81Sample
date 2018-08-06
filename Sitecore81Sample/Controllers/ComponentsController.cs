using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glass.Mapper.Sc.Web.Mvc;
using Sitecore.Data.Items;
using Sitecore81.Core.Glass;
using Sitecore81.Core.RenderingParameters;
using Sitecore81Sample.ViewModels;

namespace Sitecore81Sample.Controllers
{
    public class ComponentsController : GlassController
    {
        public ActionResult Title()
        {
            var vm = SitecoreContext.GetCurrentItem<IBasePage>();
            return !string.IsNullOrEmpty(vm.Title) || Sitecore.Context.PageMode.IsExperienceEditor 
                ? PartialView(vm) : null;
        }

        public ActionResult BodyText()
        {
            var vm = SitecoreContext.GetCurrentItem<IBasePage>();
            return !string.IsNullOrEmpty(vm.BodyText) || Sitecore.Context.PageMode.IsExperienceEditor 
                ? PartialView(vm) : null;
        }

        public ActionResult CtaImageSlider()
        {
            var vm = GetLayoutItem<ICTA_Image_Slider_Group>();
            return vm.Slides.Any() || Sitecore.Context.PageMode.IsExperienceEditor 
                ? PartialView(vm) : null;
        }

        public ActionResult GenericContainer()
        {
            var parameters = GetRenderingParameters<GenericContainerRenderingModel>();
            var vm = new GenericContainerViewModel(parameters);

            return PartialView(vm);
        }

        public ActionResult GenericTileRow()
        {
            var parameters = GetRenderingParameters<GenericTileRowParametersRenderingModel>();
            var vm = new GenericTileRowViewModel(parameters);

            return vm.Tiles.Any() ? PartialView(vm) : null;
        }
    }
}