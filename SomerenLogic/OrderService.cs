using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class OrderService
    {
        OrderDao orderDao = new OrderDao();

        // get the AddOrder from the DAL layer
        public void AddOrders(Order order)
        {
            // give the AddOrder the current value of the order
            // e.g. StudentName: Bob, DrinkName: Fanta
            orderDao.AddOrder(order);
        }
    }
}
