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
    public partial class Lecturer_lessons : Form
    {
        Lecturer lec;
        Users user1;

        public Lecturer_lessons(Lecturer lec, Users user)
        {
            InitializeComponent();
            this.lec = lec;
            user1 = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            lec.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lecturer_AddLesson add = new Lecturer_AddLesson(this, user1);
            add.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<CourseDetails> del = new List<CourseDetails>();
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM lecturerSchedule where id= '" + user1.id + "'", conn);
            SqlDataReader dr = cmd1.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                del.Add(new CourseDetails());
                del[count].start = (string)dr["StartTime"];
                del[count].end = (string)dr["EndTime"];
                del[count].name = (string)dr["CourseName"];
                del[count].type = (string)dr["Type"];
                del[count].day = (string)dr["Day"];
                del[count].index = (string)dr["index"];
                del[count].approved = (string)dr["Approved"];
                count++;
            }
            Celender cel = new Celender(del,user1.id);
            cel.Show();
        }

        private void Celender_Click(object sender, EventArgs e)
        {
            
           
        }
    }
}
