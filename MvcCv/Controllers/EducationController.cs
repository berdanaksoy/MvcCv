using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class EducationController : Controller
    {
        GenericRepository<TblEducation> repo = new GenericRepository<TblEducation>();
        public ActionResult Index()
        {
            var educations = repo.List();
            return View(educations);
        }

        [HttpGet]
        public ActionResult AddEducation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEducation(TblEducation education)
        {
            if(!ModelState.IsValid)
            {
                return View("AddEducation");
            }
            repo.Add(education);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteEducation(int id)
        {
            var education = repo.Find(x => x.ID == id);
            repo.Delete(education);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditEducation(int id)
        {
            var education = repo.Find(x => x.ID == id);
            return View(education);
        }

        [HttpPost]
        public ActionResult EditEducation(TblEducation education)
        {
            if(!ModelState.IsValid)
            {
                return View("EditEducation");
            }
            var existingEducation = repo.Find(x => x.ID == education.ID);
            existingEducation.Title = education.Title;
            existingEducation.Subtitle1 = education.Subtitle1;
            existingEducation.Subtitle2 = education.Subtitle2;
            existingEducation.Date = education.Date;
            existingEducation.GNO = education.GNO;
            repo.Update(existingEducation);
            return RedirectToAction("Index");
        }
    }
}