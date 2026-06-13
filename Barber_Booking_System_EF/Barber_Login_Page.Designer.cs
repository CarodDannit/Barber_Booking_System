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
            btnUserLoginPage.Location = new Point(1114, 825);
            btnUserLoginPage.Margin = new Padding(4, 6, 4, 6);
            btnUserLoginPage.Name = "btnUserLoginPage";
            btnUserLoginPage.Size = new Size(280, 77);
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
            panel1.Location = new Point(390, 109);
            panel1.Margin = new Padding(4, 6, 4, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 791);
            panel1.TabIndex = 11;
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
            // btnBarberLogin
            // 
            btnBarberLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBarberLogin.Location = new Point(248, 666);
            btnBarberLogin.Margin = new Padding(4, 6, 4, 6);
            btnBarberLogin.Name = "btnBarberLogin";
            btnBarberLogin.Size = new Size(164, 77);
            btnBarberLogin.TabIndex = 7;
            btnBarberLogin.Text = "log in";
            btnBarberLogin.UseVisualStyleBackColor = true;
            btnBarberLogin.Click += btnBarberLogin_Click;
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
            // tbEmail
            // 
            tbEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(76, 122);
            tbEmail.Margin = new Padding(4, 6, 4, 6);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(508, 39);
            tbEmail.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(622, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 64);
            label1.TabIndex = 10;
            label1.Text = "Log In";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(818, 60);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(105, 30);
            label5.TabIndex = 9;
            label5.Text = "for barber";
            // 
            // Barber_Login_Page
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(1413, 924);
            Controls.Add(label5);
            Controls.Add(btnUserLoginPage);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(4, 6, 4, 6);
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