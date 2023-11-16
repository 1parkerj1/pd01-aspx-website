using PD01_Parker_Johnson.App_Code.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace PD01_Parker_Johnson.WebPages
{
    public partial class Licenses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                for (int i = 1; i <= 31; i++)
                {
                    ddlDay.Items.Add(new ListItem(i.ToString(), i.ToString()));
                }

                string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                for (int i = 0; i < months.Length; i++)
                {
                    ddlMonth.Items.Add(new ListItem(months[i], (i + 1).ToString()));
                }


                int currentYear = DateTime.Now.Year;
                for (int i = currentYear; i >= currentYear - 100; i--)
                {
                    ddlYear.Items.Add(new ListItem(i.ToString(), i.ToString()));
                }
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            
            
        }


        protected void btnLicence_Click(object sender, EventArgs e)
        {
            int day = int.Parse(ddlDay.SelectedValue);
            int month = int.Parse(ddlMonth.SelectedValue);
            int year = int.Parse(ddlYear.SelectedValue);
            DateTime today = DateTime.Today;
            DateTime nextYear = today.AddYears(1);

            DateTime expiry = nextYear;
            DateTime DOB = new DateTime(year, month, day);
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            string licence = lblLicenceType.Text;
            

            

            User user = new User();
            bool emailExists = user.emailValidate(email);

            if (!emailExists)
            {
                lblFail.Text = "Email doesn't exist. Create an account.";
            }
            else
            {
                if (validateEmail(email))
                {
                    user.addLicenceInfo(email, DOB, address, licence, expiry);

                    Response.Redirect("~/WebPages/LicenceView.aspx ?firstname=" + txtFname.Text + "&lastname=" + txtSname.Text + "$expirydate=" + nextYear + "?address=" + txtAddress.Text + "&licence=" + licence);
                }
                else
                {
                    lblFail.Text = "Invalid Email.";
                }
            }
        }

        protected void ddlUpdate_Click(object sender, EventArgs e)
        {
            int day = int.Parse(ddlDay.SelectedValue);
            int month = int.Parse(ddlMonth.SelectedValue);
            int year = int.Parse(ddlYear.SelectedValue);
            DateTime DOB = new DateTime(year, month, day);

            //DateTime DOB = Calendar1.SelectedValue;
            DateTime Today = DateTime.UtcNow.Date;

            int age = Today.Year - DOB.Year;
            string licence = null;
            double price = 0;

            if (age < 18)
            {
                licence = "Child";
                price = 10.00;
                lblLicencePrice.Text = "£" + price.ToString();
                lblLicenceType.Text = licence.ToString();

            }
            else if (age >= 18 && age < 60)
            {
                licence = "Standard";
                price = 50.00;
                lblLicencePrice.Text = "£" + price.ToString();
                lblLicenceType.Text = licence.ToString();
            }
            else if (age >= 60)
            {
                licence = "Senior";
                price = 15.00;
                lblLicencePrice.Text = "£" + price.ToString();
                lblLicenceType.Text = licence.ToString();
            }
            else
            {
                lblFail.Text = "Incorrect age.";
            }

            if (txtDisabled.Checked)
            {
                licence = "Disabled";
                price = 10.00;
                lblLicencePrice.Text = "£" + price.ToString();
                lblLicenceType.Text = licence.ToString();
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