// <copyright file="RouteConfig.cs" company="trewsly">Copyright (c) Sprocket Enterprises. All rights reserved.</copyright>
// <author>auto gen MS</author>
namespace MVCClean
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Routing;

    /// <summary> routeing area for incoming requests </summary>
    public class RouteConfig
    {
        /// <summary>
        /// Joins a first name and a last name together into a single string.
        /// </summary>
        /// <param name="routes">routes param</param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }
    }
}