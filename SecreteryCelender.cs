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
    public partial class SecreteryCelender : Form
    {
        List<CourseDetails> course;
        List<Button> newnut = new List<Button>();
        List<Button> temp = new List<Button>();
        string index;
        string name1;
        public SecreteryCelender(List<CourseDetails> courses)
        {
           
            
            InitializeComponent();
            course = courses;
            comboBox1.Items.Add("A1");
            comboBox1.Items.Add("A2");
            comboBox1.Items.Add("A3");
            comboBox1.Items.Add("B1");
            comboBox1.Items.Add("B2");
            comboBox1.Items.Add("B3");
            comboBox1.Items.Add("C1");
            comboBox1.Items.Add("C2");
            comboBox1.Items.Add("C3");
            comboBox1.Items.Add("D1");
            comboBox1.Items.Add("D2");
            comboBox1.Items.Add("D3");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SecreteryCelender_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fill(comboBox1.Text+ "        ");
        }
        public void fill(string choose)
        {

            this.table1.RowStyles.Clear();
            table1.Controls.Clear();
            comboBox2.Items.Clear();
            this.restarttable();
            int columnIndex = 0, rowIndex = 0, jump = 0;
            int count = 0;
            foreach (CourseDetails elements in course)
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
               
                if (elements.semester == choose)
                {
                    table1.Controls.Add(newnut[count], columnIndex, rowIndex);
                    table1.SetRowSpan(newnut[count], jump);
                    newnut[count].Text = "" + elements.name + " " + elements.type + "";
                
                    if (elements.type == "practice  ")
                    {
                        newnut[count].BackColor = Color.Yellow;
                        newnut[count].ForeColor = Color.Black;
                    }
                    else if (elements.type == "Office Hours")
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
                    comboBox2.Items.Add(elements.name+" "+elements.type);
                    name1 = elements.index;
                }


                

            }
           
        }
        public void restarttable()
        {
            
            // 
            // table1
            // 
            this.table1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.table1.ColumnCount = 8;
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.table1.Controls.Add(this.label2, 0, 2);
            this.table1.Controls.Add(this.label3, 0, 3);
            this.table1.Controls.Add(this.label4, 0, 4);
            this.table1.Controls.Add(this.label5, 0, 5);
            this.table1.Controls.Add(this.label6, 0, 6);
            this.table1.Controls.Add(this.label7, 0, 7);
            this.table1.Controls.Add(this.label9, 0, 9);
            this.table1.Controls.Add(this.label8, 0, 8);
            this.table1.Controls.Add(this.label10, 0, 10);
            this.table1.Controls.Add(this.label11, 0, 11);
            this.table1.Controls.Add(this.label12, 0, 12);
            this.table1.Controls.Add(this.label14, 2, 0);
            this.table1.Controls.Add(this.label15, 3, 0);
            this.table1.Controls.Add(this.label16, 4, 0);
            this.table1.Controls.Add(this.label17, 5, 0);
            this.table1.Controls.Add(this.label18, 7, 0);
            this.table1.Controls.Add(this.label19, 6, 0);
            this.table1.Controls.Add(this.label13, 1, 0);
            this.table1.Controls.Add(this.label1, 0, 1);
            this.table1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.table1.Location = new System.Drawing.Point(26, 12);
            this.table1.Name = "table1";
            this.table1.RowCount = 13;
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table1.Size = new System.Drawing.Size(531, 303);
            this.table1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "09:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "10:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(3, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "11:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(3, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "12:00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(3, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "13:00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(3, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "14:00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(3, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "16:00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(3, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "15:00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(3, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "17:00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.Location = new System.Drawing.Point(3, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "18:00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.Location = new System.Drawing.Point(3, 273);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "19:00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label14.Location = new System.Drawing.Point(135, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 15);
            this.label14.TabIndex = 13;
            this.label14.Text = "Monday";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label15.Location = new System.Drawing.Point(201, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 15);
            this.label15.TabIndex = 14;
            this.label15.Text = "Tuesday";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label16.Location = new System.Drawing.Point(267, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 23);
            this.label16.TabIndex = 15;
            this.label16.Text = "Wednesday";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label17.Location = new System.Drawing.Point(333, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 15);
            this.label17.TabIndex = 16;
            this.label17.Text = "Thursday";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label18.Location = new System.Drawing.Point(465, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 15);
            this.label18.TabIndex = 17;
            this.label18.Text = "Saturday";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label19.Location = new System.Drawing.Point(399, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 15);
            this.label19.TabIndex = 18;
            this.label19.Text = "Friday";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.Location = new System.Drawing.Point(69, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 15);
            this.label13.TabIndex = 12;
            this.label13.Text = "Sunday";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "08:00";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(582, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(582, 99);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Approve";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(598, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Remove lesson";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(598, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SecreteryCelender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 327);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.table1);
            this.Name = "SecreteryCelender";
            this.Text = "SecreteryCelender";
            this.Load += new System.EventHandler(this.SecreteryCelender_Load);
            this.table1.ResumeLayout(false);
            this.table1.PerformLayout();
            this.ResumeLayout(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=scedata.database.windows.net; Initial Catalog = Branch_B; Persist Security Info = True; User ID = scedata; Password = Shadi1234");
            conn.Open();
            SqlCommand cmddatabase = new SqlCommand("UPDATE lecturerSchedule SET Approved=@a1 WHERE [index]=@a2", conn);
            cmddatabase.Parameters.AddWithValue("@a1", "true");
            cmddatabase.Parameters.AddWithValue("@a2", index);

            cmddatabase.ExecuteNonQuery();
            
            conn.Close();
            MessageBox.Show("Saved");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            index = course[comboBox2.SelectedIndex].index;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            Tools tool = new Tools(new Users());
            //int index2=Convert.ToInt32(index) + 1;
            
            tool.deletecourses(name1);
        }

        private void table1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
