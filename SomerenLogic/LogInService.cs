using System;
using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

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
        public bool CheckPassword(string user, string password, string passwordSalt, string passwordDigest, HashAlgorithm hashAlgo)
        {
            //byte[] saltBytes = Encoding.UTF8.GetBytes(passwordSalt);
            byte[] passwordAsBytes = Encoding.UTF8.GetBytes(password);
            //List<byte> passwordWithSaltBytes = new List<byte>();
            //passwordWithSaltBytes.AddRange(passwordAsBytes);
            //passwordWithSaltBytes.AddRange(saltBytes);
            //byte[] digestBytes = hashAlgo.ComputeHash(passwordWithSaltBytes.ToArray());
            if(passwordDigest == Convert.ToBase64String(passwordAsBytes) + passwordSalt)
            {
                return true;
            }
            return false;
        }
    }
}
