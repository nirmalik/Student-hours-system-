using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_19
{
    public partial class PlacementStudents : Form
    {
        public Form form;
        List<CourseDetails> courses = new List<CourseDetails>();
        List<CourseDetails> appCourses = new List<CourseDetails>();
        List<GiveGrades> schedule = new List<GiveGrades>();
        List<Users> users = new List<Users>();
        List<int> usersid = new List<int>();
        int selectedindex, courseid, block, selected2, studid;
        string name, type;
        int counter2 = 1, count2 = 0,finel=0;
        public PlacementStudents(Form form)
        {
            InitializeComponent();
            this.form = form;
            label4.Hide();
            textBox1.Hide();

            comboBox3.Items.Add("A1");
            comboBox3.Items.Add("A2");
            comboBox3.Items.Add("A3");
            comboBox3.Items.Add("B1");
            comboBox3.Items.Add("B2");
            comboBox3.Items.Add("B3");
            comboBox3.Items.Add("C1");
            comboBox3.Items.Add("C2");
            comboBox3.Items.Add("C3");
            comboBox3.Items.Add("D1");
            comboBox3.Items.Add("D2");
            comboBox3.Items.Add("D3");



            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Courses ", conn);
            SqlDataReader dr = cmd1.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                courses.Add(new CourseDetails());
                courses[count].courseid = (int)dr["Id"];
                courses[count].name = (string)dr["name"];
                courses[count].type = (string)dr["type"];
                courses[count].semester = (string)dr["semester"];
                //courses[count].blocked = (int)dr["blockCourseId"];
                count++;
            }
            dr.Close();

            SqlCommand cmd2 = new SqlCommand("SELECT * FROM lecturerSchedule ", conn);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            count = 0;
            while (dr2.Read())
            {
                appCourses.Add(new CourseDetails());
                appCourses[count].courseid = (int)dr2["Id"];
                appCourses[count].name = (string)dr2["CourseName"];
                appCourses[count].type = (string)dr2["Type"];
                appCourses[count].semester = (string)dr2["semester"];
                appCourses[count].day = (string)dr2["Day"];
                appCourses[count].start = (string)dr2["StartTime"];
                appCourses[count].end = (string)dr2["EndTime"];

                count++;
            }
            dr2.Close();

            SqlCommand cmd3 = new SqlCommand("SELECT * FROM Schedule ", conn);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            count = 0;
            while (dr3.Read())
            {
                schedule.Add(new GiveGrades());
                schedule[count].Id = (int)dr3["Id"];
                schedule[count].studentId = (int)dr3["studentId"];
                schedule[count].CourseId = (int)dr3["couseId"];
                //if (!("".Equals(dr3["score"].ToString())))
                //{
                //    schedule[count].score = (int)dr3["score"];
                //}

                //else
                //{
                //    schedule[count].score = 0;
                //}

                count++;
                if(counter2!= (int)dr3["Id"])
                {
                    finel = counter2;
                }
                else
                {
                    counter2++;
                }
                
            }
            dr3.Close();
            string job = "student";

            SqlCommand cmd4 = new SqlCommand("SELECT * FROM Users where job= '" + job + "'", conn);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            count = 0;
            count2 = 0;
            while (dr4.Read())
            {

                users.Add(new Users());
                users[count].id = (int)dr4["Id"];
                users[count].firstName = (string)dr4["firstName"];
                users[count].lastName = (string)dr4["lastName"];
                count2++;

                count++;
            }
            dr4.Close();
        }

        private void PlacementStudents_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sub1 = appCourses[selectedindex].start.Substring(0, 2);
            string sub2 = appCourses[selectedindex].end.Substring(0, 2);
            string newtime = (sub1 + ":" + sub2);
            int room = 0;

            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            
            cmd.CommandText = "insert into Schedule values('" + finel + "','" + studid + "','" + courseid + "','" + newtime + "','" + appCourses[selectedindex].day + "','" + room + "','" + room + "','" + room + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Saved");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = 0;
            int flag = 0;
            comboBox2.Items.Clear();

            textBox1.Clear();

            selectedindex = comboBox1.SelectedIndex;
            name = appCourses[selectedindex].name;
            type = appCourses[selectedindex].type;
            foreach (CourseDetails elements in courses)
            {
                if (elements.name.Equals(name) && elements.type.Equals(type))
                    courseid = elements.courseid;
            }
            List<Users> users1 = new List<Users>();
            Users specuser = new Users();
            int flag1 = 0, stid = 0;
            string first = "", last = "";
            textBox1.Show();
            textBox1.Paste(appCourses[selectedindex].day + " " + appCourses[selectedindex].start + ":" + appCourses[selectedindex].end);
            //foreach(GiveGrades elem in schedule)
            //{

            count = 0;
            List<GiveGrades> elems = schedule.Where(x => x.CourseId == courseid).ToList();
            foreach (Users elem2 in users)
            {

                //if (elem.studentId!=elem2.id && elem.CourseId==courseid)
                if (elems.FirstOrDefault(x => x.studentId == elem2.id) == null)
                {
                    specuser.id = elem2.id;
                    specuser.firstName = elem2.firstName;
                    specuser.lastName = elem2.lastName;

                    users1.Add(new Users());
                    users1[count].id = elem2.id;
                    users1[count].firstName = elem2.firstName;
                    users1[count].lastName = elem2.lastName;
                    count++;
                    //foreach (Users elem3 in users1)
                    //{
                    //    if (!(users1.Contains(specuser)))
                    //    {
                    //        users1.Add(new Users());
                    //        users1[count].id = elem2.id;
                    //        users1[count].firstName = elem2.firstName;
                    //        users1[count].lastName = elem2.lastName;
                    //        count++;
                    //    }

                    //}

                }
            }


            //}
            count = 0;
            foreach (Users elem3 in users1)
            {
                comboBox2.Items.Add(elem3.firstName + " " + elem3.lastName);
                usersid.Add(new int());
                usersid[count] = elem3.id;
                count++;
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected2 = comboBox2.SelectedIndex;
            studid = usersid[selected2];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox1.Items.Clear();
            textBox1.Clear();


            foreach (CourseDetails elements in appCourses)
            {
                comboBox1.Items.Add(elements.name + " " + elements.type);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //public bool searchq(int temp)
        //{

        //}

    }
}
