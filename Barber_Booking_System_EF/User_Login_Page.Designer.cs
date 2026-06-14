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
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(363, 8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 37);
            label1.TabIndex = 0;
            label1.Text = "Log In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 34);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 112);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 296);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 5;
            label4.Text = "Don't have an account?";
            // 
            // lnkUserRegisterAcc
            // 
            lnkUserRegisterAcc.AutoSize = true;
            lnkUserRegisterAcc.Location = new Point(217, 296);
            lnkUserRegisterAcc.Margin = new Padding(2, 0, 2, 0);
            lnkUserRegisterAcc.Name = "lnkUserRegisterAcc";
            lnkUserRegisterAcc.Size = new Size(92, 15);
            lnkUserRegisterAcc.TabIndex = 6;
            lnkUserRegisterAcc.TabStop = true;
            lnkUserRegisterAcc.Text = "register account";
            lnkUserRegisterAcc.LinkClicked += lnkUserRegisterAcc_LinkClicked;
            // 
            // btnUserLogin
            // 
            btnUserLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUserLogin.Location = new Point(145, 333);
            btnUserLogin.Margin = new Padding(2, 3, 2, 3);
            btnUserLogin.Name = "btnUserLogin";
            btnUserLogin.Size = new Size(96, 38);
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
            panel1.Location = new Point(227, 56);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 396);
            panel1.TabIndex = 8;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(44, 138);
            tbPassword.Margin = new Padding(2, 3, 2, 3);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(298, 26);
            tbPassword.TabIndex = 8;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(44, 61);
            tbEmail.Margin = new Padding(2, 3, 2, 3);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(298, 26);
            tbEmail.TabIndex = 3;
            // 
            // btnBarberLoginPage
            // 
            btnBarberLoginPage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBarberLoginPage.Location = new Point(649, 412);
            btnBarberLoginPage.Margin = new Padding(2, 3, 2, 3);
            btnBarberLoginPage.Name = "btnBarberLoginPage";
            btnBarberLoginPage.Size = new Size(163, 38);
            btnBarberLoginPage.TabIndex = 9;
            btnBarberLoginPage.Text = "barber mode";
            btnBarberLoginPage.UseVisualStyleBackColor = true;
            btnBarberLoginPage.Click += btnBarberLoginPage_Click;
            // 
            // btnBarbersignup
            // 
            btnBarbersignup.Location = new Point(40, 129);
            btnBarbersignup.Margin = new Padding(2, 2, 2, 2);
            btnBarbersignup.Name = "btnBarbersignup";
            btnBarbersignup.Size = new Size(158, 43);
            btnBarbersignup.TabIndex = 11;
            btnBarbersignup.Text = "BARBER SIGN UUUP";
            btnBarbersignup.UseVisualStyleBackColor = true;
            btnBarbersignup.Click += btnBarbersignup_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(645, 149);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 12;
            label5.Text = "EF version";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(35, 374);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(163, 38);
            button1.TabIndex = 13;
            button1.Text = "barber mode";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // User_Login_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(824, 462);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(btnBarbersignup);
            Controls.Add(btnBarberLoginPage);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(2, 3, 2, 3);
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
        private Button button1;
    }
}

