﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testGit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //dev1
            //feature1
            //feature2
            //dev2
            //feature3
            //feature4
            //feature5
            //hotfix1
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}