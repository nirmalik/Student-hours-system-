using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THEUSERS;
using Connections;

namespace PROJECT_19.Forms
{
    public partial class chooseStudent : Form
    {
        public chooseStudent()
        {
            InitializeComponent();
        }

        
        private void chooseStudent_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" )
            {
                button1.Enabled = true;
            }
            else
                button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = DBConnect.selectUser("Id", textBox1.Text);

            if(user!=null)
            {
                if (user.getJob() == Job.Student)
                {
                    Form open = new SecertaryCreatShedule(user);
                    this.Hide();
                    open.Show();
                }
                else
                {
                    MessageBox.Show("This user isn't Student!");
                }
            }
            else
            {
                MessageBox.Show("This user isn't exist in the system!");
            }
        }
    }
}
