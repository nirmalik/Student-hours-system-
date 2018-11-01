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
    public partial class Secretary_department_schedule : Form
    {
        // Secretery_department sec_dep;
        Form sec_dep;
        public Secretary_department_schedule(Form sec_dep)
        {
            InitializeComponent();
            this.sec_dep = sec_dep;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecreteryAddLesson se = new SecreteryAddLesson();
            se.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            sec_dep.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            List<CourseDetails> del = new List<CourseDetails>();
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM lecturerSchedule ", conn);
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
                del[count].semester = (string)dr["Semester"];
                count++;
            }
            SecreteryCelender se = new SecreteryCelender(del);
            se.Show();
            
        }
    }
}
