using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class SocialMediaController : Controller
    {
        GenericRepository<TblSocialMedia> repo = new GenericRepository<TblSocialMedia>();
        public ActionResult Index()
        {
            var values = repo.List();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddSocialMedia()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSocialMedia(TblSocialMedia p)
        {
            repo.Add(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditSocialMedia(int id)
        {
            var value = repo.Find(x => x.Id == id);
            return View(value);
        }

        [HttpPost]
        public ActionResult EditSocialMedia(TblSocialMedia p)
        {
            var value = repo.Find(x => x.Id == p.Id);
            value.Name = p.Name;
            value.Link = p.Link;
            value.Icon = p.Icon;
            value.IsActive = true;
            repo.Update(value);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSocialMedia(int id)
        {
            var value = repo.Find(x => x.Id == id);
            value.IsActive = false;
            repo.Update(value);
            return RedirectToAction("Index");
        }
    }
}