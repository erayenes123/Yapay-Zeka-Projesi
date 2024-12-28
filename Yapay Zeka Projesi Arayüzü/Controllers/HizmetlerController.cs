using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yapay_Zeka_Projesi_Arayüzü.Models;

namespace Yapay_Zeka_Projesi_Arayüzü.Controllers
{
    public class HizmetlerController : Controller
    {   
        YzprojesiEntities db = new YzprojesiEntities();
        public ActionResult Index()
        {
            var value = db.Hizmetler.ToList();
            return View(value);
        }

        public ActionResult Sil(int id)
        {
            var value = db.Hizmetler.Find(id);
            db.Hizmetler.Remove(value);
            db.SaveChanges();

            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Hizmetler model)
        {
            db.Hizmetler.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var value = db.Hizmetler.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult Update(Hizmetler model)
        {
            var value = db.Hizmetler.Find(model.Hizmetlerid);
            value.ResimUrl = model.ResimUrl;
            value.Aciklama = model.Aciklama;
            value.Baslik = model.Baslik;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}