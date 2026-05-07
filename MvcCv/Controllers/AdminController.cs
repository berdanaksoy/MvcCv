using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class AdminController : Controller
    {
        GenericRepository<TblAdmin> repo = new GenericRepository<TblAdmin>();
        public ActionResult Index()
        {
            var values = repo.List();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAdmin(TblAdmin admin)
        {
            repo.Add(admin);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteAdmin(int id)
        {
            TblAdmin admin = repo.Find(x => x.ID == id);
            repo.Delete(admin);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditAdmin(int id)
        {
            TblAdmin admin = repo.Find(x => x.ID == id);
            return View(admin);
        }

        [HttpPost]
        public ActionResult EditAdmin(TblAdmin admin)
        {
            TblAdmin existingAdmin = repo.Find(x => x.ID == admin.ID);
            existingAdmin.Username = admin.Username;
            existingAdmin.Password = admin.Password;
            repo.Update(existingAdmin);
            return RedirectToAction("Index");
        }
    }
}