using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using PROJECT_19.Models;
namespace PROJECT_19
{
    public partial class Lecturer : Form
    {
        Users users1;
        Form menu1;
        public Lecturer(Form menu,Users users)
        {
            
            InitializeComponent();
            users1 = users;
            menu1 = menu;
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lecturer_lessons less = new Lecturer_lessons(this,users1);
            less.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangePassword change = new ChangePassword(this,users1);
            change.Show();
            this.Hide();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Lecturer_grades grade = new Lecturer_grades(this);
            grade.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            menu1.Show();
            this.Close();
        }

        private void Lecturer_Load(object sender, EventArgs e)
        {

        }
    }
}
