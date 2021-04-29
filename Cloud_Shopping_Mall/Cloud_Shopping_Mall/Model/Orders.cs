using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud_Shopping_Mall.Model
{
   public  class Orders
    {
        SqlConnection conn;
        public Orders() { }
        public Orders(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddOrder(Order order)
        {
            conn.Open();
            string query = String.Format("INSERT INTO CustomerOrder VALUES('{0}','{1}','{2}')", order.ProductId, order.Quantity,order.CustomerUser);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;
        }
        public ArrayList GetAllOrder()
        {
            ArrayList orders = new ArrayList();
            conn.Open();
            string query = String.Format("select * FROM CustomerOrder");
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Order order = new Order();

                order.OrderId = reader.GetInt32(reader.GetOrdinal("OrderId"));
                order.ProductId = reader.GetInt32(reader.GetOrdinal("ProductId"));
                order.Quantity = reader.GetInt32(reader.GetOrdinal("Quantity"));
             
                order.CustomerUser = reader.GetString(reader.GetOrdinal("CustomerUser"));
                orders.Add(order);
                ;
            }
            conn.Close();
            return orders;
        }
    }
}
