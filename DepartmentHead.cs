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
    public partial class DepartmentHead : Form
    {
        Users users1;
        Form menu1;

        public DepartmentHead(Form menu,Users users)
        {
            InitializeComponent();
            menu1 = menu;
            users1 = users;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DepartmentHead_editing_users edit = new DepartmentHead_editing_users(this,users1);
            edit.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            DepartmentHead_courses course = new DepartmentHead_courses(this);
            course.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            menu1.Show();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ChangePassword change = new ChangePassword(this, users1);
            change.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DepartmentHead_lecturers lec = new DepartmentHead_lecturers(this);
            lec.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DepartmentHead_students stud = new DepartmentHead_students(this);
            stud.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DepartmentHead_Load(object sender, EventArgs e)
        {

        }
    }
}
