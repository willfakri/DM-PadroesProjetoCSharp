using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvpWebApp.Helper;
using MvpWebApp.Models;
using MvpWebApp.Views;

namespace MvpWebApp.Presenter
{
    public class ShipperOperationsPresenter
    {
        IShipperOperations view;
        IShipperRepository operations;
        INavigator navigator;

        public event EventHandler<ShipperNavigationEventArgs> NavigateToOrders;

        //indica se uma operação foi realizada com sucesso
        public bool IsSuccessful
        {
            get
            {
                return operations.IsSuccessful;
            }
        }

        //armazena View
        public IShipperOperations View
        {
            get
            {
                return this.view;
            }
            set
            {
                this.view = value;
                AttachEventsToView();
            }
        }

        public ShipperOperationsPresenter(IShipperRepository operations, INavigator navigator)
        {
            this.operations = operations;
            this.navigator = navigator;
        }

        private void AttachEventsToView()
        {
            view.LoadShippers += OnLoadShippers;
            view.AddShipper += OnAddShipper;
            view.GetShipper += OnGetShipper;
            view.ModifyShipper += OnModifyingShipper;
            view.NavigateToOrders += OnNavigateToOrders;
        }

        private void OnNavigateToOrders(object sender, ShipperNavigationEventArgs e)
        {
            LoadOrderOfShippers(e.ShipperId);
        }

        private void LoadOrderOfShippers(int shipperId)
        {
            Dictionary<string, string> queryStringValues = new Dictionary<string, string>();
            queryStringValues.Add("ID", shipperId.ToString());
            navigator.NavigateTo("ShipperOrders.aspx", queryStringValues);
        }

        private void OnModifyingShipper(object sender, ModifyShipperEventArgs e)
        {
            operations.ModifyShipper(e.ModifiedShipper);
        }

        private void OnGetShipper(object sender, GetShipperEventArgs e)
        {
            e.ShipperDetails = operations.GetShipper(e.ShipperId);
        }

        private void OnAddShipper(object sender, AddShipperEventArgs e)
        {
            operations.AddNewShipper(e.NewShipper);
        }

        //carregando shippers para exibir na view
        private void OnLoadShippers(object sender, EventArgs e)
        {
            view.Shippers = operations.Shippers;
        }
    }
}