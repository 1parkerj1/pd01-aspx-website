using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Hosting;
using System.Web.Services;
using System.Web.UI.WebControls;
using PD01_Parker_Johnson.App_Code.DAL;


namespace PD01_Parker_Johnson
{
    /// <summary>
    /// Summary description for LicenceInfo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class LicenceInfo : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string licenceInfo(string UserEmail, DateTime UserDOB, string UserAddress, string UserLicenceType, DateTime UserExpiry)
        {

                OleDbConnection infoConn = openConnection();

                string licenceSQL = "UPDATE Users SET UserDOB = '" + UserDOB + "', UserAddress = '" + UserAddress + "', LicenceType = '" + UserLicenceType + "', UserExpiry = '" + UserExpiry + "'" +
                    " WHERE UserEmail = '" + UserEmail + "';";


                OleDbCommand cmd = new OleDbCommand(licenceSQL, infoConn);

                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT @@IDENTITY";

                cmd.ExecuteScalar();
                infoConn.Close();
                return UserEmail;
            
        }

        public  OleDbConnection openConnection()
        {
            String dbconn = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source= " + HostingEnvironment.MapPath("~/App_Data/UlsterFly1.accdb");

            try
            {
                OleDbConnection connOpen = new OleDbConnection(dbconn);
                connOpen.Open();
                return connOpen;
            }
            catch
            {
                return null;
            }
        }

        public bool licenceExists(string UserEmail)
        {
            OleDbConnection licenceConn = openConnection();

            if(licenceConn != null)
            {
                string licenceSQL = "SELECT COUNT(*) FROM Users WHERE UserEmail = '" + UserEmail + "'";
                OleDbCommand cmd = new OleDbCommand (licenceSQL, licenceConn);
                
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                licenceConn.Close();

                return count > -1;

            } else
            {
                return false;
            }
        }


    }
}
