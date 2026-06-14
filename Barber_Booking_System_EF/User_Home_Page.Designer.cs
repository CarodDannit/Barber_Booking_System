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
            btnNewBooking = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblService = new Label();
            lblBarber = new Label();
            lblOutlet = new Label();
            lblDate = new Label();
            lblTimeSlot = new Label();
            lblStatus = new Label();
            lblBookingId = new Label();
            btnCheckBooking = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
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
            tabPage2 = new TabPage();
            btnLogout = new Button();
            tbEmail = new TextBox();
            tbName = new TextBox();
            label2 = new Label();
            button1 = new Button();
            btnDeleteBooking = new Button();
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
            tabPage1.Controls.Add(btnDeleteBooking);
            tabPage1.Controls.Add(lblService);
            tabPage1.Controls.Add(lblBarber);
            tabPage1.Controls.Add(lblOutlet);
            tabPage1.Controls.Add(lblDate);
            tabPage1.Controls.Add(lblTimeSlot);
            tabPage1.Controls.Add(lblStatus);
            tabPage1.Controls.Add(lblBookingId);
            tabPage1.Controls.Add(btnCheckBooking);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
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
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblService.Location = new Point(154, 345);
            lblService.Name = "lblService";
            lblService.Size = new Size(0, 28);
            lblService.TabIndex = 26;
            // 
            // lblBarber
            // 
            lblBarber.AutoSize = true;
            lblBarber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBarber.Location = new Point(154, 373);
            lblBarber.Name = "lblBarber";
            lblBarber.Size = new Size(0, 28);
            lblBarber.TabIndex = 25;
            // 
            // lblOutlet
            // 
            lblOutlet.AutoSize = true;
            lblOutlet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutlet.Location = new Point(154, 401);
            lblOutlet.Name = "lblOutlet";
            lblOutlet.Size = new Size(0, 28);
            lblOutlet.TabIndex = 24;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(154, 429);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(0, 28);
            lblDate.TabIndex = 23;
            // 
            // lblTimeSlot
            // 
            lblTimeSlot.AutoSize = true;
            lblTimeSlot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimeSlot.Location = new Point(154, 457);
            lblTimeSlot.Name = "lblTimeSlot";
            lblTimeSlot.Size = new Size(0, 28);
            lblTimeSlot.TabIndex = 22;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(154, 485);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 28);
            lblStatus.TabIndex = 21;
            // 
            // lblBookingId
            // 
            lblBookingId.AutoSize = true;
            lblBookingId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookingId.Location = new Point(154, 317);
            lblBookingId.Name = "lblBookingId";
            lblBookingId.Size = new Size(0, 28);
            lblBookingId.TabIndex = 20;
            // 
            // btnCheckBooking
            // 
            btnCheckBooking.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheckBooking.Location = new Point(33, 543);
            btnCheckBooking.Margin = new Padding(3, 4, 3, 4);
            btnCheckBooking.Name = "btnCheckBooking";
            btnCheckBooking.Size = new Size(104, 51);
            btnCheckBooking.TabIndex = 19;
            btnCheckBooking.Text = "Check";
            btnCheckBooking.UseVisualStyleBackColor = true;
            btnCheckBooking.Click += btnCheckBooking_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(33, 401);
            label9.Name = "label9";
            label9.Size = new Size(67, 28);
            label9.TabIndex = 18;
            label9.Text = "Outlet";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(33, 457);
            label8.Name = "label8";
            label8.Size = new Size(89, 28);
            label8.TabIndex = 17;
            label8.Text = "TimeSlot";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(33, 485);
            label7.Name = "label7";
            label7.Size = new Size(65, 28);
            label7.TabIndex = 16;
            label7.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(33, 429);
            label6.Name = "label6";
            label6.Size = new Size(53, 28);
            label6.TabIndex = 15;
            label6.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 373);
            label5.Name = "label5";
            label5.Size = new Size(69, 28);
            label5.TabIndex = 14;
            label5.Text = "Barber";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 345);
            label4.Name = "label4";
            label4.Size = new Size(74, 28);
            label4.TabIndex = 13;
            label4.Text = "Service";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 317);
            label3.Name = "label3";
            label3.Size = new Size(29, 28);
            label3.TabIndex = 12;
            label3.Text = "Id";
            // 
            // dgvBookings
            // 
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.AllowUserToDeleteRows = false;
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookings.Columns.AddRange(new DataGridViewColumn[] { Id, Date, Description, OutletId, OutletLocation, BarberId, BarberName, ServiceId, ServiceName, TimeslotId, Time, Status });
            dgvBookings.Location = new Point(33, 72);
            dgvBookings.Margin = new Padding(2, 2, 2, 2);
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
            // tabPage2
            // 
            tabPage2.Controls.Add(btnLogout);
            tabPage2.Controls.Add(tbEmail);
            tabPage2.Controls.Add(tbName);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(button1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(910, 607);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Profile";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(345, 445);
            btnLogout.Margin = new Padding(2, 2, 2, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(87, 27);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(352, 210);
            tbEmail.Margin = new Padding(2, 2, 2, 2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(118, 27);
            tbEmail.TabIndex = 14;
            // 
            // tbName
            // 
            tbName.Location = new Point(273, 126);
            tbName.Margin = new Padding(2, 2, 2, 2);
            tbName.Name = "tbName";
            tbName.Size = new Size(118, 27);
            tbName.TabIndex = 13;
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
            // 
            // btnDeleteBooking
            // 
            btnDeleteBooking.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteBooking.Location = new Point(154, 543);
            btnDeleteBooking.Margin = new Padding(3, 4, 3, 4);
            btnDeleteBooking.Name = "btnDeleteBooking";
            btnDeleteBooking.Size = new Size(104, 51);
            btnDeleteBooking.TabIndex = 27;
            btnDeleteBooking.Text = "Delete";
            btnDeleteBooking.UseVisualStyleBackColor = true;
            btnDeleteBooking.Click += btnDeleteBooking_Click;
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
        private System.Windows.Forms.Button btnNewBooking;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private TextBox tbEmail;
        private TextBox tbName;
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
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblService;
        private Label lblBarber;
        private Label lblOutlet;
        private Label lblDate;
        private Label lblTimeSlot;
        private Label lblStatus;
        private Label lblBookingId;
        private Button btnCheckBooking;
        private Button btnDeleteBooking;
    }
}