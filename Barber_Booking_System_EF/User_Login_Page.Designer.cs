namespace Barber_Booking_System_EF
{
    partial class User_Login_Page
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lnkUserRegisterAcc = new LinkLabel();
            btnUserLogin = new Button();
            panel1 = new Panel();
            tbPassword = new TextBox();
            tbEmail = new TextBox();
            btnBarberLoginPage = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(425, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 46);
            label1.TabIndex = 0;
            label1.Text = "Log In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 45);
            label2.Margin = new Padding(2, 0, 2, 0);
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
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 2;
            label3.Text = "password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 395);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(163, 20);
            label4.TabIndex = 5;
            label4.Text = "Don't have an account?";
            // 
            // lnkUserRegisterAcc
            // 
            lnkUserRegisterAcc.AutoSize = true;
            lnkUserRegisterAcc.Location = new Point(248, 395);
            lnkUserRegisterAcc.Margin = new Padding(2, 0, 2, 0);
            lnkUserRegisterAcc.Name = "lnkUserRegisterAcc";
            lnkUserRegisterAcc.Size = new Size(115, 20);
            lnkUserRegisterAcc.TabIndex = 6;
            lnkUserRegisterAcc.TabStop = true;
            lnkUserRegisterAcc.Text = "register account";
            lnkUserRegisterAcc.LinkClicked += lnkUserRegisterAcc_LinkClicked;
            // 
            // btnUserLogin
            // 
            btnUserLogin.BackColor = Color.Gold;
            btnUserLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUserLogin.Location = new Point(166, 444);
            btnUserLogin.Margin = new Padding(2, 4, 2, 4);
            btnUserLogin.Name = "btnUserLogin";
            btnUserLogin.Size = new Size(110, 51);
            btnUserLogin.TabIndex = 7;
            btnUserLogin.Text = "log in";
            btnUserLogin.UseVisualStyleBackColor = false;
            btnUserLogin.Click += btnUserLogin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.BlanchedAlmond;
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(btnUserLogin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lnkUserRegisterAcc);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbEmail);
            panel1.Location = new Point(259, 75);
            panel1.Margin = new Padding(2, 4, 2, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 528);
            panel1.TabIndex = 8;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = SystemColors.InactiveCaption;
            tbPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(50, 184);
            tbPassword.Margin = new Padding(2, 4, 2, 4);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(340, 30);
            tbPassword.TabIndex = 8;
            tbPassword.Text = "ahmad";
            // 
            // tbEmail
            // 
            tbEmail.BackColor = SystemColors.InactiveCaption;
            tbEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(50, 81);
            tbEmail.Margin = new Padding(2, 4, 2, 4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(340, 30);
            tbEmail.TabIndex = 3;
            tbEmail.Text = "ahmad@ahmad";
            // 
            // btnBarberLoginPage
            // 
            btnBarberLoginPage.BackColor = Color.Gold;
            btnBarberLoginPage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBarberLoginPage.Location = new Point(742, 549);
            btnBarberLoginPage.Margin = new Padding(2, 4, 2, 4);
            btnBarberLoginPage.Name = "btnBarberLoginPage";
            btnBarberLoginPage.Size = new Size(186, 51);
            btnBarberLoginPage.TabIndex = 9;
            btnBarberLoginPage.Text = "barber mode";
            btnBarberLoginPage.UseVisualStyleBackColor = false;
            btnBarberLoginPage.Click += btnBarberLoginPage_Click;
            // 
            // User_Login_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            ClientSize = new Size(942, 616);
            Controls.Add(btnBarberLoginPage);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(2, 4, 2, 4);
            Name = "User_Login_Page";
            Text = "User Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lnkUserRegisterAcc;
        private System.Windows.Forms.Button btnUserLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnBarberLoginPage;
    }
}

