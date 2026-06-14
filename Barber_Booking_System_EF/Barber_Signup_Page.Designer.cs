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
            labelRegister.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRegister.Location = new Point(284, 8);
            labelRegister.Name = "labelRegister";
            labelRegister.Size = new Size(239, 37);
            labelRegister.TabIndex = 1;
            labelRegister.Text = "Register Barber";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
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
            panel1.Location = new Point(128, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(566, 603);
            panel1.TabIndex = 67;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(396, 495);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(154, 38);
            btnBack.TabIndex = 82;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBoxBarber);
            groupBox1.Location = new Point(396, 201);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(154, 163);
            groupBox1.TabIndex = 81;
            groupBox1.TabStop = false;
            groupBox1.Text = "Barber Photo Profile";
            // 
            // pictureBoxBarber
            // 
            pictureBoxBarber.Image = Properties.Resources.rukia04;
            pictureBoxBarber.Location = new Point(7, 22);
            pictureBoxBarber.Margin = new Padding(4);
            pictureBoxBarber.Name = "pictureBoxBarber";
            pictureBoxBarber.Size = new Size(140, 134);
            pictureBoxBarber.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBarber.TabIndex = 25;
            pictureBoxBarber.TabStop = false;
            // 
            // gbGender
            // 
            gbGender.Controls.Add(rdFemale);
            gbGender.Controls.Add(rdMale);
            gbGender.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbGender.Location = new Point(22, 240);
            gbGender.Name = "gbGender";
            gbGender.Size = new Size(324, 63);
            gbGender.TabIndex = 80;
            gbGender.TabStop = false;
            gbGender.Text = "Gender";
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.ForeColor = Color.FromArgb(255, 128, 128);
            rdFemale.Location = new Point(174, 27);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(75, 24);
            rdFemale.TabIndex = 1;
            rdFemale.TabStop = true;
            rdFemale.Text = "female";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.ForeColor = Color.FromArgb(128, 128, 255);
            rdMale.Location = new Point(74, 27);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(61, 24);
            rdMale.TabIndex = 0;
            rdMale.TabStop = true;
            rdMale.Text = "male";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // btnUpload
            // 
            btnUpload.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpload.Location = new Point(424, 376);
            btnUpload.Margin = new Padding(2);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(93, 38);
            btnUpload.TabIndex = 79;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(396, 540);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(154, 38);
            btnRegister.TabIndex = 78;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(19, 186);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(327, 26);
            tbPassword.TabIndex = 77;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(18, 159);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 76;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(16, 408);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 75;
            label6.Text = "Service";
            // 
            // checkListService
            // 
            checkListService.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkListService.FormattingEnabled = true;
            checkListService.Location = new Point(22, 434);
            checkListService.Margin = new Padding(4);
            checkListService.Name = "checkListService";
            checkListService.Size = new Size(313, 130);
            checkListService.TabIndex = 74;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 325);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 73;
            label5.Text = "Outlet";
            // 
            // cbOutlet
            // 
            cbOutlet.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbOutlet.FormattingEnabled = true;
            cbOutlet.Location = new Point(22, 352);
            cbOutlet.Margin = new Padding(4);
            cbOutlet.Name = "cbOutlet";
            cbOutlet.Size = new Size(324, 28);
            cbOutlet.TabIndex = 72;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(392, 159);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 71;
            label4.Text = "Photo Profile";
            // 
            // tbName
            // 
            tbName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbName.Location = new Point(19, 115);
            tbName.Name = "tbName";
            tbName.PasswordChar = '*';
            tbName.Size = new Size(327, 26);
            tbName.TabIndex = 70;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 23);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 67;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 89);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 68;
            label3.Text = "Name";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(19, 50);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(327, 26);
            tbEmail.TabIndex = 69;
            // 
            // Barber_Signup_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.Lime;
            ClientSize = new Size(824, 462);
            Controls.Add(panel1);
            Controls.Add(labelRegister);
            Margin = new Padding(4);
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