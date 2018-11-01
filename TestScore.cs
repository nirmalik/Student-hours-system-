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
    public partial class TestScore : Form
    {
        public Form test;
        List<CourseDetails> del = new List<CourseDetails>();
        List<GiveGrades> grade = new List<GiveGrades>();
        List<Users> users = new List<Users>();
        List<int> usersIdlist = new List<int>();
        int id,courseid,studentid;
        int score;
        public TestScore(Form test)
        {
            InitializeComponent();
            this.test = test;
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
            string type = "lecture";
            string job = "student";
            string str = "none", semester = "";
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Courses where type= '" + type + "'", conn);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            int count = 0, temp = 0;

            while (dr1.Read())
            {
                del.Add(new CourseDetails());
                del[count].semester = (string)dr1["semester"];
                del[count].name = (string)dr1["name"];
                del[count].courseid = (int)dr1["Id"];
                count++;
            }

            dr1.Close();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Users where job= '" + job + "'", conn);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            count = 0; 

            while (dr2.Read())
            {
                users.Add(new Users());
                users[count].id = (int)dr2["Id"];
                users[count].firstName = (string)dr2["firstName"];
                users[count].lastName = (string)dr2["lastName"];
                count++;
            }

            dr2.Close();

            SqlCommand cmd3 = new SqlCommand("SELECT * FROM Schedule ", conn);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            count = 0;

            while (dr3.Read())
            {
                grade.Add(new GiveGrades());
                grade[count].Id = (int)dr3["Id"];
                grade[count].studentId = (int)dr3["studentId"];
                grade[count].CourseId = (int)dr3["couseId"];
                count++;
            }

            dr3.Close();
            
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            int count = 0;
            foreach (CourseDetails elements in del)
            {

                if (elements.name == comboBox1.Text)
                {
                    courseid = elements.courseid;
                }
            }
            
            foreach (GiveGrades elements2 in grade)
            {
                foreach (Users elements3 in users)
                {
                    if ((elements2.studentId == elements3.id) && (elements2.CourseId == courseid))
                    {
                        comboBox2.Items.Add(elements3.firstName + " " + elements3.lastName);
                        usersIdlist.Add(new int());
                        usersIdlist[count] = elements2.studentId;
                        count++;
                    }
                }       
            }

        }
        

        private void TestScore_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentid = usersIdlist[comboBox2.SelectedIndex];
            foreach (GiveGrades elements in grade)
            {

                if ((elements.studentId == studentid) && (elements.CourseId==courseid))
                {
                    id = elements.Id;
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();

            int count = 0;
            foreach (CourseDetails elements in del)
            {

                if (elements.semester == comboBox3.Text)
                {
                    count++;
                    comboBox1.Items.Add(elements.name);
                    
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            test.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            try
            {
                if (Convert.ToInt32(textBox1.Text) >= 0 && Convert.ToInt32(textBox1.Text) <= 100)
                {
                    SqlCommand cmddatabase = new SqlCommand("UPDATE Schedule SET testScore=@a1  WHERE Id=@a2", conn);
                    cmddatabase.Parameters.Add("a1", Convert.ToInt32(textBox1.Text));
                    cmddatabase.Parameters.Add("a2", id);
                    cmddatabase.ExecuteNonQuery();
                    SqlDataReader reader;
                    try
                    {
                        reader = cmddatabase.ExecuteReader();
                        System.Windows.Forms.MessageBox.Show("Saved");
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("not Saved");
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Please enter a valid grade");
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Please enter a valid grade");
            }
            conn.Close();
            this.Close();
            test.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            try
            {
                if (Convert.ToInt32(textBox1.Text) >= 0 && Convert.ToInt32(textBox1.Text) <= 100)
                {
                    SqlCommand cmddatabase = new SqlCommand("UPDATE Schedule SET testScore=@a1  WHERE Id=@a2", conn);
                    cmddatabase.Parameters.Add("a1", Convert.ToInt32(textBox1.Text));
                    cmddatabase.Parameters.Add("a2", id);
                    cmddatabase.ExecuteNonQuery();
                    SqlDataReader reader;
                    try
                    {
                        reader = cmddatabase.ExecuteReader();
                        System.Windows.Forms.MessageBox.Show("Saved");
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("not Saved");
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Please enter a valid grade");
                }
            }catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Please enter a valid grade");
            }
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
