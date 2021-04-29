using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud_Shopping_Mall.Model
{
    public class Products
    {
        SqlConnection conn;
        public Products(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddProduct(Product product)
        {
            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            string query = String.Format("INSERT INTO Product VALUES('{0}','{1}','{2}','{3}','{4}')", product.Id, product.Name, product.Quantity,product.Price,product.ShopId);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;
        }
        public bool DeleteProduct(int id)
        {
            conn.Open();
            string query = String.Format("Delete FROM Product WHERE Id='{0}'", id);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        public bool UpdateProduct(Product product)
        {
            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            string query = String.Format("UPDATE Product SET Quantity='{0}',Price='{1}' WHERE Id='{2}'",product.Quantity, product.Price, product.Id);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        public ArrayList GetAllProduct(int id)
        {
            ArrayList products = new ArrayList();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            string query = String.Format("Select * FROM Product WHERE ShopId='{0}'",id);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product();
                product.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                product.Name = reader.GetString(reader.GetOrdinal("Name"));
                product.Quantity = reader.GetInt32(reader.GetOrdinal("Quantity"));
                product.Price= reader.GetInt32(reader.GetOrdinal("Price"));
                product.ShopId= reader.GetInt32(reader.GetOrdinal("ShopId"));
                products.Add(product);
            }

            conn.Close();
            return products;
        }
        public ArrayList GetAllProduct1()
        {
            ArrayList products = new ArrayList();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            string query = String.Format("Select * FROM Product");
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product();
                product.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                product.Name = reader.GetString(reader.GetOrdinal("Name"));
                product.Quantity = reader.GetInt32(reader.GetOrdinal("Quantity"));
                product.Price = reader.GetInt32(reader.GetOrdinal("Price"));
                product.ShopId = reader.GetInt32(reader.GetOrdinal("ShopId"));
                products.Add(product);
            }

            conn.Close();
            return products;
        }
        public Product GetProduct(int id)
        {

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            string query = String.Format("SELECT * FROM Product WHERE Id={0}", id);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Product product = null;
            while (reader.Read())
            {
                product = new Product();
                product.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                product.Name = reader.GetString(reader.GetOrdinal("Name"));
                product.Quantity = reader.GetInt32(reader.GetOrdinal("Quantity"));
                product.Price= reader.GetInt32(reader.GetOrdinal("Price"));
            }
            conn.Close();
            return product;
        }
        public bool UpdateProduct1(Product product)
        {
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            string query = String.Format("UPDATE Product SET Quantity='{0}' WHERE Id='{1}'", product.Quantity,product.Id);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
    }
}
