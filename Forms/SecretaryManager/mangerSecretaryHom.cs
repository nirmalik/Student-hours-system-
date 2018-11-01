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
using PROJECT_19.Forms.SecretaryManager;
namespace PROJECT_19.Forms
{
    public partial class mangerSecretaryHom : Form
    {
        public mangerSecretaryHom()
        {
            InitializeComponent();
            welcomLabel.Text = "Welcome Student";
            labelName.Text = User.ins.getFirstName() + " " + User.ins.getLastName();
        }

        private void welcomLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Controller.exitSystem();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Controller.logOut();
        }

        private void creatSecheduleButton_Click(object sender, EventArgs e)
        {
            Controller.ins.addSecretaryForm = new AddSecretary();
            Controller.ins.showManagerAddSecretaryForm();
        }
    }
}
