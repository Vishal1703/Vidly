using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes(); 
            //routes.MapRoute(
            //    "MoviesbyReleasedDate",
            //    "Movie/released/{year}/{month}",
            //    new { controller="movie",action="ByreleasedDate" },
            //   // new { year=@"\d{4}",month=@"\d{2}"}
            //    new { year = "2016|2017", month = @"\d{2}" }
            //    );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
