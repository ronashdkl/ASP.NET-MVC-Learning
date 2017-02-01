
using LearnMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnMVC.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Index ()
        {
            return View(new Auth { username = null });
        }

        [HttpPost]
        public ActionResult Index(Auth form)
        {

            if (ModelState.IsValid)
            {
                if (form.username != "ronash")
                {
                    ModelState.AddModelError("username", "Username or Password is not correct");
                    return View(form);
                }
            }
            return Content("Welcome "+ form.username);
           
            
        }
    }
}