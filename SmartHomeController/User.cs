using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeController
{
    internal class User
    {

        //private fields
        private int userID;
        private string userName;
        private string ContactInfo;



        //public properties
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        
        public string Contactinfo
        {
            get { return ContactInfo; }
            set { ContactInfo = value; }
        }

        public User(int constructoruserID, string constructoruserName, string constructorContactInfo)
        {
            userID = constructoruserID;
            userName = constructoruserName;
            ContactInfo = constructorContactInfo;
        }
        public void Login(int UserID, string UserName)
        {

        }

        public void Logout()
        {

        }

        public void ControlDevice()
        {

        }
    }
}
