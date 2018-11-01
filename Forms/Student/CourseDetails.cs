using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Courses;
namespace PROJECT_19.Forms
{
    public partial class CourseDetails : Form
    {
        private Course cors;
        public CourseDetails()
        {
            InitializeComponent();
            lname.Text = "Name : " + CourseDes.ins.cors.getName() +" - " + CourseDes.ins.cors.getType();
            lpoint.Text = "Points : " + CourseDes.ins.cors.getPoints();
            lpass.Text = "Pass Grade : " + CourseDes.ins.cors.getPassScore();
            lId.Text = "Id : " + CourseDes.ins.cors.getId();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
