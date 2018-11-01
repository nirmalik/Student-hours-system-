using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Connections;

namespace PROJECT_19.Forms
{
    public partial class SecertarySetCreatingDate : Form
    {
        string [] startdate,endDate;
        public SecertarySetCreatingDate()
        {
            InitializeComponent();
            DateTime today = DateTime.Today;
            startdate= (today.ToShortDateString()).Split('/');
            endDate= (today.ToShortDateString()).Split('/');
        }

        private void Set_Click(object sender, EventArgs e)
        {
            if (int.Parse(endDate[0]) != int.Parse(startdate[0]))
            {
                MessageBox.Show("the start and end days must be in the same month");
            }
            else if (int.Parse(endDate[1]) < int.Parse(startdate[1]))
            {
                MessageBox.Show("the end day can't be before the start day!");
            }
            else
            {
                DBConnect.setCreatingDate(startdate, endDate);
                MessageBox.Show("Done!");
                this.Close();
            }
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            startdate = (monthCalendar.SelectionRange.Start.ToShortDateString()).Split('/');
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            endDate= (monthCalendar1.SelectionRange.Start.ToShortDateString()).Split('/');
        }
    }
}
