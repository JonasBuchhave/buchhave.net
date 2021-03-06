﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace buchhave.net.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        [Route("~/")]
        [Route("~/Index")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("~/Generic")]
        public ActionResult Generic()
        {
            return View();
        }

        [Route("~/Elements")]
        public ActionResult Elements()
        {
            return View();
        }

        [ActionName("Menu")]
        public ActionResult Menu()
        {
            return View();
        }

    }
}