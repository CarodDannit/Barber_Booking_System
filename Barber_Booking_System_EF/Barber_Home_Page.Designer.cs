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
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barber_Home_Page));
            LiveChartsCore.Drawing.Padding padding1 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding2 = new LiveChartsCore.Drawing.Padding();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnCompleteBooking = new Button();
            btnAcceptBooking = new Button();
            btnRejectButton = new Button();
            lIdTab1 = new Label();
            lServiceTab1 = new Label();
            lCustomerTab1 = new Label();
            lDateTab1 = new Label();
            lblService = new Label();
            lblCustomer = new Label();
            lblDate = new Label();
            lblStatus = new Label();
            lblBookingId = new Label();
            btnViewDetails = new Button();
            lStatusTab1 = new Label();
            dgvBookings = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            sName = new DataGridViewTextBoxColumn();
            cName = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
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
            label15 = new Label();
            label14 = new Label();
            label7 = new Label();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            btnGenerate = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabPage5 = new TabPage();
            lblHighMonRev = new Label();
            lblAvgMonRev = new Label();
            lblTotalRev = new Label();
            label13 = new Label();
            label12 = new Label();
            label9 = new Label();
            btnGenerateRevenue = new Button();
            chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label8 = new Label();
            labelToDoRevenue = new Label();
            label50 = new Label();
            label40 = new Label();
            label30 = new Label();
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
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartRevenue).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(11, 13);
            tabControl1.Margin = new Padding(2, 4, 2, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(918, 672);
            tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.BlanchedAlmond;
            tabPage1.Controls.Add(btnCompleteBooking);
            tabPage1.Controls.Add(btnAcceptBooking);
            tabPage1.Controls.Add(btnRejectButton);
            tabPage1.Controls.Add(lIdTab1);
            tabPage1.Controls.Add(lServiceTab1);
            tabPage1.Controls.Add(lCustomerTab1);
            tabPage1.Controls.Add(lDateTab1);
            tabPage1.Controls.Add(lblService);
            tabPage1.Controls.Add(lblCustomer);
            tabPage1.Controls.Add(lblDate);
            tabPage1.Controls.Add(lblStatus);
            tabPage1.Controls.Add(lblBookingId);
            tabPage1.Controls.Add(btnViewDetails);
            tabPage1.Controls.Add(lStatusTab1);
            tabPage1.Controls.Add(dgvBookings);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2, 4, 2, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 4, 2, 4);
            tabPage1.Size = new Size(910, 639);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Bookings";
            // 
            // btnCompleteBooking
            // 
            btnCompleteBooking.BackColor = Color.Gold;
            btnCompleteBooking.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompleteBooking.Location = new Point(588, 544);
            btnCompleteBooking.Margin = new Padding(3, 4, 3, 4);
            btnCompleteBooking.Name = "btnCompleteBooking";
            btnCompleteBooking.Size = new Size(159, 51);
            btnCompleteBooking.TabIndex = 50;
            btnCompleteBooking.Text = "Complete";
            btnCompleteBooking.UseVisualStyleBackColor = false;
            btnCompleteBooking.Visible = false;
            btnCompleteBooking.Click += btnCompleteBooking_Click;
            // 
            // btnAcceptBooking
            // 
            btnAcceptBooking.BackColor = Color.Gold;
            btnAcceptBooking.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAcceptBooking.Location = new Point(400, 544);
            btnAcceptBooking.Margin = new Padding(3, 4, 3, 4);
            btnAcceptBooking.Name = "btnAcceptBooking";
            btnAcceptBooking.Size = new Size(159, 51);
            btnAcceptBooking.TabIndex = 49;
            btnAcceptBooking.Text = "Accept";
            btnAcceptBooking.UseVisualStyleBackColor = false;
            btnAcceptBooking.Click += btnAcceptBooking_Click;
            // 
            // btnRejectButton
            // 
            btnRejectButton.BackColor = Color.Gold;
            btnRejectButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRejectButton.Location = new Point(215, 544);
            btnRejectButton.Margin = new Padding(3, 4, 3, 4);
            btnRejectButton.Name = "btnRejectButton";
            btnRejectButton.Size = new Size(159, 51);
            btnRejectButton.TabIndex = 48;
            btnRejectButton.Text = "Reject";
            btnRejectButton.UseVisualStyleBackColor = false;
            btnRejectButton.Click += btnRejectButton_Click;
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
            lDateTab1.Location = new Point(34, 402);
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
            lblService.Size = new Size(22, 28);
            lblService.TabIndex = 42;
            lblService.Text = "a";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomer.Location = new Point(155, 374);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(22, 28);
            lblCustomer.TabIndex = 41;
            lblCustomer.Text = "a";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(155, 402);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(22, 28);
            lblDate.TabIndex = 39;
            lblDate.Text = "a";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(155, 430);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(22, 28);
            lblStatus.TabIndex = 37;
            lblStatus.Text = "a";
            // 
            // lblBookingId
            // 
            lblBookingId.AutoSize = true;
            lblBookingId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookingId.Location = new Point(155, 318);
            lblBookingId.Name = "lblBookingId";
            lblBookingId.Size = new Size(22, 28);
            lblBookingId.TabIndex = 36;
            lblBookingId.Text = "a";
            // 
            // btnViewDetails
            // 
            btnViewDetails.BackColor = Color.Gold;
            btnViewDetails.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewDetails.Location = new Point(34, 544);
            btnViewDetails.Margin = new Padding(3, 4, 3, 4);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(159, 51);
            btnViewDetails.TabIndex = 35;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // lStatusTab1
            // 
            lStatusTab1.AutoSize = true;
            lStatusTab1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lStatusTab1.Location = new Point(34, 430);
            lStatusTab1.Name = "lStatusTab1";
            lStatusTab1.Size = new Size(65, 28);
            lStatusTab1.TabIndex = 32;
            lStatusTab1.Text = "Status";
            // 
            // dgvBookings
            // 
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.AllowUserToDeleteRows = false;
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookings.Columns.AddRange(new DataGridViewColumn[] { Id, sName, cName, Date, Time, Status });
            dgvBookings.Location = new Point(33, 72);
            dgvBookings.Margin = new Padding(2, 3, 2, 3);
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.RowHeadersWidth = 20;
            dgvBookings.Size = new Size(849, 219);
            dgvBookings.TabIndex = 11;
            dgvBookings.CellClick += dgvBookings_CellClick;
            dgvBookings.CellContentClick += dgvBookings_CellContentClick;
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
            sName.MinimumWidth = 6;
            sName.Name = "sName";
            sName.ReadOnly = true;
            sName.Width = 125;
            // 
            // cName
            // 
            cName.DataPropertyName = "cName";
            cName.HeaderText = "Customer";
            cName.MinimumWidth = 6;
            cName.Name = "cName";
            cName.ReadOnly = true;
            cName.Width = 125;
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
            Status.Width = 175;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 4);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(170, 46);
            label1.TabIndex = 0;
            label1.Text = "Bookings";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.BlanchedAlmond;
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
            // 
            // checkedListServices
            // 
            checkedListServices.BackColor = SystemColors.InactiveCaption;
            checkedListServices.FormattingEnabled = true;
            checkedListServices.Location = new Point(49, 416);
            checkedListServices.Margin = new Padding(2);
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
            label11.Text = "Service";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveCaption;
            groupBox1.Controls.Add(pictureBoxBarber);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(637, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(175, 221);
            groupBox1.TabIndex = 82;
            groupBox1.TabStop = false;
            groupBox1.Text = "Photo Profile";
            // 
            // pictureBoxBarber
            // 
            pictureBoxBarber.Image = Properties.Resources.rukia04;
            pictureBoxBarber.Location = new Point(6, 32);
            pictureBoxBarber.Name = "pictureBoxBarber";
            pictureBoxBarber.Size = new Size(160, 180);
            pictureBoxBarber.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBarber.TabIndex = 25;
            pictureBoxBarber.TabStop = false;
            // 
            // checkedListTimeSlot
            // 
            checkedListTimeSlot.BackColor = SystemColors.InactiveCaption;
            checkedListTimeSlot.FormattingEnabled = true;
            checkedListTimeSlot.Location = new Point(301, 416);
            checkedListTimeSlot.Margin = new Padding(2);
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
            rbMale.Margin = new Padding(2);
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
            rbFemale.Margin = new Padding(2);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(91, 32);
            rbFemale.TabIndex = 1;
            rbFemale.Text = "female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // cbOutlet
            // 
            cbOutlet.BackColor = SystemColors.InactiveCaption;
            cbOutlet.Font = new Font("Microsoft Sans Serif", 12F);
            cbOutlet.FormattingEnabled = true;
            cbOutlet.Location = new Point(162, 323);
            cbOutlet.Name = "cbOutlet";
            cbOutlet.Size = new Size(243, 33);
            cbOutlet.TabIndex = 73;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = SystemColors.InactiveCaption;
            tbPassword.Font = new Font("Microsoft Sans Serif", 12F);
            tbPassword.Location = new Point(162, 209);
            tbPassword.Margin = new Padding(1);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(243, 30);
            tbPassword.TabIndex = 24;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // tbId
            // 
            tbId.BackColor = SystemColors.InactiveCaption;
            tbId.Font = new Font("Microsoft Sans Serif", 12F);
            tbId.Location = new Point(162, 64);
            tbId.Margin = new Padding(1);
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
            label90.Click += label90_Click;
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
            btnLogout.BackColor = Color.Gold;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(761, 582);
            btnLogout.Margin = new Padding(1);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(123, 42);
            btnLogout.TabIndex = 15;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Gold;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(616, 582);
            btnSave.Margin = new Padding(1);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(123, 42);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.Gold;
            btnUpload.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpload.Location = new Point(664, 279);
            btnUpload.Margin = new Padding(1);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(123, 42);
            btnUpload.TabIndex = 83;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = SystemColors.InactiveCaption;
            tbEmail.Font = new Font("Microsoft Sans Serif", 12F);
            tbEmail.Location = new Point(162, 158);
            tbEmail.Margin = new Padding(1);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(243, 30);
            tbEmail.TabIndex = 14;
            tbEmail.TextChanged += tbEmail_TextChanged;
            // 
            // tbName
            // 
            tbName.BackColor = SystemColors.InactiveCaption;
            tbName.Font = new Font("Microsoft Sans Serif", 12F);
            tbName.Location = new Point(162, 110);
            tbName.Margin = new Padding(1);
            tbName.Name = "tbName";
            tbName.Size = new Size(243, 30);
            tbName.TabIndex = 13;
            tbName.TextChanged += tbName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 9);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 46);
            label2.TabIndex = 11;
            label2.Text = "Profile";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.BlanchedAlmond;
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
            // 
            // btnAddBarber
            // 
            btnAddBarber.BackColor = Color.Gold;
            btnAddBarber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddBarber.Location = new Point(223, 553);
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
            tbBarberEmail.BackColor = SystemColors.InactiveCaption;
            tbBarberEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbBarberEmail.Location = new Point(128, 401);
            tbBarberEmail.Name = "tbBarberEmail";
            tbBarberEmail.ReadOnly = true;
            tbBarberEmail.Size = new Size(252, 34);
            tbBarberEmail.TabIndex = 64;
            tbBarberEmail.TextChanged += tbBarberEmail_TextChanged;
            // 
            // tbBarberGender
            // 
            tbBarberGender.BackColor = SystemColors.InactiveCaption;
            tbBarberGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbBarberGender.Location = new Point(128, 443);
            tbBarberGender.Name = "tbBarberGender";
            tbBarberGender.ReadOnly = true;
            tbBarberGender.Size = new Size(252, 34);
            tbBarberGender.TabIndex = 63;
            // 
            // tbBarberOutlet
            // 
            tbBarberOutlet.BackColor = SystemColors.InactiveCaption;
            tbBarberOutlet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbBarberOutlet.Location = new Point(128, 488);
            tbBarberOutlet.Name = "tbBarberOutlet";
            tbBarberOutlet.ReadOnly = true;
            tbBarberOutlet.Size = new Size(252, 34);
            tbBarberOutlet.TabIndex = 62;
            // 
            // tbBarberName
            // 
            tbBarberName.BackColor = SystemColors.InactiveCaption;
            tbBarberName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbBarberName.Location = new Point(128, 356);
            tbBarberName.Name = "tbBarberName";
            tbBarberName.ReadOnly = true;
            tbBarberName.Size = new Size(252, 34);
            tbBarberName.TabIndex = 61;
            // 
            // tbBarberId
            // 
            tbBarberId.BackColor = SystemColors.InactiveCaption;
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
            btnDeleteBarber.BackColor = Color.Gold;
            btnDeleteBarber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteBarber.ForeColor = SystemColors.ControlText;
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
            label10.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(5, 3);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(127, 46);
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
            dgvBarber.RowHeadersWidth = 20;
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
            tabPage4.BackColor = Color.BlanchedAlmond;
            tabPage4.Controls.Add(label15);
            tabPage4.Controls.Add(label14);
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
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(6, 3);
            label15.Name = "label15";
            label15.Size = new Size(151, 46);
            label15.TabIndex = 6;
            label15.Text = "Analysis";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(23, 136);
            label14.Name = "label14";
            label14.Size = new Size(218, 20);
            label14.TabIndex = 5;
            label14.Text = "Total Haircut By Customers";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(572, 136);
            label7.Name = "label7";
            label7.Size = new Size(223, 20);
            label7.TabIndex = 4;
            label7.Text = "Total Booking By Customers";
            label7.Click += label7_Click;
            // 
            // pieChart1
            // 
            pieChart1.AutoUpdateEnabled = true;
            pieChart1.ChartTheme = null;
            skDefaultLegend1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultLegend1.Content = null;
            skDefaultLegend1.IsValid = false;
            skDefaultLegend1.Opacity = 1F;
            padding1.Bottom = 0F;
            padding1.Left = 0F;
            padding1.Right = 0F;
            padding1.Top = 0F;
            skDefaultLegend1.Padding = padding1;
            skDefaultLegend1.RemoveOnCompleted = false;
            skDefaultLegend1.RotateTransform = 0F;
            skDefaultLegend1.X = 0F;
            skDefaultLegend1.Y = 0F;
            pieChart1.Legend = skDefaultLegend1;
            pieChart1.Location = new Point(572, 170);
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(300, 300);
            pieChart1.TabIndex = 3;
            skDefaultTooltip1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultTooltip1.Content = null;
            skDefaultTooltip1.IsValid = false;
            skDefaultTooltip1.Opacity = 1F;
            padding2.Bottom = 0F;
            padding2.Left = 0F;
            padding2.Right = 0F;
            padding2.Top = 0F;
            skDefaultTooltip1.Padding = padding2;
            skDefaultTooltip1.RemoveOnCompleted = false;
            skDefaultTooltip1.RotateTransform = 0F;
            skDefaultTooltip1.Wedge = 10;
            skDefaultTooltip1.X = 0F;
            skDefaultTooltip1.Y = 0F;
            pieChart1.Tooltip = skDefaultTooltip1;
            pieChart1.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
            pieChart1.Load += pieChart1_Load_2;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.Gold;
            btnGenerate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.Black;
            btnGenerate.Location = new Point(704, 573);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(200, 60);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "GENERATE";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // chart1
            // 
            chart1.BackColor = SystemColors.InactiveCaption;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(23, 170);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(500, 375);
            chart1.TabIndex = 1;
            chart1.Text = "chart1";
            chart1.Click += chart1_Click;
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.BlanchedAlmond;
            tabPage5.Controls.Add(lblHighMonRev);
            tabPage5.Controls.Add(lblAvgMonRev);
            tabPage5.Controls.Add(lblTotalRev);
            tabPage5.Controls.Add(label13);
            tabPage5.Controls.Add(label12);
            tabPage5.Controls.Add(label9);
            tabPage5.Controls.Add(btnGenerateRevenue);
            tabPage5.Controls.Add(chartRevenue);
            tabPage5.Controls.Add(label8);
            tabPage5.Controls.Add(labelToDoRevenue);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(910, 639);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Revenue";
            // 
            // lblHighMonRev
            // 
            lblHighMonRev.AutoSize = true;
            lblHighMonRev.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHighMonRev.Location = new Point(721, 430);
            lblHighMonRev.Name = "lblHighMonRev";
            lblHighMonRev.Size = new Size(22, 28);
            lblHighMonRev.TabIndex = 50;
            lblHighMonRev.Text = "a";
            // 
            // lblAvgMonRev
            // 
            lblAvgMonRev.AutoSize = true;
            lblAvgMonRev.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvgMonRev.Location = new Point(745, 375);
            lblAvgMonRev.Name = "lblAvgMonRev";
            lblAvgMonRev.Size = new Size(22, 28);
            lblAvgMonRev.TabIndex = 49;
            lblAvgMonRev.Text = "a";
            // 
            // lblTotalRev
            // 
            lblTotalRev.AutoSize = true;
            lblTotalRev.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalRev.Location = new Point(695, 325);
            lblTotalRev.Name = "lblTotalRev";
            lblTotalRev.Size = new Size(22, 28);
            lblTotalRev.TabIndex = 48;
            lblTotalRev.Text = "a";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(553, 430);
            label13.Name = "label13";
            label13.Size = new Size(162, 28);
            label13.TabIndex = 47;
            label13.Text = "Highest Monthly:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(553, 375);
            label12.Name = "label12";
            label12.Size = new Size(186, 28);
            label12.TabIndex = 46;
            label12.Text = "Average per Month:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(553, 325);
            label9.Name = "label9";
            label9.Size = new Size(136, 28);
            label9.TabIndex = 45;
            label9.Text = "Total Revenue:";
            // 
            // btnGenerateRevenue
            // 
            btnGenerateRevenue.BackColor = Color.Gold;
            btnGenerateRevenue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerateRevenue.ForeColor = Color.Black;
            btnGenerateRevenue.Location = new Point(704, 573);
            btnGenerateRevenue.Name = "btnGenerateRevenue";
            btnGenerateRevenue.Size = new Size(200, 60);
            btnGenerateRevenue.TabIndex = 16;
            btnGenerateRevenue.Text = "GENERATE";
            btnGenerateRevenue.UseVisualStyleBackColor = false;
            btnGenerateRevenue.Click += btnGenerateRevenue_Click;
            // 
            // chartRevenue
            // 
            chartRevenue.BackColor = SystemColors.InactiveCaption;
            chartArea2.Name = "ChartArea1";
            chartRevenue.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartRevenue.Legends.Add(legend2);
            chartRevenue.Location = new Point(36, 83);
            chartRevenue.Name = "chartRevenue";
            chartRevenue.RightToLeft = RightToLeft.No;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartRevenue.Series.Add(series2);
            chartRevenue.Size = new Size(495, 375);
            chartRevenue.TabIndex = 15;
            chartRevenue.Text = "chart2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(2, 3);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(155, 46);
            label8.TabIndex = 14;
            label8.Text = "Revenue";
            // 
            // labelToDoRevenue
            // 
            labelToDoRevenue.AutoSize = true;
            labelToDoRevenue.Location = new Point(398, 29);
            labelToDoRevenue.Name = "labelToDoRevenue";
            labelToDoRevenue.Size = new Size(446, 20);
            labelToDoRevenue.TabIndex = 0;
            labelToDoRevenue.Text = "almost cam analysis. Services mana buat berapa banyak profit, etc";
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
            // Barber_Home_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
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
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartRevenue).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
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
        private ComboBox cbOutlet;
        private CheckedListBox checkedListTimeSlot;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private GroupBox groupBox1;
        private PictureBox pictureBoxBarber;
        private Label lblService;
        private Label lblCustomer;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button btnGenerate;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private Label label7;
        private TabPage tabPage5;
        private TabPage tabPage1;
        private Label lIdTab1;
        private Label lServiceTab1;
        private Label lCustomerTab1;
        private Label lDateTab1;
        private Button btnViewDetails;
        private Label lStatusTab1;
        private DataGridView dgvBookings;
        private Label label1;
        private Label labelToDoRevenue;
        private Button btnAcceptBooking;
        private Button btnRejectButton;
        private Button btnCompleteBooking;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private Label label8;
        private Button btnGenerateRevenue;
        private Label label9;
        private Label label13;
        private Label label12;
        private Label lblHighMonRev;
        private Label lblAvgMonRev;
        private Label lblTotalRev;
        private Label label15;
        private Label label14;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn sName;
        private DataGridViewTextBoxColumn cName;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Status;
    }
}