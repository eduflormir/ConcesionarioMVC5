using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConcesionarioMVC.Models;

namespace ConcesionarioMVC.Controllers
{
    public class TiposController : Controller
    {
        Concesionario25Entities db = new Concesionario25Entities();



        public ActionResult Buscar(String matricula, String marca, int idTipo)
        {
            var data = db.Vehiculos.Where(o => o.matricula == matricula || o.marca == marca || o.idTipo==idTipo).OrderBy(o => o.marca);
            
            return PartialView("_listadoVehiculos", data);
        }

        public ActionResult ListadoVehiculos(int? id)
        {
            ViewBag.Tipos = db.Tipos.ToList();
            if (id != null)
            {
                var data = db.Vehiculos.Where(o => o.idTipo == id);
                return View(data);
            }
            // nameof para obtener el nombre de las acciones

            return RedirectToAction(nameof(Controllers.TiposController.ListadoVehiculos),
                nameof(Controllers.TiposController).Replace("Controller",""));


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
