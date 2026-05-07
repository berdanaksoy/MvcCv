using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceRepository repo = new ExperienceRepository();

        public ActionResult Index()
        {
            var values = repo.List();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddExperience()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddExperience(TblExperience experience)
        {
            repo.Add(experience);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteExperience(int id)
        {
            TblExperience experience = repo.Find(x => x.ID == id);
            repo.Delete(experience);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditExperience(int id)
        {
            TblExperience experience = repo.Find(x => x.ID == id);
            return View(experience);
        }

        [HttpPost]
        public ActionResult EditExperience(TblExperience experience)
        {
            TblExperience exp = repo.Find(x => x.ID == experience.ID);
            exp.Title = experience.Title;
            exp.Subtitle = experience.Subtitle;
            exp.Date = experience.Date;
            exp.Description = experience.Description;
            repo.Update(exp);
            return RedirectToAction("Index");
        }
    }
}