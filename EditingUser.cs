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
    public partial class EditingUser : Form
    {
        Users users1;
        Form form,form2;
        public EditingUser(Users users,Form form,Form form2)
        {
            InitializeComponent();
            users1 = users;
            this.form = form;
            this.form2 = form2;
            textBox1.Paste(users1.firstName);
            textBox2.Paste(users1.lastName);
            textBox4.Paste(users1.password);
            textBox5.Paste(users1.mail);
            //if (!("NULL".Equals(users1.address.GetType())))
            //{
                textBox6.Paste(users1.address);
            //}
            //if (!("NULL".Equals(users1.phone.GetType())))
            //{
                textBox7.Paste(users1.phone.ToString());
            //}
            
            
        }

        private void EditingUser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            users1.firstName = textBox1.Text;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            users1.lastName = textBox2.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            users1.password = textBox4.Text;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            users1.mail = textBox5.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            users1.address = textBox6.Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            users1.phone = Convert.ToInt32(textBox7.Text);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            SqlCommand cmddatabase = new SqlCommand("UPDATE Users SET firstName=@a1 , lastName=@a2 , password=@a3 , mail=@a4 , address=@a5 , phone=@a6 WHERE userName=@a7", conn);
            cmddatabase.Parameters.Add("a1", users1.firstName);
            cmddatabase.Parameters.Add("a2", users1.lastName);
            cmddatabase.Parameters.Add("a3", users1.password);
            cmddatabase.Parameters.Add("a4", users1.mail);
            cmddatabase.Parameters.Add("a5", users1.address);
            cmddatabase.Parameters.Add("a6", users1.phone);
            cmddatabase.Parameters.Add("a7", users1.userName);
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
            conn.Close();
            form.Close();
            form2.Show();
            this.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
            form2.Show();
        }
    }
}
