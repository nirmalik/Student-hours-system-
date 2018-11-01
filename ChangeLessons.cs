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
    public partial class ChangeLessons : Form
    {
        int count=0;
        public int id;
        string name;
        string type;
        string index;
        List<CourseDetails> del1;
        public ChangeLessons(List<CourseDetails> del2,int id)
        {
            InitializeComponent();
            del1 = del2;
            this.id = id; 
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

            foreach(CourseDetails elements in del2)
            {
                comboBox1.Items.Add(elements.name+elements.type);
                count++;
            }
        }

        private void ChangeLessons_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            textBox1.Paste(del1[comboBox1.SelectedIndex].day);
            textBox2.Paste(del1[comboBox1.SelectedIndex].start);
            textBox3.Paste(del1[comboBox1.SelectedIndex].end);
            name = del1[comboBox1.SelectedIndex].name;
            type = del1[comboBox1.SelectedIndex].type;
            index = del1[comboBox1.SelectedIndex].index;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            if (comboBox2.Text!=""&&comboBox3.Text!=""&&comboBox4.Text!="")
            {
                
                SqlCommand cmddatabase = new SqlCommand("UPDATE lecturerSchedule SET Day=@a1 , StartTime=@a2 , EndTime=@a3,Approved=@a5 WHERE [index]=@a4", conn);
                cmddatabase.Parameters.AddWithValue("@a1", comboBox2.Text);
                cmddatabase.Parameters.AddWithValue("@a2", comboBox3.Text);
                cmddatabase.Parameters.AddWithValue("@a3", comboBox4.Text);
                cmddatabase.Parameters.AddWithValue("@a4",index);
                cmddatabase.Parameters.AddWithValue("@a5", "");
                cmddatabase.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Saved");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("please fill all details");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
