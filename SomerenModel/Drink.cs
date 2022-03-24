using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drink
    {
        public int DrinkId { get; set; } // DrinkId, e.g. 2
        public string DrinkName { get; set; } // Drinkname, e.g. Fanta, Cola
        public decimal DrinkPrice { get; set; } // DrinkPrice, e.g. Math, 3.99, 5.00
        public int DrinkStock { get; set; } // DrinkStock, e.g. 20, 60
        public int DrinkVAT { get; set; } // DrinkVAT, e.g. 21%
        public decimal DrinkValue { get; set; } //money earned from the drink probably?
        public int DrinksSold { get; set; } //amount of drinks sold
        public bool StockAmount 
        {
            get
            {
                bool stock = true; 
                if (this.DrinkStock < 10) stock = false;
                return stock;
            }
        }
    }
}
