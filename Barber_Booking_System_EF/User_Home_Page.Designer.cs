namespace Barber_Booking_System_EF
{
    partial class User_Home_Page
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
            tabPage2 = new TabPage();
            button1 = new Button();
            label2 = new Label();
            tabPage1 = new TabPage();
            button2 = new Button();
            label1 = new Label();
            tabControl1 = new TabControl();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbEmail = new ListBox();
            lbUsername = new ListBox();
            lbPhoneNo = new ListBox();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lbPhoneNo);
            tabPage2.Controls.Add(lbUsername);
            tabPage2.Controls.Add(lbEmail);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(button1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(910, 553);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Profile";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(717, 494);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(187, 51);
            button1.TabIndex = 12;
            button1.Text = "edit profile";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 6);
            label2.Name = "label2";
            label2.Size = new Size(134, 46);
            label2.TabIndex = 11;
            label2.Text = "Profile";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(910, 553);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Bookings";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(717, 491);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(187, 51);
            button2.TabIndex = 10;
            button2.Text = "new booking";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 4);
            label1.Name = "label1";
            label1.Size = new Size(186, 46);
            label1.TabIndex = 0;
            label1.Text = "Bookings";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 15);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(918, 586);
            tabControl1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(281, 295);
            label5.Name = "label5";
            label5.Size = new Size(94, 25);
            label5.TabIndex = 17;
            label5.Text = "phone no";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(281, 90);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 13;
            label3.Text = "email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(281, 193);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 14;
            label4.Text = "username";
            // 
            // lbEmail
            // 
            lbEmail.FormattingEnabled = true;
            lbEmail.Location = new Point(281, 140);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(314, 24);
            lbEmail.TabIndex = 18;
            // 
            // lbUsername
            // 
            lbUsername.FormattingEnabled = true;
            lbUsername.Location = new Point(281, 237);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(314, 24);
            lbUsername.TabIndex = 19;
            // 
            // lbPhoneNo
            // 
            lbPhoneNo.FormattingEnabled = true;
            lbPhoneNo.Location = new Point(281, 343);
            lbPhoneNo.Name = "lbPhoneNo";
            lbPhoneNo.Size = new Size(314, 24);
            lbPhoneNo.TabIndex = 20;
            // 
            // User_Home_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(942, 616);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "User_Home_Page";
            Text = "User Home Page";
            Load += Form2_Load;
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private TabPage tabPage2;
        private Label label2;
        private Button button1;
        private TabPage tabPage1;
        private Label label1;
        private Button button2;
        private TabControl tabControl1;
        private Label label5;
        private Label label3;
        private Label label4;
        private ListBox lbPhoneNo;
        private ListBox lbUsername;
        private ListBox lbEmail;
    }
}