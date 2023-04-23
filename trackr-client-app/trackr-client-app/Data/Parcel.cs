using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trackr_client_app.Data
{
    public class Parcel
    {
        public long parcelId { get; set; }
        public string parcelName { get; set;}
        public DateTime orderDate { get; set; }
        public string parcelStatus { get; set;}
        public DateTime estimateDate { get; set; }
        public long cusId { get; set; }
        public string cusName { get; set;}
        public string cusPhone { get; set;}
        public string cusAddress { get; set;}
    }
}
