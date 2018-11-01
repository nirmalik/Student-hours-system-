using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THEUSERS;
using Facebook;
namespace PROJECT_19.Classes
{
    class Controller
    {
        private Form homeForm;
        private Form studentHome;
        private Form secretaryHome;
        private Form passowrdForm;
        private Form secretaryEditCourseForm;
        public Form holiday;
        public Form calender;
        public Form scheduleForm;
        public Form examsForm;
        public Form secretaryManger;
        public Form addSecretaryForm;
        public Form emptyClassesForm;
        public Form recHorseForm;
        public static Controller ins;
        public Form memberForm;
        public Form sendReq;
        public Form reqShow;

        public Controller()
        {
            if (ins == null)
                ins = this;
        }
        public void setHomeForm(Form form)
        {
            this.homeForm = form;
        }
        public void showHomeForm()
        {
            //Show home form
            this.homeForm.Show();
            if (studentHome != null)
                studentHome.Close();
            if (this.secretaryHome != null)
                this.secretaryHome.Close();
            if (this.passowrdForm != null)
                this.passowrdForm.Close();
            if (this.secretaryEditCourseForm != null)
                this.secretaryEditCourseForm.Close();
            if(this.holiday != null)
                this.holiday.Close();
            if (this.calender != null)
                this.calender.Close();
            if (this.scheduleForm != null)
                this.scheduleForm.Close();
            if (this.examsForm != null)
                this.examsForm.Close();
            if (this.secretaryManger != null)
                this.secretaryManger.Close();
            if (this.addSecretaryForm != null)
                this.addSecretaryForm.Close();
            if (this.recHorseForm != null)
                this.recHorseForm.Close();
            if (this.emptyClassesForm != null)
                this.emptyClassesForm.Close();
            if (this.memberForm != null)
                this.memberForm.Close();
            if (this.sendReq != null)
                this.sendReq.Close();
            if (this.reqShow != null)
                this.reqShow.Close();

        }

        public void showStudentHomeForm()
        {
            this.homeForm.Hide();
            if(passowrdForm.Enabled)
                this.passowrdForm.Close();
            if (this.holiday != null)
                this.holiday.Close();
            if (this.calender != null)
                this.calender.Close();
            if (this.scheduleForm != null)
                this.scheduleForm.Close();
            if (this.examsForm != null)
                this.examsForm.Close();
            if (this.recHorseForm != null)
                this.recHorseForm.Close();
            if (this.emptyClassesForm != null)
                this.emptyClassesForm.Close();
            if (this.sendReq != null)
                this.sendReq.Close();
            this.studentHome.Show();
        }
        public void showSecretaryManagerForm()
        {
            this.homeForm.Hide();
            this.secretaryManger.Show();
            if(this.addSecretaryForm != null)
                this.addSecretaryForm.Close();
        }
        public void showManagerAddSecretaryForm()
        {
            this.secretaryManger.Hide();
            this.addSecretaryForm.Show();
        }
        public void setStudentHomeForm(Form form)
        {
            this.studentHome = form;
        }

        public void setSecretaryForm(Form form)
        {
            this.secretaryHome = form;
        }
        public void setSecretaryEditCourseForm(Form frm)
        {
            this.secretaryEditCourseForm = frm;
        }
        public void showSecretaryHomeForm()
        {
            this.homeForm.Hide();
            if(this.passowrdForm.Enabled)
                this.passowrdForm.Close();
            if (this.secretaryEditCourseForm != null)
                this.secretaryEditCourseForm.Close();
            this.secretaryHome.Show();
        }
        public void setPassowrdForm(Form form)
        {
            this.passowrdForm = form;
        }
        public void showCreatSch()
        {
            this.scheduleForm.Show();
            if (this.studentHome != null)
                this.studentHome.Hide();
        }

        public void showSecretaryEditCourseForm()
        {
            this.secretaryHome.Hide();
            this.secretaryEditCourseForm.Show();
        }
        public void showPasswordForm()
        {
            this.passowrdForm.Show();
            if(this.secretaryHome != null)
                this.secretaryHome.Hide();
            if(this.studentHome != null)
                this.studentHome.Hide();
        }
        public void showHoliday()
        {
            this.holiday.Show();
            if (this.secretaryHome != null)
                this.secretaryHome.Hide();
            if (this.studentHome != null)
                this.studentHome.Hide();
        }
        public void showCalender()
        {
            this.calender.Show();
            if (this.secretaryHome != null)
                this.secretaryHome.Hide();
            if (this.studentHome != null)
                this.studentHome.Hide();
        }
        public void showExams()
        {
            this.examsForm.Show();
            this.studentHome.Hide();
        }

        public void showRecHourse()
        {
            this.studentHome.Hide();
            this.recHorseForm.Show();
        }

        public void showEmptyClassesForm()
        {
            this.emptyClassesForm.Show();
            this.studentHome.Hide();
        }

        public void showMemberForm()
        {
            this.memberForm.Show();
            this.homeForm.Hide();
            if (this.reqShow != null)
                this.reqShow.Close();
        }
        public void showSendReq()
        {
            this.sendReq.Show();
            this.studentHome.Hide();
        }
        public void reqShowShow()
        {
            this.memberForm.Hide();
            this.reqShow.Show();
        }

        static public void exitSystem()
        {
            LogIn.logIns.logoutfacebook();
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
        


        //Log out operation
        static public void logOut()
        {
            LogIn.logIns.logoutfacebook();
            User.ins = null;
            Controller.ins.showHomeForm();
        }
    }
}
