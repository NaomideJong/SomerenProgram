﻿using System;
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
            string query = "SELECT drinkId, drinkName, drinkPrice, drinkStock, drinkVAT, drinkValue, drinksSold FROM [Drinks]" +
                "WHERE drinkName != 'Water' OR" +
                "drinkName != 'Orangeade' OR" +
                "drinkName != 'Cherry juice' AND" +
                "drinkStock > 0 AND" +
                "drinkPrice > 0" +
                "ORDER BY drinkStock, drinkValue, drinksSold ASC";
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
                    DrinkValue = (decimal)dr["drinkValue"],
                    DrinksSold = (int)dr["drinksSold"]
                };
                // add the drink to the list
                drinks.Add(drink);
            }
            return drinks;
        }
        public void AddDrink(Drink drink)
        {
            string query = "INSERT INTO Drink (drinkName, drinkPrice, drinkVAT, drinkValue) " +
                "VALUES (@drinkName, @drinkPrince, @drinkValue)";
            SqlParameter[] sqlParameters = new SqlParameter[4]
           {
                new SqlParameter("@drinkName", drink.DrinkName),
                new SqlParameter("@drinkPrice", drink.DrinkPrice),
                new SqlParameter("@drinkVat", drink.DrinkVAT),
                new SqlParameter("@drinkValue", drink.DrinkValue)
           };
            //add drink to the table
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateDrink(Drink drink)
        {
            string query = "UPDATE Drinks SET(drinkName=@drinkName, drinkPrice=@drinkPrice, drinkVAT=@drinkVAT, drinkValue=@drinkValue" +
                "WHERE drinkId = @drinkId)";
            SqlParameter[] sqlParameters = new SqlParameter[4]
           {
                new SqlParameter("@drinkName", drink.DrinkName),
                new SqlParameter("@drinkPrice", drink.DrinkPrice),
                new SqlParameter("@drinkVat", drink.DrinkVAT),
                new SqlParameter("@drinkValue", drink.DrinkValue)
           };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DeleteDrink(Drink drink)
        {
            string query = "DELETE FROM Drink WHERE drinkId = @drinkId)";
            SqlParameter[] sqlParameters = new SqlParameter[1]
           {
                new SqlParameter("@drinkId", drink.DrinkId),
           };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
