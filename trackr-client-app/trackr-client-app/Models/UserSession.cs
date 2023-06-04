using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trackr_client_app.Models
{
    public static class UserSession
    {
        public static readonly string apiUrl = "https://trackrwebserver.azurewebsites.net/api/";
        public static Customer customer;
        public static Admin admin;
        public static DeliveryMan delivery;
        public static List<Parcel> parcels = new List<Parcel>();
        public static List<DeliveryMan> deliveryMen = new List<DeliveryMan>();
        public static List<Customer> customers = new List<Customer>();
    }
}
