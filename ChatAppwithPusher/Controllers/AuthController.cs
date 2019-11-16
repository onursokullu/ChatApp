using ChatAppwithPusher.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChatAppwithPusher.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        [HttpPost]
        public ActionResult Login()
        {   
            string Username = Request.Form["username"];
            if (Username.Trim() == "") {
                return Redirect("/");
            }

            using(var db = new Models.ChatContext())
            {
                User user = db.Users.FirstOrDefault(u => u.Name == Username);
                if(user == null)
                {
                    user = new Models.User { Name = Username };
                    db.Users.Add(user);
                    db.SaveChanges();
                }
                Session["user"] = user;
            }
            return Redirect("/chat");
        }
    }
}