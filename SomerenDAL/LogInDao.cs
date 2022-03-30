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
            string query = $"SELECT userId, adminStatus, passwordSalt, passwordDigest FROM [Users] " +
                $"WHERE userId = @userId";
            SqlParameter[] sqlParameters = new SqlParameter[1]
            {
                new SqlParameter("@userId", userId)
            };

            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }
        private LogIn ReadTable(DataTable dataTable)
        {
            LogIn logIn = null;
            if (dataTable.Rows.Count > 0)
            {
                DataRow dr = dataTable.Rows[0];

                logIn = new LogIn()
                {
                    UserId = (string)dr["userId"],
                    AdminStatus = (string)dr["adminStatus"],
                    PasswordSalt = (string)dr["passwordSalt"],
                    PasswordDigest = (string)dr["passwordDigest"]
                };
            }
            
            return logIn;
        }
    }
}
