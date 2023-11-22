using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Security;
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
                else
                {
                    FormsAuthentication.SignOut();
                    Response.Redirect("~/WebPages/Login.aspx");
                }

            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string email = txtUserEmail.Text;
            string pass = txtPassword.Text;

            User user = new User();
            bool emailExists = user.emailValidate(email);

            if (!emailExists)
            {
                lblFail.Text = "No account with the email: " + email.ToString();
                lblFail.Visible = true;
            }
            else
            {
                if(validateEmail(email))
                {
                    User auth = user.loginUser(email, pass);


                    if (auth != null)
                    {
                        bool validateUser = user.userValidate(email, pass);
                        if (validateUser)
                        {
                            if (RememberMe.Checked)
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

                            FormsAuthentication.RedirectFromLoginPage(email, true);
                            Response.Redirect("~/WebPages/Index.aspx");
                        }
                    }
                    else
                    {
                        lblFail.Text = "Password incorrect";
                        lblFail.Visible = true;
                    }
                }
                
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