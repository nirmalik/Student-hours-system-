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
    
    public partial class ShowTableEdit : Form
    {
        public DataGridView Dgv { get; set; }
        Form form, form2;
        public Users users = new Users();
        string job1;

        public ShowTableEdit(Form form, Form form2,string job)
        {
            InitializeComponent();
            this.form = form;
            this.form2 = form2;
            job1 = job;
            comboBox1.Items.Add("Id");
            comboBox1.Items.Add("First Name");
            comboBox1.Items.Add("Last Name");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sd = "student";

            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Users where job= '" + job1 + "'", conn);

            try
            {

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd1;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbdataset;
                this.dataGridView1.DataSource = bsource;
                sda.Update(dbdataset);
                comboBox2.DataSource = dbdataset;
                comboBox2.DisplayMember = "userName";
               
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("cant show");
            }
            //reader.Close();
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    search("Id", textBox1.Text);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    search("First Name", textBox1.Text);
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    search("Last Name", textBox1.Text);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("please choose option");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("please fill details");
            }
        }
        public void search(string choose, string name)
        {
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            if (choose == "Id")
            {
                cmd1 = new SqlCommand("SELECT * FROM Users WHERE Id = '" + name + "' and job= '" + job1 + "'", conn);

            }
            if (choose == "First Name")
            {
                cmd1 = new SqlCommand("SELECT * FROM Users WHERE FirstName = '" + name + "' and job= '" + job1 + "'", conn);

            }
            if (choose == "Last Name")
            {
                cmd1 = new SqlCommand("SELECT * FROM Users WHERE LastName = '" + name + "' and job= '" + job1 + "'", conn);

            }
            SqlDataReader reader;
            try
            {

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd1;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbdataset;
                this.dataGridView1.DataSource = bsource;
                sda.Update(dbdataset);
                comboBox2.DataSource = dbdataset;
                comboBox2.DisplayMember = "userName";

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("cant show");
            }
            conn.Close();
        }

  

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            if (comboBox2.SelectedIndex >= 0)
            {
                cmd1 = new SqlCommand("SELECT * FROM Users WHERE userName = '" + comboBox2.Text+  "'" , conn);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                
         

                while (dr1.Read())
                {
                    //   (string)dr1["id"]
                    users.id = (int)dr1["id"];
                    users.firstName = (string)dr1["firstName"];
                    users.lastName = (string)dr1["lastName"];
                    users.userName = (string)dr1["userName"];
                    users.password = (string)dr1["password"];
                    users.mail = (string)dr1["mail"];

                    if (!("".Equals(dr1["address"].ToString())))
                    {
                        users.address = (string)dr1["address"];
                    }
                    else
                    {
                        users.address = "none".ToString();
                    }
                    if (!("".Equals(dr1["phone"].ToString())))
                    {
                        users.phone = Convert.ToInt32(dr1["phone"]);
                    }
                   
                    else
                    {
                        users.phone = Convert.ToInt32(0);
                    }
                    users.job = (string)dr1["job"];
                }
                dr1.Close();
                EditingUser ed = new EditingUser(users,this,form2);
                ed.Show();
                this.Hide();

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("choose an user");
            }
            conn.Close();
        }
    }
}
