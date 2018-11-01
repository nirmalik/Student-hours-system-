namespace PROJECT_19.Forms.SecretaryManager
{
    partial class AddSecretary
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.exitButton = new System.Windows.Forms.ToolStripLabel();
            this.logOutButton = new System.Windows.Forms.ToolStripLabel();
            this.menuButton = new System.Windows.Forms.ToolStripLabel();
            this.errMsg = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1368, 1045);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1368, 209);
            this.panel1.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1368, 209);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkCyan;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitButton,
            this.logOutButton,
            this.menuButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(1368, 41);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // exitButton
            // 
            this.exitButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitButton.Image = global::PROJECT_19.Properties.Resources.images;
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(32, 38);
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(132, 38);
            this.logOutButton.Text = "LOG OUT";
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.Image = global::PROJECT_19.Properties.Resources.הורד;
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(32, 38);
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // errMsg
            // 
            this.errMsg.AutoSize = true;
            this.errMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.errMsg.ForeColor = System.Drawing.Color.DarkRed;
            this.errMsg.Location = new System.Drawing.Point(458, 0);
            this.errMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errMsg.Name = "errMsg";
            this.errMsg.Size = new System.Drawing.Size(446, 166);
            this.errMsg.TabIndex = 14;
            this.errMsg.Text = "Please check the inputs";
            this.errMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errMsg.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.Controls.Add(this.userName, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.id, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.email, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.lastName, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.firstName, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.password, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.address, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.add, 0, 7);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(454, 166);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 8;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(454, 498);
            this.tableLayoutPanel4.TabIndex = 13;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.add.Location = new System.Drawing.Point(4, 439);
            this.add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(204, 54);
            this.add.TabIndex = 19;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(4, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 52);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(4, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 52);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(4, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 52);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(4, 253);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 52);
            this.label4.TabIndex = 7;
            this.label4.Text = "User Name : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlText;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(4, 315);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 52);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlText;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(4, 377);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 52);
            this.label8.TabIndex = 10;
            this.label8.Text = "Address : ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // address
            // 
            this.address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.address.Location = new System.Drawing.Point(216, 377);
            this.address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(204, 52);
            this.address.TabIndex = 12;
            // 
            // password
            // 
            this.password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.password.Location = new System.Drawing.Point(216, 315);
            this.password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(204, 52);
            this.password.TabIndex = 13;
            // 
            // firstName
            // 
            this.firstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.firstName.Location = new System.Drawing.Point(216, 5);
            this.firstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstName.Multiline = true;
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(204, 52);
            this.firstName.TabIndex = 14;
            // 
            // lastName
            // 
            this.lastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lastName.Location = new System.Drawing.Point(216, 67);
            this.lastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastName.Multiline = true;
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(204, 52);
            this.lastName.TabIndex = 15;
            // 
            // email
            // 
            this.email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.email.Location = new System.Drawing.Point(216, 129);
            this.email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(204, 52);
            this.email.TabIndex = 16;
            // 
            // id
            // 
            this.id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.id.Location = new System.Drawing.Point(216, 191);
            this.id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(204, 52);
            this.id.TabIndex = 17;
            // 
            // userName
            // 
            this.userName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.userName.Location = new System.Drawing.Point(216, 253);
            this.userName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userName.Multiline = true;
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(204, 52);
            this.userName.TabIndex = 18;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.errMsg, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 212);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1362, 830);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // AddSecretary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 1045);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddSecretary";
            this.Text = "AddSecretary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel exitButton;
        private System.Windows.Forms.ToolStripLabel logOutButton;
        private System.Windows.Forms.ToolStripLabel menuButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label errMsg;
    }
}