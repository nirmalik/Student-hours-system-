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
    public partial class Removelesson : Form
    {
        
        string index;
        Users user2;
        List<CourseDetails> del3;
        public Removelesson(Users user1, List<CourseDetails> del2)
        {
            InitializeComponent();
            
            del3 = del2;
            user2 = user1;
            foreach(CourseDetails elements in del2)
            {
                    comboBox1.Items.Add(elements.name+" "+elements.type);  
            }
        }

        private void Removelesson_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (del3[comboBox1.SelectedIndex].approved == "true")
            {
                SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
                conn.Open();
                SqlCommand cmddatabase = new SqlCommand("UPDATE lecturerSchedule SET Approved=@a1 WHERE [index]=@a2", conn);
                cmddatabase.Parameters.AddWithValue("@a1","remove");
                cmddatabase.Parameters.AddWithValue("@a4", index);
                System.Windows.Forms.MessageBox.Show("your request sended to department secretary");
            }
            else if (del3[comboBox1.SelectedIndex].approved=="remove")
            {
                System.Windows.Forms.MessageBox.Show("your already request to remove this lesson");
            }
            else
            {
                Tools tools = new Tools(user2);
                tools.deletecourses(index);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.index = del3[comboBox1.SelectedIndex].index;
        }
    }
}
