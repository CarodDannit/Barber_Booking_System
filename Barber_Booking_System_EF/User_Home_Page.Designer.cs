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
            btnSave = new Button();
            tbPassword = new TextBox();
            tbPhone = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnLogout = new Button();
            tbEmail = new TextBox();
            btnLogout = new Button();
            label2 = new Label();
            btnEditProfile = new Button();
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
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(717, 491);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(187, 51);
            button2.TabIndex = 10;
            button2.Text = "new booking";
            button2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 15);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(918, 586);
            tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvBookings);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(910, 553);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Bookings";
            tabPage1.UseVisualStyleBackColor = true;
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
            dgvBookings.Size = new Size(849, 372);
            dgvBookings.TabIndex = 11;
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
            tabPage2.Controls.Add(btnSave);
            tabPage2.Controls.Add(tbPassword);
            tabPage2.Controls.Add(tbPhone);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(btnLogout);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(btnEditProfile);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(910, 553);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Profile";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(365, 484);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(154, 51);
            btnSave.TabIndex = 21;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(289, 433);
            tbPassword.Margin = new Padding(3, 4, 3, 4);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.ReadOnly = true;
            tbPassword.Size = new Size(340, 30);
            tbPassword.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(284, 398);
            label6.Name = "label6";
            label6.Size = new Size(96, 25);
            label6.TabIndex = 19;
            label6.Text = "password";
            // 
            // tbPhone
            // 
            tbPhone.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPhone.Location = new Point(285, 330);
            tbPhone.Margin = new Padding(3, 4, 3, 4);
            tbPhone.Name = "tbPhone";
            tbPhone.PasswordChar = '*';
            tbPhone.ReadOnly = true;
            tbPhone.Size = new Size(340, 30);
            tbPhone.TabIndex = 18;
            // 
            // label5
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(717, 398);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(187, 64);
            btnSave.TabIndex = 21;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(352, 333);
            tbPassword.Margin = new Padding(2);
            tbPassword.Name = "tbPassword";
            tbPassword.ReadOnly = true;
            tbPassword.Size = new Size(118, 27);
            tbPassword.TabIndex = 20;
            tbPassword.Visible = false;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(352, 269);
            tbPhone.Margin = new Padding(2);
            tbPhone.Name = "tbPhone";
            tbPhone.ReadOnly = true;
            tbPhone.Size = new Size(118, 27);
            tbPhone.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(224, 333);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 18;
            label6.Text = "Password";
            label6.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(224, 276);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 17;
            label5.Text = "Phone No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(224, 208);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 16;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 142);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 15;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(798, 25);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(87, 27);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(352, 201);
            tbEmail.Margin = new Padding(2);
            tbEmail.Name = "tbEmail";
            tbEmail.ReadOnly = true;
            tbEmail.Size = new Size(118, 27);
            tbEmail.TabIndex = 14;
            // 
            // tbName
            // 
            tbName.Location = new Point(352, 139);
            tbName.Margin = new Padding(2);
            tbName.Name = "tbName";
            tbName.ReadOnly = true;
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
            button1.Click += button1_Click_1;
            // 
            // User_Home_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(942, 616);
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
        private TextBox tbPhone;
        private Label label5;
        private TextBox tbUsername;
        private Label label3;
        private Label label4;
        private Label label3;
        private TextBox tbPassword;
        private TextBox tbPhone;
        private Button btnSave;
    }
}