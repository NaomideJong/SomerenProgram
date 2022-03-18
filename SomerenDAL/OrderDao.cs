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

        public List<Order> GetAllOrders()
        {
            string query = "SELECT orderId, studentId, drinkId, dateOfPurchase FROM [Orders]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void AddOrder(Order order)
        {
            string query = "INSERT INTO Orders (studentId, drinkId, dateOfPurchase)" +
                "VALUES (@studentId, @drinkId, @dateOfPurchase); " +
                "SELECT SCOPE_IDENTITY();";

            SqlParameter[] sqlParameters = new SqlParameter[3]
            {
                new SqlParameter("@studentId", order.StudentOrderId),
                new SqlParameter("@drinkId", order.DrinkOrderId),
                new SqlParameter("@dateOfPurchase", order.DateOfPurchase)
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            // check each row of the DataTable
            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    OrderId = (int)dr["orderId"],
                    StudentOrderId = (int)dr["studentId"],
                    DrinkOrderId = (int)dr["drinkId"],
                    DateOfPurchase = (SqlDbType)dr["dateOfPurchase"]
                };
                // add the order to the list
                orders.Add(order);
            }
            return orders;
        }
    }
}
