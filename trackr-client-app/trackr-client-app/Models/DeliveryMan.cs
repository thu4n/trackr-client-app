using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trackr_client_app.Models
{
    public class DeliveryMan
    {
        public DeliveryMan() 
        {
            ManName = string.Empty;
            ManPhone = string.Empty;
        }
        public int ManID { get; set; }
        public string ManName { get; set; }
        public string ManPhone { get; set; }
        public string ManAccount { get; set; }
        public string ManPassword { get; set; }
        public string ManImage { get; set; }
    }
}
