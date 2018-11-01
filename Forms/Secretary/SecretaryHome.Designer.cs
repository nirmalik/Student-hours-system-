namespace PROJECT_19.Forms
{
    partial class SecretaryHome
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.welcomLabel = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.changePassButton = new System.Windows.Forms.Button();
            this.editCourses = new System.Windows.Forms.Button();
            this.CreatSchedule = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sechedulButtonA = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 100);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::PROJECT_19.Properties.Resources.attar;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.welcomLabel);
            this.panel3.Controls.Add(this.labelName);
            this.panel3.Location = new System.Drawing.Point(110, 11);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 73);
            this.panel3.TabIndex = 1;
            // 
            // welcomLabel
            // 
            this.welcomLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.welcomLabel.Location = new System.Drawing.Point(7, 15);
            this.welcomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomLabel.Name = "welcomLabel";
            this.welcomLabel.Size = new System.Drawing.Size(259, 29);
            this.welcomLabel.TabIndex = 1;
            this.welcomLabel.Text = "Welcome Secretary";
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
            this.panel2.Location = new System.Drawing.Point(26, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 73);
            this.panel2.TabIndex = 0;
            // 
            // changePassButton
            // 
            this.changePassButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.changePassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassButton.Location = new System.Drawing.Point(283, 78);
            this.changePassButton.Margin = new System.Windows.Forms.Padding(2);
            this.changePassButton.Name = "changePassButton";
            this.changePassButton.Size = new System.Drawing.Size(278, 71);
            this.changePassButton.TabIndex = 8;
            this.changePassButton.Text = "Change Password";
            this.changePassButton.UseVisualStyleBackColor = false;
            this.changePassButton.Click += new System.EventHandler(this.changePassButton_Click);
            // 
            // editCourses
            // 
            this.editCourses.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.editCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCourses.Location = new System.Drawing.Point(2, 78);
            this.editCourses.Margin = new System.Windows.Forms.Padding(2);
            this.editCourses.Name = "editCourses";
            this.editCourses.Size = new System.Drawing.Size(277, 71);
            this.editCourses.TabIndex = 9;
            this.editCourses.Text = "Add Course";
            this.editCourses.UseVisualStyleBackColor = false;
            this.editCourses.Click += new System.EventHandler(this.editCourses_Click);
            // 
            // CreatSchedule
            // 
            this.CreatSchedule.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CreatSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatSchedule.Location = new System.Drawing.Point(283, 2);
            this.CreatSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.CreatSchedule.Name = "CreatSchedule";
            this.CreatSchedule.Size = new System.Drawing.Size(278, 71);
            this.CreatSchedule.TabIndex = 10;
            this.CreatSchedule.Text = "Creat Student Schedule";
            this.CreatSchedule.UseVisualStyleBackColor = false;
            this.CreatSchedule.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(37, 22);
            this.exitButton.Text = "EXIT";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(70, 22);
            this.toolStripLabel2.Text = "LOG OUT";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel3.Text = "Main";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.CadetBlue;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitButton,
            this.toolStripLabel2,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(643, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CreatSchedule, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.editCourses, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.changePassButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.sechedulButtonA, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(36, 154);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(563, 228);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button3.Location = new System.Drawing.Point(284, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(276, 70);
            this.button3.TabIndex = 12;
            this.button3.Text = "Students";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 69);
            this.button1.TabIndex = 9;
            this.button1.Text = "Set Scheduling Time";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // sechedulButtonA
            // 
            this.sechedulButtonA.BackColor = System.Drawing.Color.LightCoral;
            this.sechedulButtonA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sechedulButtonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sechedulButtonA.Location = new System.Drawing.Point(3, 155);
            this.sechedulButtonA.Name = "sechedulButtonA";
            this.sechedulButtonA.Size = new System.Drawing.Size(275, 70);
            this.sechedulButtonA.TabIndex = 11;
            this.sechedulButtonA.Text = "Schedule";
            this.sechedulButtonA.UseVisualStyleBackColor = false;
            this.sechedulButtonA.Click += new System.EventHandler(this.sechedulButtonA_Click);
            // 
            // SecretaryHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 562);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "SecretaryHome";
            this.ShowIcon = false;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.SecretaryHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label welcomLabel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button changePassButton;
        private System.Windows.Forms.Button editCourses;
        private System.Windows.Forms.Button CreatSchedule;
        private System.Windows.Forms.ToolStripLabel exitButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sechedulButtonA;
        private System.Windows.Forms.Button button3;
    }
}