using System.Security.Principal;

namespace ConcesionarioMVC.Seguridad
{
    public class PrincipalPersonalizado : IPrincipal
    {
        /// <summary>
        /// Le paso el nombre del rol
        /// // verifica si el Rol es valido
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public bool IsInRole(string role)
        {
            //if (MiIdentidadPersonalizado.Rol == role)
            //    return true;
            //return false;
            return MiIdentidadPersonalizado.Rol == role;
        }


        public IIdentity Identity { get; set; }

        public IdentityPersonalizado MiIdentidadPersonalizado
        {
            get { return (IdentityPersonalizado)Identity; }
            set { Identity = value; }
        }

        public PrincipalPersonalizado(IdentityPersonalizado identity)
        {
            Identity = identity;
        }
    }
}