﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChatAppwithPusher.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public ActionResult Index()
        {
            //if(Session["User"] != null)
            //{
            //    return Redirect("/chat");
            //}
            return View();
        }
    }
}