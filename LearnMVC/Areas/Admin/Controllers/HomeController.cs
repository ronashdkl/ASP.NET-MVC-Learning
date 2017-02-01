﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearnMVC.Infrastructure;

namespace LearnMVC.Areas.Admin.Controllers
{
    [Authorize(Roles ="admin")]
    [SelectedTab("Home")]
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}