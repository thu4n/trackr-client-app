using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trackr_client_app.Models
{
    public class Customer
    {
        public int CusID { get; set; }
        public string CusName { get; set; }
        public string CusAddress { get; set; }
        public string CusPhone { get; set; }
        public DateTime CusBirth { get; set; }
        public DateTime CusDateRegister { get; set; }
        public string CusAccount { get; set; }
        public string CusPassword { get; set; }
        public string CusImage { get; set; }
    }
}
