using MvpWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvpWebApp.Helper;

namespace MvpWebApp.Views
{
    public interface IShipperOperations : IView
    {
        IEnumerable<Shipper> Shippers { get; set; }
        event EventHandler LoadShippers;
        event EventHandler<AddShipperEventArgs> AddShipper;
        event EventHandler<GetShipperEventArgs> GetShipper;
        event EventHandler<ModifyShipperEventArgs> ModifyShipper;
        event EventHandler<ShipperNavigationEventArgs> NavigateToOrders;
    }
}
