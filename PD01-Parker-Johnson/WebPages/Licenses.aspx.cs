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
                string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                for (int i = 0; i < months.Length; i++)
                {
                    ddlMonth.Items.Add(new ListItem(months[i], (i + 1).ToString()));
                }

                int monthsFix = 31;

                if (ddlMonth.SelectedItem.Equals("February"))
                {
                    monthsFix = 28;
                }

                // code to fill fthe drop downs for the user dob
                for (int i = 1; i <= monthsFix; i++)
                {
                    ddlDay.Items.Add(new ListItem(i.ToString(), i.ToString()));
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
            // variables for day, month, year, today and next year
            int day = int.Parse(ddlDay.SelectedValue);
            int month = int.Parse(ddlMonth.SelectedValue);
            int year = int.Parse(ddlYear.SelectedValue);

            //using todays date and 1 year to make the expiry date 1 year
            DateTime today = DateTime.Now;
            DateTime expiryDate = today.AddYears(1);
            string expiryDateString = expiryDate.ToString("dd/mm/yyyy");

            // date of birth
            DateTime DOB = new DateTime(year, month, day);

            // email, address, licence from the txt boxs
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
                // validate email method to checkif the email has correct format
                if (validateEmail(email))
                {
                    if (user.licenceExits(email))
                    {
                        lblFail.Text = "Licence With this email already exists";
                    }
                    else
                    {
                        // add info to database using dataaccess method
                        user.addLicenceInfo(email, DOB, address, licence, expiryDate);

                        // query string to transfer data to the liucence view page
                        Response.Redirect("~/LicencePage/LicenceView.aspx?firstname=" + txtFname.Text + "&lastname=" + txtSname.Text + "&expirydate=" + Server.UrlEncode(expiryDateString) + "&address=" + txtAddress.Text + "&licence=" + licence.ToString());
                    }

                }
                else
                {
                    lblFail.Text = "Invalid Email.";
                }
            }
        }

        //    if (!emailExists)
        //    {
        //        lblFail.Text = "Email doesn't exist. Create an account.";
        //    }
        //    else
        //    {   // validate email method to checkif the email has correct format
        //        if (validateEmail(email))
        //        {
        //            user.addLicenceInfo(email, DOB, address, licence, expiry);

        //            // query string to transfer data to the liucence view page
        //            Response.Redirect("~/LicencePage/LicenceView.aspx?firstname=" + txtFname.Text + "&lastname=" + txtSname.Text + "&expirydate=" + expiry + "&address=" + txtAddress.Text + "&licence=" + licence.ToString());
        //        }
        //        else
        //        {
        //            lblFail.Text = "Invalid Email.";
        //        }
        //    }
        //}

        protected void ddlUpdate_Click(object sender, EventArgs e)
        {

            // adds the dob to the method and then checks the age
            int day = int.Parse(ddlDay.SelectedValue);
            int month = int.Parse(ddlMonth.SelectedValue);
            int year = int.Parse(ddlYear.SelectedValue);
            DateTime DOB = new DateTime(year, month, day);

            //DateTime DOB = Calendar1.SelectedValue;
            DateTime Today = DateTime.Today;

            int age = Today.Year - DOB.Year;
            string licence = null;
            double price = 0;



            // licence type and price dependant on age using if statements to check 
            // and then fill in the data for price and licence type
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