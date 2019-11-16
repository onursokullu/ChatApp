using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChatAppwithPusher.Controllers
{
    public class ChatController : Controller
    {
        // GET: Chat
        public ActionResult Index()
        {
            if(Session["user"] == null)
            {
                return Redirect("/");
            }
            var currentUser = (Models.User)Session["user"];
            using(var db = new Models.ChatContext())
            {
                ViewBag.allUsers = db.Users.Where(u => u.Name != currentUser.Name).ToList();
            }
            ViewBag.currentUser = currentUser;
            return View();
        }
    }
}