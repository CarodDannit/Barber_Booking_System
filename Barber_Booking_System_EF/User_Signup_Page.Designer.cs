namespace Barber_Booking_System_EF
{
    partial class User_Signup_Page
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
            btnBarberLoginPage = new Button();
            panel1 = new Panel();
            tbPassword = new TextBox();
            label6 = new Label();
            tbPhone = new TextBox();
            label5 = new Label();
            tbUsername = new TextBox();
            btnUserSignup = new Button();
            label2 = new Label();
            lnkUserLoginAcc = new LinkLabel();
            label3 = new Label();
            label4 = new Label();
            tbEmail = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBarberLoginPage
            // 
            btnBarberLoginPage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBarberLoginPage.Location = new Point(714, 634);
            btnBarberLoginPage.Margin = new Padding(3, 4, 3, 4);
            btnBarberLoginPage.Name = "btnBarberLoginPage";
            btnBarberLoginPage.Size = new Size(187, 51);
            btnBarberLoginPage.TabIndex = 18;
            btnBarberLoginPage.Text = "barber mode";
            btnBarberLoginPage.UseVisualStyleBackColor = true;
            btnBarberLoginPage.Click += btnBarberLoginPage_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(tbPhone);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(btnUserSignup);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lnkUserLoginAcc);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbEmail);
            panel1.Location = new Point(253, 74);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 626);
            panel1.TabIndex = 17;
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
            // btnUserSignup
            // 
            btnUserSignup.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUserSignup.Location = new Point(171, 560);
            btnUserSignup.Margin = new Padding(3, 4, 3, 4);
            btnUserSignup.Name = "btnUserSignup";
            btnUserSignup.Size = new Size(110, 51);
            btnUserSignup.TabIndex = 7;
            btnUserSignup.Text = "sign up";
            btnUserSignup.UseVisualStyleBackColor = true;
            btnUserSignup.Click += btnUserSignup_Click;
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
            // lnkUserLoginAcc
            // 
            lnkUserLoginAcc.AutoSize = true;
            lnkUserLoginAcc.Location = new Point(289, 519);
            lnkUserLoginAcc.Name = "lnkUserLoginAcc";
            lnkUserLoginAcc.Size = new Size(52, 20);
            lnkUserLoginAcc.TabIndex = 6;
            lnkUserLoginAcc.TabStop = true;
            lnkUserLoginAcc.Text = "sign in";
            lnkUserLoginAcc.LinkClicked += lnkUserLoginAcc_LinkClicked;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 519);
            label4.Name = "label4";
            label4.Size = new Size(178, 20);
            label4.TabIndex = 5;
            label4.Text = "Already have an account?";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(50, 81);
            tbEmail.Margin = new Padding(3, 4, 3, 4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(340, 30);
            tbEmail.TabIndex = 3;
            tbEmail.TextChanged += tbEmail_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(394, 11);
            label1.Name = "label1";
            label1.Size = new Size(162, 46);
            label1.TabIndex = 16;
            label1.Text = "Sign Up";
            // 
            // User_Signup_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Lime;
            ClientSize = new Size(942, 616);
            Controls.Add(btnBarberLoginPage);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "User_Signup_Page";
            Text = "Sign Up";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBarberLoginPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btnUserSignup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkUserLoginAcc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label1;
    }
}