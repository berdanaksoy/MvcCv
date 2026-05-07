using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class SkillController : Controller
    {
        GenericRepository<TblSkill> repo = new GenericRepository<TblSkill>();
        public ActionResult Index()
        {
            var skills = repo.List();
            return View(skills);
        }

        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSkill(TblSkill s)
        {
            repo.Add(s);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSkill(int id)
        {
            var skill = repo.Find(x => x.ID == id);
            repo.Delete(skill);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditSkill(int id)
        {
            var skill = repo.Find(x => x.ID == id);
            return View(skill);
        }

        [HttpPost]
        public ActionResult EditSkill(TblSkill s)
        {
            var skill = repo.Find(x => x.ID == s.ID);
            skill.Skill = s.Skill;
            skill.Progress = s.Progress;
            repo.Update(skill);
            return RedirectToAction("Index");
        }
    }
}