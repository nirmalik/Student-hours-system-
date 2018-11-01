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
    public partial class PlacmentTests : Form
    {
        Users users = new Users();
        
        List<CourseDetails> courses = new List<CourseDetails>();
        
        public PlacmentTests()
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
            Tools tools = new Tools(users);
            tools.buildCourse(courses);
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Classes", conn);
            SqlDataReader dr = cmd1.ExecuteReader();
            int count = 0;

            while (dr.Read())
            {
                comboBox4.Items.Add((int)dr["num"]);
                count++;
            }

            dr.Close();
            int temp = 8;
            for(int i = 0; i < 12; i++)
            {
                comboBox3.Items.Add(""+temp+":00");
                temp++;
            }

        }

        private void PlacmentTests_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            foreach(CourseDetails elem in courses)
            {
                if (elem.semester.Equals(comboBox1.Text))
                {
                    comboBox2.Items.Add(elem.name);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            Tools tools = new Tools(users);
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
                conn.Open();
                num = tools.examsnum();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Exams values('" + num + "','" + comboBox2.Text + "','" + textBox1.Text + "','" + comboBox4.Text + "','" + comboBox1.Text + "','" + comboBox3.Text + "')";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Saved");
                this.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("not Saved");
            }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
