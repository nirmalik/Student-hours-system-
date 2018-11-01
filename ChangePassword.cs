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
    

    public partial class ChangePassword : Form
    {
        Users users1;
        Form obj1;
        public ChangePassword(Form obj,Users users)
        {
            InitializeComponent();
            users1 = users;
            obj1 = obj;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            obj1.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == users1.password)
            {
                if (textBox2.Text == textBox3.Text)
                {
                    users1.password = textBox2.Text;
                    Tools tool = new Tools(users1);
                    tool.ChangePassword();
                    this.Close();
                    obj1.Show();

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("new passwords unidentical");
                }
                
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Old password is wrong");
            }
            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
