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
    public partial class Lecturer_grades : Form
    {
        Lecturer lec;
        public Lecturer_grades(Lecturer lec)
        {
            InitializeComponent();
            this.lec = lec;
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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TestScore test = new TestScore(this);
            this.Hide();
            test.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FinalScore final = new FinalScore(this);
            this.Hide();
            final.Show();
        }
    }
}
