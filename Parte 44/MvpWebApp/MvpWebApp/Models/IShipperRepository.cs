using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvpWebApp.Models
{
    public interface IShipperRepository
    {
        List<Shipper> Shippers { get; }

        bool IsSuccessful { get; set; }

        void AddNewShipper(Shipper shipper);

        void ModifyShipper(Shipper shipper);

        IEnumerable<Order> GetShipperOrders(int ShipperId);

        Shipper GetShipper(int ShipperId);
    }
}
