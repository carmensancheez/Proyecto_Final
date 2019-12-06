using Final_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final_Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            progwebEntities pwe = new progwebEntities();
            List < AspNetUser > listaUsuarios= pwe.AspNetUsers.ToList();
            
            ViewData["usuarios"] = from u in listaUsuarios select new Listas { listaUsuarios = u };

            return View(ViewData["usuarios"]);
        }
    }
}