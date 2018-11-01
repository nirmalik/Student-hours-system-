using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_19
{
    public partial class StudentAdministration_students : Form
    {
        StudentAdministration admin;
        public StudentAdministration_students(StudentAdministration admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            admin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentRegistration sr = new StudentRegistration(this,admin);
            this.Hide();
            sr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            AcceptNewStudentsSA acc = new AcceptNewStudentsSA(this);
            ShowRegistrationTable show = new ShowRegistrationTable(this,acc);
            this.Hide();
            show.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PlacementStudents place = new PlacementStudents(this);
            this.Hide();
            place.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowTableEdit show1 = new ShowTableEdit(this, admin, "student");
            show1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Files fe = new Files();
            fe.Show();
        }
    }
}
