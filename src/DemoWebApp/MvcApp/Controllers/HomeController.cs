﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PlainHtml()
        {
            return View();
        }

        public ActionResult ClientSideHtmlWithController()
        {
            return View();
        }

        public ActionResult FormsAndAngularJs()
        {
            return View();
        }
    }
}
