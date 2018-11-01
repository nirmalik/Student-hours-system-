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
    public partial class PlacementClasses : Form
    {
        string selectedIndex, name, type, day, start, end,courseid;
        public Form form;
        List<CourseDetails> del = new List<CourseDetails>();
        List<CourseDetail2> del2 = new List<CourseDetail2>();
        List<int> integerlist = new List<int>();
        int courseid2;
        

        public PlacementClasses(Form form)
        {
            
            InitializeComponent();
            this.form = form;
            string str = "true";
            label6.Hide();
            textBox1.Hide();

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
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM lecturerSchedule where Approved= '" + str + "'", conn);
            SqlDataReader dr = cmd1.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                del.Add(new CourseDetails());
                del[count].start = (string)dr["StartTime"];
                del[count].end = (string)dr["EndTime"];
                del[count].name = (string)dr["CourseName"];
                del[count].type = (string)dr["Type"];
                del[count].day = (string)dr["Day"];
                del[count].index = (string)dr["index"];
                del[count].semester = (string)dr["Semester"];
                del[count].courseid = Convert.ToInt32(dr["CourseId"]);
                count++;
            }
            dr.Close();

            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Schedule ", conn);
            SqlDataReader dr1 = cmd2.ExecuteReader();
            count = 0;
            while (dr1.Read())
            {
                del2.Add(new CourseDetail2());
                
                del2[count].time = (string)dr1["time"];
                del2[count].courseId = (int)dr1["couseId"];
                del2[count].day = (string)dr1["day"];
                del2[count].Id = (int)dr1["Id"];

                count++;
            }

            dr1.Close();
            conn.Close();
            foreach(CourseDetails elements in del)
            {
                (elements.semester)=(elements.semester).Trim();
                (elements.day) = (elements.day).Trim();
                (elements.start) = (elements.start).Trim();
                (elements.end) = (elements.end).Trim();
            }
         

        }

        private void PlacementClasses_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            SqlCommand cmddatabase = new SqlCommand("UPDATE lecturerSchedule SET Room=@a1  WHERE [index]=@a2", conn);
            cmddatabase.Parameters.Add("a1", comboBox4.Text);
            cmddatabase.Parameters.Add("a2", selectedIndex);

            cmddatabase.ExecuteNonQuery();

            SqlDataReader reader;
            try
            {
                reader = cmddatabase.ExecuteReader();
                System.Windows.Forms.MessageBox.Show("Set a room to lesson");
                reader.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("not Saved");
            }
            

            string sub1 = start.Substring(0, 2);
            string sub2 = end.Substring(0, 2);
            string newtime = (sub1 + ":" + sub2);
            int room = Convert.ToInt32(comboBox4.Text);
            //int count = 0;
            //foreach(CourseDetail2 elements in del2)
            //{
            //    if((courseid.Equals(elements.courseId)) && (newtime.Equals(elements.time)) && (day.Equals(elements.day)))
            //    {
            //        integerlist.Add(new int());
            //        integerlist[count]=elements.Id;
            //        count++;
            //    }
            //}
            //foreach (int element in integerlist)
            //{
                SqlCommand cmddatabase2 = new SqlCommand("UPDATE Schedule SET room=@a1 WHERE couseId=@a2 AND time=@a3 AND day=@a4", conn);
                cmddatabase2.Parameters.Add("a1", room);
                cmddatabase2.Parameters.Add("a2", courseid2 );
                cmddatabase2.Parameters.Add("a3", newtime);
                cmddatabase2.Parameters.Add("a4", day);
                cmddatabase2.ExecuteNonQuery();

            //}

            SqlDataReader reader2;
            try
            {
                reader2 = cmddatabase2.ExecuteReader();
                //System.Windows.Forms.MessageBox.Show("Set a room to lesson");
                reader2.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("not Saved");
            }

            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox4.Items.Clear();
            label6.Hide();
            textBox1.Hide();
            foreach(CourseDetails elements in del)
            {
                if((elements.semester).Equals(comboBox1.Text))
                {
                    comboBox2.Items.Add(elements.name + " " + elements.type);
                    name = elements.name;
                    type = elements.type;
                    //courseid2 =elements.courseid;
                    
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox4.Items.Clear();
            label6.Show();
            textBox1.Show();
            textBox1.Paste(del[comboBox2.SelectedIndex].day + ":" + del[comboBox2.SelectedIndex].start + "- " + del[comboBox2.SelectedIndex].end);
            day = del[comboBox2.SelectedIndex].day;
            start = del[comboBox2.SelectedIndex].start;
            end = del[comboBox2.SelectedIndex].end;
            courseid2 = del[comboBox2.SelectedIndex].courseid;
            string[] str = { "10", "11" ,"12","13", "14","15","16","17","18","19"};
  
            foreach (string elements in str)
            {
                comboBox4.Items.Add(elements);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(CourseDetails elements in del)
            {
                if(elements.name.Equals(name) && elements.type.Equals(type) && elements.day.Equals(day)
                    && elements.start.Equals(start) && elements.end.Equals(end))
                    {
                    selectedIndex = elements.index;
                    }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
