using System;
using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class LogInService
    {
        LogInDao logIndb;

        public LogInService()
        {
            logIndb = new LogInDao();
        }

        public LogIn GetById()
        {

        }
    }
}
