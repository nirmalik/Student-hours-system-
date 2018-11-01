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
    public partial class Secretery_department : Form
    {
        Form menu1;
        Users users1;

        public Secretery_department(Form menu,Users users)
        {
            InitializeComponent();
            menu1 = menu;
            users1 = users;
        

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("in construction");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Secretary_department_schedule sched = new Secretary_department_schedule(this);
            sched.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Secretary_department_courses course = new Secretary_department_courses(this);
            course.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Secretary_department_students stud = new Secretary_department_students(this,users1);
            stud.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangePassword change = new ChangePassword(this, users1);
            change.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu1.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
            this.Close();
        }
    }
}
