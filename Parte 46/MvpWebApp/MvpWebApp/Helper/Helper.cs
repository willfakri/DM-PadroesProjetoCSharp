using MvpWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvpWebApp.Helper
{

    public class AddShipperEventArgs : EventArgs
    {
        private Shipper newShipper;

        public Shipper NewShipper
        {
            get { return this.newShipper; }
            set { this.newShipper = value; }
        }

        public AddShipperEventArgs(Shipper shipper)
        {
            this.newShipper = shipper;
        }
    }

    public class ModifyShipperEventArgs : EventArgs
    {
        private Shipper modifiedShipper;

        public Shipper ModifiedShipper
        {
            get { return this.modifiedShipper; }
            set { this.modifiedShipper = value; }
        }

        public ModifyShipperEventArgs(Shipper shipper)
        {
            this.modifiedShipper = shipper;
        }
    }

    public class ShipperNavigationEventArgs : EventArgs
    {
        private int shipperId;

        public int ShipperId
        {
            get { return this.shipperId; }
            set { this.shipperId = value; }
        }

        public ShipperNavigationEventArgs(int shipperId)
        {
            this.shipperId = shipperId;
        }
    }

    public class GetShipperEventArgs : EventArgs
    {
        private int shipperId;

        public int ShipperId
        {
            get { return this.shipperId; }
            set { this.shipperId = value; }
        }

        public Shipper ShipperDetails { get; set; }

        public GetShipperEventArgs(int shipperId)
        {
            this.shipperId = shipperId;
        }
    }
}