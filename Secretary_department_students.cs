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
    public partial class Secretary_department_students : Form
    {
        Form sec_dep;
        Users users1;
        public Secretary_department_students(Form sec_dep,Users users)
        {
            InitializeComponent();
            this.sec_dep = sec_dep;
            users1 = users;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            sec_dep.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CallStudent ce = new CallStudent(this);
            this.Hide();
            ce.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowTable show1 = new ShowTable(this, sec_dep, "student");
            show1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
