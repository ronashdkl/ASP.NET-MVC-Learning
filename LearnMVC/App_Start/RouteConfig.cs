using LearnMVC.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LearnMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var namespaces = new[] { typeof(HomeController).Namespace };
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");



            routes.MapRoute("Home", "home", new { controller = "Home", action = "Index" }, namespaces);
            routes.MapRoute("Login", "login", new { controller = "Login", action = "Index" });


            //routes.MapRoute(

            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }


            //);

        }
    }
}
