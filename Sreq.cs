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
using Connections;
using THEUSERS;
namespace PROJECT_19
{
    public partial class Sreq : Form
    {
        public Sreq()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Controller.exitSystem();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Controller.logOut();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            Controller.ins.showStudentHomeForm();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text.Length < 10)
            {
                msgError.Visible = true;
                doneLabel.Visible = false;
            }
            else
            {
                DBConnect.insetRequest(User.ins.getId(), User.ins.getFirstName() + " " + User.ins.getLastName(), textBox1.Text);
                msgError.Visible = false;
                doneLabel.Visible = true;
                textBox1.Text = "";
            }
        }
    }
}
