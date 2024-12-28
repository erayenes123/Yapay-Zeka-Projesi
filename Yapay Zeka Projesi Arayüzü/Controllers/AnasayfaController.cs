using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yapay_Zeka_Projesi_Arayüzü.Models;

namespace Yapay_Zeka_Projesi_Arayüzü.Controllers
{
    public class AnasayfaController : Controller
    {
        YzprojesiEntities db = new YzprojesiEntities();

        public ActionResult Index()
        {   
            var value = db.Anasayfa.ToList();
            return View(value);
        }

        public ActionResult Sil(int id)
        {
            var value = db.Anasayfa.Find(id);
            db.Anasayfa.Remove(value);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Add()
        {   
            return View();
        }

        [HttpPost]
        public ActionResult Add(Anasayfa model)
        {
            db.Anasayfa.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int id) 
        {
            var value = db.Anasayfa.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult Update(Anasayfa model) 
        {
            var value = db.Anasayfa.Find(model.Anasayfaid);

            value.ButtonYazi = model.ButtonYazi;
            value.Aciklama = model.Aciklama;
            value.Baslik = model.Baslik;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}