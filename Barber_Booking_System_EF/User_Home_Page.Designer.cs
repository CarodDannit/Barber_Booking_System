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
            btnViewDetails = new Button();
            btnDeleteBooking = new Button();
            lblService = new Label();
            lblBarber = new Label();
            lblOutlet = new Label();
            lblDate = new Label();
            lblTimeSlot = new Label();
            lblStatus = new Label();
            lblBookingId = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
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
            btnCancelProfile = new Button();
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
            label1.Location = new Point(6, 4);
            label1.Name = "label1";
            label1.Size = new Size(186, 46);
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
            tabControl1.Location = new Point(12, 15);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(918, 640);
            tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
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
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label11);
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
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnViewDetails
            // 
            btnViewDetails.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewDetails.Location = new Point(33, 543);
            btnViewDetails.Margin = new Padding(3, 4, 3, 4);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(157, 51);
            btnViewDetails.TabIndex = 44;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = true;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // btnDeleteBooking
            // 
            btnDeleteBooking.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteBooking.Location = new Point(220, 543);
            btnDeleteBooking.Margin = new Padding(3, 4, 3, 4);
            btnDeleteBooking.Name = "btnDeleteBooking";
            btnDeleteBooking.Size = new Size(104, 51);
            btnDeleteBooking.TabIndex = 43;
            btnDeleteBooking.Text = "Delete";
            btnDeleteBooking.UseVisualStyleBackColor = true;
            btnDeleteBooking.Click += btnDeleteBooking_Click;
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblService.Location = new Point(154, 343);
            lblService.Name = "lblService";
            lblService.Size = new Size(0, 28);
            lblService.TabIndex = 42;
            // 
            // lblBarber
            // 
            lblBarber.AutoSize = true;
            lblBarber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBarber.Location = new Point(154, 371);
            lblBarber.Name = "lblBarber";
            lblBarber.Size = new Size(0, 28);
            lblBarber.TabIndex = 41;
            // 
            // lblOutlet
            // 
            lblOutlet.AutoSize = true;
            lblOutlet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutlet.Location = new Point(154, 399);
            lblOutlet.Name = "lblOutlet";
            lblOutlet.Size = new Size(0, 28);
            lblOutlet.TabIndex = 40;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(154, 427);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(0, 28);
            lblDate.TabIndex = 39;
            // 
            // lblTimeSlot
            // 
            lblTimeSlot.AutoSize = true;
            lblTimeSlot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimeSlot.Location = new Point(154, 455);
            lblTimeSlot.Name = "lblTimeSlot";
            lblTimeSlot.Size = new Size(0, 28);
            lblTimeSlot.TabIndex = 38;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(154, 483);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 28);
            lblStatus.TabIndex = 37;
            // 
            // lblBookingId
            // 
            lblBookingId.AutoSize = true;
            lblBookingId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookingId.Location = new Point(154, 315);
            lblBookingId.Name = "lblBookingId";
            lblBookingId.Size = new Size(0, 28);
            lblBookingId.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(33, 399);
            label9.Name = "label9";
            label9.Size = new Size(67, 28);
            label9.TabIndex = 34;
            label9.Text = "Outlet";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(33, 455);
            label8.Name = "label8";
            label8.Size = new Size(89, 28);
            label8.TabIndex = 33;
            label8.Text = "TimeSlot";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(33, 483);
            label7.Name = "label7";
            label7.Size = new Size(65, 28);
            label7.TabIndex = 32;
            label7.Text = "Status";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(33, 427);
            label10.Name = "label10";
            label10.Size = new Size(53, 28);
            label10.TabIndex = 31;
            label10.Text = "Date";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(33, 371);
            label11.Name = "label11";
            label11.Size = new Size(69, 28);
            label11.TabIndex = 30;
            label11.Text = "Barber";
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
            dgvBookings.Columns.AddRange(new DataGridViewColumn[] { Id, Date, Description, OutletId, OutletLocation, BarberId, BarberName, ServiceId, ServiceName, TimeslotId, Time, Status });
            dgvBookings.Location = new Point(33, 72);
            dgvBookings.Margin = new Padding(2);
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.RowHeadersWidth = 72;
            dgvBookings.Size = new Size(849, 219);
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
            btnNewBooking.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewBooking.Location = new Point(717, 543);
            btnNewBooking.Margin = new Padding(3, 4, 3, 4);
            btnNewBooking.Name = "btnNewBooking";
            btnNewBooking.Size = new Size(187, 51);
            btnNewBooking.TabIndex = 10;
            btnNewBooking.Text = "new booking";
            btnNewBooking.UseVisualStyleBackColor = true;
            btnNewBooking.Click += btnNewBooking_Click;
            // 
            // tabPage2
            // 
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
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(385, 245);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 43);
            btnSave.TabIndex = 21;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(294, 95);
            tbName.Margin = new Padding(1);
            tbName.Name = "tbName";
            tbName.ReadOnly = true;
            tbName.Size = new Size(216, 27);
            tbName.TabIndex = 13;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(294, 136);
            tbEmail.Margin = new Padding(1);
            tbEmail.Name = "tbEmail";
            tbEmail.ReadOnly = true;
            tbEmail.Size = new Size(216, 27);
            tbEmail.TabIndex = 14;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(294, 185);
            tbPassword.Margin = new Padding(1);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.ReadOnly = true;
            tbPassword.Size = new Size(216, 30);
            tbPassword.TabIndex = 20;
            tbPassword.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(149, 185);
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
            label4.Location = new Point(149, 139);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 16;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(149, 94);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 15;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(773, 533);
            btnLogout.Margin = new Padding(1);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(91, 34);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
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
            // btnEditProfile
            // 
            btnEditProfile.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditProfile.Location = new Point(521, 249);
            btnEditProfile.Margin = new Padding(2, 3, 2, 3);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(125, 34);
            btnEditProfile.TabIndex = 12;
            btnEditProfile.Text = "edit profile";
            btnEditProfile.UseVisualStyleBackColor = true;
            btnEditProfile.Click += button1_Click_1;
            // 
            // btnCancelProfile
            // 
            btnCancelProfile.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelProfile.Location = new Point(247, 245);
            btnCancelProfile.Margin = new Padding(2);
            btnCancelProfile.Name = "btnCancelProfile";
            btnCancelProfile.Size = new Size(125, 43);
            btnCancelProfile.TabIndex = 22;
            btnCancelProfile.Text = "CANCEL";
            btnCancelProfile.UseVisualStyleBackColor = true;
            btnCancelProfile.Visible = false;
            btnCancelProfile.Click += btnCancelProfile_Click;
            // 
            // User_Home_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditProfile;
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
        private Button btnDeleteBooking;
        private Label lblService;
        private Label lblBarber;
        private Label lblOutlet;
        private Label lblDate;
        private Label lblTimeSlot;
        private Label lblStatus;
        private Label lblBookingId;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button btnViewDetails;
        private Button btnCancelProfile;
    }
}