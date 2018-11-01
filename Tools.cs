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
    public class Tools : Form
    {
        public Users users1 { set; get; }
        public Tools(Users users)
        {

            users1 = users;
        }


        public void ChangePassword()
        {
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            SqlCommand cmddatabase = new SqlCommand("UPDATE Users SET password= '" + users1.password + "' WHERE userName= '" + users1.userName + "'", conn);
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

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Tools
            // 
            this.ClientSize = new System.Drawing.Size(278, 241);
            this.Name = "Tools";
            this.Load += new System.EventHandler(this.Tools_Load);
            this.ResumeLayout(false);

        }

        private void Tools_Load(object sender, EventArgs e)
        {

        }
        public void deleteUsers(string str1)
        {
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Registration where Accepted='" + str1 + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            
            
        }
        public void deletecourses(string str1)
        {
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            
                cmd.CommandText = "delete from lecturerSchedule where [index]='" + str1 + "'";
            
            cmd.ExecuteNonQuery();
            conn.Close();
            System.Windows.Forms.MessageBox.Show("lesson has been deleted");
        }
        public bool buildCourse(List<CourseDetails> temp)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
                conn.Open();
                string type = "lecture";
                string str = "none", semester = "";
                SqlCommand cmd1 = new SqlCommand("SELECT * FROM Courses where type= '" + type + "'", conn);
                SqlDataReader dr = cmd1.ExecuteReader();
                int count = 0;

                while (dr.Read())
                {
                    temp.Add(new CourseDetails());
                    temp[count].semester = (string)dr["semester"];
                    temp[count].name = (string)dr["name"];
                    temp[count].courseid = (int)dr["Id"];
                    count++;
                }

                dr.Close();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }
        public int examsnum()
        {
            int num = 0;
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Exams", conn);
            SqlDataReader dr = cmd1.ExecuteReader();
            int count = 0;

            while (dr.Read())
            {
                
                count++;
            }
            dr.Read();
            conn.Close();
            return count+1;
        }
        
    }
    

}
