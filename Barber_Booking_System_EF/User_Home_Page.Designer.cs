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
            label1 = new Label();
            button2 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnDeleteBooking = new Button();
            lblService = new Label();
            lblBarber = new Label();
            lblOutlet = new Label();
            lblDate = new Label();
            lblTimeSlot = new Label();
            lblStatus = new Label();
            lblBookingId = new Label();
            label9 = new Label();
            label800 = new Label();
            label700 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            dgvBookings = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            OutletId = new DataGridViewTextBoxColumn();
            OutletLocation = new DataGridViewTextBoxColumn();
            BarberId = new DataGridViewTextBoxColumn();
            BarberName = new DataGridViewTextBoxColumn();
            ServiceId = new DataGridViewTextBoxColumn();
            ServiceName = new DataGridViewTextBoxColumn();
            TimeslotId = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            btnNewBooking = new Button();
            tabPage2 = new TabPage();
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
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnViewDetails = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 4);
            label1.Name = "label1";
            label1.Size = new Size(257, 64);
            label1.TabIndex = 0;
            label1.Text = "Bookings";
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
            tabControl1.Location = new Point(18, 22);
            tabControl1.Margin = new Padding(4, 6, 4, 6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1377, 960);
            tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.DarkGreen;
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(btnViewDetails);
            tabPage1.Controls.Add(btnDeleteBooking);
            tabPage1.Controls.Add(lblService);
            tabPage1.Controls.Add(lblBarber);
            tabPage1.Controls.Add(lblOutlet);
            tabPage1.Controls.Add(lblDate);
            tabPage1.Controls.Add(lblTimeSlot);
            tabPage1.Controls.Add(lblStatus);
            tabPage1.Controls.Add(lblBookingId);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label800);
            tabPage1.Controls.Add(label700);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(dgvBookings);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnNewBooking);
            tabPage1.Location = new Point(4, 39);
            tabPage1.Margin = new Padding(4, 6, 4, 6);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 6, 4, 6);
            tabPage1.Size = new Size(1369, 917);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Bookings";
            tabPage1.Click += tabPage1_Click;
            // 
            // btnDeleteBooking
            // 
            btnDeleteBooking.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteBooking.Location = new Point(330, 814);
            btnDeleteBooking.Margin = new Padding(4, 6, 4, 6);
            btnDeleteBooking.Name = "btnDeleteBooking";
            btnDeleteBooking.Size = new Size(156, 76);
            btnDeleteBooking.TabIndex = 43;
            btnDeleteBooking.Text = "Delete";
            btnDeleteBooking.UseVisualStyleBackColor = true;
            btnDeleteBooking.Click += btnDeleteBooking_Click;
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblService.Location = new Point(231, 514);
            lblService.Margin = new Padding(4, 0, 4, 0);
            lblService.Name = "lblService";
            lblService.Size = new Size(0, 38);
            lblService.TabIndex = 42;
            // 
            // lblBarber
            // 
            lblBarber.AutoSize = true;
            lblBarber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBarber.Location = new Point(231, 556);
            lblBarber.Margin = new Padding(4, 0, 4, 0);
            lblBarber.Name = "lblBarber";
            lblBarber.Size = new Size(0, 38);
            lblBarber.TabIndex = 41;
            // 
            // lblOutlet
            // 
            lblOutlet.AutoSize = true;
            lblOutlet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutlet.Location = new Point(231, 598);
            lblOutlet.Margin = new Padding(4, 0, 4, 0);
            lblOutlet.Name = "lblOutlet";
            lblOutlet.Size = new Size(0, 38);
            lblOutlet.TabIndex = 40;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(231, 640);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(0, 38);
            lblDate.TabIndex = 39;
            // 
            // lblTimeSlot
            // 
            lblTimeSlot.AutoSize = true;
            lblTimeSlot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimeSlot.Location = new Point(231, 682);
            lblTimeSlot.Margin = new Padding(4, 0, 4, 0);
            lblTimeSlot.Name = "lblTimeSlot";
            lblTimeSlot.Size = new Size(0, 38);
            lblTimeSlot.TabIndex = 38;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(231, 724);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 38);
            lblStatus.TabIndex = 37;
            // 
            // lblBookingId
            // 
            lblBookingId.AutoSize = true;
            lblBookingId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookingId.Location = new Point(231, 472);
            lblBookingId.Margin = new Padding(4, 0, 4, 0);
            lblBookingId.Name = "lblBookingId";
            lblBookingId.Size = new Size(0, 38);
            lblBookingId.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(50, 598);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(94, 38);
            label9.TabIndex = 34;
            label9.Text = "Outlet";
            // 
            // label800
            // 
            label800.AutoSize = true;
            label800.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label800.Location = new Point(50, 682);
            label800.Margin = new Padding(4, 0, 4, 0);
            label800.Name = "label800";
            label800.Size = new Size(125, 38);
            label800.TabIndex = 33;
            label800.Text = "TimeSlot";
            // 
            // label700
            // 
            label700.AutoSize = true;
            label700.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label700.Location = new Point(50, 724);
            label700.Margin = new Padding(4, 0, 4, 0);
            label700.Name = "label700";
            label700.Size = new Size(91, 38);
            label700.TabIndex = 32;
            label700.Text = "Status";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(50, 640);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(75, 38);
            label10.TabIndex = 31;
            label10.Text = "Date";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(50, 556);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(98, 38);
            label11.TabIndex = 30;
            label11.Text = "Barber";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(50, 514);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(105, 38);
            label12.TabIndex = 29;
            label12.Text = "Service";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(50, 472);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(40, 38);
            label13.TabIndex = 28;
            label13.Text = "Id";
            // 
            // dgvBookings
            // 
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.AllowUserToDeleteRows = false;
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookings.Columns.AddRange(new DataGridViewColumn[] { Id, Date, Description, OutletId, OutletLocation, BarberId, BarberName, ServiceId, ServiceName, TimeslotId, Time, Status });
            dgvBookings.Location = new Point(33, 72);
            dgvBookings.Margin = new Padding(2);
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.RowHeadersWidth = 72;
            dgvBookings.Size = new Size(1274, 328);
            dgvBookings.TabIndex = 11;
            dgvBookings.CellClick += dgvBookings_CellClick;
            dgvBookings.CellContentClick += dgvBookings_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 9;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 80;
            // 
            // Date
            // 
            Date.DataPropertyName = "Date";
            Date.HeaderText = "Date";
            Date.MinimumWidth = 9;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 150;
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.MinimumWidth = 9;
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Width = 175;
            // 
            // OutletId
            // 
            OutletId.DataPropertyName = "OutletId";
            OutletId.HeaderText = "OutletId";
            OutletId.MinimumWidth = 9;
            OutletId.Name = "OutletId";
            OutletId.ReadOnly = true;
            OutletId.Width = 90;
            // 
            // OutletLocation
            // 
            OutletLocation.DataPropertyName = "oLocation";
            OutletLocation.HeaderText = "Location";
            OutletLocation.MinimumWidth = 9;
            OutletLocation.Name = "OutletLocation";
            OutletLocation.ReadOnly = true;
            OutletLocation.Width = 175;
            // 
            // BarberId
            // 
            BarberId.DataPropertyName = "BarberId";
            BarberId.HeaderText = "BarberId";
            BarberId.MinimumWidth = 9;
            BarberId.Name = "BarberId";
            BarberId.ReadOnly = true;
            BarberId.Width = 90;
            // 
            // BarberName
            // 
            BarberName.DataPropertyName = "bName";
            BarberName.HeaderText = "Barber Name";
            BarberName.MinimumWidth = 9;
            BarberName.Name = "BarberName";
            BarberName.ReadOnly = true;
            BarberName.Width = 175;
            // 
            // ServiceId
            // 
            ServiceId.DataPropertyName = "ServiceId";
            ServiceId.HeaderText = "ServiceId";
            ServiceId.MinimumWidth = 9;
            ServiceId.Name = "ServiceId";
            ServiceId.ReadOnly = true;
            ServiceId.Width = 90;
            // 
            // ServiceName
            // 
            ServiceName.DataPropertyName = "sName";
            ServiceName.HeaderText = "Service Name";
            ServiceName.MinimumWidth = 9;
            ServiceName.Name = "ServiceName";
            ServiceName.ReadOnly = true;
            ServiceName.Width = 175;
            // 
            // TimeslotId
            // 
            TimeslotId.DataPropertyName = "TimeslotId";
            TimeslotId.HeaderText = "TimeslotId";
            TimeslotId.MinimumWidth = 9;
            TimeslotId.Name = "TimeslotId";
            TimeslotId.ReadOnly = true;
            TimeslotId.Width = 90;
            // 
            // Time
            // 
            Time.DataPropertyName = "Time";
            Time.HeaderText = "Time";
            Time.MinimumWidth = 9;
            Time.Name = "Time";
            Time.ReadOnly = true;
            Time.Width = 175;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 9;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 175;
            // 
            // btnNewBooking
            // 
            btnNewBooking.BackColor = Color.LightGreen;
            btnNewBooking.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewBooking.ForeColor = Color.Black;
            btnNewBooking.Location = new Point(717, 543);
            btnNewBooking.Margin = new Padding(3, 4, 3, 4);
            btnNewBooking.Name = "btnNewBooking";
            btnNewBooking.Size = new Size(280, 76);
            btnNewBooking.TabIndex = 10;
            btnNewBooking.Text = "new booking";
            btnNewBooking.UseVisualStyleBackColor = false;
            btnNewBooking.Click += btnNewBooking_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.DarkGreen;
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label70);
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
            tabPage2.Location = new Point(4, 39);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(1369, 917);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Profile";
            tabPage2.Click += tabPage2_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gold;
            btnSave.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(268, 414);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(269, 100);
            btnSave.TabIndex = 21;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(300, 92);
            tbName.Margin = new Padding(1);
            tbName.Name = "tbName";
            tbName.ReadOnly = true;
            tbName.Size = new Size(208, 27);
            tbName.TabIndex = 13;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(300, 137);
            tbEmail.Margin = new Padding(1);
            tbEmail.Name = "tbEmail";
            tbEmail.ReadOnly = true;
            tbEmail.Size = new Size(208, 27);
            tbEmail.TabIndex = 14;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(300, 216);
            tbPassword.Margin = new Padding(1);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.ReadOnly = true;
            tbPassword.Size = new Size(208, 30);
            tbPassword.TabIndex = 20;
            tbPassword.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(149, 221);
            label6.Name = "label6";
            label6.Size = new Size(138, 32);
            label6.TabIndex = 18;
            label6.Text = "Password";
            label6.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(149, 139);
            label4.Name = "label4";
            label4.Size = new Size(86, 32);
            label4.TabIndex = 16;
            label4.Text = "Email";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(149, 94);
            label3.Name = "label3";
            label3.Size = new Size(144, 32);
            label3.TabIndex = 15;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.LightGreen;
            btnLogout.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.Black;
            btnLogout.Location = new Point(736, 6);
            btnLogout.Margin = new Padding(1);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(156, 46);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(6, 6);
            label2.Name = "label2";
            label2.Size = new Size(187, 64);
            label2.TabIndex = 11;
            label2.Text = "Profile";
            label2.Click += label2_Click;
            // 
            // btnEditProfile
            // 
            btnEditProfile.BackColor = Color.LightGreen;
            btnEditProfile.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditProfile.Location = new Point(725, 534);
            btnEditProfile.Margin = new Padding(2, 3, 2, 3);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(167, 54);
            btnEditProfile.TabIndex = 12;
            btnEditProfile.Text = "edit profile";
            btnEditProfile.UseVisualStyleBackColor = false;
            btnEditProfile.Click += btnEditProfile_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gold;
            label5.Location = new Point(33, 315);
            label5.Name = "label5";
            label5.Size = new Size(631, 98);
            label5.TabIndex = 12;
            label5.Text = "PICK YOUR STYLE, OWN YOUR lOOK";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // label70
            // 
            label70.AutoSize = true;
            label70.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label70.ForeColor = Color.White;
            label70.Location = new Point(57, 319);
            label70.Name = "label70";
            label70.Size = new Size(787, 35);
            label70.TabIndex = 22;
            label70.Text = "\"Gaya rambut bukan sekadar rupa, ia adalah lambang reputasi.\"";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(65, 367);
            label8.Name = "label8";
            label8.Size = new Size(95, 20);
            label8.TabIndex = 23;
            label8.Text = "~By Imran~";
            // 
            // btnViewDetails
            // 
            btnViewDetails.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewDetails.Location = new Point(50, 814);
            btnViewDetails.Margin = new Padding(4, 6, 4, 6);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(236, 76);
            btnViewDetails.TabIndex = 44;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = true;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // User_Home_Page
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(942, 672);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 6, 4, 6);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private Button btnNewBooking;
        private Button btnLogout;
        private DataGridView dgvBookings;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn OutletId;
        private DataGridViewTextBoxColumn OutletLocation;
        private DataGridViewTextBoxColumn BarberId;
        private DataGridViewTextBoxColumn BarberName;
        private DataGridViewTextBoxColumn ServiceId;
        private DataGridViewTextBoxColumn ServiceName;
        private DataGridViewTextBoxColumn TimeslotId;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Status;
        private Label label6;
        private TextBox tbName;
        private TextBox tbEmail;
        private Label label3;
        private Label label4;
        private TextBox tbPassword;
        private Button btnSave;
        private Button btnEditProfile;
        private Label label5;
        private Label label70;
        private Label label8;
        private Button btnDeleteBooking;
        private Label lblService;
        private Label lblBarber;
        private Label lblOutlet;
        private Label lblDate;
        private Label lblTimeSlot;
        private Label lblStatus;
        private Label lblBookingId;
        private Label label9;
        private Label label800;
        private Label label700;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button btnViewDetails;
    }
}