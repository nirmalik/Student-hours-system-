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
    public partial class HandelingRequset : Form
    {
        List<Users> ba = new List<Users>();
        public HandelingRequset()
        {
            InitializeComponent();
            int count = 0;
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Exeptions", conn);
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                ba.Add(new Users());
                ba[count].firstName = (string)dr["firstName"];
                ba[count].lastName = (string)dr["lastName"];
                comboBox1.Items.Add(ba[count].firstName + " " + ba[count].lastName);
                count++;
            }
            dr.Close();
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Exeptions", conn);
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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            string temp = "false";
            int temp2 = comboBox1.SelectedIndex + 1;
            SqlCommand cmddatabase = new SqlCommand("UPDATE Exeptions SET aprooved= '" + temp + "' WHERE [Index]= '" + temp2 + "'", conn);
            SqlDataReader reader;
            try
            {

                reader = cmddatabase.ExecuteReader();
                System.Windows.Forms.MessageBox.Show("Saved");
                while (reader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("not Saved");
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            string temp = "true";
            int temp2 = comboBox1.SelectedIndex + 1;
            SqlCommand cmddatabase = new SqlCommand("UPDATE Exeptions SET aprooved = '" + temp + "' WHERE [Index]= '" + temp2 + "'", conn);
            SqlDataReader reader;
            try
            {
                reader = cmddatabase.ExecuteReader();
                System.Windows.Forms.MessageBox.Show("Saved");

                while (reader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("not Saved");
            }
            conn.Close();
        }
    }
}
