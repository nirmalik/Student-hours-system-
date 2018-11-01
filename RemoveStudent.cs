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
   
    public partial class RemoveStudent : Form
    {
        Form form;
        public DataGridView Dgv { get; set; }
        List<Users> users = new List<Users>();
        int selectedindex;
        Users user = new Users();
        public RemoveStudent(Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM BadStudents ", conn);

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
                //comboBox1.DataSource = dbdataset;
                //comboBox1.DisplayMember = "userName";
                SqlDataReader dr1 = cmd1.ExecuteReader();
                int count = 0;

                while (dr1.Read())
                {
                    users.Add(new Users());
                    users[count].id = Convert.ToInt32(dr1["Id"]);
                    users[count].firstName = (string)dr1["firstName"];
                    users[count].lastName = (string)dr1["lastName"];
                    count++;
                }

                dr1.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("cant show");
            }
            foreach (Users elements in users)
            {
                comboBox1.Items.Add(elements.firstName + " " + elements.lastName);
            }
            //reader.Close();
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedindex = comboBox1.SelectedIndex;
            user = users[selectedindex];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from BadStudents where Id='" + user.id + "'";
                cmd.ExecuteNonQuery();


                SqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "delete from Users where Id='" + user.id + "'";
                cmd1.ExecuteNonQuery();

                SqlCommand cmd2 = conn.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "delete from Schedule where Id='" + user.id + "'";
                cmd2.ExecuteNonQuery();

                conn.Close();
                System.Windows.Forms.MessageBox.Show("User succesfully deleted");
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("cant delete");
            }

        }
    }
}
