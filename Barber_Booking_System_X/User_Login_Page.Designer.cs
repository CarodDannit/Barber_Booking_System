namespace Barber_Booking_System
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
            userRegisterAccLnk = new LinkLabel();
            userLogInBtn = new Button();
            panel1 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
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
            label2.Location = new Point(69, 69);
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
            label3.Location = new Point(69, 223);
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
            // userRegisterAccLnk
            // 
            userRegisterAccLnk.AutoSize = true;
            userRegisterAccLnk.Location = new Point(372, 592);
            userRegisterAccLnk.Margin = new Padding(4, 0, 4, 0);
            userRegisterAccLnk.Name = "userRegisterAccLnk";
            userRegisterAccLnk.Size = new Size(162, 30);
            userRegisterAccLnk.TabIndex = 6;
            userRegisterAccLnk.TabStop = true;
            userRegisterAccLnk.Text = "register account";
            userRegisterAccLnk.LinkClicked += registerUserAccLnk_LinkClicked;
            // 
            // userLogInBtn
            // 
            userLogInBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userLogInBtn.Location = new Point(248, 664);
            userLogInBtn.Margin = new Padding(4, 6, 4, 6);
            userLogInBtn.Name = "userLogInBtn";
            userLogInBtn.Size = new Size(165, 77);
            userLogInBtn.TabIndex = 7;
            userLogInBtn.Text = "log in";
            userLogInBtn.UseVisualStyleBackColor = true;
            userLogInBtn.Click += userLogInBtn_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(userLogInBtn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(userRegisterAccLnk);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(390, 111);
            panel1.Margin = new Padding(4, 6, 4, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 791);
            panel1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(76, 276);
            textBox2.Margin = new Padding(4, 6, 4, 6);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(508, 39);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(75, 122);
            textBox1.Margin = new Padding(4, 6, 4, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(508, 39);
            textBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(1114, 825);
            button2.Margin = new Padding(4, 6, 4, 6);
            button2.Name = "button2";
            button2.Size = new Size(280, 77);
            button2.TabIndex = 9;
            button2.Text = "barber mode";
            button2.UseVisualStyleBackColor = true;
            // 
            // User_Login_Page
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1413, 924);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(4, 6, 4, 6);
            Name = "User_Login_Page";
            Text = "Form1";
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
        private System.Windows.Forms.LinkLabel userRegisterAccLnk;
        private System.Windows.Forms.Button userLogInBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}

