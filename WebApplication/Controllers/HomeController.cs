﻿using System.Web.Mvc;

namespace WebApplication.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public ActionResult DashboardV1()
        {
            return View();
        }
        public ActionResult DashboardV2()
        {
            return View();
        }
    }
}