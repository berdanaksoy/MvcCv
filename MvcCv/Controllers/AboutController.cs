using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class AboutController : Controller
    {
        GenericRepository<TblAbout> repo = new GenericRepository<TblAbout>();

        [HttpGet]
        public ActionResult Index()
        {
            var values = repo.List();
            return View(values);
        }

        [HttpPost]
        public ActionResult Index(TblAbout about)
        {
            var a = repo.Find(x => x.ID == 5);
            a.Name = about.Name;
            a.Surname = about.Surname;
            a.Address = about.Address;
            a.PhoneNumber = about.PhoneNumber;
            a.Mail = about.Mail;
            a.Description = about.Description;
            a.Photo = about.Photo;
            repo.Update(a);
            return RedirectToAction("Index");
        }
    }
}