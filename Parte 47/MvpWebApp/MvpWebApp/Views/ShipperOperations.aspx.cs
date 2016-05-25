using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MvpWebApp.Presenter;
using MvpWebApp.Models;
using MvpWebApp.Helper;

namespace MvpWebApp.Views
{
    public partial class ShipperOperations : System.Web.UI.Page, IShipperOperations
    {
        ShipperOperationsPresenter presenter;

        public IEnumerable<Shipper> Shippers { get; set; }

        public event EventHandler LoadShippers;
        public event EventHandler<AddShipperEventArgs> AddShipper;
        public event EventHandler<GetShipperEventArgs> GetShipper;
        public event EventHandler<ModifyShipperEventArgs> ModifyShipper;
        public event EventHandler<ShipperNavigationEventArgs> NavigateToOrders;

        public ShipperOperations()
        {
            IShipperRepository repository = new ShipperRepository();
            INavigator navigator = new Navigator();
            presenter = new ShipperOperationsPresenter(repository, navigator);
            presenter.View = this;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindShippers();
        }

        private void BindShippers()
        {
            LoadShippers(this, new EventArgs());
            gvShippers.DataSource = this.Shippers;
            gvShippers.DataBind();
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            Shipper newShipper = new Shipper()
            {
                CompanyName = txtCompanyName.Text,
                Phone = txtPhoneNumber.Text
            };

            AddShipper(this, new AddShipperEventArgs(newShipper));
        }
    }
}