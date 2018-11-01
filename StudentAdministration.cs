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
    public partial class StudentAdministration : Form
    {
        Form menu1;
        Users users1;
        public StudentAdministration(Form menu,Users users)
        {
            InitializeComponent();
            menu1 = menu;
            users1 = users;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangePassword change = new ChangePassword(this, users1);
            change.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StudentAdministration_students stud = new StudentAdministration_students(this);
            stud.Show();
            this.Hide();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            StudentAdministration_courses course = new StudentAdministration_courses(this);
            course.Show();
            this.Hide();
        }


        private void button10_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("in construction");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("in construction");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
