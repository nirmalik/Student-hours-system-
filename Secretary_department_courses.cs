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
    public partial class Secretary_department_courses : Form
    {
        Secretery_department sec_dep;
        public Secretary_department_courses(Secretery_department sec_dep)
        {
            InitializeComponent();
            this.sec_dep = sec_dep;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            sec_dep.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
