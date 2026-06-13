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
            btnBarbersignup = new Button();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(622, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 64);
            label1.TabIndex = 0;
            label1.Text = "Log In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(68, 69);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 32);
            label2.TabIndex = 1;
            label2.Text = "email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(68, 223);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(135, 32);
            label3.TabIndex = 2;
            label3.Text = "password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(144, 592);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(232, 30);
            label4.TabIndex = 5;
            label4.Text = "Don't have an account?";
            // 
            // lnkUserRegisterAcc
            // 
            lnkUserRegisterAcc.AutoSize = true;
            lnkUserRegisterAcc.Location = new Point(372, 592);
            lnkUserRegisterAcc.Margin = new Padding(4, 0, 4, 0);
            lnkUserRegisterAcc.Name = "lnkUserRegisterAcc";
            lnkUserRegisterAcc.Size = new Size(162, 30);
            lnkUserRegisterAcc.TabIndex = 6;
            lnkUserRegisterAcc.TabStop = true;
            lnkUserRegisterAcc.Text = "register account";
            lnkUserRegisterAcc.LinkClicked += lnkUserRegisterAcc_LinkClicked;
            // 
            // btnUserLogin
            // 
            btnUserLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUserLogin.Location = new Point(248, 666);
            btnUserLogin.Margin = new Padding(4, 6, 4, 6);
            btnUserLogin.Name = "btnUserLogin";
            btnUserLogin.Size = new Size(164, 77);
            btnUserLogin.TabIndex = 7;
            btnUserLogin.Text = "log in";
            btnUserLogin.UseVisualStyleBackColor = true;
            btnUserLogin.Click += btnUserLogin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(btnUserLogin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lnkUserRegisterAcc);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbEmail);
            panel1.Location = new Point(390, 111);
            panel1.Margin = new Padding(4, 6, 4, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 791);
            panel1.TabIndex = 8;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(76, 276);
            tbPassword.Margin = new Padding(4, 6, 4, 6);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(508, 39);
            tbPassword.TabIndex = 8;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(76, 122);
            tbEmail.Margin = new Padding(4, 6, 4, 6);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(508, 39);
            tbEmail.TabIndex = 3;
            // 
            // btnBarberLoginPage
            // 
            btnBarberLoginPage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBarberLoginPage.Location = new Point(1113, 825);
            btnBarberLoginPage.Margin = new Padding(4, 6, 4, 6);
            btnBarberLoginPage.Name = "btnBarberLoginPage";
            btnBarberLoginPage.Size = new Size(280, 77);
            btnBarberLoginPage.TabIndex = 9;
            btnBarberLoginPage.Text = "barber mode";
            btnBarberLoginPage.UseVisualStyleBackColor = true;
            btnBarberLoginPage.Click += btnBarberLoginPage_Click;
            // 
            // btnBarbersignup
            // 
            btnBarbersignup.Location = new Point(69, 258);
            btnBarbersignup.Margin = new Padding(3, 4, 3, 4);
            btnBarbersignup.Name = "btnBarbersignup";
            btnBarbersignup.Size = new Size(270, 86);
            btnBarbersignup.TabIndex = 11;
            btnBarbersignup.Text = "BARBER SIGN UUUP";
            btnBarbersignup.UseVisualStyleBackColor = true;
            btnBarbersignup.Click += btnBarbersignup_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1105, 298);
            label5.Name = "label5";
            label5.Size = new Size(106, 30);
            label5.TabIndex = 12;
            label5.Text = "EF version";
            // 
            // User_Login_Page
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(1412, 924);
            Controls.Add(label5);
            Controls.Add(btnBarbersignup);
            Controls.Add(btnBarberLoginPage);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(4, 6, 4, 6);
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
        private System.Windows.Forms.Button btnBarbersignup;
        private Label label5;
    }
}

