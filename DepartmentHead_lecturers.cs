﻿using System;
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
    public partial class DepartmentHead_lecturers : Form
    {
        DepartmentHead head;
        public DepartmentHead_lecturers(DepartmentHead head)
        {
            InitializeComponent();
            this.head = head;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            head.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowTable show1 = new ShowTable(this, head, "lecturer\r\n");
            show1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
