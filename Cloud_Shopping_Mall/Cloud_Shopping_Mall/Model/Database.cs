using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Cloud_Shopping_Mall.View;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud_Shopping_Mall.Model
{
   public  class Database
    {
        public Admins Admins { get; set; }
        public Employees Employees { get; set; }
        public Customers Customers { get; set; }
        public Shops Shops { get; set; }
        public Products Products { get; set; }
        public Orders Orders { get; set; }
        public Database()
        {
            string conn = @"Server=DESKTOP-DU2RP3H;Database=CloudShop;Integrated Security=true;";
            SqlConnection connection = new SqlConnection(conn);


            Admins = new Admins(connection);
            Employees = new Employees(connection);
            Customers = new Customers(connection);
            Shops = new Shops(connection);
            Products = new Products(connection);
            Orders = new Orders(connection);

        }
    }
}
