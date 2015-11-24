using System.Linq;
using System.Web.Security;
using ConcesionarioMVC.Models;
using ConcesionarioMVC.Utilidades;

namespace ConcesionarioMVC.Seguridad
{
    public class ProveedorAutenticacion : MembershipProvider
    {
        public override MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer,
            bool isApproved, object providerUserKey, out MembershipCreateStatus status)
        {
            throw new System.NotImplementedException();
        }

        public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion,
            string newPasswordAnswer)
        {
            throw new System.NotImplementedException();
        }

        public override string GetPassword(string username, string answer)
        {
            throw new System.NotImplementedException();
        }

        public override bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            throw new System.NotImplementedException();
        }

        public override string ResetPassword(string username, string answer)
        {
            throw new System.NotImplementedException();
        }

        public override void UpdateUser(MembershipUser user)
        {
            throw new System.NotImplementedException();
        }

        public override bool ValidateUser(string username, string password)
        {
            using (var db = new Concesionario25Entities())
            {
                //var clave = ConfigurationManager.AppSettings["ClaveCifrado"];
                // var login = SeguridadUtilidades.Cifrar(username, clave);
                var pwd = SeguridadUtilidades.GetSha1(password);

                return db.Usuario.Any(o => o.password == pwd && o.login == username); // si encuentra es True, de lo contrario False
            }
        }

        public override bool UnlockUser(string userName)
        {
            throw new System.NotImplementedException();
        }
        /// <summary>
        /// Obtiene el usuario membership
        /// </summary>
        /// <param name="providerUserKey"></param>
        /// <param name="userIsOnline"></param>
        /// <returns></returns>
        public override MembershipUser GetUser(object providerUserKey, bool userIsOnline)
        {
            throw new System.NotImplementedException();
        }

        public override MembershipUser GetUser(string username, bool userIsOnline)
        {
            using (var db = new Concesionario25Entities())
            {
                // var clave = ConfigurationManager.AppSettings["ClaveCifrado"];
                // var login = SeguridadUtilidades.Cifrar(username, clave);
                // var user = db.Usuario.FirstOrDefault(o => o.login == login);

                var user = db.Usuario.FirstOrDefault(o => o.login == username);

                if (user == null)
                    return null;

                return new UsuarioMembership(user); // por defecto devuelvo user

            }
        }

        public override string GetUserNameByEmail(string email)
        {
            throw new System.NotImplementedException();
        }

        public override bool DeleteUser(string username, bool deleteAllRelatedData)
        {
            throw new System.NotImplementedException();
        }

        public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
        {
            throw new System.NotImplementedException();
        }

        public override int GetNumberOfUsersOnline()
        {
            throw new System.NotImplementedException();
        }

        public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new System.NotImplementedException();
        }

        public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new System.NotImplementedException();
        }

        public override bool EnablePasswordRetrieval { get; }
        public override bool EnablePasswordReset { get; }
        public override bool RequiresQuestionAndAnswer { get; }
        public override string ApplicationName { get; set; }
        public override int MaxInvalidPasswordAttempts { get; }
        public override int PasswordAttemptWindow { get; }
        public override bool RequiresUniqueEmail { get; }
        public override MembershipPasswordFormat PasswordFormat { get; }
        public override int MinRequiredPasswordLength { get; }
        public override int MinRequiredNonAlphanumericCharacters { get; }
        public override string PasswordStrengthRegularExpression { get; }
    }
}