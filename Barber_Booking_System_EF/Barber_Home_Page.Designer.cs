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
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend12 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barber_Home_Page));
            LiveChartsCore.Drawing.Padding padding23 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip12 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding24 = new LiveChartsCore.Drawing.Padding();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lIdTab1 = new Label();
            lServiceTab1 = new Label();
            lCustomerTab1 = new Label();
            lDateTab1 = new Label();
            lblService = new Label();
            lblCustomer = new Label();
            lblOutlet = new Label();
            lblDate = new Label();
            lblTimeSlot = new Label();
            lblStatus = new Label();
            lblBookingId = new Label();
            btnCheckBooking = new Button();
            lOutletTab1 = new Label();
            lTimeslotTab1 = new Label();
            lStatusTab1 = new Label();
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
            groupBox1 = new GroupBox();
            pictureBoxBarber = new PictureBox();
            checkedListTimeSlot = new CheckedListBox();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            cbOutlet = new ComboBox();
            tbPassword = new TextBox();
            tbId = new TextBox();
            label90 = new Label();
            label80 = new Label();
            label70 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnLogout = new Button();
            btnSave = new Button();
            btnUpload = new Button();
            tbEmail = new TextBox();
            tbName = new TextBox();
            label2 = new Label();
            tabPage3 = new TabPage();
            btnAddBarber = new Button();
            tbBarberEmail = new TextBox();
            tbBarberGender = new TextBox();
            tbBarberOutlet = new TextBox();
            tbBarberName = new TextBox();
            tbBarberId = new TextBox();
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
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            btnGenerate = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label50 = new Label();
            label40 = new Label();
            label30 = new Label();
            label7 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBarber).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBarber).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
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
            tabPage1.Controls.Add(lIdTab1);
            tabPage1.Controls.Add(lServiceTab1);
            tabPage1.Controls.Add(lCustomerTab1);
            tabPage1.Controls.Add(lDateTab1);
            tabPage1.Controls.Add(lblService);
            tabPage1.Controls.Add(lblCustomer);
            tabPage1.Controls.Add(lblOutlet);
            tabPage1.Controls.Add(lblDate);
            tabPage1.Controls.Add(lblTimeSlot);
            tabPage1.Controls.Add(lblStatus);
            tabPage1.Controls.Add(lblBookingId);
            tabPage1.Controls.Add(btnCheckBooking);
            tabPage1.Controls.Add(lOutletTab1);
            tabPage1.Controls.Add(lTimeslotTab1);
            tabPage1.Controls.Add(lStatusTab1);
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
            // lIdTab1
            // 
            lIdTab1.AutoSize = true;
            lIdTab1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lIdTab1.Location = new Point(34, 318);
            lIdTab1.Name = "lIdTab1";
            lIdTab1.Size = new Size(31, 28);
            lIdTab1.TabIndex = 46;
            lIdTab1.Text = "ID";
            // 
            // lServiceTab1
            // 
            lServiceTab1.AutoSize = true;
            lServiceTab1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lServiceTab1.Location = new Point(34, 346);
            lServiceTab1.Name = "lServiceTab1";
            lServiceTab1.Size = new Size(74, 28);
            lServiceTab1.TabIndex = 45;
            lServiceTab1.Text = "Service";
            // 
            // lCustomerTab1
            // 
            lCustomerTab1.AutoSize = true;
            lCustomerTab1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lCustomerTab1.Location = new Point(34, 374);
            lCustomerTab1.Name = "lCustomerTab1";
            lCustomerTab1.Size = new Size(96, 28);
            lCustomerTab1.TabIndex = 44;
            lCustomerTab1.Text = "Customer";
            // 
            // lDateTab1
            // 
            lDateTab1.AutoSize = true;
            lDateTab1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lDateTab1.Location = new Point(34, 430);
            lDateTab1.Name = "lDateTab1";
            lDateTab1.Size = new Size(53, 28);
            lDateTab1.TabIndex = 43;
            lDateTab1.Text = "Date";
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
            // lOutletTab1
            // 
            lOutletTab1.AutoSize = true;
            lOutletTab1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lOutletTab1.Location = new Point(34, 402);
            lOutletTab1.Name = "lOutletTab1";
            lOutletTab1.Size = new Size(67, 28);
            lOutletTab1.TabIndex = 34;
            lOutletTab1.Text = "Outlet";
            // 
            // lTimeslotTab1
            // 
            lTimeslotTab1.AutoSize = true;
            lTimeslotTab1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lTimeslotTab1.Location = new Point(34, 458);
            lTimeslotTab1.Name = "lTimeslotTab1";
            lTimeslotTab1.Size = new Size(89, 28);
            lTimeslotTab1.TabIndex = 33;
            lTimeslotTab1.Text = "TimeSlot";
            // 
            // lStatusTab1
            // 
            lStatusTab1.AutoSize = true;
            lStatusTab1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lStatusTab1.Location = new Point(34, 486);
            lStatusTab1.Name = "lStatusTab1";
            lStatusTab1.Size = new Size(65, 28);
            lStatusTab1.TabIndex = 32;
            lStatusTab1.Text = "Status";
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
            Id.HeaderText = "Iiiiid";
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
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(checkedListTimeSlot);
            tabPage2.Controls.Add(rbMale);
            tabPage2.Controls.Add(rbFemale);
            tabPage2.Controls.Add(cbOutlet);
            tabPage2.Controls.Add(tbPassword);
            tabPage2.Controls.Add(tbId);
            tabPage2.Controls.Add(label90);
            tabPage2.Controls.Add(label80);
            tabPage2.Controls.Add(label70);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(btnLogout);
            tabPage2.Controls.Add(btnSave);
            tabPage2.Controls.Add(btnUpload);
            tabPage2.Controls.Add(tbEmail);
            tabPage2.Controls.Add(tbName);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 29);
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
            checkedListServices.Location = new Point(49, 416);
            checkedListServices.Margin = new Padding(2, 2, 2, 2);
            checkedListServices.Name = "checkedListServices";
            checkedListServices.Size = new Size(222, 114);
            checkedListServices.TabIndex = 87;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(49, 386);
            label11.Margin = new Padding(1, 0, 1, 0);
            label11.Name = "label11";
            label11.Size = new Size(78, 25);
            label11.TabIndex = 86;
            label11.Text = "Servies";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBoxBarber);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(610, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(229, 221);
            groupBox1.TabIndex = 82;
            groupBox1.TabStop = false;
            groupBox1.Text = "Barber Photo Profile";
            // 
            // pictureBoxBarber
            // 
            pictureBoxBarber.Image = Properties.Resources.rukia04;
            pictureBoxBarber.Location = new Point(6, 26);
            pictureBoxBarber.Name = "pictureBoxBarber";
            pictureBoxBarber.Size = new Size(217, 183);
            pictureBoxBarber.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBarber.TabIndex = 25;
            pictureBoxBarber.TabStop = false;
            // 
            // checkedListTimeSlot
            // 
            checkedListTimeSlot.FormattingEnabled = true;
            checkedListTimeSlot.Location = new Point(301, 416);
            checkedListTimeSlot.Margin = new Padding(2, 2, 2, 2);
            checkedListTimeSlot.Name = "checkedListTimeSlot";
            checkedListTimeSlot.Size = new Size(236, 114);
            checkedListTimeSlot.TabIndex = 74;
            checkedListTimeSlot.SelectedIndexChanged += checkedListTimeSlot_SelectedIndexChanged;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Checked = true;
            rbMale.Font = new Font("Segoe UI", 12F);
            rbMale.ForeColor = Color.FromArgb(128, 128, 255);
            rbMale.Location = new Point(162, 262);
            rbMale.Margin = new Padding(2, 2, 2, 2);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(75, 32);
            rbMale.TabIndex = 0;
            rbMale.TabStop = true;
            rbMale.Text = "male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Segoe UI", 12F);
            rbFemale.ForeColor = Color.FromArgb(255, 128, 128);
            rbFemale.Location = new Point(257, 262);
            rbFemale.Margin = new Padding(2, 2, 2, 2);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(91, 32);
            rbFemale.TabIndex = 1;
            rbFemale.Text = "female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // cbOutlet
            // 
            cbOutlet.Font = new Font("Microsoft Sans Serif", 12F);
            cbOutlet.FormattingEnabled = true;
            cbOutlet.Location = new Point(162, 323);
            cbOutlet.Name = "cbOutlet";
            cbOutlet.Size = new Size(243, 33);
            cbOutlet.TabIndex = 73;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Microsoft Sans Serif", 12F);
            tbPassword.Location = new Point(162, 209);
            tbPassword.Margin = new Padding(1, 1, 1, 1);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(243, 30);
            tbPassword.TabIndex = 24;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // tbId
            // 
            tbId.Font = new Font("Microsoft Sans Serif", 12F);
            tbId.Location = new Point(162, 64);
            tbId.Margin = new Padding(1, 1, 1, 1);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(243, 30);
            tbId.TabIndex = 20;
            tbId.TabStop = false;
            tbId.TextChanged += tbId_TextChanged;
            // 
            // label90
            // 
            label90.AutoSize = true;
            label90.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label90.Location = new Point(301, 386);
            label90.Margin = new Padding(1, 0, 1, 0);
            label90.Name = "label90";
            label90.Size = new Size(95, 25);
            label90.TabIndex = 75;
            label90.Text = "Time Slot";
            label90.Click += this.label90_Click;
            // 
            // label80
            // 
            label80.AutoSize = true;
            label80.Font = new Font("Microsoft Sans Serif", 12F);
            label80.Location = new Point(49, 326);
            label80.Margin = new Padding(1, 0, 1, 0);
            label80.Name = "label80";
            label80.Size = new Size(64, 25);
            label80.TabIndex = 23;
            label80.Text = "Outlet";
            // 
            // label70
            // 
            label70.AutoSize = true;
            label70.Font = new Font("Microsoft Sans Serif", 12F);
            label70.Location = new Point(49, 267);
            label70.Margin = new Padding(1, 0, 1, 0);
            label70.Name = "label70";
            label70.Size = new Size(77, 25);
            label70.TabIndex = 22;
            label70.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(49, 161);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(60, 25);
            label6.TabIndex = 21;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(49, 209);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(98, 25);
            label5.TabIndex = 19;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(49, 112);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 18;
            label4.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 67);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 17;
            label3.Text = "Barber ID";
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(761, 582);
            btnLogout.Margin = new Padding(1, 1, 1, 1);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(123, 42);
            btnLogout.TabIndex = 15;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 255, 192);
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(616, 582);
            btnSave.Margin = new Padding(1, 1, 1, 1);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(123, 42);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpload
            // 
            btnUpload.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpload.Location = new Point(664, 279);
            btnUpload.Margin = new Padding(1);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(123, 42);
            btnUpload.TabIndex = 83;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Microsoft Sans Serif", 12F);
            tbEmail.Location = new Point(162, 158);
            tbEmail.Margin = new Padding(1, 1, 1, 1);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(243, 30);
            tbEmail.TabIndex = 14;
            tbEmail.TextChanged += tbEmail_TextChanged;
            // 
            // tbName
            // 
            tbName.Font = new Font("Microsoft Sans Serif", 12F);
            tbName.Location = new Point(162, 110);
            tbName.Margin = new Padding(1, 1, 1, 1);
            tbName.Name = "tbName";
            tbName.Size = new Size(243, 30);
            tbName.TabIndex = 13;
            tbName.TextChanged += tbName_TextChanged;
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
            // tabPage3
            // 
            tabPage3.Controls.Add(btnAddBarber);
            tabPage3.Controls.Add(tbBarberEmail);
            tabPage3.Controls.Add(tbBarberGender);
            tabPage3.Controls.Add(tbBarberOutlet);
            tabPage3.Controls.Add(tbBarberName);
            tabPage3.Controls.Add(tbBarberId);
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
            //tabPage3.Click += this.tabPage3_Click;
            // 
            // btnAddBarber
            // 
            btnAddBarber.BackColor = Color.DeepSkyBlue;
            btnAddBarber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddBarber.Location = new Point(223, 577);
            btnAddBarber.Margin = new Padding(2, 3, 2, 3);
            btnAddBarber.Name = "btnAddBarber";
            btnAddBarber.Size = new Size(157, 44);
            btnAddBarber.TabIndex = 59;
            btnAddBarber.Text = "create barber";
            btnAddBarber.UseVisualStyleBackColor = false;
            btnAddBarber.Click += btnAddBarber_Click;
            // 
            // tbBarberEmail
            // 
            tbBarberEmail.BackColor = Color.PaleTurquoise;
            tbBarberEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbBarberEmail.Location = new Point(128, 401);
            tbBarberEmail.Name = "tbBarberEmail";
            tbBarberEmail.Size = new Size(252, 34);
            tbBarberEmail.TabIndex = 64;
            tbBarberEmail.TextChanged += tbBarberEmail_TextChanged;
            // 
            // tbBarberGender
            // 
            tbBarberGender.BackColor = Color.PaleTurquoise;
            tbBarberGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbBarberGender.Location = new Point(128, 443);
            tbBarberGender.Name = "tbBarberGender";
            tbBarberGender.Size = new Size(252, 34);
            tbBarberGender.TabIndex = 63;
            //tbBarberGender.TextChanged += this.tbBarberGender_TextChanged;
            // 
            // tbBarberOutlet
            // 
            tbBarberOutlet.BackColor = Color.PaleTurquoise;
            tbBarberOutlet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbBarberOutlet.Location = new Point(128, 488);
            tbBarberOutlet.Name = "tbBarberOutlet";
            tbBarberOutlet.Size = new Size(252, 34);
            tbBarberOutlet.TabIndex = 62;
            // 
            // tbBarberName
            // 
            tbBarberName.BackColor = Color.PaleTurquoise;
            tbBarberName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbBarberName.Location = new Point(128, 356);
            tbBarberName.Name = "tbBarberName";
            tbBarberName.Size = new Size(252, 34);
            tbBarberName.TabIndex = 61;
            //tbBarberName.TextChanged += this.tbBarberName_TextChanged;
            // 
            // tbBarberId
            // 
            tbBarberId.BackColor = Color.PaleTurquoise;
            tbBarberId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbBarberId.Location = new Point(128, 314);
            tbBarberId.Name = "tbBarberId";
            tbBarberId.ReadOnly = true;
            tbBarberId.Size = new Size(252, 34);
            tbBarberId.TabIndex = 60;
            tbBarberId.TextChanged += tbBarberId_TextChanged;
            // 
            // btnDeleteBarber
            // 
            btnDeleteBarber.BackColor = Color.DeepSkyBlue;
            btnDeleteBarber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteBarber.ForeColor = Color.White;
            btnDeleteBarber.Location = new Point(30, 553);
            btnDeleteBarber.Margin = new Padding(3, 4, 3, 4);
            btnDeleteBarber.Name = "btnDeleteBarber";
            btnDeleteBarber.Size = new Size(157, 44);
            btnDeleteBarber.TabIndex = 57;
            btnDeleteBarber.Text = "delete barber";
            btnDeleteBarber.UseVisualStyleBackColor = false;
            btnDeleteBarber.Click += btnDeleteBarber_Click;
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
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(pieChart1);
            tabPage4.Controls.Add(btnGenerate);
            tabPage4.Controls.Add(chart1);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(910, 639);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Analysis";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // pieChart1
            // 
            pieChart1.AutoUpdateEnabled = true;
            pieChart1.ChartTheme = null;
            skDefaultLegend12.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultLegend12.Content = null;
            skDefaultLegend12.IsValid = false;
            skDefaultLegend12.Opacity = 1F;
            padding23.Bottom = 0F;
            padding23.Left = 0F;
            padding23.Right = 0F;
            padding23.Top = 0F;
            skDefaultLegend12.Padding = padding23;
            skDefaultLegend12.RemoveOnCompleted = false;
            skDefaultLegend12.RotateTransform = 0F;
            skDefaultLegend12.X = 0F;
            skDefaultLegend12.Y = 0F;
            pieChart1.Legend = skDefaultLegend12;
            pieChart1.Location = new Point(566, 116);
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(300, 300);
            pieChart1.TabIndex = 3;
            skDefaultTooltip12.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultTooltip12.Content = null;
            skDefaultTooltip12.IsValid = false;
            skDefaultTooltip12.Opacity = 1F;
            padding24.Bottom = 0F;
            padding24.Left = 0F;
            padding24.Right = 0F;
            padding24.Top = 0F;
            skDefaultTooltip12.Padding = padding24;
            skDefaultTooltip12.RemoveOnCompleted = false;
            skDefaultTooltip12.RotateTransform = 0F;
            skDefaultTooltip12.Wedge = 10;
            skDefaultTooltip12.X = 0F;
            skDefaultTooltip12.Y = 0F;
            pieChart1.Tooltip = skDefaultTooltip12;
            pieChart1.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
            pieChart1.Load += pieChart1_Load_2;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.DeepSkyBlue;
            btnGenerate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(325, 500);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(264, 91);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "GENERATE";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // chart1
            // 
            chartArea12.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            chart1.Legends.Add(legend12);
            chart1.Location = new Point(26, 41);
            chart1.Name = "chart1";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            chart1.Series.Add(series12);
            chart1.Size = new Size(500, 375);
            chart1.TabIndex = 1;
            chart1.Text = "chart1";
            chart1.Click += chart1_Click;
            // 
            // label50
            // 
            label50.Location = new Point(0, 0);
            label50.Name = "label50";
            label50.Size = new Size(100, 23);
            label50.TabIndex = 0;
            // 
            // label40
            // 
            label40.Location = new Point(0, 0);
            label40.Name = "label40";
            label40.Size = new Size(100, 23);
            label40.TabIndex = 0;
            // 
            // label30
            // 
            label30.Location = new Point(0, 0);
            label30.Name = "label30";
            label30.Size = new Size(100, 23);
            label30.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(592, 71);
            label7.Name = "label7";
            label7.Size = new Size(260, 25);
            label7.TabIndex = 4;
            label7.Text = "Total Booking By Customers";
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
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxBarber).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBarber).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvBookings;
        private Label label1;
        private TabPage tabPage2;
        private Button btnSave;
        private Button btnUpload;
        private TextBox tbEmail;
        private TextBox tbName;
        private Label label2;
        private Button btnLogout;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
        private TextBox tbId;
        private TextBox tbPassword;
        private Label lTimeslotTab1;
        private Label lStatusTab1;
        private ComboBox cbOutlet;
        private Label lOutletTab1;
        private CheckedListBox checkedListTimeSlot;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private GroupBox groupBox1;
        private PictureBox pictureBoxBarber;
        private Label lblService;
        private Label lblCustomer;
        private Label lblOutlet;
        private Label lblDate;
        private Label lblTimeSlot;
        private Label lblStatus;
        private Label lblBookingId;
        private Button btnCheckBooking;
        private Label label90;
        private Label label80;
        private Label label70;
        private Label label50;
        private Label label40;
        private Label label30;
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
        private TextBox tbBarberId;
        private TextBox tbBarberEmail;
        private TextBox tbBarberGender;
        private TextBox tbBarberOutlet;
        private TextBox tbBarberName;
        private CheckedListBox checkedListServices;
        private Label label11;
        private Button btnAddBarber;
        private Label lDateTab1;
        private Label lServiceTab1;
        private Label lCustomerTab1;
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
        private Label lIdTab1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button btnGenerate;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private Label label7;
    }
}