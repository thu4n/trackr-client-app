using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trackr_client_app.Models
{
    public class Parcel
    {
        public Parcel() 
        { 
            ParID = 0;
            ParDescription = "";
            ParStatus = "";
            ParDeliveryDate = DateTime.Now;
            ParLocation = "";
            Realtime = DateTime.Now;
            Note = "";
            Price = 0;
            CusID = 0;
            ManID = 0;
        }
        public int ParID { get; set; }
        public string ParDescription { get; set; }
        public string ParStatus { get; set; }
        public DateTime ParDeliveryDate { get; set; }
        public string ParLocation { get; set; }
        public DateTime Realtime { get; set; }
        public string Note { get; set; }
        public int Price { get; set; }
        public int CusID { get; set; }
        public int ManID { get; set; }
    }
}
