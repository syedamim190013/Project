using Cloud_Shopping_Mall.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud_Shopping_Mall.Controller
{
    public class ProductController
    {
        static Database db = new Database();
        public static bool AddProduct(dynamic product)
        {
            Product p = new Product();
            p.Id = product.Id;
            p.Name = product.Name;
            p.Quantity = product.Quantity;
            p.Price = product.Price;
            p.ShopId = product.ShopId;
            return db.Products.AddProduct(p);
        }
        public static Product GetProduct(int id)
        {
            return db.Products.GetProduct(id);
        }
        public static bool UpdateProduct(dynamic product)
        {
            Product p = new Product();
            p.Id = product.Id;
            // p.Name = product.Name;
            p.Price = product.Price;
            p.Quantity = product.Quantity;
            return db.Products.UpdateProduct(p);
        }
        public static bool UpdateProduct1(dynamic product)
        {
            Product p = new Product();
            p.Id = product.Id;
            // p.Name = product.Name;
           // p.Price = product.Price;
            p.Quantity = product.Quantity;
            return db.Products.UpdateProduct1(p);
        }
        public static bool DeleteProduct(int id)
        {
            return db.Products.DeleteProduct(id);
        }
        public static ArrayList GetAllProduct(int id)
        { 
            return db.Products.GetAllProduct(id);
        }
        public static ArrayList GetAllProduct1()
        {
            return db.Products.GetAllProduct1();
        }
    }
}
