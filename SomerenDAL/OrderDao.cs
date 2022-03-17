using SomerenModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class OrderDao : BaseDao
    {

        public void AddOrder(Order order)
        {
            // create a query where elements shall be inserted into the tables below
            string query = "INSERT INTO Orders (studentId, drinkId)" +
                "VALUES (@studentId, @drinkId); " +
                "SELECT SCOPE_IDENTITY();";

            // get a new sqlParameter and put the value of order.StudentOrderId and DrinkOrderId
            // in their respective tables
            SqlParameter[] sqlParameters = new SqlParameter[2]
            {
                new SqlParameter("@studentId", order.StudentOrderId),
                new SqlParameter("@drinkId", order.DrinkOrderId)
            };

            // execute the query and the parameters
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
