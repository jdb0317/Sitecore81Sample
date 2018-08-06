using Glass.Mapper.Sc.Web.Mvc;
using Sitecore.Data.Items;
using Sitecore81.Core.Glass;
using Sitecore81Sample.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace Sitecore81Sample.Controllers
{
    public class NavigationController : GlassController
    {
        public ActionResult MainNavigation()
        {
            var items = Sitecore.Context.Database.GetItem(Sitecore.Context.Site.StartPath).Children
                .Select(c => SitecoreContext.Cast<IBasePage>(c))
                .Where(c => c.Active && c.Display_In_Menu);

            return PartialView(items);
        }

        public ActionResult FooterNavigation()
        {
            Item item = Sitecore.Context.Database.GetItem(Sitecore.Context.Site.RootPath)?.Children
                .FirstOrDefault(c => c.TemplateID == ISiteDataFolderConstants.TemplateId)?.Children
                .FirstOrDefault(c => c.TemplateID == ISettingsFolderConstants.TemplateId)?.Children
                .FirstOrDefault(c => c.TemplateID == IFooterSettingsConstants.TemplateId);
            FooterSettingsVM vm = new FooterSettingsVM(SitecoreContext.Cast<IFooterSettings>(item));

            return PartialView(vm);
        }
    }
}