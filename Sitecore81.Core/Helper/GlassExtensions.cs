using System;
using System.Collections.Generic;
using System.Linq;
using Sitecore;
using Sitecore.Links;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Fields;
using Sitecore.Data.Items;
using Sitecore.Data;
using Sitecore.Data.Managers;
using Sitecore.Data.Templates;
using Sitecore81.Core.Glass;

namespace Sitecore81.Core.Helper

{
    public static class Extensions
    {
        /// <summary>
        /// Return site's home item
        /// </summary>
        public static Item SiteHomeItem => Context.Database.GetItem(Context.Site.StartPath);

        /// <summary>
        /// Return site's home item url
        /// </summary>
        public static string SiteHomeUrl => LinkManager.GetItemUrl(SiteHomeItem);

        /// <summary>
        /// Friendly url path to item. Returns # if item is nonexistent;
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static string GetItemFriendlyUrl(this Item item) => item != null ? LinkManager.GetItemUrl(item) : "#";

        /// <summary>
        /// Return base Item object from glass interface
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static Item GetItem(this IGlassBase item) => Context.Database.GetItem(item.Id);

        /// <summary>
        /// Determine whether or not link has value
        /// </summary>
        /// <param name="link"></param>
        /// <param name="sitecoreContext"></param>
        /// <returns></returns>
        public static bool HasLink(this Link link, ISitecoreContext sitecoreContext = null)
        {
            if (link != null)
            {
                if (link.Type == LinkType.External && !string.IsNullOrEmpty(link.Url))
                {
                    return true;
                }
                if (link.Type == LinkType.Internal)
                {
                    var target = (sitecoreContext ?? new SitecoreContext()).Database.GetItem(new ID(link.TargetId));
                    if (target != null) return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Defaults to homepage url if none set
        /// </summary>
        /// <param name="link"></param>
        /// <param name="sitecoreContext"></param>
        /// <returns></returns>
        public static string GetLinkUrl(this Link link, ISitecoreContext sitecoreContext = null)
        {
            var url = string.Empty;
            if (link != null)
            {
                if (link.Type == LinkType.Internal)
                {
                    var target = (sitecoreContext ?? new SitecoreContext()).Database.GetItem(new ID(link.TargetId));
                    url = target == null ? string.Empty : LinkManager.GetItemUrl(target);
                }

                url = link.Url;
            }

            url = !string.IsNullOrEmpty(url) ? url : SiteHomeUrl;
            return url;
        }

        /// <summary>
		/// Returns the URL of the Glass Image field, handles null reference handling by returning an empty string
		/// </summary>
		/// <param name="image"></param>
		/// <returns></returns>
		public static string GetSrc(this Image image)
        {
            return image.GetSrc(string.Empty);
        }

        /// <summary>
        /// Returns the URL of the Glass Image field, handles null reference handling by returning an empty string
        /// </summary>
        /// <param name="image"></param>
        /// <param name="resizingQuerystring">Querystring parameters for resizing and cropping images</param>
        /// <returns></returns>
        public static string GetSrc(this Image image, string resizingQuerystring)
        {
            if (image != null)
            {
                if (String.IsNullOrEmpty(resizingQuerystring))
                    return image.Src;
                else
                {
                    string imageSrc = String.Format("{0}?" + resizingQuerystring, image.Src);
                    return Sitecore.Resources.Media.HashingUtils.ProtectAssetUrl(imageSrc);
                }
            }
            return string.Empty;
        }

        /// <summary>
        /// Returns link TARGET value
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        public static string GetTargetValue(this Link link)
        {
            if (link == null) return string.Empty;
            return !string.IsNullOrEmpty(link.Target)
                ? link.Target
                : "_self";
        }

        /// <summary>
        /// Returns link ALT value
        /// </summary>
        /// <param name="img"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static string GetAltValue(this Image img, string defaultValue = null)
        {
            if (img == null) return string.Empty;
            return !string.IsNullOrEmpty(img.Alt)
                ? img.Alt
                : !string.IsNullOrEmpty(defaultValue)
                    ? defaultValue
                    : !string.IsNullOrEmpty(img.Title)
                        ? img.Title
                        : "image";
        }

        public static bool IsDerived([NotNull] this Item item, [NotNull] ID templateId)
        {
            return TemplateManager.GetTemplate(item).IsDerived(templateId);
        }

        public static bool IsDerived([NotNull] this Template template, [NotNull] ID templateId)
        {
            return template.ID == templateId || template.GetBaseTemplates().Any(baseTemplate => IsDerived(baseTemplate, templateId));
        }

        public static IEnumerable<T> GetChildrenOf<T>(this ISitecoreContext sitecoreContext, [NotNull] Item item) where T : class
        {
            return item.Children.Select(x => sitecoreContext.GetItem<T>(x.ID.ToGuid()));
        }

        public static List<T> GetRandomItems<T>(this List<T> list, int count)
        {
            var returnData = new List<T>();

            var cap = list.Count();
            count = Math.Min(count, cap);
            var randomIndicies = new List<int>();

            var rand = new Random();
            for (var i = 0; i < count; ++i)
            {
                var index = rand.Next(0, cap);
                while (randomIndicies.Contains(index))
                {
                    index = rand.Next(0, cap);
                }

                randomIndicies.Add(index);
            }

            foreach (var index in randomIndicies)
            {
                returnData.Add(list[index]);
            }

            return returnData;
        }
    }
}
