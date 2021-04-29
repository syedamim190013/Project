using Cloud_Shopping_Mall.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud_Shopping_Mall.Controller
{
   public class OrderController
    {
        static Database db = new Database();
        public static bool AddOrder(dynamic order)
        {
            Order o = new Order();
            o.ProductId = order.ProductId;
            o.Quantity = order.Quantity;
            o.CustomerUser = order.CustomerUser;
            return db.Orders.AddOrder(o);
        }
        public static ArrayList GetAllOrder()
        {
            return db.Orders.GetAllOrder();
        }
    }
}
