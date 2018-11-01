using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_19
{
    public partial class DepartmentHead_editing_users : Form
    {
        DepartmentHead head;
        Users users1;
        public DepartmentHead_editing_users(DepartmentHead head,Users user)
        {
            InitializeComponent();
            this.head = head;
            users1 = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            head.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowTableEdit show1 = new ShowTableEdit(this,head,"student");
            show1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowTableEdit show1 = new ShowTableEdit(this, head, "lecturer\r\n");
            show1.Show();
            this.Hide();
        }

        private void DepartmentHead_editing_users_Load(object sender, EventArgs e)
        {

        }
    }
}
