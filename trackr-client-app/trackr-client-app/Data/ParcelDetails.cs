using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trackr_client_app.Data
{
    public class ParcelDetails
    {
        private static readonly string[] Names = new[]
        {
            "Áo Levents", "Áo The North Face", "Quần YaMe", "Túi LV Phake"
        };
        private static readonly string[] Statuses = new[]
        {
            "Đang chuẩn bị", "Đang giao", "Đã giao"
        };
        public Task<Parcel[]> GetParcels(DateTime startDate)
        {
            return Task.FromResult(Enumerable.Range(1, 10).Select(index => new Parcel
            {
                orderDate = startDate,
                parcelId = Random.Shared.Next(10000, 30000),
                parcelName = Names[Random.Shared.Next(Names.Length)],
                parcelStatus = Statuses[Random.Shared.Next(Statuses.Length)],
                estimateDate = startDate.AddDays(Random.Shared.Next(1, 3)),
                cusId = 21522652,
                cusName = "Tống Võ Anh Thuận",
                cusAddress = "Trường Đại học Công nghệ Thông tin",
                cusPhone = "0795998888"
            }).ToArray());
        }
    }
}
