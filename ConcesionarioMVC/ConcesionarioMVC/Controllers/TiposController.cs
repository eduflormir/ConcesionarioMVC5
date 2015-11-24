using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConcesionarioMVC.Models;

namespace ConcesionarioMVC.Controllers
{
    [Authorize]
    public class TiposController : Controller
    {
        Concesionario25Entities db = new Concesionario25Entities();
        
        // GET: Tipos
        public ActionResult Index()
        {
            return View(db.Tipos.ToList());
        }

        public ActionResult Alta()
        {
            return View(new Tipos());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Alta(Tipos model)
        {
            if (ModelState.IsValid)
            {
                db.Tipos.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");    
            }

            return View(model);
        }


    }
}
