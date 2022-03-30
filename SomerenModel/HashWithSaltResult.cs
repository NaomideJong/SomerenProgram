using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class HashWithSaltResult
    {
        LogIn logIn = new LogIn();

        public HashWithSaltResult(string salt, string digest)
        {
            logIn.PasswordSalt = salt;
            logIn.PasswordDigest = digest;
        }
    }
}
