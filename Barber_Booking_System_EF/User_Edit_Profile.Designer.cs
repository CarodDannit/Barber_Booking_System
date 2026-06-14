namespace Barber_Booking_System_EF
{
    partial class User_Edit_Profile
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
            panel1 = new Panel();
            tbPassword = new TextBox();
            label6 = new Label();
            tbPhone = new TextBox();
            label5 = new Label();
            tbUsername = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tbEmail = new TextBox();
            btnUpdate = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(tbPhone);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbEmail);
            panel1.Location = new Point(251, 80);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 626);
            panel1.TabIndex = 18;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(54, 389);
            tbPassword.Margin = new Padding(3, 4, 3, 4);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(340, 30);
            tbPassword.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(49, 354);
            label6.Name = "label6";
            label6.Size = new Size(96, 25);
            label6.TabIndex = 11;
            label6.Text = "password";
            // 
            // tbPhone
            // 
            tbPhone.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPhone.Location = new Point(50, 286);
            tbPhone.Margin = new Padding(3, 4, 3, 4);
            tbPhone.Name = "tbPhone";
            tbPhone.PasswordChar = '*';
            tbPhone.Size = new Size(340, 30);
            tbPhone.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(46, 251);
            label5.Name = "label5";
            label5.Size = new Size(94, 25);
            label5.TabIndex = 9;
            label5.Text = "phone no";
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(51, 184);
            tbUsername.Margin = new Padding(3, 4, 3, 4);
            tbUsername.Name = "tbUsername";
            tbUsername.PasswordChar = '*';
            tbUsername.Size = new Size(340, 30);
            tbUsername.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 46);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 1;
            label2.Text = "email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 149);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 2;
            label3.Text = "username";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(50, 81);
            tbEmail.Margin = new Padding(3, 4, 3, 4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(340, 30);
            tbEmail.TabIndex = 3;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(150, 528);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 43);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(315, 24);
            label1.Name = "label1";
            label1.Size = new Size(317, 41);
            label1.TabIndex = 19;
            label1.Text = "Edit Your Profile here";
            // 
            // User_Edit_Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Lime;
            ClientSize = new Size(942, 541);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "User_Edit_Profile";
            Text = "User_Edit_Profile";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnUpdate;
        private TextBox tbPassword;
        private Label label6;
        private TextBox tbPhone;
        private Label label5;
        private TextBox tbUsername;
        private Label label2;
        private Label label3;
        private TextBox tbEmail;
        private Label label1;
    }
}