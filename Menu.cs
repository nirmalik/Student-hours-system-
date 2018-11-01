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
//using PROJECT_19.Models;



namespace PROJECT_19
{
    public partial class Menu : Form
    {
        conncection conn;
        string name;
        string password;
        private readonly object massgebox;

        public Menu()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.sce.ac.il");
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string job = null;
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Users WHERE userName = '" + textBox1.Text+ "'", conn);
            SqlCommand cmd = new SqlCommand("SELECT userName,password FROM Users WHERE userName = '" + textBox1.Text+ "' and password= '" + textBox2.Text+ "'",conn);
            
            SqlDataReader dr;
            SqlDataReader dr1;
            dr = cmd.ExecuteReader();
            int count=0;
            while (dr.Read())
            {
                count+=1;
               
            }
            if (count == 1)
            {
                dr.Close();
                dr1 = cmd1.ExecuteReader();
                Users users = new Users();
                
                while (dr1.Read())
                {
                 //   (string)dr1["id"]
                    users.id = (int)dr1["id"];
                    users.firstName = (string)dr1["firstName"];
                    users.lastName = (string)dr1["lastName"];
                    users.userName = (string)dr1["userName"];
                    users.password = (string)dr1["password"];
                    users.mail = (string)dr1["mail"];
                    users.job = (string)dr1["job"];
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


                    job = (string)dr1["job"];
                }
                dr1.Close();
                if (job == "lecturer"||job== "lecturer\r\n") 
                {
                    this.Hide();
                    Lecturer lecturer = new Lecturer(this,users);
                    lecturer.Show();
                    

                }
                if(job == "Secretery department" || job== "Secretery department\r\n")
                {
                    this.Hide();
                    Secretery_department secretery = new Secretery_department(this,users);
                    secretery.Show();
                }
                if(job== "Department head"||job== "Department head\r\n")
                {
                    this.Hide();
                    DepartmentHead head = new DepartmentHead(this,users);
                    head.Show();
                }
                if(job== "Student administration"||job== "Student administration\r\n")
                {
                    this.Hide();
                    StudentAdministration admin = new StudentAdministration(this,users);
                    admin.Show();
         
                }

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("the user does not exist");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            password = Console.ReadLine();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = Console.ReadLine();
        }
    }
}
