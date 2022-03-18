using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Order
    {
        public int OrderId { get; set; } // OrderId, e.g. 2
        public int StudentOrderId { get; set; } // StudentOrderId, e.g. 5, 7
        public int DrinkOrderId { get; set; } // DrinkOrderId, e.g. 1, 6
        public DateTime DateOfPurchase { get; set; } // Date when a drink is purchased

        public Order(int studentOrderId, int drinkOrderId, DateTime dateOfPurchase)
        {
            StudentOrderId = studentOrderId;
            DrinkOrderId = drinkOrderId;
            DateOfPurchase = dateOfPurchase;
        }
    }
}
