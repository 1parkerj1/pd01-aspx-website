using PD01_Parker_Johnson.App_Code.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace PD01_Parker_Johnson.SecurePages
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Method triggered when a row in the GridView is selected
            // Copies the text from the second cell of the selected row to txtRemove textbox
            txtRemove.Text = GridView1.SelectedRow.Cells[1].Text;
            txtRemove.Text = GridView1.SelectedRow.Cells[1].Text;
        }

        protected void btnRemoveUser_Click(object sender, EventArgs e)
        {
            User user = new User();

            // Checks if txtRemove textbox is not empty
            if (txtRemove.Text != " ")
            {
                int userID = Convert.ToInt32(txtRemove.Text);
                user.setUserID(userID);

                if (userID != 17)
                {
                    // Calls the removeUser method from the User class
                    user.removeUser();
                }
                else
                {
                    lblFail.Text = "cannot remove admin account";
                }
            } else
            {
                lblFail.Text = "No Id selected.";
            }

        }
    }
}