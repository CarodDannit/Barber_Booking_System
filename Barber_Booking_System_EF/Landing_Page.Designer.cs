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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Landing_Page));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnUserLogInPage = new Button();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2026_07_02_080118;
            pictureBox1.Location = new Point(12, 74);
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
            // btnUserLogInPage
            // 
            btnUserLogInPage.BackColor = Color.Gold;
            btnUserLogInPage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUserLogInPage.Location = new Point(798, 13);
            btnUserLogInPage.Margin = new Padding(3, 4, 3, 4);
            btnUserLogInPage.Name = "btnUserLogInPage";
            btnUserLogInPage.Size = new Size(132, 51);
            btnUserLogInPage.TabIndex = 13;
            btnUserLogInPage.Text = "Log In";
            btnUserLogInPage.UseVisualStyleBackColor = false;
            btnUserLogInPage.Click += btnUserLogInPage_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(368, 258);
            label3.Name = "label3";
            label3.Size = new Size(544, 46);
            label3.TabIndex = 15;
            label3.Text = "\"Book your perfect cut, anytime\"";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(383, 320);
            label2.Name = "label2";
            label2.Size = new Size(547, 104);
            label2.TabIndex = 16;
            label2.Text = resources.GetString("label2.Text");
            // 
            // Landing_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            ClientSize = new Size(942, 493);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(btnUserLogInPage);
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
        private Button btnUserLogInPage;
        private Label label3;
        private Label label2;
    }
}