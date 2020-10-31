using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HWEShop
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "MainPage",
                url: "",
                defaults: new { controller = "MainPage", action = "Index"}
            );

            routes.MapRoute(
                name: "MainPage2",
                url: "MainPage",
                defaults: new { controller = "MainPage", action = "Index" }
            );

            routes.MapRoute(
                name: "MainPage3",
                url: "Index",
                defaults: new { controller = "MainPage", action = "Index" }
            );

            routes.MapRoute(
                name: "Categories",
                url: "Categories",
                defaults: new { controller = "Categories", action = "Index" }
            );

            routes.MapRoute(
                name: "Categories2",
                url: "Categories/{action}/{id}",
                defaults: new { controller = "Categories", action = "Details", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
