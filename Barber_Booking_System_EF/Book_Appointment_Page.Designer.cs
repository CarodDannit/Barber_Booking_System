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
            groupBox1 = new GroupBox();
            pictureBoxBarber = new PictureBox();
            btnBook = new Button();
            label4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            button1 = new Button();
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
            tableLayoutPanel1.SuspendLayout();
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
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnBook);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tableLayoutPanel1);
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
            panel1.Size = new Size(960, 1432);
            panel1.TabIndex = 42;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBoxBarber);
            groupBox1.Location = new Point(656, 598);
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
            pictureBoxBarber.Image = Properties.Resources.rukia04;
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
            btnBook.Location = new Point(656, 1312);
            btnBook.Margin = new Padding(4);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(264, 77);
            btnBook.TabIndex = 64;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 968);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(134, 32);
            label4.TabIndex = 63;
            label4.Text = "Time Slot";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.61111F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.38889F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 153F));
            tableLayoutPanel1.Controls.Add(button8, 3, 1);
            tableLayoutPanel1.Controls.Add(button7, 2, 1);
            tableLayoutPanel1.Controls.Add(button6, 0, 1);
            tableLayoutPanel1.Controls.Add(button5, 3, 0);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button4, 1, 1);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Location = new Point(33, 1022);
            tableLayoutPanel1.Margin = new Padding(6, 8, 6, 8);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.3871F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.6129F));
            tableLayoutPanel1.Size = new Size(586, 210);
            tableLayoutPanel1.TabIndex = 62;
            // 
            // button8
            // 
            button8.Location = new Point(438, 109);
            button8.Margin = new Padding(6, 8, 6, 8);
            button8.Name = "button8";
            button8.Size = new Size(130, 93);
            button8.TabIndex = 10;
            button8.Text = "1:30 PM";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(288, 109);
            button7.Margin = new Padding(6, 8, 6, 8);
            button7.Name = "button7";
            button7.Size = new Size(130, 93);
            button7.TabIndex = 9;
            button7.Text = "1:00 PM";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(6, 109);
            button6.Margin = new Padding(6, 8, 6, 8);
            button6.Name = "button6";
            button6.Size = new Size(125, 93);
            button6.TabIndex = 8;
            button6.Text = "12:00 PM";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(438, 8);
            button5.Margin = new Padding(6, 8, 6, 8);
            button5.Name = "button5";
            button5.Size = new Size(136, 85);
            button5.TabIndex = 7;
            button5.Text = "11:30 AM";
            button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(288, 8);
            button3.Margin = new Padding(6, 8, 6, 8);
            button3.Name = "button3";
            button3.Size = new Size(130, 85);
            button3.TabIndex = 6;
            button3.Text = "11 AM";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(143, 8);
            button2.Margin = new Padding(6, 8, 6, 8);
            button2.Name = "button2";
            button2.Size = new Size(130, 85);
            button2.TabIndex = 5;
            button2.Text = "10:30 AM";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(143, 109);
            button4.Margin = new Padding(6, 8, 6, 8);
            button4.Name = "button4";
            button4.Size = new Size(130, 93);
            button4.TabIndex = 3;
            button4.Text = "12:30 PM";
            button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(6, 8);
            button1.Margin = new Padding(6, 8, 6, 8);
            button1.Name = "button1";
            button1.Size = new Size(125, 85);
            button1.TabIndex = 4;
            button1.Text = "10:00 AM";
            button1.UseVisualStyleBackColor = true;
            // 
            // calendar
            // 
            calendar.Location = new Point(36, 103);
            calendar.Margin = new Padding(18, 21, 18, 21);
            calendar.Name = "calendar";
            calendar.TabIndex = 61;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 808);
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
            cbService.Location = new Point(36, 862);
            cbService.Margin = new Padding(6, 8, 6, 8);
            cbService.Name = "cbService";
            cbService.Size = new Size(534, 40);
            cbService.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 669);
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
            cbBarber.Location = new Point(36, 724);
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
            label5.Location = new Point(28, 540);
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
            cbOutlet.Location = new Point(36, 594);
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
            ClientSize = new Size(1413, 1564);
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
            tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBarber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbOutlet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
    }
}