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

namespace PROJECT_19.Forms
{
    public partial class RecHourse : Form
    {
        public RecHourse()
        {
            InitializeComponent();
            List<string> str = DBConnect.getRecHourse();
            for(int i = 0; i < str.Count; i++)
            {
                recList.Items.Add(str[i]);
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
            Controller.ins.showStudentHomeForm();
        }
    }
}
