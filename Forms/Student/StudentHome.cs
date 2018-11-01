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
using StudentSpace;
using Connections;
namespace PROJECT_19.Forms
{
    public partial class StudentHome : Form
    {
        public StudentHome()
        {
            InitializeComponent();
            //Show the name on the top and Welcom msg
            welcomLabel.Text = "Welcome Student";
            labelName.Text = User.ins.getFirstName() +" " + User.ins.getLastName();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form passForm = new Password();
            Controller.ins.setPassowrdForm(passForm);
            Controller.ins.showPasswordForm();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            User.ins = null;
            Controller.ins.showHomeForm();

            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exit the system
            Controller.exitSystem();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            //Exit the system
            Controller.exitSystem();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Controller.logOut();
        }

        private void emptyClassesButton_Click(object sender, EventArgs e)
        {
            Controller.ins.emptyClassesForm = new EmptyClasses();
            Controller.ins.showEmptyClassesForm();
        }

        private void creatSecheduleButton_Click(object sender, EventArgs e)
        {

           // if (DBConnect.canCreatShedule())
           // {
                Controller.ins.scheduleForm = new CreateSecheduleHome();
                Controller.ins.showCreatSch();
          //  }
           // else
           //     MessageBox.Show("this option will be avillable in: "+ DBConnect.whenCan());

        }

        private void muSecheduleButton_Click(object sender, EventArgs e)
        {
            Form s = new Weeklyschedule();
            s.Show();
        }

        private void eventHolidays_Click(object sender, EventArgs e)
        {
            Form holiday = new Holidays();
            Controller.ins.holiday = holiday;
            Controller.ins.showHoliday();

        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            Form assign = new Assignments();
            assign.Show();
        }

        private void calender_Click(object sender, EventArgs e)
        {
            Controller.ins.calender = new Calendar();
            Controller.ins.showCalender();
        }

        private void examButton_Click(object sender, EventArgs e)
        {
            Controller.ins.examsForm = new Exams();
            Controller.ins.showExams();
        }

        private void recHoures_Click(object sender, EventArgs e)
        {
            Controller.ins.recHorseForm = new RecHourse();
            Controller.ins.showRecHourse();
        }
        private int summ(int a,int b)
        {
            return a + b;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Controller.ins.sendReq = new Sreq();
            Controller.ins.showSendReq();
        }
    }
}
