using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trackr_client_app.Models
{
    public static class UserSession
    {
        // https://testtestserver20230526163638.azurewebsites.net/api/
        // https://trackrwebserver.azurewebsites.net/api/
        public static readonly string apiUrl = "https://testtestserver20230526163638.azurewebsites.net/api/";
        public static Customer customer;
        public static Admin admin;
        public static DeliveryMan delivery;
        public static List<Parcel> parcels;
    }
}
