using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_19
{
    public class Users
    {
        public int id { set; get; }
        public string firstName { set; get; }
        public string lastName { set; get; }
        public string userName { set; get; }
        public string password { set; get; }
        public string mail;
        public string address;
        public int phone;
        public string job;

        public void  set_first_name(string name)
        {
            firstName = name;
        }
        public string get_first_name()
        {
            return firstName;
        }
        public void set_last_name(string name)
        {
            lastName = name;
        }
        public string get_last_name()
        {
            return lastName;
        }
        public void set_Password(string name)
        {
            password = name;
        }
        public string get_Password()
        {
            return password;
        }
        public void set_mail(string name)
        {
            mail = name;
        }
        public string get_mail()
        {
            return mail;
        }
        public void set_address(string name)
        {
            address = name;
        }
        public string get_address()
        {
            return address;
        }
        public void set_phone(int num)
        {
            phone = num;
        }
        public int get_phone()
        {
            return phone;
        }
        public void set_job(string name)
        {
            job = name;
        }
        public string get_job()
        {
            return job;
        }



    }
}
