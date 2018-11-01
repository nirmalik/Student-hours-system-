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
    public partial class SecreteryAddLesson : Form
    {
        List<Users> users = new List<Users>();
        List<CourseDetails> course = new List<CourseDetails>();
        public SecreteryAddLesson()
        {
            InitializeComponent();
            string type = "lecturer\r\n";
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Users WHERE job= '" + type + "'", conn);
            SqlDataReader dr = cmd1.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                users.Add(new Users());
                users[count].id = (int)dr["Id"];
                users[count].firstName = (string)dr["firstName"];
                users[count].lastName = (string)dr["lastName"];
                count++;
            }
            dr.Close();
            count = 0;
            foreach (Users elem in users)
            {
                comboBox1.Items.Add(elem.firstName + " " + elem.lastName);
            }
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Courses ", conn);
            SqlDataReader dr1 = cmd2.ExecuteReader();
            while (dr1.Read())
            {
                course.Add(new CourseDetails());
                course[count].semester = (string)dr1["semester"];
                course[count].name = (string)dr1["name"];
                course[count].type = (string)dr1["type"];
                course[count].courseid = (int)dr1["Id"];
                count++;
            }
            foreach (CourseDetails elem in course)
            {
                comboBox2.Items.Add(elem.name + " " + elem.type);
                
            }
            comboBox3.Items.Add("Sunday");
            comboBox3.Items.Add("Monday");

            comboBox3.Items.Add("Tuesday");
            comboBox3.Items.Add("Wednesday");
            comboBox3.Items.Add("Thursday");
            comboBox4.Items.Add("08:00");
            comboBox4.Items.Add("09:00");
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

            comboBox5.Items.Add("10:00");
            comboBox5.Items.Add("11:00");
            comboBox5.Items.Add("12:00");
            comboBox5.Items.Add("13:00");
            comboBox5.Items.Add("14:00");
            comboBox5.Items.Add("15:00");
            comboBox5.Items.Add("16:00");
            comboBox5.Items.Add("17:00");
            comboBox5.Items.Add("18:00");
            comboBox5.Items.Add("19:00");
            comboBox5.Items.Add("20:00");
            comboBox5.Items.Add("21:00");
            dr1.Close();
            conn.Close();
        }
        private void SecreteryAddLesson_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            string str = "none", semester = "";
            int count = 0;
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM lecturerSchedule ", conn);
            SqlDataReader dr1 = cmd2.ExecuteReader();
            int count2 = 0;
            while (dr1.Read())
            {
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
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into lecturerSchedule values('" + count.ToString() + "','" + users[comboBox1.SelectedIndex].firstName + "','" + course[comboBox2.SelectedIndex].courseid + "','" + comboBox4.Text + "','" + comboBox5.Text + "','" + str + "','" + str + "','" + comboBox3.Text + "','" + str + "','" + course[comboBox2.SelectedIndex].type + "','" + users[comboBox1.SelectedIndex].id + "','" + course[comboBox2.SelectedIndex].name + "','" + course[comboBox2.SelectedIndex].semester + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Saved");
        }
    }
}
