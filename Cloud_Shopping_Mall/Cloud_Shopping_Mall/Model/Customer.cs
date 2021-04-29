using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud_Shopping_Mall.Model
{
    public class Customer
    {
        public string Name { get; set; }
        public int MobileNo { get; set; }
        public string Gender { get; set; }
        public string Division { get; set; }
        public int ZipCode { get; set; }
        public string PresentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public int Balance { get; set; }
        public int Nid { get; set; }
        public int BirthCertificate { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
