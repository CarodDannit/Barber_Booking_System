namespace Barber_Booking_System_EF
{
    partial class Landing_Page
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnUserLogInPage = new Button();
            btnBarberLogInPage = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2026_07_02_080118;
            pictureBox1.Location = new Point(12, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 350);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(350, 46);
            label1.TabIndex = 11;
            label1.Text = "BRO Barber Booking";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(523, 160);
            label2.Name = "label2";
            label2.Size = new Size(120, 46);
            label2.TabIndex = 12;
            label2.Text = "Log In";
            // 
            // btnUserLogInPage
            // 
            btnUserLogInPage.BackColor = Color.Gold;
            btnUserLogInPage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUserLogInPage.Location = new Point(422, 253);
            btnUserLogInPage.Margin = new Padding(3, 4, 3, 4);
            btnUserLogInPage.Name = "btnUserLogInPage";
            btnUserLogInPage.Size = new Size(132, 51);
            btnUserLogInPage.TabIndex = 13;
            btnUserLogInPage.Text = "USER";
            btnUserLogInPage.UseVisualStyleBackColor = false;
            btnUserLogInPage.Click += btnUserLogInPage_Click;
            // 
            // btnBarberLogInPage
            // 
            btnBarberLogInPage.BackColor = Color.Gold;
            btnBarberLogInPage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBarberLogInPage.Location = new Point(614, 253);
            btnBarberLogInPage.Margin = new Padding(3, 4, 3, 4);
            btnBarberLogInPage.Name = "btnBarberLogInPage";
            btnBarberLogInPage.Size = new Size(132, 51);
            btnBarberLogInPage.TabIndex = 14;
            btnBarberLogInPage.Text = "BARBER";
            btnBarberLogInPage.UseVisualStyleBackColor = false;
            btnBarberLogInPage.Click += btnBarberLogInPage_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(423, 438);
            label3.Name = "label3";
            label3.Size = new Size(323, 28);
            label3.TabIndex = 15;
            label3.Text = "\"Book your perfect cut, anytime\"";
            // 
            // Landing_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            ClientSize = new Size(799, 493);
            Controls.Add(label3);
            Controls.Add(btnBarberLogInPage);
            Controls.Add(btnUserLogInPage);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Landing_Page";
            Text = "Landing_Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button btnUserLogInPage;
        private Button btnBarberLogInPage;
        private Label label3;
    }
}