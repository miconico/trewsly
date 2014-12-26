// <copyright file="WebApiConfig.cs" company="Trewsly">
//     Copyright Trewsly All rights reserved.
// </copyright>
// <author>auto gen MS</author>
namespace MVCClean
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;

    /// <summary> web api configuration </summary>
    public static class WebApiConfig
    {
        /// <summary> web api </summary>
        /// <param name="config">configuration object</param>
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });
        }
    }
}
