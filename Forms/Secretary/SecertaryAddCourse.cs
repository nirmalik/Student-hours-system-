using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Courses;
using Connections;

namespace PROJECT_19.Forms
{
    public partial class SecertaryAddCourse : Form
    {
        string name, semester,type;
        int passGrade=56, points;
      

        public SecertaryAddCourse()
        {
            InitializeComponent();
            trackBar1.Maximum = 70;
            trackBar1.Minimum = 56;
            string [] a = { "A","B" };

            ComboboxItem item;

            for (int i=0;i<2;i++)
            {
                for(int j=1;j<5;j++)
                {
                    item = new ComboboxItem(a[i] + j, i);
                    comboBox1.Items.Add(item);
                   
                }
            }

            comboBox2.Items.Add(new ComboboxItem("0", 0));
            comboBox2.Items.Add(new ComboboxItem("4", 0));
            comboBox2.Items.Add(new ComboboxItem("5", 0));
            comboBox2.Items.Add(new ComboboxItem("6", 0));

            comboBox4.Items.Add(new ComboboxItem("lecture", 0));
            comboBox4.Items.Add(new ComboboxItem("practice", 0));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
            if(textBox1.Text!="" && comboBox1.SelectedItem!=null && comboBox4.SelectedItem != null && comboBox4.SelectedItem != null)
                button1.Enabled = true;           
            else
                button1.Enabled = false;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            type = ((ComboboxItem)comboBox4.SelectedItem).Text.ToString();
            if (textBox1.Text != "" && comboBox1.SelectedItem != null && comboBox4.SelectedItem != null && comboBox4.SelectedItem != null)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Course> courses = DBConnect.getAllCoursesPlus();
            int id = courses[courses.Count -1].getId();
            DBConnect.addCourse(id+1,name,semester,type,points,passGrade);
            MessageBox.Show("The Course "+name+" was added successfully");
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            points = int.Parse(((ComboboxItem)comboBox2.SelectedItem).Text.ToString());
            if (textBox1.Text != "" && comboBox1.SelectedItem != null && comboBox4.SelectedItem != null && comboBox4.SelectedItem != null)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            semester = ((ComboboxItem)comboBox1.SelectedItem).Text.ToString();
            if (textBox1.Text != "" && comboBox1.SelectedItem != null && comboBox4.SelectedItem != null && comboBox4.SelectedItem != null)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label4.Text = trackBar1.Value.ToString();
            passGrade = Int32.Parse(label4.Text);
        }
    }
}
