﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace LearnMVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult index()
        {
            return Content("Hello World!");
        }

    }
}