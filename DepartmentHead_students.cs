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
    public partial class DepartmentHead_students : Form
    {
        DepartmentHead head;
        public DepartmentHead_students(DepartmentHead head)
        {
            InitializeComponent();
            this.head = head;
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
            ShowTable show1 = new ShowTable(this, head, "student");
            show1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bad_student_mode bad = new Bad_student_mode(this,head);
            bad.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AcceptNewStudentsDH acc = new AcceptNewStudentsDH(this);
            ShowRegistrationTable show = new ShowRegistrationTable(this,acc);
            this.Hide();
            show.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HandelingRequset he = new HandelingRequset();
            he.Show();
        }
    }
}
