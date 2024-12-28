using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Yapay_Zeka_Projesi_Arayüzü.Controllers
{
    public class AdminLayoutController : Controller
    {
        // GET: AdminLayout
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult AdminSpinner()
        {
            return PartialView();
        }

        public PartialViewResult AdminSideBar()
        {
            return PartialView();
        }




        
        
    }
}