using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROJECT_19
{
    public partial class cancelCourse : Form
    {
        List<CourseDetails> ce = new List<CourseDetails>();
        public cancelCourse()
        {
            InitializeComponent();
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
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Courses ", conn);
            SqlDataReader dr = cmd1.ExecuteReader();
            int count = 0, temp = 0;


            while (dr.Read())
            {
                ce.Add(new CourseDetails());
                ce[count].name = (string)dr["name"];
                ce[count].courseid = (int)dr["Id"];
                ce[count].semester = (string)dr["semester"];

                count++;
            }

            dr.Close();
            conn.Close();

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            int count = 0;
            foreach (CourseDetails elements in ce)
            {

                if (elements.semester.CompareTo(comboBox1.Text) == 0)
                {
                    count++;
                    comboBox2.Items.Add(elements.name);

                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
                conn.Open();
                SqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "delete from Courses where name='" + comboBox2.Text + "'";
                cmd1.ExecuteNonQuery();

                conn.Close();
                System.Windows.Forms.MessageBox.Show("Course succesfully deleted");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("cant Delete");
            }

        }

        private void cancelCourse_Load(object sender, EventArgs e)
        {

        }
    }
}
