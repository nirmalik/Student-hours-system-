using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sech;
using Connections;
using THEUSERS;
using Courses;
namespace PROJECT_19.Forms
{
    public partial class Weeklyschedule : Form
    {
        List<List<string>> detailsList;
        Sechedule studentSechedule;
        List<Course> clis;
        public Weeklyschedule()
        {
            clis = new List<Course>();
            InitializeComponent();
            //Get user courses from schedule as list of text
            detailsList = DBConnect.getSechedule("studentId", User.ins.getId().ToString());
            //Creat a schedule (a list of courses with time and day)
            studentSechedule = this.getStudentSechedule(detailsList);
            this.showCoursesBlock(studentSechedule);
        }
        private Sechedule getStudentSechedule(List<List<string>> details)
        {
            Sechedule sechdule = null;
            if (details.Count > 0)
            {
                sechdule = new Sechedule();
                for (int i = 0; i < details.Count; i++)
                {
                    Course cors = DBConnect.getOneCourse("Id", details[i][0].ToString());
                    cors.setDay(details[i][2].ToString());
                    cors.setTime(details[i][1].ToString());
                    sechdule.addCourse(cors);
                }
            }
            return sechdule;
        }

        private void addPanelToTable(int day, int startTime, int endTime, Course cors)
        {
            Button pan = new Button();
            clis.Add(cors);
            if (cors.getType() == CourseType.Lecture)
                pan.BackColor = Color.CadetBlue;
            else
                pan.BackColor = Color.BlueViolet;
            pan.Dock = DockStyle.Fill;
            pan.Location = new Point(100, 100);
            this.table.Controls.Add(pan);
            this.table.Controls.Add(pan, (day - 1), (startTime - 7));
            this.table.SetRowSpan(pan, endTime - startTime);
            pan.Text = clis.Count + " : " + cors.getName() + " - " + cors.getType();
            pan.ForeColor = Color.White;
            pan.Font = new Font(pan.Font, FontStyle.Bold);
            pan.Click += new EventHandler(this.panButtonClicked);

        }
        private void panButtonClicked(Object sender, EventArgs e)
        {
            CourseDes.ins = null;
            string num = ((Button)sender).Text.Substring(0,1);
            CourseDes coursIns = new CourseDes();
            coursIns.cors = clis[int.Parse(num) - 1];
            Form asd = new CourseDetails();
            asd.Show();
        }
        private void showCoursesBlock(Sechedule mySech)
        {
            if (mySech != null)
            {
                for (int i = 0; i < mySech.getAllCourses().Count; i++)
                {
                    string day = mySech.getCourse(i).getDay();
                    int startTime = int.Parse(mySech.getCourse(i).getTime().Substring(0, 2));
                    int endTime = int.Parse(mySech.getCourse(i).getTime().Substring(3));
                    int dayInNum = this.getDayInNum(day);
                    

                    this.addPanelToTable(dayInNum, startTime, endTime, mySech.getCourse(i));
                }
            }
        }
        private int getDayInNum(string day)
        {
            int dayInNum = 2;
            switch (day)
            {
                case "Sunday":
                    dayInNum = 1;
                    break;
                case "Monday":
                    dayInNum = 2;
                    break;
                case "Tuesday":
                    dayInNum = 3;
                    break;
                case "Wednesday":
                    dayInNum = 4;
                    break;
                case "Thursday":
                    dayInNum = 5;
                    break;
                default:
                    break;
            }
            return dayInNum;
        }
    }
}
