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
    public partial class StudentAdministration_courses : Form
    {
        StudentAdministration admin;
        public StudentAdministration_courses(StudentAdministration admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            admin.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlacementClasses place = new PlacementClasses(this);
            place.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RequsetExeptions re = new RequsetExeptions();
            re.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PlacmentTests place = new PlacmentTests();
            place.Show();
        }
    }
}
