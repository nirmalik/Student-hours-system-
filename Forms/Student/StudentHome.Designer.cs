namespace PROJECT_19.Forms
{
    partial class StudentHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.emptyClassesButton = new System.Windows.Forms.Button();
            this.creatSecheduleButton = new System.Windows.Forms.Button();
            this.muSecheduleButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.recHoures = new System.Windows.Forms.Button();
            this.examButton = new System.Windows.Forms.Button();
            this.assignButton = new System.Windows.Forms.Button();
            this.eventHolidays = new System.Windows.Forms.Button();
            this.calender = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.welcomLabel = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 70);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkCyan;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(680, 17);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 14);
            this.toolStripLabel1.Text = "EXIT";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(70, 14);
            this.toolStripLabel2.Text = "LOG OUT";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(42, 14);
            this.toolStripLabel3.Text = "Main";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(196, 68);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // emptyClassesButton
            // 
            this.emptyClassesButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.emptyClassesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emptyClassesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyClassesButton.Location = new System.Drawing.Point(2, 2);
            this.emptyClassesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emptyClassesButton.Name = "emptyClassesButton";
            this.emptyClassesButton.Size = new System.Drawing.Size(190, 62);
            this.emptyClassesButton.TabIndex = 6;
            this.emptyClassesButton.Text = "Empty classes";
            this.emptyClassesButton.UseVisualStyleBackColor = false;
            this.emptyClassesButton.Click += new System.EventHandler(this.emptyClassesButton_Click);
            // 
            // creatSecheduleButton
            // 
            this.creatSecheduleButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.creatSecheduleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.creatSecheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatSecheduleButton.Location = new System.Drawing.Point(196, 2);
            this.creatSecheduleButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.creatSecheduleButton.Name = "creatSecheduleButton";
            this.creatSecheduleButton.Size = new System.Drawing.Size(190, 62);
            this.creatSecheduleButton.TabIndex = 7;
            this.creatSecheduleButton.Text = "Create sechedule";
            this.creatSecheduleButton.UseVisualStyleBackColor = false;
            this.creatSecheduleButton.Click += new System.EventHandler(this.creatSecheduleButton_Click);
            // 
            // muSecheduleButton
            // 
            this.muSecheduleButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.muSecheduleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.muSecheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muSecheduleButton.Location = new System.Drawing.Point(2, 68);
            this.muSecheduleButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.muSecheduleButton.Name = "muSecheduleButton";
            this.muSecheduleButton.Size = new System.Drawing.Size(190, 62);
            this.muSecheduleButton.TabIndex = 8;
            this.muSecheduleButton.Text = "My sechedule";
            this.muSecheduleButton.UseVisualStyleBackColor = false;
            this.muSecheduleButton.Click += new System.EventHandler(this.muSecheduleButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 459);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(680, 87);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.button2, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.recHoures, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.examButton, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.assignButton, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.eventHolidays, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.button1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.creatSecheduleButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.muSecheduleButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.emptyClassesButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.calender, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(50, 143);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(50, 52, 50, 52);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(584, 264);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // recHoures
            // 
            this.recHoures.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.recHoures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recHoures.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recHoures.Location = new System.Drawing.Point(390, 134);
            this.recHoures.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.recHoures.Name = "recHoures";
            this.recHoures.Size = new System.Drawing.Size(192, 62);
            this.recHoures.TabIndex = 13;
            this.recHoures.Text = "Reception Hours";
            this.recHoures.UseVisualStyleBackColor = false;
            this.recHoures.Click += new System.EventHandler(this.recHoures_Click);
            // 
            // examButton
            // 
            this.examButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.examButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.examButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examButton.Location = new System.Drawing.Point(2, 134);
            this.examButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.examButton.Name = "examButton";
            this.examButton.Size = new System.Drawing.Size(190, 62);
            this.examButton.TabIndex = 12;
            this.examButton.Text = "Exams";
            this.examButton.UseVisualStyleBackColor = false;
            this.examButton.Click += new System.EventHandler(this.examButton_Click);
            // 
            // assignButton
            // 
            this.assignButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.assignButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignButton.Location = new System.Drawing.Point(390, 68);
            this.assignButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(192, 62);
            this.assignButton.TabIndex = 10;
            this.assignButton.Text = "Assignments";
            this.assignButton.UseVisualStyleBackColor = false;
            this.assignButton.Click += new System.EventHandler(this.assignButton_Click);
            // 
            // eventHolidays
            // 
            this.eventHolidays.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.eventHolidays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventHolidays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventHolidays.Location = new System.Drawing.Point(390, 2);
            this.eventHolidays.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eventHolidays.Name = "eventHolidays";
            this.eventHolidays.Size = new System.Drawing.Size(192, 62);
            this.eventHolidays.TabIndex = 9;
            this.eventHolidays.Text = "Holidays and Events";
            this.eventHolidays.UseVisualStyleBackColor = false;
            this.eventHolidays.Click += new System.EventHandler(this.eventHolidays_Click);
            // 
            // calender
            // 
            this.calender.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.calender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calender.Location = new System.Drawing.Point(196, 134);
            this.calender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calender.Name = "calender";
            this.calender.Size = new System.Drawing.Size(190, 62);
            this.calender.TabIndex = 11;
            this.calender.Text = "Calender";
            this.calender.UseVisualStyleBackColor = false;
            this.calender.Click += new System.EventHandler(this.calender_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::PROJECT_19.Properties.Resources.attar;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.welcomLabel);
            this.panel3.Controls.Add(this.labelName);
            this.panel3.Location = new System.Drawing.Point(136, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 73);
            this.panel3.TabIndex = 1;
            // 
            // welcomLabel
            // 
            this.welcomLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.welcomLabel.Location = new System.Drawing.Point(8, 14);
            this.welcomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomLabel.Name = "welcomLabel";
            this.welcomLabel.Size = new System.Drawing.Size(259, 29);
            this.welcomLabel.TabIndex = 1;
            this.welcomLabel.Text = "Welcome Student";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(8, 43);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(116, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name : herName";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::PROJECT_19.Properties.Resources.blue_and_white_person_icon_png_clipart_image_iconbug_com_g7EhRd_clipart;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(26, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 73);
            this.panel2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(196, 200);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 62);
            this.button2.TabIndex = 14;
            this.button2.Text = "Send Request ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // StudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 459);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label welcomLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button emptyClassesButton;
        private System.Windows.Forms.Button creatSecheduleButton;
        private System.Windows.Forms.Button muSecheduleButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button eventHolidays;
        private System.Windows.Forms.Button assignButton;
        private System.Windows.Forms.Button calender;
        private System.Windows.Forms.Button examButton;
        private System.Windows.Forms.Button recHoures;
        private System.Windows.Forms.Button button2;
    }
}