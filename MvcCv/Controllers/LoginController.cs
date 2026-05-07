using MvcCv.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcCv.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TblAdmin p)
        {
            DbCvEntities1 db = new DbCvEntities1();
            var user = db.TblAdmins.FirstOrDefault(x => x.Username == p.Username && x.Password == p.Password);
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(user.Username, false);
                Session["Username"] = user.Username.ToString();
                return RedirectToAction("Index", "About");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}