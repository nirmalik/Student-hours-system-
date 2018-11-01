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
    public partial class Lecturer_AddLesson : Form
    {
        Users user;
        Form form;
        public Lecturer_AddLesson(Form form,Users user)
        {
            InitializeComponent();
            this.form = form;
            this.user = user;
            string type = "lecture";
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Courses where type= '" + type + "'", conn);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd1;
            DataTable dbdataset = new DataTable();
            sda.Fill(dbdataset);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = dbdataset;
            sda.Update(dbdataset);

            comboBox1.DataSource = dbdataset;
            comboBox1.DisplayMember = "name";
            conn.Close();

            comboBox2.Items.Add("Sunday");
            comboBox2.Items.Add("Monday");
           
            comboBox2.Items.Add("Tuesday");
            comboBox2.Items.Add("Wednesday");
            comboBox2.Items.Add("Thursday");
            comboBox3.Items.Add("08:00");
            comboBox3.Items.Add("09:00");
            comboBox3.Items.Add("10:00");
            comboBox3.Items.Add("11:00");
            comboBox3.Items.Add("12:00");
            comboBox3.Items.Add("13:00");
            comboBox3.Items.Add("14:00");
            comboBox3.Items.Add("15:00");
            comboBox3.Items.Add("16:00");
            comboBox3.Items.Add("17:00");
            comboBox3.Items.Add("18:00");
            comboBox3.Items.Add("19:00");

            comboBox4.Items.Add("10:00");
            comboBox4.Items.Add("11:00");
            comboBox4.Items.Add("12:00");
            comboBox4.Items.Add("13:00");
            comboBox4.Items.Add("14:00");
            comboBox4.Items.Add("15:00");
            comboBox4.Items.Add("16:00");
            comboBox4.Items.Add("17:00");
            comboBox4.Items.Add("18:00");
            comboBox4.Items.Add("19:00");
            comboBox4.Items.Add("20:00");
            comboBox4.Items.Add("21:00");

            comboBox5.Items.Add("lecture");
            comboBox5.Items.Add("practice");
            comboBox5.Items.Add("Office Hours");


        }

        private void Lecturer_AddLesson_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            string str = "none", semester = "";
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Courses WHERE name = '" + comboBox1.Text + "' and type= '" + comboBox5.Text + "'", conn);
            SqlDataReader dr = cmd1.ExecuteReader();
            int count = 0, temp = 0;

            while (dr.Read())
            {
                semester = (string)dr["semester"];
                temp = (int)dr["id"];
            }

            dr.Close();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM lecturerSchedule ", conn);
            SqlDataReader dr1 = cmd2.ExecuteReader();
            
            int count2 = 0;
            List<CourseDetails> course = new List<CourseDetails>();
            while (dr1.Read())
            {
                course.Add(new CourseDetails());
                course[count].day = (string)dr1["Day"];
                course[count].end = (string)dr1["EndTime"];
                course[count].start = (string)dr1["StartTime"];
                course[count].name= (string)dr1["Name"];
                count++;
                count2 = Convert.ToInt32((string)dr1["index"]);
                if (count != count2)
                {
                    break;
                }
            }
            if (count == count2)
            {
                count++;
            }
            dr1.Close();
            int flag = 0;
            try
            {
                foreach(CourseDetails elem in course)
                {
                    (elem.name) = (elem.name).Trim();
                    (elem.day) = (elem.day).Trim();
                    (elem.start) = (elem.start).Trim();
                    (elem.end) = (elem.end).Trim();
                    if (elem.name.Equals(user.firstName) && elem.day.Equals(comboBox2.Text) && ((elem.start.CompareTo(comboBox3.Text) <= 0 && elem.end.CompareTo(comboBox4.Text) >= 0) || (elem.start.CompareTo(comboBox3.Text) >= 0 && elem.start.CompareTo(comboBox4.Text) <= 0)|| (elem.end.CompareTo(comboBox3.Text) >= 0 && elem.end.CompareTo(comboBox4.Text) <= 0)))
                    {
                        MessageBox.Show("you have other lesson at that time");
                        flag = 1;
                        break;
                       
                    }
                }
                if (flag == 0)
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into lecturerSchedule values('" + count.ToString() + "','" + user.firstName + "','" + temp + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + str + "','" + str + "','" + comboBox2.Text + "','" + str + "','" + comboBox5.Text + "','" + user.id + "','" + comboBox1.Text + "','" + semester + "')";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Saved");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Not saved/Check detalis");
            }
            }
            

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
