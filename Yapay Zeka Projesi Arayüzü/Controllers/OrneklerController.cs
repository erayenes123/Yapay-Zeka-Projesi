using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yapay_Zeka_Projesi_Arayüzü.Models;

namespace Yapay_Zeka_Projesi_Arayüzü.Controllers
{
    public class OrneklerController : Controller
    {
        YzprojesiEntities db = new YzprojesiEntities();
        public ActionResult Index()
        {   

            var value = db.Analizler.ToList();
            return View(value);
        }

        public ActionResult Sil(int id)
        {
            var value = db.Analizler.Find(id);
            db.Analizler.Remove(value);
            db.SaveChanges();

            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Analizler model)
        {
            db.Analizler.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var value = db.Analizler.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult Update(Analizler model)
        {
            var value = db.Analizler.Find(model.Ornekid);
            value.ResimUrl = model.ResimUrl;
            value.Ad = model.Ad;
            value.ModelMiktar = model.ModelMiktar;
            value.ModelIcindekiler = model.ModelIcindekiler;
            value.ModelProtein = model.ModelProtein;
            value.ModelKarbonhidrat = model.ModelKarbonhidrat;
            value.ModelKalori = model.ModelKalori;
            
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}