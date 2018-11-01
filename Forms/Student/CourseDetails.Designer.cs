namespace PROJECT_19.Forms
{
    partial class CourseDetails
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
            this.button1 = new System.Windows.Forms.Button();
            this.lname = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lpass = new System.Windows.Forms.Label();
            this.lpoint = new System.Windows.Forms.Label();
            this.lId = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(150, 440);
            this.button1.Margin = new System.Windows.Forms.Padding(150, 20, 150, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lname
            // 
            this.lname.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lname.Location = new System.Drawing.Point(0, 0);
            this.lname.Margin = new System.Windows.Forms.Padding(0);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(574, 105);
            this.lname.TabIndex = 1;
            this.lname.Text = "label1";
            this.lname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lpass, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lpoint, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lname, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lId, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(574, 529);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lpass
            // 
            this.lpass.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lpass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lpass.Location = new System.Drawing.Point(0, 210);
            this.lpass.Margin = new System.Windows.Forms.Padding(0);
            this.lpass.Name = "lpass";
            this.lpass.Size = new System.Drawing.Size(574, 105);
            this.lpass.TabIndex = 3;
            this.lpass.Text = "label1";
            this.lpass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lpoint
            // 
            this.lpoint.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lpoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpoint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lpoint.Location = new System.Drawing.Point(0, 105);
            this.lpoint.Margin = new System.Windows.Forms.Padding(0);
            this.lpoint.Name = "lpoint";
            this.lpoint.Size = new System.Drawing.Size(574, 105);
            this.lpoint.TabIndex = 2;
            this.lpoint.Text = "label1";
            this.lpoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lId.Location = new System.Drawing.Point(0, 315);
            this.lId.Margin = new System.Windows.Forms.Padding(0);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(574, 105);
            this.lId.TabIndex = 4;
            this.lId.Text = "label1";
            this.lId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CourseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(574, 529);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CourseDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseDetails";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lpoint;
        private System.Windows.Forms.Label lpass;
        private System.Windows.Forms.Label lId;
    }
}