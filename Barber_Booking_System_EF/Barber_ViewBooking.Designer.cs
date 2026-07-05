namespace Barber_Booking_System_EF
{
    partial class Barber_ViewBooking
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
            panel1 = new Panel();
            labelPrice = new Label();
            labelService = new Label();
            lPrice = new Label();
            lService = new Label();
            btnOK = new Button();
            groupBoxCust = new GroupBox();
            labelEmail = new Label();
            labelCust = new Label();
            lId = new Label();
            lDate = new Label();
            labelDate = new Label();
            labelOutlet = new Label();
            labelTimeslot = new Label();
            labelStatus = new Label();
            labelId = new Label();
            lOutlet = new Label();
            lTimeslot = new Label();
            lStatus = new Label();
            labelBookingDetails = new Label();
            panel1.SuspendLayout();
            groupBoxCust.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BlanchedAlmond;
            panel1.Controls.Add(labelPrice);
            panel1.Controls.Add(labelService);
            panel1.Controls.Add(lPrice);
            panel1.Controls.Add(lService);
            panel1.Controls.Add(btnOK);
            panel1.Controls.Add(groupBoxCust);
            panel1.Controls.Add(lId);
            panel1.Controls.Add(lDate);
            panel1.Controls.Add(labelDate);
            panel1.Controls.Add(labelOutlet);
            panel1.Controls.Add(labelTimeslot);
            panel1.Controls.Add(labelStatus);
            panel1.Controls.Add(labelId);
            panel1.Controls.Add(lOutlet);
            panel1.Controls.Add(lTimeslot);
            panel1.Controls.Add(lStatus);
            panel1.Location = new Point(27, 59);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(569, 458);
            panel1.TabIndex = 0;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrice.Location = new Point(151, 240);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(22, 28);
            labelPrice.TabIndex = 73;
            labelPrice.Text = "a";
            // 
            // labelService
            // 
            labelService.AutoSize = true;
            labelService.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelService.Location = new Point(151, 203);
            labelService.Name = "labelService";
            labelService.Size = new Size(22, 28);
            labelService.TabIndex = 72;
            labelService.Text = "a";
            // 
            // lPrice
            // 
            lPrice.AutoSize = true;
            lPrice.Font = new Font("Segoe UI", 12F);
            lPrice.Location = new Point(31, 240);
            lPrice.Name = "lPrice";
            lPrice.Size = new Size(54, 28);
            lPrice.TabIndex = 71;
            lPrice.Text = "Price";
            // 
            // lService
            // 
            lService.AutoSize = true;
            lService.Font = new Font("Segoe UI", 12F);
            lService.Location = new Point(31, 203);
            lService.Name = "lService";
            lService.Size = new Size(74, 28);
            lService.TabIndex = 70;
            lService.Text = "Service";
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.Gold;
            btnOK.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOK.Location = new Point(406, 379);
            btnOK.Margin = new Padding(3, 4, 3, 4);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(137, 51);
            btnOK.TabIndex = 68;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // groupBoxCust
            // 
            groupBoxCust.BackColor = SystemColors.InactiveCaption;
            groupBoxCust.Controls.Add(labelEmail);
            groupBoxCust.Controls.Add(labelCust);
            groupBoxCust.Location = new Point(349, 132);
            groupBoxCust.Margin = new Padding(4, 5, 4, 5);
            groupBoxCust.Name = "groupBoxCust";
            groupBoxCust.Padding = new Padding(4, 5, 4, 5);
            groupBoxCust.Size = new Size(194, 146);
            groupBoxCust.TabIndex = 66;
            groupBoxCust.TabStop = false;
            groupBoxCust.Text = "Customer details";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = SystemColors.ButtonHighlight;
            labelEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(7, 108);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(49, 20);
            labelEmail.TabIndex = 54;
            labelEmail.Text = "Email:";
            labelEmail.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelCust
            // 
            labelCust.BackColor = SystemColors.ButtonHighlight;
            labelCust.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCust.Location = new Point(22, 38);
            labelCust.Name = "labelCust";
            labelCust.Size = new Size(149, 28);
            labelCust.TabIndex = 53;
            labelCust.Text = "a";
            labelCust.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lId
            // 
            lId.AutoSize = true;
            lId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lId.Location = new Point(31, 34);
            lId.Name = "lId";
            lId.Size = new Size(31, 28);
            lId.TabIndex = 60;
            lId.Text = "ID";
            // 
            // lDate
            // 
            lDate.AutoSize = true;
            lDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lDate.Location = new Point(31, 71);
            lDate.Name = "lDate";
            lDate.Size = new Size(53, 28);
            lDate.TabIndex = 59;
            lDate.Text = "Date";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDate.Location = new Point(151, 71);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(22, 28);
            labelDate.TabIndex = 56;
            labelDate.Text = "a";
            // 
            // labelOutlet
            // 
            labelOutlet.AutoSize = true;
            labelOutlet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOutlet.Location = new Point(151, 139);
            labelOutlet.Name = "labelOutlet";
            labelOutlet.Size = new Size(22, 28);
            labelOutlet.TabIndex = 54;
            labelOutlet.Text = "a";
            // 
            // labelTimeslot
            // 
            labelTimeslot.AutoSize = true;
            labelTimeslot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTimeslot.Location = new Point(151, 106);
            labelTimeslot.Name = "labelTimeslot";
            labelTimeslot.Size = new Size(22, 28);
            labelTimeslot.TabIndex = 52;
            labelTimeslot.Text = "a";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStatus.Location = new Point(151, 297);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(22, 28);
            labelStatus.TabIndex = 51;
            labelStatus.Text = "a";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelId.Location = new Point(151, 34);
            labelId.Name = "labelId";
            labelId.Size = new Size(22, 28);
            labelId.TabIndex = 50;
            labelId.Text = "a";
            // 
            // lOutlet
            // 
            lOutlet.AutoSize = true;
            lOutlet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lOutlet.Location = new Point(31, 139);
            lOutlet.Name = "lOutlet";
            lOutlet.Size = new Size(67, 28);
            lOutlet.TabIndex = 49;
            lOutlet.Text = "Outlet";
            // 
            // lTimeslot
            // 
            lTimeslot.AutoSize = true;
            lTimeslot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lTimeslot.Location = new Point(31, 106);
            lTimeslot.Name = "lTimeslot";
            lTimeslot.Size = new Size(86, 28);
            lTimeslot.TabIndex = 48;
            lTimeslot.Text = "Timeslot";
            // 
            // lStatus
            // 
            lStatus.AutoSize = true;
            lStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lStatus.Location = new Point(31, 297);
            lStatus.Name = "lStatus";
            lStatus.Size = new Size(65, 28);
            lStatus.TabIndex = 47;
            lStatus.Text = "Status";
            // 
            // labelBookingDetails
            // 
            labelBookingDetails.AutoSize = true;
            labelBookingDetails.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBookingDetails.ForeColor = Color.White;
            labelBookingDetails.Location = new Point(147, 9);
            labelBookingDetails.Name = "labelBookingDetails";
            labelBookingDetails.Size = new Size(330, 43);
            labelBookingDetails.TabIndex = 42;
            labelBookingDetails.Text = "Booking Details";
            // 
            // Barber_ViewBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            ClientSize = new Size(624, 549);
            Controls.Add(labelBookingDetails);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Barber_ViewBooking";
            Text = "Barber_ViewBooking";
            Load += ViewBookingDetails_Page_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBoxCust.ResumeLayout(false);
            groupBoxCust.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelBookingDetails;
        private Label lId;
        private Label lDate;
        private Label labelDate;
        private Label labelOutlet;
        private Label labelCust;
        private Label labelTimeslot;
        private Label labelStatus;
        private Label labelId;
        private Label lOutlet;
        private Label lTimeslot;
        private Label lStatus;
        private GroupBox groupBoxCust;
        private Label labelEmail;
        private Button btnOK;
        private Label lPrice;
        private Label lService;
        private Label labelPrice;
        private Label labelService;
    }
}