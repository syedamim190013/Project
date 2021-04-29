using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud_Shopping_Mall.Model
{
    public class Admins
    {
        SqlConnection conn;
        public Admins(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddAdmin(Admin admin)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Admin VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", admin.Name, admin.PresentAddress, admin.MobileNo,admin.Gender ,admin.Email, admin.Password);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;
        }
        public Admin AuthenticateAdmin(string email, string password)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Admin WHERE Email='{0}' AND Password='{1}'", email, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Admin admin = null;
            while (reader.Read())
            {
                admin = new Admin();
                admin.Name = reader.GetString(reader.GetOrdinal("Name"));
                admin.PresentAddress = reader.GetString(reader.GetOrdinal("PresentAddress"));
                admin.MobileNo = reader.GetInt32(reader.GetOrdinal("MobileNo"));
                admin.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                admin.Email = reader.GetString(reader.GetOrdinal("Email"));
                admin.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return admin;
        }
        public ArrayList GetAllAdmin()
        {
            ArrayList admins = new ArrayList();
            conn.Open();
            string query = "Select * FROM Admin";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                Admin admin = new Admin();
                admin.Name = reader.GetString(reader.GetOrdinal("Name"));
                admin.PresentAddress = reader.GetString(reader.GetOrdinal("PresentAddress"));
                admin.MobileNo = reader.GetInt32(reader.GetOrdinal("MobileNo"));
                admin.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                admin.Email = reader.GetString(reader.GetOrdinal("Email"));
                //admin.Password = reader.GetString(reader.GetOrdinal("Password"));
                admins.Add(admin);

            }
            conn.Close();
            return admins;
        }
        public bool UpdateAdmin(Admin admin)
        {
            conn.Open();
            string query = String.Format("UPDATE Admin SET Name='{0}',PresentAddress='{1}',MobileNo='{2}' WHERE (Email='{3}' AND Password='{4}')", admin.Name, admin.PresentAddress, admin.MobileNo,admin.Email,admin.Password);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        public bool DeleteAdmin(string email,string password)
        {
            conn.Open();
            string query = String.Format("DELETE FROM Admin WHERE Email='{0}' AND Password='{1}'", email,password);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        public Admin GetAdmin(string email)
        {
            conn.Open();
            string query = String.Format("Select * FROM Admin WHERE Email='{0}'", email);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Admin admin = null;
            while (reader.Read())
            {
                admin = new Admin();
                admin.Name = reader.GetString(reader.GetOrdinal("Name"));
                admin.PresentAddress = reader.GetString(reader.GetOrdinal("PresentAddress"));
                admin.MobileNo = reader.GetInt32(reader.GetOrdinal("MobileNo"));
                admin.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                admin.Email = reader.GetString(reader.GetOrdinal("Email"));
                admin.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return admin;
        }
        public Admin GetAdmin1(string email,string password)
        {
            conn.Open();
            string query = String.Format("Select * FROM Admin WHERE (Email='{0}' AND Password='{1}')", email,password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Admin admin = null;
            while (reader.Read())
            {
                admin = new Admin();
                admin.Name = reader.GetString(reader.GetOrdinal("Name"));
                admin.PresentAddress = reader.GetString(reader.GetOrdinal("PresentAddress"));
                admin.MobileNo = reader.GetInt32(reader.GetOrdinal("MobileNo"));
                admin.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                admin.Email = reader.GetString(reader.GetOrdinal("Email"));
                admin.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return admin;
        }

    }
}
