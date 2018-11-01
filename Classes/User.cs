using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Connections;
namespace THEUSERS
{
    //Enum for the job of the User
    public enum Job
    {

        Student, Scaretary,Association,SecretaryAdministration,User
    }
    public class User
    {
        private int id;
        private String firstName;
        private String lastName;
        private String userName;
        private String password;
        private String mail;
        private String address;
        private int phoneNumber;
        public string j;
        public bool forA = false;
        static public User ins;
        public User()
        {
            if (ins == null)
                ins = this;
        }

        public void setId(int id)
        {
            //Set user id
            this.id = id;
        }
        public void setFirstName(String name)
        {
            //set first name
            this.firstName = name;
        }
        public void setLastName(String lastName)
        {
            //Set last name of the user
            this.lastName = lastName;
        }
        public void setUserName(String username)
        {
            //Set user name of the user
            this.userName = username;
        }
        public void setMail(String mail)
        {
            //Set mail of the user
            this.mail = mail;
        }
        public void setAddress(String address)
        {
            this.address = address;
        }
        public void setPhoneNumber(int number = -1)
        {
                this.phoneNumber = number;
        }

        public void setPassword(String pass)
        {
            this.password = pass;
        }
        ///Get functions
        public String getUserName()
        {
            return this.userName;
        }

        public String getMail()
        {
            return this.mail;
        }
        public String getFirstName()
        {
            return this.firstName;
        }
        public String getLastName()
        {
            return this.lastName;
        }
        public int getPhoneNumber()
        {
            return this.phoneNumber;
        }
        public int getId()
        {
            return this.id;
        }
        public String getAddress()
        {
            return this.address;
        }
        public String getPassword()
        {
            return this.password;
        }
        public virtual Job getJob()
        {
            return Job.User;
        }
        public virtual String getJobString()
        {
            return "User";
        }


    }
}
