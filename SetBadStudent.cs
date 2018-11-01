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
    public partial class SetBadStudent : Form
    {
        public DataGridView Dgv { get; set; }
        Form form;
        string str;
        List<Users> users = new List<Users>();
        int selectedindex;
        Users user = new Users();
        public SetBadStudent(Form form,string str)
        {
            InitializeComponent();
            this.form = form;
            this.str = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sd = "student";

            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Users where job= '" + sd + "'", conn);

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
                    users[count].mail = (string)dr1["mail"];
                   
                    if (!("".Equals(dr1["address"].ToString())))
                    {
                        users[count].address = (string)dr1["address"];
                    }
                    else
                    {
                        users[count].address = "none".ToString();
                    }

                    if (!("".Equals(dr1["phone"].ToString())))
                    {
                        users[count].phone = Convert.ToInt32(dr1["phone"]);
                    }

                    else
                    {
                        users[count].phone = Convert.ToInt32(0);
                    }
                    count++;
                }

                dr1.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("cant show");
            }
            foreach(Users elements in users)
            {
                comboBox1.Items.Add(elements.firstName + " " + elements.lastName);
            }
            //reader.Close();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string empty = "";
            cmd.CommandText = "insert into BadStudents values('" + user.id + "','" + user.firstName + "','" + user.lastName + "','" + user.address + "','" + user.phone + "','" + user.mail + "','" + str + "','" + empty + "','" + empty + "')";

            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Saved");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedindex = comboBox1.SelectedIndex;
            user = users[selectedindex];
        }

        private void SetBadStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
