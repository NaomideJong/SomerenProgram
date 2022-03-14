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
    public class DrinkDao : BaseDao
    {
        public List<Drink> GetAllDrinks()
        {
            // select the query from the drinks database
            string query = "SELECT drinkId, drinkName, drinkPrice, drinkStock, drinkVAT FROM [Drinks]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            // check each row of the DataTable
            foreach (DataRow dr in dataTable.Rows)
            {
                Drink drink = new Drink()
                {
                    DrinkId = (int)dr["drinkId"],
                    DrinkName = (string)dr["drinkName"],
                    DrinkPrice = (decimal)dr["drinkPrice"],
                    DrinkStock = (int)dr["drinkStock"],
                    DrinkVAT = (decimal)dr["drinkVAT"],
                };
                // add the drink to the list
                drinks.Add(drink);
            }
            return drinks;
        }
    }
}
