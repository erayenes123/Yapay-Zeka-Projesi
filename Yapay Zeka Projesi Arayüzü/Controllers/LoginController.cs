using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Yapay_Zeka_Projesi_Arayüzü.Models;

namespace Yapay_Zeka_Projesi_Arayüzü.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {   
        YzprojesiEntities db = new YzprojesiEntities();
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin model)
        {
            var value = db.Admin.FirstOrDefault(x => x.Email == model.Email && x.Password == model.Password);
            //where kullanmamamızın sebebi birden fazla değer döndürebilecek olması 
            //FirsOrDefault kullanmamızın sebebi ise eğerki bir değer bulamazsa hata fırlatmak yerine onun ilk değer tipini döner


            if (value == null)
            {
                ModelState.AddModelError("", "Email veya Şifre Hatalı");
                return View(model);
            }
            FormsAuthentication.SetAuthCookie(value.Email, false);

            Session["email"] = value.Email;
            return RedirectToAction("Index", "Anasayfa");
        }

        
        public ActionResult End()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index","Login");
        }
    }
}