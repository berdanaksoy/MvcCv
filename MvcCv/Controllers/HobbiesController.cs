using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class HobbiesController : Controller
    {
        GenericRepository<TblHobby> repo = new GenericRepository<TblHobby>();

        [HttpGet]
        public ActionResult Index()
        {
            var hobbies = repo.List();
            return View(hobbies);
        }

        [HttpPost]
        public ActionResult Index(TblHobby hobbies)
        {
            var h = repo.Find(x => x.ID == 1);
            h.Description1 = hobbies.Description1;
            h.Description2 = hobbies.Description2;
            repo.Update(h);
            return RedirectToAction("Index");
        }
    }
}