namespace Barber_Booking_System_EF
{
    partial class Book_Appointment_Page
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
            panel1 = new Panel();
            cbTimeslot = new ComboBox();
            groupBox1 = new GroupBox();
            pictureBoxBarber = new PictureBox();
            btnBook = new Button();
            label4 = new Label();
            calendar = new MonthCalendar();
            label3 = new Label();
            cbService = new ComboBox();
            label1 = new Label();
            cbBarber = new ComboBox();
            label5 = new Label();
            cbOutlet = new ComboBox();
            label2 = new Label();
            btnBack = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBarber).BeginInit();
            SuspendLayout();
            // 
            // labelRegister
            // 
            labelRegister.AutoSize = true;
            labelRegister.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRegister.Location = new Point(426, 17);
            labelRegister.Margin = new Padding(4, 0, 4, 0);
            labelRegister.Name = "labelRegister";
            labelRegister.Size = new Size(484, 64);
            labelRegister.TabIndex = 41;
            labelRegister.Text = "Book Appointment";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(cbTimeslot);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnBook);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(calendar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cbService);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbBarber);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cbOutlet);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(216, 120);
            panel1.Margin = new Padding(4, 6, 4, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 1153);
            panel1.TabIndex = 42;
            // 
            // cbTimeslot
            // 
            cbTimeslot.Enabled = false;
            cbTimeslot.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTimeslot.FormattingEnabled = true;
            cbTimeslot.Location = new Point(36, 990);
            cbTimeslot.Margin = new Padding(6, 8, 6, 8);
            cbTimeslot.Name = "cbTimeslot";
            cbTimeslot.Size = new Size(534, 40);
            cbTimeslot.TabIndex = 66;
            cbTimeslot.SelectedIndexChanged += cbTimeslot_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBoxBarber);
            groupBox1.Location = new Point(656, 562);
            groupBox1.Margin = new Padding(6, 8, 6, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 8, 6, 8);
            groupBox1.Size = new Size(264, 326);
            groupBox1.TabIndex = 65;
            groupBox1.TabStop = false;
            groupBox1.Text = "Barber Photo Profile";
            // 
            // pictureBoxBarber
            // 
            pictureBoxBarber.Location = new Point(12, 43);
            pictureBoxBarber.Margin = new Padding(6, 8, 6, 8);
            pictureBoxBarber.Name = "pictureBoxBarber";
            pictureBoxBarber.Size = new Size(240, 268);
            pictureBoxBarber.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBarber.TabIndex = 25;
            pictureBoxBarber.TabStop = false;
            // 
            // btnBook
            // 
            btnBook.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBook.Location = new Point(668, 1026);
            btnBook.Margin = new Padding(4);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(264, 77);
            btnBook.TabIndex = 64;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 932);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(134, 32);
            label4.TabIndex = 63;
            label4.Text = "Time Slot";
            // 
            // calendar
            // 
            calendar.Location = new Point(36, 103);
            calendar.Margin = new Padding(18, 21, 18, 21);
            calendar.MaxSelectionCount = 1;
            calendar.Name = "calendar";
            calendar.TabIndex = 61;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 772);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 32);
            label3.TabIndex = 60;
            label3.Text = "Service";
            // 
            // cbService
            // 
            cbService.Enabled = false;
            cbService.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbService.FormattingEnabled = true;
            cbService.Location = new Point(36, 826);
            cbService.Margin = new Padding(6, 8, 6, 8);
            cbService.Name = "cbService";
            cbService.Size = new Size(534, 40);
            cbService.TabIndex = 59;
            cbService.SelectedIndexChanged += cbService_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 633);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 32);
            label1.TabIndex = 58;
            label1.Text = "Barber";
            // 
            // cbBarber
            // 
            cbBarber.Enabled = false;
            cbBarber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbBarber.FormattingEnabled = true;
            cbBarber.Location = new Point(36, 688);
            cbBarber.Margin = new Padding(6, 8, 6, 8);
            cbBarber.Name = "cbBarber";
            cbBarber.Size = new Size(534, 40);
            cbBarber.TabIndex = 57;
            cbBarber.SelectedIndexChanged += cbBarber_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(28, 504);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 32);
            label5.TabIndex = 56;
            label5.Text = "Outlet";
            // 
            // cbOutlet
            // 
            cbOutlet.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbOutlet.FormattingEnabled = true;
            cbOutlet.Location = new Point(36, 558);
            cbOutlet.Margin = new Padding(6, 8, 6, 8);
            cbOutlet.Name = "cbOutlet";
            cbOutlet.Size = new Size(534, 40);
            cbOutlet.TabIndex = 55;
            cbOutlet.SelectedIndexChanged += cbOutlet_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 36);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(199, 32);
            label2.TabIndex = 54;
            label2.Text = "Date and Time";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(1142, 21);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(222, 77);
            btnBack.TabIndex = 66;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Book_Appointment_Page
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Lime;
            ClientSize = new Size(1413, 1036);
            Controls.Add(btnBack);
            Controls.Add(panel1);
            Controls.Add(labelRegister);
            Margin = new Padding(6, 8, 6, 8);
            Name = "Book_Appointment_Page";
            Text = "Book Appointment";
            Load += Book_Appointment_Page_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxBarber).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxBarber;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBarber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbOutlet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private ComboBox cbTimeslot;
    }
}