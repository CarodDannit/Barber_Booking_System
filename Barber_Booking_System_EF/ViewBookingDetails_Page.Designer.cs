namespace Barber_Booking_System_EF
{
    partial class ViewBookingDetails_Page
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
            labelToDo = new Label();
            tbPrice = new TextBox();
            tbService = new TextBox();
            tbOutlet = new TextBox();
            tbTimeslot = new TextBox();
            tbDate = new TextBox();
            tbId = new TextBox();
            tbDesc = new TextBox();
            btnClose = new Button();
            btnSave = new Button();
            lPrice = new Label();
            lService = new Label();
            groupBoxPhoto = new GroupBox();
            labelEmail = new Label();
            pictureBoxBarber = new PictureBox();
            labelBarber = new Label();
            lId = new Label();
            lDate = new Label();
            lDesc = new Label();
            labelStatus = new Label();
            lOutlet = new Label();
            lTimeslot = new Label();
            lStatus = new Label();
            labelBookingDetails = new Label();
            panel1.SuspendLayout();
            groupBoxPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBarber).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BlanchedAlmond;
            panel1.Controls.Add(labelToDo);
            panel1.Controls.Add(tbPrice);
            panel1.Controls.Add(tbService);
            panel1.Controls.Add(tbOutlet);
            panel1.Controls.Add(tbTimeslot);
            panel1.Controls.Add(tbDate);
            panel1.Controls.Add(tbId);
            panel1.Controls.Add(tbDesc);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(lPrice);
            panel1.Controls.Add(lService);
            panel1.Controls.Add(groupBoxPhoto);
            panel1.Controls.Add(lId);
            panel1.Controls.Add(lDate);
            panel1.Controls.Add(lDesc);
            panel1.Controls.Add(labelStatus);
            panel1.Controls.Add(lOutlet);
            panel1.Controls.Add(lTimeslot);
            panel1.Controls.Add(lStatus);
            panel1.Location = new Point(27, 59);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(722, 528);
            panel1.TabIndex = 0;
            // 
            // labelToDo
            // 
            labelToDo.AutoSize = true;
            labelToDo.Location = new Point(57, 383);
            labelToDo.Name = "labelToDo";
            labelToDo.Size = new Size(94, 20);
            labelToDo.TabIndex = 67;
            labelToDo.Text = "service, price";
            //
            // tbPrice
            // 
            tbPrice.Font = new Font("Microsoft Sans Serif", 12F);
            tbPrice.Location = new Point(151, 259);
            tbPrice.Margin = new Padding(1);
            tbPrice.Name = "tbPrice";
            tbPrice.ReadOnly = true;
            tbPrice.Size = new Size(112, 30);
            tbPrice.TabIndex = 80;
            tbPrice.TabStop = false;
            // 
            // tbService
            // 
            tbService.Font = new Font("Microsoft Sans Serif", 12F);
            tbService.Location = new Point(151, 222);
            tbService.Margin = new Padding(1);
            tbService.Name = "tbService";
            tbService.ReadOnly = true;
            tbService.Size = new Size(240, 30);
            tbService.TabIndex = 79;
            tbService.TabStop = false;
            // 
            // tbOutlet
            // 
            tbOutlet.Font = new Font("Microsoft Sans Serif", 12F);
            tbOutlet.Location = new Point(151, 147);
            tbOutlet.Margin = new Padding(1);
            tbOutlet.Name = "tbOutlet";
            tbOutlet.ReadOnly = true;
            tbOutlet.Size = new Size(240, 30);
            tbOutlet.TabIndex = 78;
            tbOutlet.TabStop = false;
            // 
            // tbTimeslot
            // 
            tbTimeslot.Font = new Font("Microsoft Sans Serif", 12F);
            tbTimeslot.Location = new Point(151, 110);
            tbTimeslot.Margin = new Padding(1);
            tbTimeslot.Name = "tbTimeslot";
            tbTimeslot.ReadOnly = true;
            tbTimeslot.Size = new Size(112, 30);
            tbTimeslot.TabIndex = 77;
            tbTimeslot.TabStop = false;
            // 
            // tbDate
            // 
            tbDate.Font = new Font("Microsoft Sans Serif", 12F);
            tbDate.Location = new Point(151, 71);
            tbDate.Margin = new Padding(1);
            tbDate.Name = "tbDate";
            tbDate.ReadOnly = true;
            tbDate.Size = new Size(240, 30);
            tbDate.TabIndex = 76;
            tbDate.TabStop = false;
            // 
            // tbId
            // 
            tbId.Font = new Font("Microsoft Sans Serif", 12F);
            tbId.Location = new Point(151, 34);
            tbId.Margin = new Padding(1);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(58, 30);
            tbId.TabIndex = 75;
            tbId.TabStop = false;
            // 
            // tbDesc
            // 
            tbDesc.Font = new Font("Microsoft Sans Serif", 12F);
            tbDesc.Location = new Point(151, 300);
            tbDesc.Multiline = true;
            tbDesc.Name = "tbDesc";
            tbDesc.ScrollBars = ScrollBars.Vertical;
            tbDesc.Size = new Size(228, 64);
            tbDesc.TabIndex = 74;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(579, 463);
            btnClose.Margin = new Padding(1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(123, 42);
            btnClose.TabIndex = 73;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 255, 192);
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(434, 463);
            btnSave.Margin = new Padding(1);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(123, 42);
            btnSave.TabIndex = 72;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lPrice
            // 
            lPrice.AutoSize = true;
            lPrice.Font = new Font("Microsoft Sans Serif", 12F);
            lPrice.Location = new Point(33, 262);
            lPrice.Name = "lPrice";
            lPrice.Size = new Size(56, 25);
            lPrice.TabIndex = 69;
            lPrice.Text = "Price";
            // 
            // lService
            // 
            lService.AutoSize = true;
            lService.Font = new Font("Microsoft Sans Serif", 12F);
            lService.Location = new Point(33, 225);
            lService.Name = "lService";
            lService.Size = new Size(78, 25);
            lService.TabIndex = 68;
            lService.Text = "Service";
            // 
            // groupBoxPhoto
            // 
            groupBoxPhoto.BackColor = SystemColors.InactiveCaption;
            groupBoxPhoto.Controls.Add(labelEmail);
            groupBoxPhoto.Controls.Add(pictureBoxBarber);
            groupBoxPhoto.Controls.Add(labelBarber);
            groupBoxPhoto.Location = new Point(494, 34);
            groupBoxPhoto.Margin = new Padding(4, 5, 4, 5);
            groupBoxPhoto.Name = "groupBoxPhoto";
            groupBoxPhoto.Padding = new Padding(4, 5, 4, 5);
            groupBoxPhoto.Size = new Size(194, 294);
            groupBoxPhoto.TabIndex = 66;
            groupBoxPhoto.TabStop = false;
            groupBoxPhoto.Text = "Barber details";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = SystemColors.ButtonHighlight;
            labelEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(8, 254);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(49, 20);
            labelEmail.TabIndex = 54;
            labelEmail.Text = "Email:";
            labelEmail.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBoxBarber
            // 
            pictureBoxBarber.Location = new Point(8, 29);
            pictureBoxBarber.Margin = new Padding(4, 5, 4, 5);
            pictureBoxBarber.Name = "pictureBoxBarber";
            pictureBoxBarber.Size = new Size(178, 179);
            pictureBoxBarber.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBarber.TabIndex = 25;
            pictureBoxBarber.TabStop = false;
            // 
            // labelBarber
            // 
            labelBarber.AutoSize = true;
            labelBarber.BackColor = SystemColors.ButtonHighlight;
            labelBarber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBarber.Location = new Point(79, 219);
            labelBarber.Name = "labelBarber";
            labelBarber.Size = new Size(22, 28);
            labelBarber.TabIndex = 53;
            labelBarber.Text = "a";
            labelBarber.TextAlign = ContentAlignment.TopCenter;
            // 
            // lId
            // 
            lId.AutoSize = true;
            lId.Font = new Font("Microsoft Sans Serif", 12F);
            lId.Location = new Point(33, 37);
            lId.Name = "lId";
            lId.Size = new Size(31, 25);
            lId.TabIndex = 60;
            lId.Text = "ID";
            // 
            // lDate
            // 
            lDate.AutoSize = true;
            lDate.Font = new Font("Microsoft Sans Serif", 12F);
            lDate.Location = new Point(33, 74);
            lDate.Name = "lDate";
            lDate.Size = new Size(53, 25);
            lDate.TabIndex = 59;
            lDate.Text = "Date";
            // 
            // lDesc
            // 
            lDesc.AutoSize = true;
            lDesc.Font = new Font("Microsoft Sans Serif", 12F);
            lDesc.Location = new Point(33, 299);
            lDesc.Name = "lDesc";
            lDesc.Size = new Size(109, 25);
            lDesc.TabIndex = 58;
            lDesc.Text = "Description";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStatus.Location = new Point(151, 395);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(22, 28);
            labelStatus.TabIndex = 51;
            labelStatus.Text = "a";
            // 
            // lOutlet
            // 
            lOutlet.AutoSize = true;
            lOutlet.Font = new Font("Microsoft Sans Serif", 12F);
            lOutlet.Location = new Point(33, 150);
            lOutlet.Name = "lOutlet";
            lOutlet.Size = new Size(64, 25);
            lOutlet.TabIndex = 49;
            lOutlet.Text = "Outlet";
            // 
            // lTimeslot
            // 
            lTimeslot.AutoSize = true;
            lTimeslot.Font = new Font("Microsoft Sans Serif", 12F);
            lTimeslot.Location = new Point(33, 113);
            lTimeslot.Name = "lTimeslot";
            lTimeslot.Size = new Size(86, 25);
            lTimeslot.TabIndex = 48;
            lTimeslot.Text = "Timeslot";
            // 
            // lStatus
            // 
            lStatus.AutoSize = true;
            lStatus.Font = new Font("Microsoft Sans Serif", 12F);
            lStatus.Location = new Point(33, 398);
            lStatus.Name = "lStatus";
            lStatus.Size = new Size(68, 25);
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
            // ViewBookingDetails_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            ClientSize = new Size(624, 609);
            Controls.Add(labelBookingDetails);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "ViewBookingDetails_Page";
            Text = "ViewBookingDetails_Page";
            Load += ViewBookingDetails_Page_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBoxPhoto.ResumeLayout(false);
            groupBoxPhoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBarber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelBookingDetails;
        private Label lId;
        private Label lDate;
        private Label lDesc;
        private Label labelBarber;
        private Label labelStatus;
        private Label lOutlet;
        private Label lTimeslot;
        private Label lStatus;
        private Label labelToDo;
        private GroupBox groupBoxPhoto;
        private PictureBox pictureBoxBarber;
        private Label labelEmail;
        private Label lPrice;
        private Label lService;
        private Button btnClose;
        private Button btnSave;
        private TextBox tbDesc;
        private TextBox tbId;
        private TextBox tbOutlet;
        private TextBox tbTimeslot;
        private TextBox tbDate;
        private TextBox tbPrice;
        private TextBox tbService;
    }
}