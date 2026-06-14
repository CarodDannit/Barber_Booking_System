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
            btnLogout = new Button();
            tbEmail = new TextBox();
            tbName = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            btn = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-1, 5);
            tabControl1.Margin = new Padding(2, 3, 2, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(803, 440);
            tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvBookings);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2, 3, 2, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 3, 2, 3);
            tabPage1.Size = new Size(795, 412);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Bookings";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvBookings
            // 
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.AllowUserToDeleteRows = false;
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookings.Columns.AddRange(new DataGridViewColumn[] { Id, Date, Description, OutletId, OutletLocation, BarberId, CustId, cName, ServiceId, ServiceName, TimeslotId, Time, Status });
            dgvBookings.Location = new Point(29, 54);
            dgvBookings.Margin = new Padding(2);
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.RowHeadersWidth = 72;
            dgvBookings.Size = new Size(743, 279);
            dgvBookings.TabIndex = 11;
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
            CustId.Name = "CustId";
            CustId.ReadOnly = true;
            CustId.Width = 66;
            // 
            // cName
            // 
            cName.DataPropertyName = "cName";
            cName.HeaderText = "Cust. Name";
            cName.Name = "cName";
            cName.ReadOnly = true;
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
            label1.Location = new Point(7, 6);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 37);
            label1.TabIndex = 0;
            label1.Text = "Bookings";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btn);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(btnLogout);
            tabPage2.Controls.Add(tbEmail);
            tabPage2.Controls.Add(tbName);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(button1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2, 3, 2, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 3, 2, 3);
            tabPage2.Size = new Size(795, 412);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Profile";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(302, 334);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(76, 20);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(308, 158);
            tbEmail.Margin = new Padding(2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(104, 23);
            tbEmail.TabIndex = 14;
            // 
            // tbName
            // 
            tbName.Location = new Point(239, 94);
            tbName.Margin = new Padding(2);
            tbName.Name = "tbName";
            tbName.Size = new Size(104, 23);
            tbName.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 7);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 37);
            label2.TabIndex = 11;
            label2.Text = "Profile";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(628, 370);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(163, 38);
            button1.TabIndex = 12;
            button1.Text = "edit profile";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(359, 196);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(76, 20);
            button2.TabIndex = 15;
            button2.Text = "Log out";
            button2.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            btn.Location = new Point(8, 370);
            btn.Margin = new Padding(2);
            btn.Name = "btn";
            btn.Size = new Size(91, 33);
            btn.TabIndex = 16;
            btn.Text = "Add Barber";
            btn.UseVisualStyleBackColor = true;
            // 
            // Barber_Home_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Barber_Home_Page";
            Text = "Barber_Home_Page";
            Load += Barber_Home_Page_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
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
        private Button btnLogout;
        private TextBox tbEmail;
        private TextBox tbName;
        private Label label2;
        private Button button1;
        private Button btn;
        private Button button2;
    }
}