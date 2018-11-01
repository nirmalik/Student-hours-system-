using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace PROJECT_19
{
    public partial class Files : Form
    {
        public object Locale { get; private set; }

        public Files()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Files ", conn);
            SqlDataReader reader;

            try
            {

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd1;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbdataset;
                this.dataGridView1.Columns[0].Name = "Open";
                this.dataGridView1.DataSource = bsource;

                sda.Update(dbdataset);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("cant show");
            }
            conn.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg;.*PDF)|*.jpeg;*.bmp;*.png;*.jpg;*.PDF";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = open.FileName;
            }
        }

        private void Files_Load(object sender, EventArgs e)
        {

        }
       
    }
}
