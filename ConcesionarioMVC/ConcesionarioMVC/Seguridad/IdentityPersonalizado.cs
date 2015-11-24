using System;
using System.Security.Principal;
using System.Web.Security;

namespace ConcesionarioMVC.Seguridad
{
    public class IdentityPersonalizado : IIdentity
    {
        public string Name
        {
            get { return login; }
        }

        public string AuthenticationType
        {
            get { return Identity.AuthenticationType; }
        }

        public bool IsAuthenticated
        {
            get { return Identity.IsAuthenticated; }
        }


        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string nombre { get; set; }
        public string imagen { get; set; }
        public string apellidos { get; set; }
        public String Rol { get; set; }
        public IIdentity Identity { get; set; }
        public String Email { get; set; }

        public IdentityPersonalizado(IIdentity identity)
        {
            this.Identity = identity;
            var us = Membership.GetUser(identity.Name) as UsuarioMembership;
            nombre = us.nombre;
            apellidos = us.apellidos;
            login = us.login;
            id = us.id;
            imagen = us.imagen;
            Rol = us.Rol;
            Email = Email;


        }
    }
}