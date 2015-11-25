using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using ConcesionarioMVC.Seguridad;

namespace ConcesionarioMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
        // sender: es quien a lanzado el evento
        // EventArgs: los argumentos que se pasan de ese evento
        protected void Application_PostAuthenticateRequest(Object sender, EventArgs e)
        {
            // es recomendable hacerlo para recuperar el perfil
            // para este caso cada vez que realiza una petición pasa por aqui
            if (Request.IsAuthenticated)
            {
                var identity = new IdentityPersonalizado(HttpContext.Current.User.Identity); // recuperame el identity personalziado
                var principal = new PrincipalPersonalizado(identity); // asignamelo al principal personalizado
                HttpContext.Current.User = principal;
            }
        }
    }
}
