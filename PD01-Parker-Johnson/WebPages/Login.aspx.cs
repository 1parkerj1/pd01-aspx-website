using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PD01_Parker_Johnson.App_Code.BLL;

namespace PD01_Parker_Johnson.WebPages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack) 
            { 

                if (Request.Cookies["rememberMe"] != null)
                {
                    string cookieEmail = Request.Cookies["rememberMe"]["UserEmail"];
                    string cookiePass = Request.Cookies["rememberMe"]["UserPass"];

                    txtUserEmail.Text = cookieEmail;
                    txtPassword.Text = cookiePass;
                }

            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string email = txtUserEmail.Text;
            string pass = txtPassword.Text;

            User user = new User();
            User auth = user.loginUser(email, pass);

            if (auth != null)
            {
                if(RememberMe.Checked)
                {
                    HttpCookie rememberMe = new HttpCookie("rememberMe");

                    rememberMe["UserEmail"] = email;
                    rememberMe["UserPass"] = pass;

                    rememberMe.Expires = DateTime.Now.AddMonths(1);
                    Response.Cookies.Add(rememberMe);
                }
                else
                {
                }

                Response.Redirect("~/WebPages/Index.aspx");
            }
            else
            {

            }
        }
    }
}