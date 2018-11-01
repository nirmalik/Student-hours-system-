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
    
    public partial class Special_dates : Form
    {
        StudentAdministration admin;
        StudentAdministration_students stud;
        public Special_dates(StudentAdministration_students stud, StudentAdministration admin)
        {
            InitializeComponent();
            this.admin = admin;
            this.stud = stud;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            stud.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            stud.Close();
            admin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
