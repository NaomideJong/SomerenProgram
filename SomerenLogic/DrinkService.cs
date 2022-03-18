using System;
using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class DrinkService
    {
        DrinkDao drinkdb;

        public DrinkService()
        {
            drinkdb = new DrinkDao();
        }

        public List<Drink> GetDrinks()
        {
            // return the list of drinks
            List<Drink> drinks = drinkdb.GetAllDrinks();
            return drinks;
        }
      //  public Drink GetById(int drinkId)
       // {
            // get one drink by id number
        //    return drinkdb.GetById(drinkId);

       // }
        public void AddDrink(Drink drink)
        {
            drinkdb.AddDrink(drink);
        }
        public void UpdateDrink(Drink drink)
        {
            drinkdb.UpdateDrink(drink);
        }
        public void DeleteDrink(Drink drink)
        {
            drinkdb.DeleteDrink(drink);
        }

    }
}
