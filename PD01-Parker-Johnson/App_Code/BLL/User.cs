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

        private int UserID, UserAge;
        private string UserName, UserPass, UserEmail, UserPhone, UserLicense;

        public User(){ }

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

        public void setUserPhone(string UserPhone)
        {
            this.UserPhone = UserPhone;
        }
        public string getUserPhone() 
        { 
            return this.UserPhone; 
        }

        public void setUserLicense(string UserLicense)
        {
            this.UserLicense = UserLicense;
        }
        public string getUserLicense()
        {
            return this.UserLicense;
        }

        public void setUserAge(int UserAge)
        {
            this.UserAge = UserAge;
        }
        public int getUserAge()
        {
            return (int) this.UserAge;
        }

        public void newUser()
        {
            // call data access method to create a new user
            // the userID from the database is used for the object

            this.UserID = DataAccess.DALuserReg(this.UserEmail, this.UserName, this.UserPass);
        }

        public bool removeUser()
        {
            return DataAccess.DALuserRemove(this.UserID);
        }

        public User loginUser(string UserEmail, string UserPass)
        {
            User user = DataAccess.DALuserLogin(UserEmail, UserPass);
            return user;
        }

        public void rememberMeCookie(string UserEmail, string UserPass, bool rememberMe)
        {
            if(rememberMe)
            {
                
            }
        }


    }
}