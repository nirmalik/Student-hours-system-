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
    public partial class DepartmentHead_courses : Form
    {
        DepartmentHead head;
        public DepartmentHead_courses(DepartmentHead head)
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
            AddPreCourse add = new AddPreCourse();
            add.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cancelCourse cancel = new cancelCourse();
            cancel.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            registeretionCourse re = new registeretionCourse();
            re.Show();
        }

        private void DepartmentHead_courses_Load(object sender, EventArgs e)
        {

        }
    }
}
