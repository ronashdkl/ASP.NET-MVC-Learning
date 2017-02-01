
using LearnMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
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
        public ActionResult Index(Auth form, string returnUrl)
        {

            if (!ModelState.IsValid)            
                return View(form);
                //if (form.username != "ronash")
                //{
                //    ModelState.AddModelError("username", "Username or Password is not correct");
                //    return View(form);
                //}
               

            
            FormsAuthentication.SetAuthCookie(form.username, true);

            if (!string.IsNullOrWhiteSpace(returnUrl))            
           return Redirect(returnUrl);
           
            
          return   RedirectToRoute("home");
            

           

        }
       
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToRoute("home");
        }
    }
}