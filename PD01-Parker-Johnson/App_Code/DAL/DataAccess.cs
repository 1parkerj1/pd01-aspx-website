using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using PD01_Parker_Johnson.App_Code.BLL;
using System.Web.Management;
using System.Drawing;

namespace PD01_Parker_Johnson.App_Code.DAL
{
    public class DataAccess
    {

        // connection methods for the database operations

        //connection open 
        public static OleDbConnection openConnection()
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

        //conneciton close 
        public static OleDbConnection closeConnection(OleDbConnection connClose)
        {
            connClose.Close();
            return null;
        }


        // database CRUD methods

        // creating a user (* users)
        public static int DALuserReg(string UserEmail, string UserName, string UserPass)
        {
            OleDbConnection regConn = openConnection();

            string regSQL = "INSERT INTO Users (UserEmail, UserName, UserPass) VALUES('" + UserEmail + "', '" + UserName + "', ' " + UserPass + "')";
            OleDbCommand cmd = new OleDbCommand(regSQL, regConn);

            //cmd.Parameters.AddWithValue("@UserEmail", UserEmail);
            //cmd.Parameters.AddWithValue("@UserName", UserName);
            //cmd.Parameters.AddWithValue("@UserPass", UserPass);

            cmd.ExecuteNonQuery();
            cmd.CommandText = "SELECT @@IDENTITY";

            int UserID = Convert.ToInt32(cmd.ExecuteScalar());
            closeConnection(regConn);
            return UserID;
        }

        // removing a user
        public static bool DALuserRemove(int UserID)
        {
            OleDbConnection delConn = openConnection();
            string delSQL = "DELETE FROM Users WHERE UserID = " + UserID;

            OleDbCommand cmd = new OleDbCommand(delSQL, delConn);

            int count = cmd.ExecuteNonQuery();

            closeConnection(delConn);

            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // login with user
        public static User DALuserLogin(string UserEmail, string UserPass)
        {
            OleDbConnection loginConn = openConnection();
            User user = null;

            if (loginConn != null)
            {
                try
                {
                    string loginSQL = "SELECT * FROM Users WHERE UserEmail = @UserEmail AND UserPass = @UserPass";
                    using (OleDbCommand cmd = new OleDbCommand(loginSQL, loginConn))
                    {
                        cmd.Parameters.AddWithValue("@UserEmail", UserEmail);
                        cmd.Parameters.AddWithValue("@UserPass", UserPass);

                        using (OleDbDataReader read = cmd.ExecuteReader())
                        {
                            if (read.Read())
                            {
                                user = new User();
                                user.setUserID(read.GetInt32(read.GetOrdinal("UserID")));
                                user.setUserEmail(read.GetString(read.GetOrdinal("UserEmail")));
                                user.setUserPass(read.GetString(read.GetOrdinal("UserPass")));
                            }
                        }
                    }
                }
                finally
                {
                    loginConn.Close();

                }
            }

            return user;

        }

        public bool DALemailValidate(string email)
        {
            OleDbConnection validateConn = openConnection();
            bool emailExists = false;
            int id = -1;

            if (validateConn != null)
            {
                try
                {
                    string validateSQL = "SELECT * FROM Users WHERE UserEmail = '" + email + "'" ;
                    using (OleDbCommand cmd = new OleDbCommand(validateSQL, validateConn))
                    {
                        using (OleDbDataReader read = cmd.ExecuteReader())
                        {
                            if (read.Read())
                            {
                                id = (read.GetInt32(read.GetOrdinal("UserID")));
                            }
                        }
                    }
                }
                finally
                {
                    validateConn.Close();
                }
            }

            if (id>-1)
            {
                emailExists = true;
            }

        return emailExists;
        }


    }
}