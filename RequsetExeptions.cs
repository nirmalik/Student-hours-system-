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
    
    public partial class RequsetExeptions : Form
    {
        public DataGridView Dgv { get; set; }
        string type1 = "student";
        List<Users> ba = new List<Users>();
        List<CourseDetails> ce = new List<CourseDetails>();
        string firstname,lastname, semester;

        
        public RequsetExeptions()
        {
            InitializeComponent();
            comboBox3.Items.Add("A1");
            comboBox3.Items.Add("A2");
            comboBox3.Items.Add("A3");
            comboBox3.Items.Add("B1");
            comboBox3.Items.Add("B2");
            comboBox3.Items.Add("B3");
            comboBox3.Items.Add("C1");
            comboBox3.Items.Add("C2");
            comboBox3.Items.Add("C3");
            comboBox3.Items.Add("D1");
            comboBox3.Items.Add("D2");
            comboBox3.Items.Add("D3");
            int count = 0;
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Users Where job= '" + type1 + "'", conn);
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
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Courses ", conn);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            count = 0;
            while (dr2.Read())
            {
                ce.Add(new CourseDetails());
                ce[count].courseid = (int)dr2["Id"];
                ce[count].name = (string)dr2["name"];
                ce[count].semester = (string)dr2["semester"];
                ce[count].type = (string)dr2["type"];
                comboBox2.Items.Add(ce[count].name);
                count++;

            }
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0, temp = 0; ;
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Exeptions", conn);
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                count++;
                temp = (int)dr["Index"];
                if (count != temp)
                {
                    break;
                }
            }
            if (count == temp)
            {
                count++;
            }
            dr.Close();
            try
            {
 
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                
                cmd.CommandText = "insert into Exeptions values('" + count + "','" + ba[comboBox1.SelectedIndex].firstName + "','" + ba[comboBox1.SelectedIndex].lastName + "','" + ce[comboBox2.SelectedIndex].courseid + "','" + comboBox2.Text + "','" + null + "')";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("cant show");
            }
            conn.Close();
            MessageBox.Show("Saved");
            this.Close();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Users Where job= '" + type1 + "'", conn);
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
            this.Close(); 
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            semester = comboBox3.Text;
            comboBox2.Items.Clear();
            foreach (CourseDetails elem in ce)
            {
                if (elem.semester.Equals(semester)&&elem.type.Equals("lecture"))
                {
                    comboBox2.Items.Add(elem.name);
                }
            }
        }
        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
