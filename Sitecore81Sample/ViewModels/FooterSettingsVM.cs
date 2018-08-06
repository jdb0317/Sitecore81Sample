using Glass.Mapper.Sc;
using Sitecore81.Core.Glass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore81Sample.ViewModels
{
    public class FooterSettingsVM : BaseViewModel
    {
        public IEnumerable<IBasePage> Navigation { get; set; }
        public IFooterSettings FooterSettings { get; set; }

        public FooterSettingsVM(IFooterSettings item, SitecoreContext context = null)
        {
            GlassContext = context ?? new SitecoreContext();

            FooterSettings = item;
            Navigation = Sitecore.Context.Database.GetItem(Sitecore.Context.Site.StartPath)
                .Children.Select(c => GlassContext.Cast<IBasePage>(c));
        }
    }
}