using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearnMVC.Infrastructure;
namespace LearnMVC.Controllers
{
    [SelectedTab("Home")]
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult index()
        {
            return View();
        }

    }
}