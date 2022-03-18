using System;
using System.Collections.Generic;
using System.Data;
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
        public SqlDbType DateOfPurchase { get; set; }

        public Order(int studentOrderId, int drinkOrderId)
        {
            StudentOrderId = studentOrderId;
            DrinkOrderId = drinkOrderId;
        }

        public Order()
        {
        }
    }
}
