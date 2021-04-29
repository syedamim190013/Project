using Cloud_Shopping_Mall.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud_Shopping_Mall.Controller
{
    public class AdminController
    {
        static Database db = new Database();
        public static Admin AuthenticateAdmin(string email, string password)
        {
            return db.Admins.AuthenticateAdmin(email, password);
        }
        public static bool AddAdmin(dynamic admin)
        {
            Admin a = new Admin();
            a.Name = admin.Name;
            a.PresentAddress = admin.PresentAddress;
            a.MobileNo = admin.MobileNo;
            a.Gender = admin.Gender;
            a.Email = admin.Email;
            a.Password = admin.Password;
            return db.Admins.AddAdmin(a);
        }
        public static ArrayList GetAllAdmin()
        {
            return db.Admins.GetAllAdmin();
        }
        public static bool UpdateAdmin(dynamic admin)
        {
            Admin a = new Admin();
            a.Name = admin.Name;
            a.PresentAddress = admin.PresentAddress;
            a.MobileNo = admin.MobileNo;
           // a.Gender = admin.Gender;
            a.Email = admin.Email;
            a.Password = admin.Password;
            return db.Admins.UpdateAdmin(a);
        }
        public static bool DeleteAdmin(string email,string password)
        {
            return db.Admins.DeleteAdmin(email,password);
        }
        public static Admin GetAdmin(string userName)
        {
            return db.Admins.GetAdmin(userName);
        }
        public static Admin GetAdmin1(string userName,string password)
        {
            return db.Admins.GetAdmin1(userName,password);
        }
    }
}
