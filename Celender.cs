using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_19
{
    public partial class Celender : Form
    {
        public int id;
        List<CourseDetails> del2;
        public Celender(List<CourseDetails> del1,int id)
        {
            InitializeComponent();
            del2 = del1;
            this.id = id;
            List<Button> newnut = new List<Button>();
            int columnIndex = 0, rowIndex = 0, jump = 0;
            int count = 0;
            foreach (CourseDetails elements in del1)
            {
                
                newnut.Add(new Button());
                newnut[count].Dock = DockStyle.Fill;

                if ((elements.day).Equals("Sunday    "))
                {
                    columnIndex = 1;
                }
                else if (elements.day == "Monday    ")
                {
                    columnIndex = 2;
                }
                else if (elements.day == "Tuesday   ")
                {
                    columnIndex = 3;
                }
                else if (elements.day == "Wednesday ")
                {
                    columnIndex = 4;
                }
                else if (elements.day == "Thursday  ")
                {
                    columnIndex = 5;
                }

                if (elements.start == "08:00     ")
                {
                    rowIndex = 1;
                }
                else if (elements.start == "09:00     ")
                {
                    rowIndex = 2;
                }
                else if (elements.start == "10:00     ")
                {
                    rowIndex = 3;
                }
                else if (elements.start == "11:00     ")
                {
                    rowIndex = 4;
                }
                else if (elements.start == "12:00     ")
                {
                    rowIndex = 5;
                }
                else if (elements.start == "13:00     ")
                {
                    rowIndex = 6;
                }
                else if (elements.start == "14:00     ")
                {
                    rowIndex = 7;
                }
                else if (elements.start == "15:00     ")
                {
                    rowIndex = 8;
                }
                else if (elements.start == "16:00     ")
                {
                    rowIndex = 9;
                }
                else if (elements.start == "17:00     ")
                {
                    rowIndex = 10;
                }
                else if (elements.start == "18:00     ")
                {
                    rowIndex = 11;
                }
                else if (elements.start == "19:00     ")
                {
                    rowIndex = 12;
                }

                if (elements.end == "10:00     ")
                {
                    jump = 3 - rowIndex;
                }
                else if (elements.end == "11:00     ")
                {
                    jump = 4 - rowIndex;
                }
                else if (elements.end == "12:00     ")
                {
                    jump = 5 - rowIndex;
                }
                else if (elements.end == "13:00     ")
                {
                    jump = 6 - rowIndex;
                }
                else if (elements.end == "14:00     ")
                {
                    jump = 7 - rowIndex;
                }
                else if (elements.end == "15:00     ")
                {
                    jump = 8 - rowIndex;
                }
                else if (elements.end == "16:00     ")
                {
                    jump = 9 - rowIndex;
                }
                else if (elements.end == "17:00     ")
                {
                    jump = 10 - rowIndex;
                }
                else if (elements.end == "18:00     ")
                {
                    jump = 11 - rowIndex;
                }
                else if (elements.end == "19:00     ")
                {
                    jump = 12 - rowIndex;
                }
                else if (elements.end == "20:00     ")
                {
                    jump = 13 - rowIndex;
                }
                else if (elements.end == "21:00     ")
                {
                    jump = 14 - rowIndex;
                }
                table1.Controls.Add(newnut[count], columnIndex, rowIndex);
                table1.SetRowSpan(newnut[count], jump);
                newnut[count].Text = "" + elements.name + " " + elements.type + "";
                if (elements.type== "practice  ")
                {
                    newnut[count].BackColor = Color.Yellow;
                    newnut[count].ForeColor = Color.Black;
                }
                else if(elements.type== "Office Hours")
                {
                    newnut[count].BackColor = Color.Fuchsia;
                    newnut[count].ForeColor = Color.Black;
                }
                else
                {
                    newnut[count].BackColor = Color.Coral;
                    newnut[count].ForeColor = Color.Black;
                }
                count++;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            Removelesson re = new Removelesson(user, del2);
            re.Show();
        }

        

        private void Celender_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeLessons change = new ChangeLessons(del2,id);
            change.Show();
        }
    }
}
