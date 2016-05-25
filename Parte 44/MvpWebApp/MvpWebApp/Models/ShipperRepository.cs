using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvpWebApp.Models
{
    public class ShipperRepository:IShipperRepository// mock?
    {
        private NW ctx;

        private ShipperRepository()
        {
            ctx = new NW();
        }

        public List<Shipper> Shippers
        {
            get {
                return ctx.Shippers.ToList();
            }
        }

        public bool IsSuccessful
        {
            get; set;
        }

        public void AddNewShipper(Shipper shipper)
        {
            try
            {
                ctx.Shippers.Add(shipper);
                ctx.SaveChanges();
                IsSuccessful = true;
            }
            catch
            {
                IsSuccessful = false;
            }           
        }

        public void ModifyShipper(Shipper shipper)
        {
            try
            {
                Shipper originalShipper = ctx.Shippers
                    .Where(s => s.ShipperID == shipper.ShipperID)
                    .Select(s => s).FirstOrDefault();
                ctx.Entry(shipper).State = System.Data.EntityState.Modified;
                ctx.SaveChanges();
                IsSuccessful = true;
            }
            catch (Exception)
            {
                IsSuccessful = false;
            }
        }

        public IEnumerable<Order> GetShipperOrders(int ShipperId)
        {
            return ctx.Shippers
                .Where(s => s.ShipperID == ShipperId).Select(s => s.Orders)
                .FirstOrDefault();
        }

        public Shipper GetShipper(int ShipperId)
        {
            return ctx.Shippers
                .Where(s => s.ShipperID == ShipperId)
                .Select(s => s)
                .FirstOrDefault();
        }
    }
}