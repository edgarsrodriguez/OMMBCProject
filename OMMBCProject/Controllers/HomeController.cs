﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace OMMBCProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string name = ClaimsPrincipal.Current.FindFirst("name")?.Value;
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