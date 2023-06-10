using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trackr_client_app.Models
{
    public class Review
    {
        public int reID { get; set; }
        public int parId { get; set; }
        public string reDescription { get; set; }
        public int star { get; set; }
    }
}
