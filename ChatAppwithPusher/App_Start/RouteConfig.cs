using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ChatAppwithPusher
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            //Bozduğun routeları yeniden yap
            //Mesajları almak için bir route ekle /contact``/conversations/{contact} "This route will accept a contact ID, retrieve messages between the current user and the contact, then return the messages in a JSON response."
        }
    }
}
