using System;
using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Configuration;

namespace SomerenLogic
{
    public class LogInService
    {
        LogInDao logIndb;

        public LogInService()
        {
            logIndb = new LogInDao();
        }

        public LogIn GetById(string user)
        {
            return logIndb.GetById(user);
        }
        public LogIn ValidatePassword(string id, string password)
        {
            return logIndb.ValidatePassword(id, password);
        }
        public LogIn CheckPassword(string id, string password, HashAlgorithm hashAlgo)
        {
            byte[] saltBytes = Convert.FromBase64String(ConfigurationManager.AppSettings["Salt"]);
            byte[] passwordAsBytes = Encoding.UTF8.GetBytes(password);
            List<byte> passwordWithSaltBytes = new List<byte>();
            passwordWithSaltBytes.AddRange(passwordAsBytes);
            passwordWithSaltBytes.AddRange(saltBytes);
            byte[] digestBytes = hashAlgo.ComputeHash(passwordWithSaltBytes.ToArray());
            return ValidatePassword(id, Convert.ToBase64String(digestBytes));
        }
    }
}
