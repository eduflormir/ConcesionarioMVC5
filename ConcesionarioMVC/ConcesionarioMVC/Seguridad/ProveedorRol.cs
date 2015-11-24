using System;
using System.Configuration;
using System.Linq;
using System.Web.Security;
using ConcesionarioMVC.Models;
using ConcesionarioMVC.Utilidades;

namespace ConcesionarioMVC.Seguridad
{
    public class ProveedorRol : RoleProvider
    {
        /// <summary>
        /// Para determinar si un usuario tiene un determinado Rol
        /// </summary>
        /// <param name="username"></param>
        /// <param name="roleName"></param>
        /// <returns></returns>
        public override bool IsUserInRole(string username, string roleName)
        {
            // cifrar el login
            var clave = ConfigurationManager.AppSettings["ClaveCifrado"];
            var cif = SeguridadUtilidades.Cifrar(username, clave);

            using (var db = new Concesionario25Entities())
            {
                var us = db.Usuario.First(o => o.login == cif);
                try
                {
                    return us.Rol.nombre == roleName;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        public override string[] GetRolesForUser(string username)
        {
            // cifrar el login
            var clave = ConfigurationManager.AppSettings["ClaveCifrado"];
            var cif = SeguridadUtilidades.Cifrar(username, clave);

            using (var db = new Concesionario25Entities())
            {
                var us = db.Usuario.First(o => o.login == username);
                try
                {
                    return new[] { us.Rol.nombre };
                }
                catch (Exception e)
                {
                    return null;
                }
            }

        }

        public override void CreateRole(string roleName)
        {
            throw new System.NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new System.NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new System.NotImplementedException();
        }
        /// <summary>
        /// Añadir usuario a roles
        /// </summary>
        /// <param name="usernames"></param>
        /// <param name="roleNames"></param>
        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new System.NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new System.NotImplementedException();
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new System.NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new System.NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Determina el nombre de la aplicación
        /// </summary>
        public override string ApplicationName { get; set; }
    }
}