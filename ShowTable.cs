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
    public partial class ShowTable : Form
    {
        public DataGridView Dgv { get; set; }
        Form form,form2;
        string job1;
        
        public ShowTable( Form form,Form form2,string job)
        {
            InitializeComponent();
            this.form = form;
            this.form2 = form2;
            job1 = job;
            comboBox1.Items.Add("Id");
            comboBox1.Items.Add("First Name");
            comboBox1.Items.Add("Last Name");

        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
            form2.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sd = "student";
            
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Users where job= '"+job1+"'", conn);
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
                
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("cant show");
            }
            conn.Close();
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

        private void ShowTable_Load(object sender, EventArgs e)
        {

        }

        public void search(string choose,string name)
        {
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand();
            if (choose=="Id")
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
                if (cmd1.Parameters.Count == 0)
                {
                    System.Windows.Forms.MessageBox.Show("user not found");
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("cant show");
            }
            conn.Close();
        }
        
    }
}
