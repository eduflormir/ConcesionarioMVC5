using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConcesionarioMVC.Models;

namespace ConcesionarioMVC.Controllers
{
    public class VehiculosController : Controller
    {

        Concesionario25Entities db = new Concesionario25Entities();

        

        public ActionResult Index(int id)
        {
            ViewBag.idTipo = id;
            var data = db.Vehiculos.Where(o => o.idTipo == id);
            return View(data.ToList());
        }

        public ActionResult Buscar(int idTipo, int campo, String contenido)
        {
            // IQueryable: elemento sobre el que puedo seguir haciendo consultas
            // Es decir enlazando consultas ( metodos de extensión)
            var data = db.Vehiculos.Where(o=>o.idTipo==idTipo);
            // Campo = 1 Es Matricula
            if (campo == 1) 
            {
                data = data.Where(o => o.matricula.Contains(contenido));
            }
            else
            {
                data = data.Where(o => o.marca.Contains(contenido));
            }

            return PartialView("_listadoVehiculos", data.ToList());
        }

        public ActionResult Alta()
        {
            return View(new Vehiculos());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Alta(Vehiculos model)
        {
            db.Vehiculos.Add(model);
            db.SaveChanges();
            return Json(model);
        }


    }
}