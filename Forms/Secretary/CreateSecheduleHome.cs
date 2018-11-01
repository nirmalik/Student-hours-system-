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
using Connections;
using THEUSERS;
using StudentSpace;
using Sech;
using PROJECT_19.Classes;
namespace PROJECT_19.Forms
{
    public partial class CreateSecheduleHome : Form
    {
        List<List<string>> detailsList;
        Sechedule studentSechedule;
        List<Course> studentCourseList;
        int dayNum, startTime, endTime;

        public CreateSecheduleHome()
        {
            InitializeComponent();
            string userSemester = ((Student)User.ins).getSemester();
            studentCourseList = DBConnect.getAllCourses(); //DBConnect.getCourses("semester", userSemester);

            //Get user courses from schedule as list of text
            detailsList = DBConnect.getSechedule("studentId", User.ins.getId().ToString());
            
                //Creat a schedule (a list of courses with time and day)
                studentSechedule = this.getStudentSechedule(detailsList);

                this.showCoursesBlock(studentSechedule);

                this.fillUserCourseList(studentCourseList, userSemester);
                this.coursesList.SelectedIndexChanged += new System.EventHandler(coursesList_SelectedIndexChanged);
                if (studentSechedule != null)
                {
                    randomSchedule.Enabled = false;
                }
            

        }

        private void coursesList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            dayBox.Items.Clear();
            string courseId = ((ComboboxItem)coursesList.SelectedItem).Value.ToString();
            List<List<string>> lis = DBConnect.getFromScheduling("courseId", courseId);
            for(int i = 0; i < lis.Count; i++)
            {
                dayBox.Items.Add(lis[i][4] + "-" + lis[i][3] + "-" + lis[i][2]);
                
            }
            
        }

        private void fillUserCourseList(List<Course> courses, string semester)
        {
            ComboboxItem item;
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].getSemester() == semester + "1" || courses[i].getSemester() == semester + "2")
                {
                    item = new ComboboxItem(courses[i].getName() + " - " + courses[i].getType(), courses[i].getId());
                    coursesList.Items.Add(item);
                }
            }
        }

        private void addPanelToTable(int day, int startTime, int endTime,Course cors)
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
            pan.Click += new EventHandler(this.panButtonClicked);

        }

        private void panButtonClicked(Object sender, EventArgs e)
        {
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

        private void randomSchedule_Click(object sender, EventArgs e)
        {
            if (this.studentSechedule == null)
            {
                for(int i = 0; i < studentCourseList.Count; i++)
                {
                    List<List<string>> a = DBConnect.getFromScheduilngOneCourseDetails("courseId", studentCourseList[i].getId().ToString());
                    DBConnect.insetCourseToSchedule(User.ins.getId(), studentCourseList[i].getId(),a[0][3], a[0][2], int.Parse(a[0][4]));
                }
                detailsList = DBConnect.getSechedule("studentId", User.ins.getId().ToString());
                studentSechedule = this.getStudentSechedule(detailsList);
                this.showCoursesBlock(studentSechedule);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (coursesList.SelectedIndex != -1 && dayBox.SelectedIndex != -1)
            {
                bool flag = false,courseExist = false;
                int courseId = int.Parse(((ComboboxItem)coursesList.SelectedItem).Value.ToString());
                string[] str = dayBox.Text.Split('-');
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
                    {
                        DBConnect.updateSchedule(User.ins.getId(), courseId, str[1], str[2], int.Parse(str[0]));
                        tst.Text = courseId.ToString();
                    }
                    else
                    {
                        tst.Text = User.ins.getId().ToString();
                        DBConnect.insetCourseToSchedule(User.ins.getId(), courseId, str[1], str[2], int.Parse(str[0]));
                    }

                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 1; j <= 14; j++)
                        {
                            Control cont = table.GetControlFromPosition(i, j);
                            table.Controls.Remove(cont);
                        }
                    }
                    //Show courses A agin
                    detailsList = DBConnect.getSechedule("studentId", User.ins.getId().ToString());
                    studentSechedule = this.getStudentSechedule(detailsList);
                    this.showCoursesBlock(studentSechedule);
                }

            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Controller.exitSystem();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Controller.logOut();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            Controller.ins.showStudentHomeForm();
        }

        private void table_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dayBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] str = dayBox.Text.Split('-');
            dayNum = getDayInNum(str[2]);
            startTime = int.Parse(str[1].Substring(0, 2));
            endTime = int.Parse(str[1].Substring(3));
        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateSecheduleHome_Load(object sender, EventArgs e)
        {

        }
    }
}
