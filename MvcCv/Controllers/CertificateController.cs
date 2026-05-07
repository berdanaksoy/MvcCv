using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class CertificateController : Controller
    {
        GenericRepository<TblCertificate> repo = new GenericRepository<TblCertificate>();
        public ActionResult Index()
        {
            var certificates = repo.List();
            return View(certificates);
        }

        [HttpGet]
        public ActionResult EditCertificate(int id)
        {
            var certificate = repo.Find(x => x.ID == id);
            return View(certificate);
        }

        [HttpPost]
        public ActionResult EditCertificate(TblCertificate certificate)
        {
            var c = repo.Find(x => x.ID == certificate.ID);
            c.Description = certificate.Description;
            c.Date = certificate.Date;
            repo.Update(c);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddCertificate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCertificate(TblCertificate certificate)
        {
            repo.Add(certificate);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCertificate(int id)
        {
            var certificate = repo.Find(x => x.ID == id);
            repo.Delete(certificate);
            return RedirectToAction("Index");
        }
    }
}