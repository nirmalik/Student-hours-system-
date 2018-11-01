using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THEUSERS;
using PROJECT_19.Classes;
namespace PROJECT_19.Forms
{
    public partial class SecretaryHome : Form
    {
        Users users1;
        public SecretaryHome()
        {
            InitializeComponent();
            //Add the name to the label 
            this.labelName.Text = User.ins.getFirstName() +" " + User.ins.getLastName();
        }
        public SecretaryHome(Users u)
        {
            InitializeComponent();
            this.labelName.Text = User.ins.getFirstName() + " " + User.ins.getLastName();
            this.users1 = u;

        }

        private void SecretaryHome_Load(object sender, EventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Controller.logOut();
        }



        private void changePassButton_Click(object sender, EventArgs e)
        {
            Form passForm = new Password();
            Controller.ins.setPassowrdForm(passForm);
            Controller.ins.showPasswordForm();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Controller.exitSystem();
        }

        private void editCourses_Click(object sender, EventArgs e)
        {

            Form open = new SecertaryAddCourse();
            open.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form open = new chooseStudent();
            open.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form asd = new SecertarySetCreatingDate();
            asd.Show();
        }

        private void sechedulButtonA_Click(object sender, EventArgs e)
        {
            Secretary_department_schedule sched = new Secretary_department_schedule(this);
            sched.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //A
            Secretary_department_students stud = new Secretary_department_students(this, users1);
            stud.Show();
            this.Hide();
        }
    }
}
