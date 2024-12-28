using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yapay_Zeka_Projesi_Arayüzü.Models;

namespace Yapay_Zeka_Projesi_Arayüzü.Controllers
{
    [AllowAnonymous]
    public class UILayoutController : Controller
    {
        YzprojesiEntities db = new YzprojesiEntities();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult DefaultNavbar()
        {
            return PartialView();
        }

        public PartialViewResult DefaultAnasayfa()
        {
            var value = db.Anasayfa.ToList();

            return PartialView(value);
        }

        public PartialViewResult DefaultHizmetler()
        {
            var value = db.Hizmetler.ToList();

            return PartialView(value);
        }

        
        public PartialViewResult DefaultTeam()
        {

            var value = db.Ekip.ToList();
            return PartialView(value);
        }

        //public PartialViewResult DefaultIletisim()
        //{
        //    return PartialView();
        //}
       

       

        public PartialViewResult DefaultFooter()
        {
            return PartialView();
        }

        public PartialViewResult DefaultOrnekler()
        {   
            var value = db.Analizler.ToList();
            return PartialView(value);
        }
        
    }
}