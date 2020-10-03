﻿using Session.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Blog()
        {
            return View();
        }
        public ActionResult BlogDetails()
        {
            return View();
        }
        [AuthorizeLogin]
        public ActionResult Courses()
        {
            return View();
        }
        public ActionResult Elements()
        {
            return View();
        }
        [AuthorizeLogin]
        public ActionResult Instructor()
        {
            return View();
        }
    }
}