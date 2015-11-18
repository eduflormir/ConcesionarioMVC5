using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConcesionarioMVC.Models;

namespace ConcesionarioMVC.Controllers
{
    public class TiposController : Controller
    {
        Concesionario25Entities db = new Concesionario25Entities();



        public ActionResult Buscar(String matricula, String marca)
        {
            var data = db.Vehiculos.Where(o => o.matricula == matricula||o.marca==marca).OrderBy(o=>o.marca);
            return PartialView("_listadoVehiculos", data);
        }

        public ActionResult ListadoVehiculos(int? id)
        {
            if (id != null)
            {
                var data = db.Vehiculos.Where(o => o.idTipo == id);
                return View(data);
            }
            
            return View("Index");
            

        }

        // GET: Tipos
        public ActionResult Index()
        {
            var data = db.Tipos.ToList();
            return View(data);
        }


        [HttpPost]
        public ActionResult Alta(Vehiculos model)
        {
            db.Vehiculos.Add(model);
            db.SaveChanges();
            return Json(model); // devuelve un objeto Json
        }


    }
}
