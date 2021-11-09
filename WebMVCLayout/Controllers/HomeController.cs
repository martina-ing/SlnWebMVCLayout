using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVCLayout.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Fecha = DateTime.Now.ToShortDateString();
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Saludos = "Ejemplo en About";
            return View();
        
        }






    }




}