using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RestServices
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "ById",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Employee", action = "GetById", id = UrlParameter.Optional }
            );
        }
    }
}
