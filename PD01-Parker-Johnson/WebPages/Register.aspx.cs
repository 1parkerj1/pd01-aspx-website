using PD01_Parker_Johnson.App_Code.BLL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace PD01_Parker_Johnson.WebPages
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Page.MaintainScrollPositionOnPostBack = true;
            }
        }

        protected void regButton_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string name = txtName.Text;
            string pass = txtPass.Text;

            User user = new User();
            bool emailExists = user.emailValidate(email);

            if (!emailExists) 
            {
                if (email != "admin@ulsterfly.com")
                {
                    if (validateEmail(email))
                    {
                        user.newUser(email, name, pass);
                        Response.Redirect("~/WebPages/Login.aspx");
                        lblFail.Text = "test";
                        
                    }
                    else
                    {
                        lblFail.Text = "Invalid Email.";
                    }
                }
            } 
            else
            {
                lblFail.Text = "Email already taken.";
            }
        }

        static bool validateEmail(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            } 
            catch (FormatException)
            {
                return false;
            }
        }
    }
}