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
            string query = $"SELECT userId, adminStatus, passwordDigest FROM [Users] " +
                $"WHERE userId = @userId";
            SqlParameter[] sqlParameters = new SqlParameter[1]
            {
                new SqlParameter("@userId", userId)
            };

            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }
        public LogIn ValidatePassword(string id, string password)
        {
            string query = $"SELECT userId, adminStatus FROM [Users] " +
                $"WHERE passwordDigest = @passwordDigest AND " +
                $"userId = @userId";
            SqlParameter[] sqlParameters = new SqlParameter[2]
            {
                new SqlParameter(("@userId"), id),
                new SqlParameter("@passwordDigest", password)
            };

            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }
        public void RegisterUser(string id, string status, string password)
        {
            string query = "INSERT INTO Users (userId, adminStatus, passwordDigest)" +
                "VALUES (@userId, @adminStatus, @passwordDigest); " +
                "SELECT SCOPE_IDENTITY();";
            SqlParameter[] sqlParameters = new SqlParameter[3]
           {
                new SqlParameter("@userId", id),
                new SqlParameter("@adminStatus", status),
                new SqlParameter("@passwordDigest", password)
           };
            //register to the table
            ExecuteSelectQuery(query, sqlParameters);
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
                };
            }
            return logIn;
        }
    }
}
