namespace Barber_Booking_System_EF
{
    partial class Barber_Home_Page
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblService = new Label();
            lblCustomer = new Label();
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
            btnNewBooking = new Button();
            dgvBookings = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            OutletId = new DataGridViewTextBoxColumn();
            OutletLocation = new DataGridViewTextBoxColumn();
            BarberId = new DataGridViewTextBoxColumn();
            CustId = new DataGridViewTextBoxColumn();
            cName = new DataGridViewTextBoxColumn();
            ServiceId = new DataGridViewTextBoxColumn();
            ServiceName = new DataGridViewTextBoxColumn();
            TimeslotId = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            label1 = new Label();
            tabPage2 = new TabPage();
            checkedListServices = new CheckedListBox();
            label11 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            pictureBoxBarber = new PictureBox();
            label9 = new Label();
            checkedListTimeSlot = new CheckedListBox();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            cbOutlet = new ComboBox();
            tbPassword = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            tbId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnAddBarber = new Button();
            btnLogout = new Button();
            btnSave = new Button();
            tbEmail = new TextBox();
            tbName = new TextBox();
            label2 = new Label();
            button1 = new Button();
            tabPage3 = new TabPage();
            tbBarberEmail = new TextBox();
            tbBarberGender = new TextBox();
            tbBarberOutlet = new TextBox();
            tbBarberName = new TextBox();
            tbBarberId = new TextBox();
            btnAddBarber = new Button();
            btnUpdateBarber = new Button();
            btnDeleteBarber = new Button();
            label18 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label10 = new Label();
            dgvBarber = new DataGridView();
            BarberId02 = new DataGridViewTextBoxColumn();
            BarberName = new DataGridViewTextBoxColumn();
            BarberEmail = new DataGridViewTextBoxColumn();
            BarberGender = new DataGridViewTextBoxColumn();
            BarberOutlet = new DataGridViewTextBoxColumn();
            tabPage4 = new TabPage();
            barbeR_serviceTableAdapter1 = new Barber_Booking_System_EF.DataSet1TableAdapters.BARBER_SERVICETableAdapter();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBarber).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBarber).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(11, 13);
            tabControl1.Margin = new Padding(2, 4, 2, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(918, 672);
            tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblService);
            tabPage1.Controls.Add(lblCustomer);
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
            tabPage1.Controls.Add(btnNewBooking);
            tabPage1.Controls.Add(dgvBookings);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2, 4, 2, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 4, 2, 4);
            tabPage1.Size = new Size(910, 639);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Bookings";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblService.Location = new Point(155, 346);
            lblService.Name = "lblService";
            lblService.Size = new Size(0, 28);
            lblService.TabIndex = 42;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomer.Location = new Point(155, 374);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(0, 28);
            lblCustomer.TabIndex = 41;
            // 
            // lblOutlet
            // 
            lblOutlet.AutoSize = true;
            lblOutlet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutlet.Location = new Point(155, 402);
            lblOutlet.Name = "lblOutlet";
            lblOutlet.Size = new Size(0, 28);
            lblOutlet.TabIndex = 40;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(155, 430);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(0, 28);
            lblDate.TabIndex = 39;
            // 
            // lblTimeSlot
            // 
            lblTimeSlot.AutoSize = true;
            lblTimeSlot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimeSlot.Location = new Point(155, 458);
            lblTimeSlot.Name = "lblTimeSlot";
            lblTimeSlot.Size = new Size(0, 28);
            lblTimeSlot.TabIndex = 38;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(155, 486);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 28);
            lblStatus.TabIndex = 37;
            // 
            // lblBookingId
            // 
            lblBookingId.AutoSize = true;
            lblBookingId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookingId.Location = new Point(155, 318);
            lblBookingId.Name = "lblBookingId";
            lblBookingId.Size = new Size(0, 28);
            lblBookingId.TabIndex = 36;
            // 
            // btnCheckBooking
            // 
            btnCheckBooking.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheckBooking.Location = new Point(34, 544);
            btnCheckBooking.Margin = new Padding(3, 4, 3, 4);
            btnCheckBooking.Name = "btnCheckBooking";
            btnCheckBooking.Size = new Size(159, 51);
            btnCheckBooking.TabIndex = 35;
            btnCheckBooking.Text = "Check";
            btnCheckBooking.UseVisualStyleBackColor = true;
            btnCheckBooking.Click += btnCheckBooking_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(34, 402);
            label9.Name = "label9";
            label9.Size = new Size(67, 28);
            label9.TabIndex = 34;
            label9.Text = "Outlet";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(34, 458);
            label8.Name = "label8";
            label8.Size = new Size(89, 28);
            label8.TabIndex = 33;
            label8.Text = "TimeSlot";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(34, 486);
            label7.Name = "label7";
            label7.Size = new Size(65, 28);
            label7.TabIndex = 32;
            label7.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(34, 430);
            label6.Name = "label6";
            label6.Size = new Size(53, 28);
            label6.TabIndex = 31;
            label6.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(34, 374);
            label5.Name = "label5";
            label5.Size = new Size(96, 28);
            label5.TabIndex = 30;
            label5.Text = "Customer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 346);
            label4.Name = "label4";
            label4.Size = new Size(74, 28);
            label4.TabIndex = 29;
            label4.Text = "Service";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 318);
            label3.Name = "label3";
            label3.Size = new Size(29, 28);
            label3.TabIndex = 28;
            label3.Text = "Id";
            // 
            // btnNewBooking
            // 
            btnNewBooking.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewBooking.Location = new Point(718, 544);
            btnNewBooking.Margin = new Padding(3, 4, 3, 4);
            btnNewBooking.Name = "btnNewBooking";
            btnNewBooking.Size = new Size(187, 51);
            btnNewBooking.TabIndex = 27;
            btnNewBooking.Text = "new booking";
            btnNewBooking.UseVisualStyleBackColor = true;
            // 
            // dgvBookings
            // 
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.AllowUserToDeleteRows = false;
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookings.Columns.AddRange(new DataGridViewColumn[] { Id, Date, Description, OutletId, OutletLocation, BarberId, CustId, cName, ServiceId, ServiceName, TimeslotId, Time, Status });
            dgvBookings.Location = new Point(33, 72);
            dgvBookings.Margin = new Padding(2, 3, 2, 3);
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
            BarberId.Visible = false;
            BarberId.Width = 90;
            // 
            // CustId
            // 
            CustId.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            CustId.DataPropertyName = "CustId";
            CustId.HeaderText = "CustId";
            CustId.MinimumWidth = 6;
            CustId.Name = "CustId";
            CustId.ReadOnly = true;
            CustId.Width = 79;
            // 
            // cName
            // 
            cName.DataPropertyName = "cName";
            cName.HeaderText = "Cust. Name";
            cName.MinimumWidth = 6;
            cName.Name = "cName";
            cName.ReadOnly = true;
            cName.Width = 125;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 4);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 46);
            label1.TabIndex = 0;
            label1.Text = "Bookings";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(checkedListServices);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(checkedListTimeSlot);
            tabPage2.Controls.Add(rbMale);
            tabPage2.Controls.Add(rbFemale);
            tabPage2.Controls.Add(cbOutlet);
            tabPage2.Controls.Add(tbPassword);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(tbId);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(btnAddBarber);
            tabPage2.Controls.Add(btnLogout);
            tabPage2.Controls.Add(btnSave);
            tabPage2.Controls.Add(tbEmail);
            tabPage2.Controls.Add(tbName);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2, 3, 2, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 4, 2, 4);
            tabPage2.Size = new Size(910, 639);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Profile";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkedListServices
            // 
            checkedListServices.FormattingEnabled = true;
            checkedListServices.Location = new Point(562, 199);
            checkedListServices.Name = "checkedListServices";
            checkedListServices.Size = new Size(222, 166);
            checkedListServices.TabIndex = 87;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(557, 172);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(72, 24);
            label11.TabIndex = 86;
            label11.Text = "Servies";
            // 
            // button1
            // 
            button1.Location = new Point(389, 224);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(154, 24);
            button1.TabIndex = 83;
            button1.Text = "Upload";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBoxBarber);
            groupBox1.Location = new Point(389, 55);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(154, 163);
            groupBox1.TabIndex = 82;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(562, 3);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(89, 24);
            label9.TabIndex = 75;
            label9.Text = "Time Slot";
            // 
            // checkedListTimeSlot
            // 
            checkedListTimeSlot.FormattingEnabled = true;
            checkedListTimeSlot.Location = new Point(562, 30);
            checkedListTimeSlot.Name = "checkedListTimeSlot";
            checkedListTimeSlot.Size = new Size(222, 130);
            checkedListTimeSlot.TabIndex = 74;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Checked = true;
            rbMale.ForeColor = Color.FromArgb(128, 128, 255);
            rbMale.Location = new Point(119, 224);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(51, 19);
            rbMale.TabIndex = 0;
            rbMale.TabStop = true;
            rbMale.Text = "male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.ForeColor = Color.FromArgb(255, 128, 128);
            rbFemale.Location = new Point(185, 227);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(61, 19);
            rbFemale.TabIndex = 1;
            rbFemale.Text = "female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // cbOutlet
            // 
            cbOutlet.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbOutlet.FormattingEnabled = true;
            cbOutlet.Location = new Point(119, 255);
            cbOutlet.Margin = new Padding(4);
            cbOutlet.Name = "cbOutlet";
            cbOutlet.Size = new Size(243, 28);
            cbOutlet.TabIndex = 73;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(119, 176);
            tbPassword.Margin = new Padding(2);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(243, 23);
            tbPassword.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(13, 255);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(59, 24);
            label8.TabIndex = 23;
            label8.Text = "Outlet";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(8, 213);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(74, 24);
            label7.TabIndex = 22;
            label7.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(11, 134);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(57, 24);
            label6.TabIndex = 21;
            label6.Text = "Email";
            // 
            // tbId
            // 
            tbId.Location = new Point(119, 55);
            tbId.Margin = new Padding(2);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(243, 23);
            tbId.TabIndex = 20;
            tbId.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(11, 172);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(92, 24);
            label5.TabIndex = 19;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 93);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 24);
            label4.TabIndex = 18;
            label4.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 55);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 24);
            label3.TabIndex = 17;
            label3.Text = "Barber ID";
            // 
            // btnAddBarber
            // 
            btnAddBarber.Location = new Point(216, 319);
            btnAddBarber.Margin = new Padding(2);
            btnAddBarber.Name = "btnAddBarber";
            btnAddBarber.Size = new Size(133, 24);
            btnAddBarber.TabIndex = 16;
            btnAddBarber.Text = "Add Barber";
            btnAddBarber.UseVisualStyleBackColor = true;
            btnAddBarber.Click += btnAddBarber_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(353, 319);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(134, 24);
            btnLogout.TabIndex = 15;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 255, 192);
            btnSave.Location = new Point(79, 319);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 24);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(119, 135);
            tbEmail.Margin = new Padding(2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(243, 23);
            tbEmail.TabIndex = 14;
            // 
            // tbName
            // 
            tbName.Location = new Point(119, 93);
            tbName.Margin = new Padding(2);
            tbName.Name = "tbName";
            tbName.Size = new Size(243, 23);
            tbName.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 9);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 46);
            label2.TabIndex = 11;
            label2.Text = "Profile";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(718, 493);
            button1.Margin = new Padding(2, 4, 2, 4);
            button1.Name = "button1";
            button1.Size = new Size(186, 51);
            button1.TabIndex = 12;
            button1.Text = "edit profile";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tbBarberEmail);
            tabPage3.Controls.Add(tbBarberGender);
            tabPage3.Controls.Add(tbBarberOutlet);
            tabPage3.Controls.Add(tbBarberName);
            tabPage3.Controls.Add(tbBarberId);
            tabPage3.Controls.Add(btnAddBarber);
            tabPage3.Controls.Add(btnUpdateBarber);
            tabPage3.Controls.Add(btnDeleteBarber);
            tabPage3.Controls.Add(label18);
            tabPage3.Controls.Add(label21);
            tabPage3.Controls.Add(label22);
            tabPage3.Controls.Add(label23);
            tabPage3.Controls.Add(label24);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(dgvBarber);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(910, 639);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Barber";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbBarberEmail
            // 
            tbBarberEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbBarberEmail.Location = new Point(128, 401);
            tbBarberEmail.Name = "tbBarberEmail";
            tbBarberEmail.Size = new Size(252, 34);
            tbBarberEmail.TabIndex = 64;
            // 
            // tbBarberGender
            // 
            tbBarberGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbBarberGender.Location = new Point(128, 443);
            tbBarberGender.Name = "tbBarberGender";
            tbBarberGender.Size = new Size(252, 34);
            tbBarberGender.TabIndex = 63;
            // 
            // tbBarberOutlet
            // 
            tbBarberOutlet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbBarberOutlet.Location = new Point(128, 488);
            tbBarberOutlet.Name = "tbBarberOutlet";
            tbBarberOutlet.Size = new Size(252, 34);
            tbBarberOutlet.TabIndex = 62;
            // 
            // tbBarberName
            // 
            tbBarberName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbBarberName.Location = new Point(128, 356);
            tbBarberName.Name = "tbBarberName";
            tbBarberName.Size = new Size(252, 34);
            tbBarberName.TabIndex = 61;
            // 
            // tbBarberId
            // 
            tbBarberId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbBarberId.Location = new Point(128, 314);
            tbBarberId.Name = "tbBarberId";
            tbBarberId.Size = new Size(252, 34);
            tbBarberId.TabIndex = 60;
            // 
            // btnAddBarber
            // 
            btnAddBarber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddBarber.Location = new Point(278, 553);
            btnAddBarber.Margin = new Padding(3, 4, 3, 4);
            btnAddBarber.Name = "btnAddBarber";
            btnAddBarber.Size = new Size(102, 68);
            btnAddBarber.TabIndex = 59;
            btnAddBarber.Text = "add barber";
            btnAddBarber.UseVisualStyleBackColor = true;
            // 
            // btnUpdateBarber
            // 
            btnUpdateBarber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateBarber.Location = new Point(151, 553);
            btnUpdateBarber.Margin = new Padding(3, 4, 3, 4);
            btnUpdateBarber.Name = "btnUpdateBarber";
            btnUpdateBarber.Size = new Size(102, 68);
            btnUpdateBarber.TabIndex = 58;
            btnUpdateBarber.Text = "update barber";
            btnUpdateBarber.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBarber
            // 
            btnDeleteBarber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteBarber.Location = new Point(30, 553);
            btnDeleteBarber.Margin = new Padding(3, 4, 3, 4);
            btnDeleteBarber.Name = "btnDeleteBarber";
            btnDeleteBarber.Size = new Size(102, 68);
            btnDeleteBarber.TabIndex = 57;
            btnDeleteBarber.Text = "delete barber";
            btnDeleteBarber.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(30, 446);
            label18.Name = "label18";
            label18.Size = new Size(76, 28);
            label18.TabIndex = 49;
            label18.Text = "Gender";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(30, 491);
            label21.Name = "label21";
            label21.Size = new Size(67, 28);
            label21.TabIndex = 46;
            label21.Text = "Outlet";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.Location = new Point(30, 404);
            label22.Name = "label22";
            label22.Size = new Size(59, 28);
            label22.TabIndex = 45;
            label22.Text = "Email";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.Location = new Point(30, 359);
            label23.Name = "label23";
            label23.Size = new Size(64, 28);
            label23.TabIndex = 44;
            label23.Text = "Name";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.Location = new Point(30, 317);
            label24.Name = "label24";
            label24.Size = new Size(29, 28);
            label24.TabIndex = 43;
            label24.Text = "Id";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(5, 3);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(139, 46);
            label10.TabIndex = 13;
            label10.Text = "Barber";
            // 
            // dgvBarber
            // 
            dgvBarber.AllowUserToAddRows = false;
            dgvBarber.AllowUserToDeleteRows = false;
            dgvBarber.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBarber.Columns.AddRange(new DataGridViewColumn[] { BarberId02, BarberName, BarberEmail, BarberGender, BarberOutlet });
            dgvBarber.Location = new Point(30, 69);
            dgvBarber.Margin = new Padding(2, 3, 2, 3);
            dgvBarber.Name = "dgvBarber";
            dgvBarber.ReadOnly = true;
            dgvBarber.RowHeadersWidth = 72;
            dgvBarber.Size = new Size(849, 219);
            dgvBarber.TabIndex = 12;
            dgvBarber.CellClick += dgvBarber_CellClick;
            // 
            // BarberId02
            // 
            BarberId02.DataPropertyName = "Id";
            BarberId02.HeaderText = "Id";
            BarberId02.MinimumWidth = 6;
            BarberId02.Name = "BarberId02";
            BarberId02.ReadOnly = true;
            BarberId02.Width = 125;
            // 
            // BarberName
            // 
            BarberName.DataPropertyName = "Name";
            BarberName.HeaderText = "Name";
            BarberName.MinimumWidth = 6;
            BarberName.Name = "BarberName";
            BarberName.ReadOnly = true;
            BarberName.Width = 125;
            // 
            // BarberEmail
            // 
            BarberEmail.DataPropertyName = "Email";
            BarberEmail.HeaderText = "Email";
            BarberEmail.MinimumWidth = 6;
            BarberEmail.Name = "BarberEmail";
            BarberEmail.ReadOnly = true;
            BarberEmail.Width = 125;
            // 
            // BarberGender
            // 
            BarberGender.DataPropertyName = "Gender";
            BarberGender.HeaderText = "Gender";
            BarberGender.MinimumWidth = 6;
            BarberGender.Name = "BarberGender";
            BarberGender.ReadOnly = true;
            BarberGender.Width = 125;
            // 
            // BarberOutlet
            // 
            BarberOutlet.DataPropertyName = "oLocation";
            BarberOutlet.HeaderText = "Outlet";
            BarberOutlet.MinimumWidth = 6;
            BarberOutlet.Name = "BarberOutlet";
            BarberOutlet.ReadOnly = true;
            BarberOutlet.Width = 125;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(910, 639);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Analysis";
            tabPage4.UseVisualStyleBackColor = true;
            //
            // barbeR_serviceTableAdapter1
            // 
            barbeR_serviceTableAdapter1.ClearBeforeFill = true;
            // 
            // Barber_Home_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(942, 698);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Barber_Home_Page";
            Text = "Barber_Home_Page";
            Load += Barber_Home_Page_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBarber).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxBarber).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvBookings;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn OutletId;
        private DataGridViewTextBoxColumn OutletLocation;
        private DataGridViewTextBoxColumn BarberId;
        private DataGridViewTextBoxColumn CustId;
        private DataGridViewTextBoxColumn cName;
        private DataGridViewTextBoxColumn ServiceId;
        private DataGridViewTextBoxColumn ServiceName;
        private DataGridViewTextBoxColumn TimeslotId;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Status;
        private Label label1;
        private TabPage tabPage2;
        private Button btnSave;
        private TextBox tbEmail;
        private TextBox tbName;
        private Label label2;
        private Button btnAddBarber;
        private Button btnLogout;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
        private TextBox tbId;
        private TextBox tbPassword;
        private Label label8;
        private Label label7;
        private DataSet1TableAdapters.BARBER_SERVICETableAdapter barbeR_serviceTableAdapter1;
        private ComboBox cbOutlet;
        private Label label9;
        private CheckedListBox checkedListTimeSlot;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private GroupBox groupBox1;
        private PictureBox pictureBoxBarber;
        private Button button1;
        private Label lblService;
        private Label lblCustomer;
        private Label lblOutlet;
        private Label lblDate;
        private Label lblTimeSlot;
        private Label lblStatus;
        private Label lblBookingId;
        private Button btnCheckBooking;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnNewBooking;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label label10;
        private DataGridView dgvBarber;
        private DataGridViewTextBoxColumn BarberId02;
        private DataGridViewTextBoxColumn BarberName;
        private DataGridViewTextBoxColumn BarberEmail;
        private DataGridViewTextBoxColumn BarberGender;
        private DataGridViewTextBoxColumn BarberOutlet;
        private Label label18;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Button btnDeleteBarber;
        private Button btnUpdateBarber;
        private TextBox tbBarberId;
        private Button btnAddBarber;
        private TextBox tbBarberEmail;
        private TextBox tbBarberGender;
        private TextBox tbBarberOutlet;
        private TextBox tbBarberName;
        private CheckedListBox checkedListServices;
        private Label label11;
    }
}