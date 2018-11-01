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
    public partial class StudentRegistration : Form
    {
        Form form, form2;
        
        public StudentRegistration(Form form,Form form2)
        {
            InitializeComponent();
            this.form = form;
            this.form2 = form2;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
            form2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //users1.id = Convert.ToInt32(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //users1.firstName = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //users1.lastName = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //users1.userName = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //users1.password = textBox5.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //users1.mail = textBox6.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
           // users1.address = textBox7.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //users1.phone = Convert.ToInt32(textBox8.Text);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
           // users1.entranceTestGrade = textBox9.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string str = "";
            cmd.CommandText = "insert into Registration values('" + Convert.ToInt32(textBox1.Text) + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + Convert.ToInt32(textBox8.Text) + "','" + textBox9.Text +"','"+str+ "')";

            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Saved");
            this.Close();
            form.Show();
        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
