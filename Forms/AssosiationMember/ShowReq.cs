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
namespace PROJECT_19.Forms.AssosiationMember
{
    public partial class ShowReq : Form
    {
        public ShowReq()
        {
            InitializeComponent();
            List < string > reg = DBConnect.getRequests();
            for(int i = 0; i < reg.Count; i++)
            {
                listBox1.Items.Add(reg[i]);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Controller.exitSystem();
            
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Controller.logOut();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Controller.ins.showMemberForm();
        }
    }
}
