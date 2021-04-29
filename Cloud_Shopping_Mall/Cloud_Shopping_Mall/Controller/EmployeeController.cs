using Cloud_Shopping_Mall.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud_Shopping_Mall.Controller
{
    public class EmployeeController
    {
        static Database db = new Database();
        public static Employee AuthenticEmployee(string UserName,string Email ,string Password)
        {
            return db.Employees.AuthenticEmployee(UserName,Email ,Password);
        }
        public static bool AddEmployee(dynamic employee)
        {
            Employee e = new Employee();
            e.Name = employee.Name;
            e.MobileNo = employee.MobileNo;
            e.Gender = employee.Gender;
            e.Division = employee.Division;
            e.ZipCode = employee.ZipCode;
            e.PresentAddress = employee.PresentAddress;
            e.PermanentAddress = employee.PermanentAddress;
            e.Nid = employee.Nid;
            e.BirthCertificate = employee.BirthCertificate;
            e.Email = employee.Email;
            e.UserName = employee.UserName;
            e.Password = employee.Password;
            return db.Employees.AddEmployee(e);
        }
        public static Employee GetEmployee(string userName,string password)
        {
            return db.Employees.GetEmployee(userName,password);
        }
        public static Employee ForgetEmployee(string userName)
        {
            return db.Employees.ForgetEmployee(userName);
        }
        public static bool UpdateEmployee(dynamic employee)
        {
            Employee e = new Employee();
            e.Name = employee.Name;
            e.MobileNo = employee.MobileNo;
            e.Division = employee.Division;
            e.ZipCode = employee.ZipCode;
            e.PresentAddress = employee.PresentAddress;
            e.PermanentAddress = employee.PermanentAddress;
            e.Email = employee.Email;
            e.UserName = employee.UserName;
            e.Password = employee.Password;
            return db.Employees.UpdateEmployee(e);
        }
        public static bool DeleteEmployee(string userName)
        {
            return db.Employees.DeleteEmployee(userName);
        }
        public static ArrayList getAllEmployee(string user)
        {
            return db.Employees.GetAllEmployee(user);
        }
    }
}
