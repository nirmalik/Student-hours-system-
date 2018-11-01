namespace PROJECT_19.Forms
{
    partial class Password
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.menuButton = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.confirmBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newPassBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.oldPssBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorMsg = new System.Windows.Forms.Label();
            this.doneLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.CadetBlue;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.menuButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(684, 35);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Image = global::PROJECT_19.Properties.Resources.images;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 32);
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(70, 32);
            this.toolStripLabel2.Text = "LOG OUT";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // menuButton
            // 
            this.menuButton.Image = global::PROJECT_19.Properties.Resources.הורד;
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(32, 32);
            this.menuButton.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.confirmBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.newPassBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.oldPssBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(239, 139);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 220);
            this.panel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(72, 173);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // confirmBox
            // 
            this.confirmBox.Location = new System.Drawing.Point(30, 137);
            this.confirmBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirmBox.Name = "confirmBox";
            this.confirmBox.Size = new System.Drawing.Size(158, 20);
            this.confirmBox.TabIndex = 5;
            this.confirmBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirm Password : ";
            // 
            // newPassBox
            // 
            this.newPassBox.Location = new System.Drawing.Point(30, 91);
            this.newPassBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newPassBox.Name = "newPassBox";
            this.newPassBox.Size = new System.Drawing.Size(158, 20);
            this.newPassBox.TabIndex = 3;
            this.newPassBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Password : ";
            // 
            // oldPssBox
            // 
            this.oldPssBox.Location = new System.Drawing.Point(30, 44);
            this.oldPssBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.oldPssBox.Name = "oldPssBox";
            this.oldPssBox.Size = new System.Drawing.Size(158, 20);
            this.oldPssBox.TabIndex = 1;
            this.oldPssBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Password : ";
            // 
            // errorMsg
            // 
            this.errorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMsg.ForeColor = System.Drawing.Color.Maroon;
            this.errorMsg.Location = new System.Drawing.Point(236, 54);
            this.errorMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(212, 31);
            this.errorMsg.TabIndex = 8;
            this.errorMsg.Text = "Please check you input password";
            this.errorMsg.Visible = false;
            // 
            // doneLabel
            // 
            this.doneLabel.AutoSize = true;
            this.doneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneLabel.ForeColor = System.Drawing.Color.Green;
            this.doneLabel.Location = new System.Drawing.Point(309, 85);
            this.doneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.doneLabel.Name = "doneLabel";
            this.doneLabel.Size = new System.Drawing.Size(45, 15);
            this.doneLabel.TabIndex = 9;
            this.doneLabel.Text = "Done!";
            this.doneLabel.Visible = false;
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 459);
            this.ControlBox = false;
            this.Controls.Add(this.doneLabel);
            this.Controls.Add(this.errorMsg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Password";
            this.Text = "Password";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel menuButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox confirmBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newPassBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oldPssBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorMsg;
        private System.Windows.Forms.Label doneLabel;
    }
}