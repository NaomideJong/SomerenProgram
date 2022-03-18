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

        /*public OrderService()
        {
            orderdb = new OrderDao();
        }*/

        public List<Order> GetAllOrders()
        {
            // return the list of orders
            return orderDao.GetAllOrders();
        }

        public void AddOrders(Order order)
        {
            orderDao.AddOrder(order);
        }
    }
}
