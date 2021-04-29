using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud_Shopping_Mall.Model
{
    public class Employees
    {
        SqlConnection conn;
        public Employees() { }
        public Employees(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddEmployee(Employee employee)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Employee VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", employee.Name,employee.MobileNo,employee.Gender,employee.Division,employee.ZipCode,employee.PresentAddress,employee.PermanentAddress,employee.Nid,employee.BirthCertificate,employee.Email,employee.UserName,employee.Password);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;
        }
        public Employee AuthenticEmployee(string userName,string email ,string password)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Employee WHERE (UserName='{0}'OR Email='{1}') AND Password='{2}'", userName,email ,password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Employee employee = null;
            while (reader.Read())
            {
                employee = new Employee();
                employee.Name = reader.GetString(reader.GetOrdinal("Name"));
                employee.MobileNo = reader.GetInt32(reader.GetOrdinal("MobileNo"));
                employee.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                employee.Division = reader.GetString(reader.GetOrdinal("Division"));
                employee.ZipCode = reader.GetInt32(reader.GetOrdinal("ZipCode"));
                employee.PresentAddress = reader.GetString(reader.GetOrdinal("PresentAddress"));
                employee.PermanentAddress = reader.GetString(reader.GetOrdinal("PermanentAddress"));
                employee.Nid = reader.GetInt32(reader.GetOrdinal("Nid"));
                employee.BirthCertificate = reader.GetInt32(reader.GetOrdinal("BirthCertificate"));
                employee.Email = reader.GetString(reader.GetOrdinal("Email"));
                employee.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                employee.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return employee;
        }
        public ArrayList GetAllEmployee(string user)
        {
            ArrayList employees = new ArrayList();
            conn.Open();
            string query = String.Format("SELECT * FROM Employee WHERE UserName='{0}'", user);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.Name = reader.GetString(reader.GetOrdinal("Name"));
                employee.MobileNo = reader.GetInt32(reader.GetOrdinal("MobileNo"));
                employee.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                employee.Division = reader.GetString(reader.GetOrdinal("Division"));
                employee.ZipCode = reader.GetInt32(reader.GetOrdinal("ZipCode"));
                employee.PresentAddress = reader.GetString(reader.GetOrdinal("PresentAddress"));
                employee.PermanentAddress = reader.GetString(reader.GetOrdinal("PermanentAddress"));
                //employee.Nid = reader.GetInt32(reader.GetOrdinal("Nid"));
               // employee.BirthCertificate = reader.GetInt32(reader.GetOrdinal("BirthCertificate"));
                employee.Email = reader.GetString(reader.GetOrdinal("Email"));
                //employee.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                //employee.Password = reader.GetString(reader.GetOrdinal("Password"));
                employees.Add(employee);
            }
            conn.Close();
            return employees;
        }
        public Employee GetEmployee(string userName,string password)
        {
            conn.Open();
            string query = String.Format("Select * FROM Employee WHERE UserName='{0}' AND Password='{1}'", userName,password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Employee employee = null;
            while (reader.Read())
            {
                employee = new Employee();
                employee.Name = reader.GetString(reader.GetOrdinal("Name"));
                employee.MobileNo = reader.GetInt32(reader.GetOrdinal("MobileNo"));
                employee.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                employee.Division = reader.GetString(reader.GetOrdinal("Division"));
                employee.ZipCode = reader.GetInt32(reader.GetOrdinal("ZipCode"));
                employee.PresentAddress = reader.GetString(reader.GetOrdinal("PresentAddress"));
                employee.PermanentAddress = reader.GetString(reader.GetOrdinal("PermanentAddress"));
                employee.Nid = reader.GetInt32(reader.GetOrdinal("Nid"));
                employee.BirthCertificate = reader.GetInt32(reader.GetOrdinal("BirthCertificate"));
                employee.Email = reader.GetString(reader.GetOrdinal("Email"));
                employee.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                employee.Password = reader.GetString(reader.GetOrdinal("Password"));

            }
            conn.Close();
            return employee;
        }
        public bool UpdateEmployee(Employee employee)
        {
            conn.Open();
            string query = String.Format("UPDATE Employee SET Name='{0}',MobileNo='{1}',Division='{2}',ZipCode='{3}',PresentAddress='{4}',PermanentAddress='{5}',Email='{6}',Password='{7}' WHERE (UserName='{8}' AND Password='{9}')", employee.Name, employee.MobileNo,employee.Division,employee.ZipCode,employee.PresentAddress,employee.PermanentAddress,employee.Email,employee.Password ,employee.UserName,employee.Password);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        public bool DeleteEmployee(string userName)
        {
            conn.Open();
            string query = String.Format("DELETE FROM Employee WHERE UserName='{0}'", userName);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        public Employee ForgetEmployee(string userName)
        {
            conn.Open();
            string query = String.Format("Select * FROM Employee WHERE UserName='{0}' ", userName);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Employee employee = null;
            while (reader.Read())
            {
                employee = new Employee();
                employee.Name = reader.GetString(reader.GetOrdinal("Name"));
                employee.MobileNo = reader.GetInt32(reader.GetOrdinal("MobileNo"));
                employee.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                employee.Division = reader.GetString(reader.GetOrdinal("Division"));
                employee.ZipCode = reader.GetInt32(reader.GetOrdinal("ZipCode"));
                employee.PresentAddress = reader.GetString(reader.GetOrdinal("PresentAddress"));
                employee.PermanentAddress = reader.GetString(reader.GetOrdinal("PermanentAddress"));
                employee.Nid = reader.GetInt32(reader.GetOrdinal("Nid"));
                employee.BirthCertificate = reader.GetInt32(reader.GetOrdinal("BirthCertificate"));
                employee.Email = reader.GetString(reader.GetOrdinal("Email"));
                employee.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                employee.Password = reader.GetString(reader.GetOrdinal("Password"));

            }
            conn.Close();
            return employee;
        }


    }
}
