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

        public ActionResult Afiliados() {
            progwebEntities pwe = new progwebEntities();
            var listaSocios = pwe.Socios.ToList();
            SelectList lista = new SelectList(listaSocios, "ID", "Nombre");
            ViewBag.Socios = lista;
            return View();
        }

        public ActionResult verAfiliados(Socio msocio) {
            progwebEntities pwe = new progwebEntities();
            List<Socio> listaSocio = pwe.Socios.ToList();
            List<Afiliado> listaAfiliado = pwe.Afiliados.ToList();

            if (msocio.Id == 0)
            {
                return Redirect("Afiliados");
            }
            else {
                ViewData["Afiliados"] = from a in listaAfiliado where a.idSocio == msocio.Id select new Listas { listaAfiliados = a};
            
            
            }

            return View();
        }

        public ActionResult agregarAfiliados()
        {
            progwebEntities pwe = new progwebEntities();
            var listaSocios = pwe.Socios.ToList();
            SelectList lista = new SelectList(listaSocios, "ID", "Nombre");
            ViewBag.Socios = lista;

            Afiliado miAfiliado = new Afiliado();
            miAfiliado.Nombre = Request.Form["Nombre"];
            miAfiliado.Apellidos = Request.Form["Apellidos"];
           

            if (!String.IsNullOrEmpty(miAfiliado.Apellidos)) {
                miAfiliado.idSocio = Int32.Parse(Request.Form["idSocio"]);
                pwe.Afiliados.Add(miAfiliado);
                pwe.SaveChanges();
                return RedirectToAction("Afiliados", "Home");
;            
            }

            return View();
        }

           
        }

    }
