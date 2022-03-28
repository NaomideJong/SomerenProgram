using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SomerenModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class LogInDao : BaseDao
    {
        public LogIn GetById(string userId)
        {
            string query = $"SELECT userId, adminStatus, userPassword FROM [Users] " +
                $"WHERE userId = @userId";
            SqlParameter[] sqlParameters = new SqlParameter[1]
            {
                new SqlParameter("@userId", userId)
            };

            return ReadTable(ExecuteSelectQuery(query, sqlParameters))[0];
        }
        private List<LogIn> ReadTable(DataTable dataTable)
        {
            List<LogIn> logIns = new List<LogIn>();

            // check each row of the DataTable
            foreach (DataRow dr in dataTable.Rows)
            {
                LogIn logIn = new LogIn()
                {
                    UserId = (string)dr["userId"],
                    AdminStatus = (string)dr["adminStatus"],
                    UserPassword = (string)dr["userPassword"]
                };
                // add the drink to the list
                logIns.Add(logIn);
            }
            return logIns;
        }
    }
}
