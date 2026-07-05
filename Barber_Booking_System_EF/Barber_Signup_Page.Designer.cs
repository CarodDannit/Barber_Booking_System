namespace Barber_Booking_System_EF
{
    partial class Barber_Signup_Page
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
            labelRegister = new Label();
            openFileDialog1 = new OpenFileDialog();
            panel1 = new Panel();
            btnBack = new Button();
            groupBox1 = new GroupBox();
            pictureBoxBarber = new PictureBox();
            gbGender = new GroupBox();
            rdFemale = new RadioButton();
            rdMale = new RadioButton();
            btnUpload = new Button();
            btnRegister = new Button();
            tbPassword = new TextBox();
            label7 = new Label();
            label6 = new Label();
            checkListService = new CheckedListBox();
            label5 = new Label();
            cbOutlet = new ComboBox();
            label4 = new Label();
            tbName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tbEmail = new TextBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBarber).BeginInit();
            gbGender.SuspendLayout();
            SuspendLayout();
            // 
            // labelRegister
            // 
            labelRegister.AutoSize = true;
            labelRegister.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRegister.ForeColor = Color.White;
            labelRegister.Location = new Point(325, 11);
            labelRegister.Name = "labelRegister";
            labelRegister.Size = new Size(266, 46);
            labelRegister.TabIndex = 1;
            labelRegister.Text = "Register Barber";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.BlanchedAlmond;
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(gbGender);
            panel1.Controls.Add(btnUpload);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(checkListService);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cbOutlet);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbEmail);
            panel1.Location = new Point(146, 89);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(647, 804);
            panel1.TabIndex = 67;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gold;
            btnBack.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(453, 660);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(176, 51);
            btnBack.TabIndex = 82;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBoxBarber);
            groupBox1.Location = new Point(453, 268);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(176, 217);
            groupBox1.TabIndex = 81;
            groupBox1.TabStop = false;
            groupBox1.Text = "Barber Photo Profile";
            // 
            // pictureBoxBarber
            // 
            pictureBoxBarber.Image = Properties.Resources.rukia04;
            pictureBoxBarber.Location = new Point(8, 29);
            pictureBoxBarber.Margin = new Padding(5);
            pictureBoxBarber.Name = "pictureBoxBarber";
            pictureBoxBarber.Size = new Size(160, 179);
            pictureBoxBarber.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBarber.TabIndex = 25;
            pictureBoxBarber.TabStop = false;
            // 
            // gbGender
            // 
            gbGender.Controls.Add(rdFemale);
            gbGender.Controls.Add(rdMale);
            gbGender.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbGender.Location = new Point(25, 320);
            gbGender.Margin = new Padding(3, 4, 3, 4);
            gbGender.Name = "gbGender";
            gbGender.Padding = new Padding(3, 4, 3, 4);
            gbGender.Size = new Size(370, 84);
            gbGender.TabIndex = 80;
            gbGender.TabStop = false;
            gbGender.Text = "Gender";
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.ForeColor = Color.FromArgb(255, 128, 128);
            rdFemale.Location = new Point(199, 36);
            rdFemale.Margin = new Padding(3, 4, 3, 4);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(91, 29);
            rdFemale.TabIndex = 1;
            rdFemale.TabStop = true;
            rdFemale.Text = "female";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.ForeColor = Color.FromArgb(128, 128, 255);
            rdMale.Location = new Point(85, 36);
            rdMale.Margin = new Padding(3, 4, 3, 4);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(75, 29);
            rdMale.TabIndex = 0;
            rdMale.TabStop = true;
            rdMale.Text = "male";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.Gold;
            btnUpload.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpload.Location = new Point(485, 501);
            btnUpload.Margin = new Padding(2, 3, 2, 3);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(106, 51);
            btnUpload.TabIndex = 79;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Gold;
            btnRegister.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(453, 720);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(176, 51);
            btnRegister.TabIndex = 78;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = SystemColors.InactiveCaption;
            tbPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(22, 248);
            tbPassword.Margin = new Padding(3, 4, 3, 4);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(373, 30);
            tbPassword.TabIndex = 77;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(21, 212);
            label7.Name = "label7";
            label7.Size = new Size(98, 25);
            label7.TabIndex = 76;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 544);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 75;
            label6.Text = "Service";
            // 
            // checkListService
            // 
            checkListService.BackColor = SystemColors.InactiveCaption;
            checkListService.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkListService.FormattingEnabled = true;
            checkListService.Location = new Point(25, 579);
            checkListService.Margin = new Padding(5);
            checkListService.Name = "checkListService";
            checkListService.Size = new Size(357, 154);
            checkListService.TabIndex = 74;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 433);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 73;
            label5.Text = "Outlet";
            // 
            // cbOutlet
            // 
            cbOutlet.BackColor = SystemColors.InactiveCaption;
            cbOutlet.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbOutlet.FormattingEnabled = true;
            cbOutlet.Location = new Point(25, 469);
            cbOutlet.Margin = new Padding(5);
            cbOutlet.Name = "cbOutlet";
            cbOutlet.Size = new Size(370, 33);
            cbOutlet.TabIndex = 72;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(448, 212);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 71;
            label4.Text = "Photo Profile";
            // 
            // tbName
            // 
            tbName.BackColor = SystemColors.InactiveCaption;
            tbName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbName.Location = new Point(22, 153);
            tbName.Margin = new Padding(3, 4, 3, 4);
            tbName.Name = "tbName";
            tbName.Size = new Size(373, 30);
            tbName.TabIndex = 70;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 31);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 67;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 119);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 68;
            label3.Text = "Name";
            // 
            // tbEmail
            // 
            tbEmail.BackColor = SystemColors.InactiveCaption;
            tbEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(22, 67);
            tbEmail.Margin = new Padding(3, 4, 3, 4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(373, 30);
            tbEmail.TabIndex = 69;
            // 
            // Barber_Signup_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(0, 64, 0);
            ClientSize = new Size(942, 616);
            Controls.Add(panel1);
            Controls.Add(labelRegister);
            Margin = new Padding(5);
            Name = "Barber_Signup_Page";
            Text = "Barber Signup Page";
            Load += Barber_Signup_Page_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxBarber).EndInit();
            gbGender.ResumeLayout(false);
            gbGender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxBarber;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox checkListService;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbOutlet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmail;
        private Button btnBack;
    }
}