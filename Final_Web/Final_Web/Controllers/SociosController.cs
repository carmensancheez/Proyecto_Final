using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.IO;
using System.Web.Mvc;
using Final_Web.Models;

namespace Final_Web.Controllers
{
    public class SociosController : Controller
    {
        private progwebEntities db = new progwebEntities();

        // GET: Socios
        public ActionResult Index()
        {
            return View(db.Socios.ToList());
        }

        // GET: Socios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Socio socio = db.Socios.Find(id);
            if (socio == null)
            {
                return HttpNotFound();
            }
            return View(socio);
        }

        // GET: Socios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Socios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,Apellidos,Cedula,Foto,Direccion,Sexo,Edad,FechaNacimiento,TipoMembresia,LugarTrabajo,DireccionTrabajo,TelefonoOficina,EstadoMembresia,FechaIngreso,FechaSalida")] Socio socio, HttpPostedFileBase Imagen)
        {
            if (ModelState.IsValid)
            {
                string fileName = Path.GetFileNameWithoutExtension(Imagen.FileName);
                string extension = Path.GetExtension(Imagen.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                socio.Foto = "~/image/" + fileName;
                fileName = Path.Combine(Server.MapPath("~/Image/"), fileName);
                Imagen.SaveAs(fileName);


                db.Socios.Add(socio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(socio);
        }

        // GET: Socios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Socio socio = db.Socios.Find(id);
            if (socio == null)
            {
                return HttpNotFound();
            }
            return View(socio);
        }

        // POST: Socios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,Apellidos,Cedula,Foto,Direccion,Sexo,Edad,FechaNacimiento,TipoMembresia,LugarTrabajo,DireccionTrabajo,TelefonoOficina,EstadoMembresia,FechaIngreso,FechaSalida")] Socio socio, HttpPostedFileBase imagen)
        {
            if (ModelState.IsValid)
            {
                string fileName = Path.GetFileNameWithoutExtension(imagen.FileName);
                string extension = Path.GetExtension(imagen.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                socio.Foto = "~/image/" + fileName;
                fileName = Path.Combine(Server.MapPath("~/Image/"), fileName);
                imagen.SaveAs(fileName);


                db.Entry(socio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(socio);
        }

        // GET: Socios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Socio socio = db.Socios.Find(id);
            if (socio == null)
            {
                return HttpNotFound();
            }
            return View(socio);
        }

        // POST: Socios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Socio socio = db.Socios.Find(id);
            db.Socios.Remove(socio);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
