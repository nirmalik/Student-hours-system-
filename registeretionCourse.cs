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
    public partial class registeretionCourse : Form
    {
        int count = 0;
        public registeretionCourse()
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
            comboBox2.Items.Add("lecture");
            comboBox2.Items.Add("practice");
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Courses", conn);
            SqlDataReader dr = cmd1.ExecuteReader();
            

            while (dr.Read())
            {
                
                count= (int)dr["Id"];
            }

            dr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=""&& comboBox1.Text!=""&& Convert.ToInt32(textBox2.Text) <= 6 && textBox3.Text!=""&& comboBox2.Text!="")
            {
                SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                count++;
                cmd.CommandText = "insert into Courses values('" + count + "','" + textBox1.Text + "','" + textBox3.Text + "','" + null + "','" + textBox2.Text + "','" + comboBox2.Text + "','" + null + "','" + comboBox1.Text + "')";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Saved");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill all details");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void registeretionCourse_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
