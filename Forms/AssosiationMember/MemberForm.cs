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
using PROJECT_19.Forms.AssosiationMember;

namespace PROJECT_19.Forms
{
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Controller.exitSystem();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Controller.logOut();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.ins.reqShow = new ShowReq();
            Controller.ins.reqShowShow();
        }
    }
}
