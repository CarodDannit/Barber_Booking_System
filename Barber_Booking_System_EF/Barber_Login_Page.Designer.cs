namespace Barber_Booking_System_EF
{
    partial class Barber_Login_Page
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
            btnUserLoginPage = new Button();
            panel1 = new Panel();
            tbPassword = new TextBox();
            btnBarberLogin = new Button();
            label2 = new Label();
            label3 = new Label();
            tbEmail = new TextBox();
            label1 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnUserLoginPage
            // 
            btnUserLoginPage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUserLoginPage.Location = new Point(743, 550);
            btnUserLoginPage.Margin = new Padding(3, 4, 3, 4);
            btnUserLoginPage.Name = "btnUserLoginPage";
            btnUserLoginPage.Size = new Size(187, 51);
            btnUserLoginPage.TabIndex = 12;
            btnUserLoginPage.Text = "user mode";
            btnUserLoginPage.UseVisualStyleBackColor = true;
            btnUserLoginPage.Click += btnUserLoginPage_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(btnBarberLogin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbEmail);
            panel1.Location = new Point(260, 73);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 527);
            panel1.TabIndex = 11;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(51, 184);
            tbPassword.Margin = new Padding(3, 4, 3, 4);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(340, 30);
            tbPassword.TabIndex = 8;
            tbPassword.Text = "123";
            // 
            // btnBarberLogin
            // 
            btnBarberLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBarberLogin.Location = new Point(165, 444);
            btnBarberLogin.Margin = new Padding(3, 4, 3, 4);
            btnBarberLogin.Name = "btnBarberLogin";
            btnBarberLogin.Size = new Size(109, 51);
            btnBarberLogin.TabIndex = 7;
            btnBarberLogin.Text = "log in";
            btnBarberLogin.UseVisualStyleBackColor = true;
            btnBarberLogin.Click += btnBarberLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 46);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 1;
            label2.Text = "email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 149);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 2;
            label3.Text = "password";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(51, 81);
            tbEmail.Margin = new Padding(3, 4, 3, 4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(340, 30);
            tbEmail.TabIndex = 3;
            tbEmail.Text = "dopymonster@abc";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(415, 10);
            label1.Name = "label1";
            label1.Size = new Size(130, 46);
            label1.TabIndex = 10;
            label1.Text = "Log In";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(545, 40);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 9;
            label5.Text = "for barber";
            // 
            // Barber_Login_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(942, 616);
            Controls.Add(label5);
            Controls.Add(btnUserLoginPage);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Barber_Login_Page";
            Text = "Barber Login Page";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUserLoginPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnBarberLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}