﻿using System.Web.Mvc;

namespace WebApplication.Controllers
{
    [AllowAnonymous]
    public class FormsController : Controller
    {
        public ActionResult General()
        {
            return View();
        }
        public ActionResult Advanced()
        {
            return View();
        }
        public ActionResult Editors()
        {
            return View();
        }
    }
}