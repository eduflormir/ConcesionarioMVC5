using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ConcesionarioMVC.Models;

namespace ConcesionarioMVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Usuario model)
        {
            // var clave = ConfigurationManager.AppSettings["ClaveCifrado"]; // recupero clave cifrado de web config
            if (Membership.ValidateUser(model.login, model.password)) // ESTA DEFINIDO EN EL WEB CONFIG
            {
                //var l = SeguridadUtilidades.DesCifrar(Convert.FromBase64String(model.login), clave);
                FormsAuthentication.RedirectFromLoginPage(model.login, false);
                RedirectToAction("Index", "Tipos");
            }
            return View(model);
        }

        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Tipos"); // Si salgo, hago redirect hacia /Tipos/Index
        }
    }
}