using MvpWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvpWebApp.Views
{
    public interface IShipperOrders : IView
    {
        IEnumerable<Order> Orders { get; set; }

        string this[string key] { get; }

        event EventHandler<EventArgs> LoadOrders;


    }
}
