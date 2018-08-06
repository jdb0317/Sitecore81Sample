using Glass.Mapper.Sc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore81Sample.ViewModels
{
    public abstract class BaseViewModel
    {
        protected SitecoreContext GlassContext { get; set; }
    }
}