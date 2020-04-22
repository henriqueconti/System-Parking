using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_aula
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               "register",
               "Register",
              defaults: new { controller = "Car", action = "register" }
            );

            routes.MapRoute(
               "criar_cars",
               "cars/criar",
              defaults: new { controller = "Car", action = "criar" }
            );

            routes.MapRoute(
               "remover_cars",
               "cars/{id}/remover",
              defaults: new { controller = "Car", action = "remover", id = 0}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Car", action = "Index", id = UrlParameter.Optional }
            );

           
        }
    }
}
