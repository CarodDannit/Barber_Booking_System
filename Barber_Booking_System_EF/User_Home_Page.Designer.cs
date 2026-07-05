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
            button2 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            labelToDoBookings = new Label();
            btnViewDetails = new Button();
            btnDeleteBooking = new Button();
            lblService = new Label();
            lblDate = new Label();
            lblStatus = new Label();
            lblBookingId = new Label();
            label7 = new Label();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            dgvBookings = new DataGridView();
            label1 = new Label();
            btnNewBooking = new Button();
            tabPage2 = new TabPage();
            btnCancelProfile = new Button();
            btnSave = new Button();
            tbName = new TextBox();
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnLogout = new Button();
            label2 = new Label();
            btnEditProfile = new Button();
            Id = new DataGridViewTextBoxColumn();
            sName = new DataGridViewTextBoxColumn();
            Barber = new DataGridViewTextBoxColumn();
            OutletLocation = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 15);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(918, 640);
            tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.BlanchedAlmond;
            tabPage1.Controls.Add(labelToDoBookings);
            tabPage1.Controls.Add(btnViewDetails);
            tabPage1.Controls.Add(btnDeleteBooking);
            tabPage1.Controls.Add(lblService);
            tabPage1.Controls.Add(lblDate);
            tabPage1.Controls.Add(lblStatus);
            tabPage1.Controls.Add(lblBookingId);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(dgvBookings);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnNewBooking);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(910, 607);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Bookings";
            // 
            // labelToDoBookings
            // 
            labelToDoBookings.AutoSize = true;
            labelToDoBookings.Location = new Point(220, 435);
            labelToDoBookings.Name = "labelToDoBookings";
            labelToDoBookings.Size = new Size(254, 20);
            labelToDoBookings.TabIndex = 48;
            labelToDoBookings.Text = "Hide irrelevant details; Sort bookings";
            // 
            // btnViewDetails
            // 
            btnViewDetails.BackColor = Color.Gold;
            btnViewDetails.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewDetails.Location = new Point(33, 543);
            btnViewDetails.Margin = new Padding(3, 4, 3, 4);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(157, 51);
            btnViewDetails.TabIndex = 44;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // btnDeleteBooking
            // 
            btnDeleteBooking.BackColor = Color.Gold;
            btnDeleteBooking.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteBooking.Location = new Point(220, 543);
            btnDeleteBooking.Margin = new Padding(3, 4, 3, 4);
            btnDeleteBooking.Name = "btnDeleteBooking";
            btnDeleteBooking.Size = new Size(104, 51);
            btnDeleteBooking.TabIndex = 43;
            btnDeleteBooking.Text = "Delete";
            btnDeleteBooking.UseVisualStyleBackColor = false;
            btnDeleteBooking.Click += btnDeleteBooking_Click;
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblService.Location = new Point(154, 343);
            lblService.Name = "lblService";
            lblService.Size = new Size(22, 28);
            lblService.TabIndex = 42;
            lblService.Text = "a";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(154, 371);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(22, 28);
            lblDate.TabIndex = 39;
            lblDate.Text = "a";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(154, 399);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(22, 28);
            lblStatus.TabIndex = 37;
            lblStatus.Text = "a";
            // 
            // lblBookingId
            // 
            lblBookingId.AutoSize = true;
            lblBookingId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookingId.Location = new Point(154, 315);
            lblBookingId.Name = "lblBookingId";
            lblBookingId.Size = new Size(22, 28);
            lblBookingId.TabIndex = 36;
            lblBookingId.Text = "a";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(33, 399);
            label7.Name = "label7";
            label7.Size = new Size(65, 28);
            label7.TabIndex = 32;
            label7.Text = "Status";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(33, 371);
            label10.Name = "label10";
            label10.Size = new Size(53, 28);
            label10.TabIndex = 31;
            label10.Text = "Date";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(33, 343);
            label12.Name = "label12";
            label12.Size = new Size(74, 28);
            label12.TabIndex = 29;
            label12.Text = "Service";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(33, 315);
            label13.Name = "label13";
            label13.Size = new Size(29, 28);
            label13.TabIndex = 28;
            label13.Text = "Id";
            // 
            // dgvBookings
            // 
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.AllowUserToDeleteRows = false;
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookings.Columns.AddRange(new DataGridViewColumn[] { Id, sName, Barber, OutletLocation, Date, Time, Status });
            dgvBookings.Location = new Point(33, 72);
            dgvBookings.Margin = new Padding(2);
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.RowHeadersWidth = 20;
            dgvBookings.Size = new Size(849, 219);
            dgvBookings.TabIndex = 11;
            dgvBookings.CellClick += dgvBookings_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 4);
            label1.Name = "label1";
            label1.Size = new Size(170, 46);
            label1.TabIndex = 0;
            label1.Text = "Bookings";
            // 
            // btnNewBooking
            // 
            btnNewBooking.BackColor = Color.Gold;
            btnNewBooking.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewBooking.Location = new Point(717, 543);
            btnNewBooking.Margin = new Padding(3, 4, 3, 4);
            btnNewBooking.Name = "btnNewBooking";
            btnNewBooking.Size = new Size(187, 51);
            btnNewBooking.TabIndex = 10;
            btnNewBooking.Text = "new booking";
            btnNewBooking.UseVisualStyleBackColor = false;
            btnNewBooking.Click += btnNewBooking_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.BlanchedAlmond;
            tabPage2.Controls.Add(btnCancelProfile);
            tabPage2.Controls.Add(btnSave);
            tabPage2.Controls.Add(tbName);
            tabPage2.Controls.Add(tbEmail);
            tabPage2.Controls.Add(tbPassword);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(btnLogout);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(btnEditProfile);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(2, 3, 2, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 3, 2, 3);
            tabPage2.Size = new Size(910, 607);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Profile";
            tabPage2.Click += tabPage2_Click;
            // 
            // btnCancelProfile
            // 
            btnCancelProfile.BackColor = Color.Gold;
            btnCancelProfile.Font = new Font("Microsoft Sans Serif", 12F);
            btnCancelProfile.Location = new Point(225, 281);
            btnCancelProfile.Margin = new Padding(2);
            btnCancelProfile.Name = "btnCancelProfile";
            btnCancelProfile.Size = new Size(125, 43);
            btnCancelProfile.TabIndex = 22;
            btnCancelProfile.Text = "Cancel";
            btnCancelProfile.UseVisualStyleBackColor = false;
            btnCancelProfile.Visible = false;
            btnCancelProfile.Click += btnCancelProfile_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gold;
            btnSave.Font = new Font("Microsoft Sans Serif", 12F);
            btnSave.Location = new Point(370, 281);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 43);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // tbName
            // 
            tbName.BackColor = SystemColors.InactiveCaption;
            tbName.Font = new Font("Microsoft Sans Serif", 12F);
            tbName.ForeColor = SystemColors.WindowText;
            tbName.Location = new Point(370, 109);
            tbName.Margin = new Padding(1);
            tbName.Name = "tbName";
            tbName.ReadOnly = true;
            tbName.Size = new Size(290, 30);
            tbName.TabIndex = 13;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = SystemColors.InactiveCaption;
            tbEmail.Font = new Font("Microsoft Sans Serif", 12F);
            tbEmail.ForeColor = SystemColors.WindowText;
            tbEmail.Location = new Point(370, 161);
            tbEmail.Margin = new Padding(1);
            tbEmail.Name = "tbEmail";
            tbEmail.ReadOnly = true;
            tbEmail.Size = new Size(290, 30);
            tbEmail.TabIndex = 14;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = SystemColors.InactiveCaption;
            tbPassword.Font = new Font("Microsoft Sans Serif", 12F);
            tbPassword.ForeColor = SystemColors.WindowText;
            tbPassword.Location = new Point(370, 218);
            tbPassword.Margin = new Padding(1);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.ReadOnly = true;
            tbPassword.Size = new Size(290, 30);
            tbPassword.TabIndex = 20;
            tbPassword.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(225, 221);
            label6.Name = "label6";
            label6.Size = new Size(98, 25);
            label6.TabIndex = 18;
            label6.Text = "Password";
            label6.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(225, 166);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 16;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(225, 112);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 15;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Gold;
            btnLogout.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(738, 530);
            btnLogout.Margin = new Padding(1);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(138, 43);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 6);
            label2.Name = "label2";
            label2.Size = new Size(126, 46);
            label2.TabIndex = 11;
            label2.Text = "Profile";
            // 
            // btnEditProfile
            // 
            btnEditProfile.BackColor = Color.Gold;
            btnEditProfile.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditProfile.Location = new Point(522, 281);
            btnEditProfile.Margin = new Padding(2, 3, 2, 3);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(138, 43);
            btnEditProfile.TabIndex = 12;
            btnEditProfile.Text = "Edit Profile";
            btnEditProfile.UseVisualStyleBackColor = false;
            btnEditProfile.Click += button1_Click_1;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ID";
            Id.MinimumWidth = 9;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 80;
            // 
            // sName
            // 
            sName.DataPropertyName = "sName";
            sName.HeaderText = "Service";
            sName.MinimumWidth = 9;
            sName.Name = "sName";
            sName.ReadOnly = true;
            sName.Width = 175;
            // 
            // Barber
            // 
            Barber.DataPropertyName = "bName";
            Barber.HeaderText = "Barber";
            Barber.MinimumWidth = 9;
            Barber.Name = "Barber";
            Barber.ReadOnly = true;
            Barber.Width = 150;
            // 
            // OutletLocation
            // 
            OutletLocation.DataPropertyName = "oLocation";
            OutletLocation.HeaderText = "Outlet";
            OutletLocation.MinimumWidth = 9;
            OutletLocation.Name = "OutletLocation";
            OutletLocation.ReadOnly = true;
            OutletLocation.Width = 175;
            // 
            // Date
            // 
            Date.DataPropertyName = "Date";
            Date.HeaderText = "Date";
            Date.MinimumWidth = 9;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 125;
            // 
            // Time
            // 
            Time.DataPropertyName = "Time";
            Time.HeaderText = "Time";
            Time.MinimumWidth = 9;
            Time.Name = "Time";
            Time.ReadOnly = true;
            Time.Width = 125;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 9;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 125;
            // 
            // User_Home_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            ClientSize = new Size(942, 672);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "User_Home_Page";
            Text = "User Home Page";
            Load += User_Home_Page_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditProfile;
        private Button btnLogout;
        private Label label6;
        private TextBox tbName;
        private TextBox tbEmail;
        private Label label3;
        private Label label4;
        private TextBox tbPassword;
        private Button btnSave;
        private Button btnCancelProfile;
        private TabPage tabPage1;
        private Button btnViewDetails;
        private Button btnDeleteBooking;
        private Label lblService;
        private Label lblDate;
        private Label lblStatus;
        private Label lblBookingId;
        private Label label7;
        private Label label10;
        private Label label12;
        private Label label13;
        private DataGridView dgvBookings;
        private Label label1;
        private Button btnNewBooking;
        private Label labelToDoBookings;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn sName;
        private DataGridViewTextBoxColumn Barber;
        private DataGridViewTextBoxColumn OutletLocation;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Status;
    }
}