using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud_Shopping_Mall.Model
{
   public class Shops
    {
        SqlConnection conn;
        public Shops(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddShop(Shop shop)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Shop VALUES('{0}','{1}','{2}')", shop.Id, shop.Name, shop.Location);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;
        }
        public bool DeleteShop(int id)
        {
            conn.Open();
            string query = String.Format("Delete FROM Shop WHERE Id='{0}'", id);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        public bool UpdateShop(Shop shop)
        {
            conn.Open();
            string query = String.Format("UPDATE Shop SET Name='{0}',Location='{1}' WHERE Id='{2}'", shop.Name, shop.Location, shop.Id);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        public Shop GetShop(int id)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Shop WHERE Id={0}", id);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Shop shop = null;
            while (reader.Read())
            {
                shop = new Shop();
                shop.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                shop.Name = reader.GetString(reader.GetOrdinal("Name"));
                shop.Location = reader.GetString(reader.GetOrdinal("Location"));
            }
            conn.Close();
            return shop;
        }
        public ArrayList GetAllShop()
        {
            ArrayList shops = new ArrayList();
            conn.Open();
            string query = "Select * FROM Shop";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Shop shop = new Shop();
                shop.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                shop.Name = reader.GetString(reader.GetOrdinal("Name"));
                shop.Location = reader.GetString(reader.GetOrdinal("Location"));
                shops.Add(shop);
            }

            conn.Close();
            return shops;
        }
    }
}
