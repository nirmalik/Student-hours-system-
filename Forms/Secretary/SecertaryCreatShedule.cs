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
using StudentSpace;
using Courses;
using Connections;
using Sech;
using System.Data.SqlClient;
using PROJECT_19.Classes;
namespace PROJECT_19.Forms
{
    public partial class SecertaryCreatShedule : Form
    {
        private static SqlConnection connection;
        List<List<string>> detailsList;
        Sechedule studentSechedule;
        Student student;
        int dayNum, startTime, endTime;

        public SecertaryCreatShedule(Object user)
        {
            InitializeComponent();
            student = ((Student)user);
            string semester = student.getSemester();
            List<Course> courses = DBConnect.getAllCourses();
            detailsList = DBConnect.getSechedule("studentId", (student.getId().ToString()));
            studentSechedule = getStudentSechedule(detailsList);
            showCoursesBlock(studentSechedule);
            fillUserCourseList(courses,semester);
        }

        private void coursesList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            timesList.Items.Clear();
            string courseId = ((ComboboxItem)coursesList.SelectedItem).Value.ToString();
            List<List<string>> lis = DBConnect.getFromScheduling("courseId", courseId);

            for (int i = 0; i < lis.Count; i++)
            {
                timesList.Items.Add(lis[i][4] + "-" + lis[i][3] + "-" + lis[i][2]);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (coursesList.SelectedIndex != -1 && timesList.SelectedIndex != -1)
            {

                bool flag=false,courseExist = false;
                int courseId = int.Parse(((ComboboxItem)coursesList.SelectedItem).Value.ToString());
                string[] str = timesList.Text.Split('-');
                int dayInNum1, startTime1, endTime1;

                
                
                if (studentSechedule != null)
                {
                    for (int i = 0; i < studentSechedule.getAllCourses().Count; i++)
                    {
                        dayInNum1 = getDayInNum(studentSechedule.getCourse(i).getDay());

                        if (dayInNum1 == dayNum && courseId != studentSechedule.getCourse(i).getId())
                        {
                            startTime1 = int.Parse(studentSechedule.getCourse(i).getTime().Substring(0, 2));
                            endTime1 = int.Parse(studentSechedule.getCourse(i).getTime().Substring(3));

                            if (startTime1 < endTime && startTime < endTime1)
                            {
                                MessageBox.Show("Please choose another time!");
                                flag = true;
                                return;
                            }
                        }

                        if (courseId == studentSechedule.getCourse(i).getId())
                            courseExist = true;
                    }
                }

                if (!flag)
                {
                    if (courseExist)
                        DBConnect.updateSchedule(student.getId(), courseId, str[1], str[2], int.Parse(str[0]));
                    else
                        DBConnect.insetCourseToSchedule(student.getId(), courseId, str[1], str[2], int.Parse(str[0]));
                   // timesList.SelectedIndex = -1;


                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 1; j <= 14; j++)
                        {
                            Control cont = table.GetControlFromPosition(i, j);
                            table.Controls.Remove(cont);
                        }
                    }
                    //Show courses A agin
                    detailsList = DBConnect.getSechedule("studentId", student.getId().ToString());
                    studentSechedule = this.getStudentSechedule(detailsList);
                    showCoursesBlock(studentSechedule);
                }
            }
        }

        private void timesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] str = timesList.Text.Split('-');
            dayNum = getDayInNum(str[2]);
            startTime = int.Parse(str[1].Substring(0, 2));
            endTime = int.Parse(str[1].Substring(3));
        }

        //============================================================
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

        private void showCoursesBlock(Sechedule mySech)
        {
            if (mySech != null)
            {
                for (int i = 0; i < mySech.getAllCourses().Count; i++)
                {
                    string day = mySech.getCourse(i).getDay();
                    int startTime = int.Parse(mySech.getCourse(i).getTime().Substring(0, 2));
                    int endTime = int.Parse(mySech.getCourse(i).getTime().Substring(3));
                    int dayInNum = getDayInNum(day);

                    addPanelToTable(dayInNum, startTime, endTime, mySech.getCourse(i));
                }
            }
        }

        private void addPanelToTable(int day, int startTime, int endTime, Course cors)
        {
            Button pan = new Button();
            if (cors.getType() == CourseType.Lecture)
                pan.BackColor = Color.CadetBlue;
            else
                pan.BackColor = Color.BlueViolet;
            pan.Dock = DockStyle.Fill;
            this.table.Controls.Add(pan);
            this.table.Controls.Add(pan, (day - 1), (startTime - 7));
            this.table.SetRowSpan(pan, endTime - startTime);
            pan.Text = cors.getName() + " - " + cors.getType();
            pan.ForeColor = Color.White;
            pan.Font = new Font(pan.Font, FontStyle.Bold);

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

        private void fillUserCourseList(List<Course> courses,string semester)
        {
            ComboboxItem item;
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].getSemester() == semester+"1" || courses[i].getSemester() == semester + "2")
                {
                    item = new ComboboxItem(courses[i].getName() + " - " + courses[i].getType(), courses[i].getId());
                    coursesList.Items.Add(item);
                }
            }
        }

        private void SecertaryCreatShedule_Load(object sender, EventArgs e)
        {

        }
    }
}
