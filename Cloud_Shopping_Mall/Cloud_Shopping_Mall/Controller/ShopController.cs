using Cloud_Shopping_Mall.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud_Shopping_Mall.Controller
{
    public class ShopController
    {
        static Database db = new Database();
        public static bool AddShop(dynamic shop)
        {
            Shop r = new Shop();
            r.Id = shop.Id;
            r.Name = shop.Name;
            r.Location = shop.Location;
            return db.Shops.AddShop(r);
        }
        public static Shop GetShop(int id)
        {
            return db.Shops.GetShop(id);
        }
        public static bool UpdateShop(dynamic shop)
        {
            Shop s = new Shop();
            s.Id = shop.Id;
            s.Name = shop.Name;
            s.Location = shop.Location;
            return db.Shops.UpdateShop(s);
        }
        public static bool DeleteShop(int id)
        {
            return db.Shops.DeleteShop(id);
        }
        public static ArrayList GetAllShop()
        {
            return db.Shops.GetAllShop();
        } 

    }
}
