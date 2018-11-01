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
    public partial class FinalScore : Form
    {
        public Form final;
        List<CourseDetails> del = new List<CourseDetails>();
        List<GiveGrades> grade = new List<GiveGrades>();
        List<Users> users = new List<Users>();
        List<int> usersIdlist = new List<int>();
        int id, courseid, studentid;
        int onehundred = 100;
        int score;
        double percent, finalscore;
        public FinalScore(Form final)
        {
            InitializeComponent();
            textBox4.Hide();
            label8.Hide();
            this.final = final;
            comboBox1.Items.Add("A1");
            comboBox1.Items.Add("A2");
            comboBox1.Items.Add("A3");
            comboBox1.Items.Add("B1");
            comboBox1.Items.Add("B2");
            comboBox1.Items.Add("B3");
            comboBox1.Items.Add("C1");
            comboBox1.Items.Add("C2");
            comboBox1.Items.Add("C3");
            comboBox1.Items.Add("D1");
            comboBox1.Items.Add("D2");
            comboBox1.Items.Add("D3");

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
            comboBox3.Items.Clear();

            int count = 0;
            foreach (CourseDetails elements in del)
            {

                if (elements.semester == comboBox1.Text)
                {
                    count++;
                    comboBox2.Items.Add(elements.name);

                }

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();

            int count = 0;
            foreach (CourseDetails elements in del)
            {

                if (elements.name == comboBox2.Text)
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
                        comboBox3.Items.Add(elements3.firstName + " " + elements3.lastName);
                        usersIdlist.Add(new int());
                        usersIdlist[count] = elements2.studentId;
                        count++;
                    }
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentid = usersIdlist[comboBox3.SelectedIndex];
            foreach (GiveGrades elements in grade)
            {

                if ((elements.studentId == studentid) && (elements.CourseId == courseid))
                {
                    id = elements.Id;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            final.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            try
            {
                if ((Convert.ToInt32(textBox1.Text) >= 0 && Convert.ToInt32(textBox1.Text) <= 100) &&
                    (Convert.ToInt32(textBox2.Text) >= 0 && Convert.ToInt32(textBox2.Text) <= 100) &&
                    (Convert.ToInt32(textBox3.Text) >= 0 && Convert.ToInt32(textBox3.Text) <= 100))
                {
                    score = Convert.ToInt32(textBox1.Text);
                    percent = (Convert.ToDouble(textBox2.Text) / onehundred);
                    double homework = Convert.ToInt32(textBox3.Text) * (1 - percent);
                    finalscore = score * percent + homework;
                    label8.Show();
                    textBox4.Paste(finalscore.ToString());
                    textBox4.Show();

                    SqlCommand cmddatabase = new SqlCommand("UPDATE Schedule SET testScore=@a1, score=@a2 WHERE Id=@a3", conn);
                    cmddatabase.Parameters.Add("a1", score);
                    cmddatabase.Parameters.Add("a2", finalscore);
                    cmddatabase.Parameters.Add("a3", id);
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
                    textBox4.Clear();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Please enter a valid grade");
                textBox4.Clear();
            }
            conn.Close();
            this.Close();
            final.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            try
            {
                if ((Convert.ToInt32(textBox1.Text) >= 0 && Convert.ToInt32(textBox1.Text) <= 100) &&
                    (Convert.ToInt32(textBox2.Text) >= 0 && Convert.ToInt32(textBox2.Text) <= 100) &&
                    (Convert.ToInt32(textBox3.Text) >= 0 && Convert.ToInt32(textBox3.Text) <= 100))
                {
                    score = Convert.ToInt32(textBox1.Text);
                    percent = (Convert.ToDouble(textBox2.Text) / onehundred);
                    double homework = Convert.ToInt32(textBox3.Text) * (1 - percent);
                    finalscore = score * percent + homework;
                    label8.Show();
                    textBox4.Paste(finalscore.ToString());
                    textBox4.Show();

                    SqlCommand cmddatabase = new SqlCommand("UPDATE Schedule SET testScore=@a1, score=@a2 WHERE Id=@a3", conn);
                    cmddatabase.Parameters.Add("a1", score);
                    cmddatabase.Parameters.Add("a2", finalscore);
                    cmddatabase.Parameters.Add("a3", id);
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
                    textBox4.Clear();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Please enter a valid grade");
                textBox4.Clear();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FinalScore_Load(object sender, EventArgs e)
        {

        }
    }
}
