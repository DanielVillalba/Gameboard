using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Gameboard
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Route override to work with Angularjs and HTML5 routing
            //routes.MapRoute(
            //    name: "GameboardOverride",
            //    url: "Products/{*.}",
            //    defaults: new { controller = "Products", action = "Index" }
            //);


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Products", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
