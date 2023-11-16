using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PD01_Parker_Johnson.WebPages
{
    public partial class LicenceView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                string firstname = Request.QueryString["firstname"];
                string lastname = Request.QueryString["lastname"];
                string expirydate = Request.QueryString["expirydate"];
                string address = Request.QueryString["address"];
                string licence = Request.QueryString["licence"];

                lblAddress.Text = address;
                lblExpiry.Text = expirydate;
                lblName.Text = firstname + " " + lastname;
                lblLicence.Text = licence;
            }

        }
    }
}