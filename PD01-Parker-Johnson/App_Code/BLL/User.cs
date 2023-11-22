using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using PD01_Parker_Johnson.App_Code.DAL;


namespace PD01_Parker_Johnson.App_Code.BLL
{
    public class User
    {

        private int UserID;
        private string UserName, UserPass, UserEmail, UserLicenseType;
        private DateTime userDOB;

        public User() { }

        // getters and setters for each class variable

        public void setUserID(int UserID)
        {
            this.UserID = UserID;
        }
        public int getUserID()
        {
            return this.UserID;
        }

        public void setUserName(string UserName)
        {
            this.UserName = UserName;
        }
        public string getUserName()
        {
            return this.UserName;
        }

        public void setUserPass(string UserPass)
        {
            this.UserPass = UserPass;
        }
        public string getUserPass()
        {
            return this.UserPass;
        }

        public void setUserEmail(string UserEmail)
        {
            this.UserEmail = UserEmail;
        }
        public string getUserEmail()
        {
            return this.UserEmail;
        }

        public void setUserLicense(string UserLicense)
        {
            this.UserLicenseType = UserLicense;
        }
        public string getUserLicense()
        {
            return this.UserLicenseType;
        }

        public void setUserDOB(DateTime userDOB)
        {
            this.userDOB = userDOB;
        }
        public DateTime getUserDOB()
        {
            return this.userDOB;
        }

        // uses dal method for new user
        public void newUser(string UserEmail, string UserName, string UserPass)
        {
            // call data access method to create a new user
            // the userID from the database is used for the object

            this.UserID = DataAccess.DALuserReg(UserEmail, UserName, UserPass);
        }
        // Method to remove a user using DataAccess class
        public bool removeUser()
        {
            return DataAccess.DALuserRemove(this.UserID);
        }

        // Method to login a user using DataAccess class
        public User loginUser(string UserEmail, string UserPass)
        {
            User user = DataAccess.DALuserLogin(UserEmail, UserPass);
            return user;
        }

        // Method to validate email using DataAccess class
        public bool emailValidate(string Email)
        {
            DataAccess da = new DataAccess();
            return da.DALemailValidate(Email);
        }

        // Method to add license information
        public void addLicenceInfo(string UserEmail, DateTime UserDOB, string UserAddress, string UserLicenceType, DateTime UserExpiry)
        {
            LicenceInfo licence = new LicenceInfo();
            licence.licenceInfo(UserEmail, UserDOB, UserAddress, UserLicenceType, UserExpiry);
        }

        // Method to validate user using DataAccess class
        public bool userValidate(string UserEmail, string UserPass)
        {
            DataAccess da = new DataAccess();
            return da.DALuserValidate(UserEmail, UserPass);
        }

        public bool licenceExits(string UserEmail)
        {
            LicenceInfo licence = new LicenceInfo();
            return licence.licenceExists(UserEmail);
        }

        public string userName(string UserEmail)
        {
            DataAccess DALname = new DataAccess();
            return DALname.DALgetUsername(UserEmail);


        }
    }
}