using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT_19.Classes;
using THEUSERS;
using Connections;

namespace PROJECT_19.Forms.SecretaryManager
{
    public partial class AddSecretary : Form
    {
        public AddSecretary()
        {
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Controller.ins.showSecretaryManagerForm();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Controller.exitSystem();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Controller.logOut();
        }
        private void addNewSecretary()
        {
            string firstName = this.firstName.Text;
            string lastName = this.lastName.Text;
            string password = this.password.Text;
            string email = this.email.Text;
            int id;
            string userName = this.userName.Text;
            string address = this.address.Text;
            string ph = "123";
            int phone;
            if(firstName.Length > 1 && lastName.Length > 1 && password.Length > 3 && email.Length > 10 && userName.Length > 3 && address.Length > 1 && int.TryParse(this.id.Text,out id) && int.TryParse(ph, out phone))
            {
                DBConnect.insetSecretary(id, firstName, lastName, userName, password, email, address, phone);
            }else
            {
                errMsg.Visible = true;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            this.addNewSecretary();
        }
    }
}
