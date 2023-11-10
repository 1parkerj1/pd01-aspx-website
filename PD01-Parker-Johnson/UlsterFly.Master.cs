using System;
using System.Web.Security;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PD01_Parker_Johnson
{
    public partial class UlsterFly : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.MaintainScrollPositionOnPostBack = true;

            if (!IsPostBack)
            {
                adminElement.Visible = HttpContext.Current.User.Identity.Name.Equals("admin");

                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    Login.Text = "Logout";
                    Login.Click += Logout_Click;
                }
                else
                {
                    Login.Text = "Login";
                    Login.Click += Login_Click;
                }
            }
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                FormsAuthentication.SignOut();
                Response.Redirect("~/WebPages/Index.aspx");
            } 
            else
            {
                Response.Redirect("~/WebPages/Login.aspx");
            }
        }
        protected void Logout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("~/WebPages/Index.aspx");
        }
    }
}