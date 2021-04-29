using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud_Shopping_Mall.Model
{
    public class Customers
    {
        SqlConnection conn;
        public Customers() { }
        public Customers(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddCustomer(Customer customer)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Customer VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')", customer.Name, customer.MobileNo, customer.Gender, customer.Division, customer.ZipCode, customer.PresentAddress, customer.PermanentAddress, customer.Balance,customer.Nid, customer.BirthCertificate, customer.Email, customer.UserName, customer.Password);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;
        }

        public Customer AuthenticCustomer(string userName, string email, string password)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Customer WHERE (UserName='{0}'OR Email='{1}') AND Password='{2}'", userName, email, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Customer customer = null;
            while (reader.Read())
            {
                customer = new Customer();
                customer.Name = reader.GetString(reader.GetOrdinal("Name"));
                customer.MobileNo = reader.GetInt32(reader.GetOrdinal("MobileNo"));
                customer.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                customer.Division = reader.GetString(reader.GetOrdinal("Division"));
                customer.ZipCode = reader.GetInt32(reader.GetOrdinal("ZipCode"));
                customer.PresentAddress = reader.GetString(reader.GetOrdinal("PresentAddress"));
                customer.PermanentAddress = reader.GetString(reader.GetOrdinal("PermanentAddress"));
                customer.Balance = reader.GetInt32(reader.GetOrdinal("Balance"));
                customer.Nid = reader.GetInt32(reader.GetOrdinal("Nid"));
                customer.BirthCertificate = reader.GetInt32(reader.GetOrdinal("BirthCertificate"));
                customer.Email = reader.GetString(reader.GetOrdinal("Email"));
                customer.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                customer.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return customer;
        }

        public Customer GetCustomer(string userName,string password)
        {
            conn.Open();
            string query = String.Format("Select * FROM Customer WHERE UserName='{0}' AND Password='{1}'", userName,password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Customer customer = null;
            while (reader.Read())
            {
                customer = new Customer();
                customer.Name = reader.GetString(reader.GetOrdinal("Name"));
                customer.MobileNo = reader.GetInt32(reader.GetOrdinal("MobileNo"));
                customer.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                customer.Division = reader.GetString(reader.GetOrdinal("Division"));
                customer.ZipCode = reader.GetInt32(reader.GetOrdinal("ZipCode"));
                customer.PresentAddress = reader.GetString(reader.GetOrdinal("PresentAddress"));
                customer.PermanentAddress = reader.GetString(reader.GetOrdinal("PermanentAddress"));
                customer.Balance = reader.GetInt32(reader.GetOrdinal("Balance"));
                customer.Nid = reader.GetInt32(reader.GetOrdinal("Nid"));
                customer.BirthCertificate = reader.GetInt32(reader.GetOrdinal("BirthCertificate"));
                customer.Email = reader.GetString(reader.GetOrdinal("Email"));
                customer.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                customer.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return customer;
        }
        public ArrayList GetAllCustomer()
        {
            ArrayList customers = new ArrayList();
            conn.Open();
            string query = "Select * FROM Customer";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.Name = reader.GetString(reader.GetOrdinal("Name"));
                customer.MobileNo = reader.GetInt32(reader.GetOrdinal("MobileNo"));
                customer.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                customer.Division = reader.GetString(reader.GetOrdinal("Division"));
                customer.ZipCode = reader.GetInt32(reader.GetOrdinal("ZipCode"));
                customer.PresentAddress = reader.GetString(reader.GetOrdinal("PresentAddress"));
                customer.PermanentAddress = reader.GetString(reader.GetOrdinal("PermanentAddress"));
                customer.Balance = reader.GetInt32(reader.GetOrdinal("Balance"));
               // customer.Nid = reader.GetInt32(reader.GetOrdinal("Nid"));
               // customer.BirthCertificate = reader.GetInt32(reader.GetOrdinal("BirthCertificate"));
                customer.Email = reader.GetString(reader.GetOrdinal("Email"));
                customer.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                //customer.Password = reader.GetString(reader.GetOrdinal("Password"));
                customers.Add(customer);
            }
            conn.Close();
            return customers;
        }
        public bool UpdateCustomer(Customer customer)
        {
            conn.Open();
            string query = String.Format("UPDATE Customer SET Name='{0}',MobileNo='{1}',Division='{2}',ZipCode='{3}',PresentAddress='{4}',PermanentAddress='{5}',Email='{6}',Password='{7}' WHERE (UserName='{8}' AND Password='{9}'", customer.Name, customer.MobileNo,customer.Division,customer.ZipCode,customer.PresentAddress,customer.PermanentAddress,customer.Email,customer.Password ,customer.UserName,customer.Password);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        public bool DeleteCustomer(string userName)
        {
            conn.Open();
            string query = String.Format("DELETE FROM Customer WHERE UserName='{0}'", userName);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        public Customer ForgetCustomer(string userName)
        {
            conn.Open();
            string query = String.Format("Select * FROM Customer WHERE UserName='{0}'", userName);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Customer customer = null;
            while (reader.Read())
            {
                customer = new Customer();
                customer.Name = reader.GetString(reader.GetOrdinal("Name"));
                customer.MobileNo = reader.GetInt32(reader.GetOrdinal("MobileNo"));
                customer.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                customer.Division = reader.GetString(reader.GetOrdinal("Division"));
                customer.ZipCode = reader.GetInt32(reader.GetOrdinal("ZipCode"));
                customer.PresentAddress = reader.GetString(reader.GetOrdinal("PresentAddress"));
                customer.PermanentAddress = reader.GetString(reader.GetOrdinal("PermanentAddress"));
                customer.Balance = reader.GetInt32(reader.GetOrdinal("Balance"));
                customer.Nid = reader.GetInt32(reader.GetOrdinal("Nid"));
                customer.BirthCertificate = reader.GetInt32(reader.GetOrdinal("BirthCertificate"));
                customer.Email = reader.GetString(reader.GetOrdinal("Email"));
                customer.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                customer.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return customer;
        }
        public bool UpdateCustomer1(Customer customer)
        {
            conn.Open();
            string query = String.Format("UPDATE Customer SET Balance='{0}' WHERE UserName='{1}'", customer.Balance,customer.UserName);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }


    }
}
