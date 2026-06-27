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
            groupBoxPhoto = new GroupBox();
            labelEmail = new Label();
            pictureBoxBarber = new PictureBox();
            labelBarber = new Label();
            lId = new Label();
            lDate = new Label();
            lDesc = new Label();
            labelDate = new Label();
            labelDesc = new Label();
            labelOutlet = new Label();
            labelTimeslot = new Label();
            labelStatus = new Label();
            labelId = new Label();
            lOutlet = new Label();
            lTimeslot = new Label();
            lStatus = new Label();
            labelBookingDetails = new Label();
            labelToDo = new Label();
            panel1.SuspendLayout();
            groupBoxPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBarber).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(labelToDo);
            panel1.Controls.Add(groupBoxPhoto);
            panel1.Controls.Add(lId);
            panel1.Controls.Add(lDate);
            panel1.Controls.Add(lDesc);
            panel1.Controls.Add(labelDate);
            panel1.Controls.Add(labelDesc);
            panel1.Controls.Add(labelOutlet);
            panel1.Controls.Add(labelTimeslot);
            panel1.Controls.Add(labelStatus);
            panel1.Controls.Add(labelId);
            panel1.Controls.Add(lOutlet);
            panel1.Controls.Add(lTimeslot);
            panel1.Controls.Add(lStatus);
            panel1.Location = new Point(27, 59);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(569, 528);
            panel1.TabIndex = 0;
            // 
            // groupBoxPhoto
            // 
            groupBoxPhoto.Controls.Add(labelEmail);
            groupBoxPhoto.Controls.Add(pictureBoxBarber);
            groupBoxPhoto.Controls.Add(labelBarber);
            groupBoxPhoto.Location = new Point(349, 132);
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
            // lDesc
            // 
            lDesc.AutoSize = true;
            lDesc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lDesc.Location = new Point(31, 229);
            lDesc.Name = "lDesc";
            lDesc.Size = new Size(112, 28);
            lDesc.TabIndex = 58;
            lDesc.Text = "Description";
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
            // labelDesc
            // 
            labelDesc.AutoSize = true;
            labelDesc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDesc.Location = new Point(151, 229);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(22, 28);
            labelDesc.TabIndex = 55;
            labelDesc.Text = "a";
            // 
            // labelOutlet
            // 
            labelOutlet.AutoSize = true;
            labelOutlet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOutlet.Location = new Point(151, 104);
            labelOutlet.Name = "labelOutlet";
            labelOutlet.Size = new Size(22, 28);
            labelOutlet.TabIndex = 54;
            labelOutlet.Text = "a";
            // 
            // labelTimeslot
            // 
            labelTimeslot.AutoSize = true;
            labelTimeslot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTimeslot.Location = new Point(151, 139);
            labelTimeslot.Name = "labelTimeslot";
            labelTimeslot.Size = new Size(22, 28);
            labelTimeslot.TabIndex = 52;
            labelTimeslot.Text = "a";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStatus.Location = new Point(151, 272);
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
            lOutlet.Location = new Point(31, 104);
            lOutlet.Name = "lOutlet";
            lOutlet.Size = new Size(67, 28);
            lOutlet.TabIndex = 49;
            lOutlet.Text = "Outlet";
            // 
            // lTimeslot
            // 
            lTimeslot.AutoSize = true;
            lTimeslot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lTimeslot.Location = new Point(31, 139);
            lTimeslot.Name = "lTimeslot";
            lTimeslot.Size = new Size(86, 28);
            lTimeslot.TabIndex = 48;
            lTimeslot.Text = "Timeslot";
            // 
            // lStatus
            // 
            lStatus.AutoSize = true;
            lStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lStatus.Location = new Point(31, 272);
            lStatus.Name = "lStatus";
            lStatus.Size = new Size(65, 28);
            lStatus.TabIndex = 47;
            lStatus.Text = "Status";
            // 
            // labelBookingDetails
            // 
            labelBookingDetails.AutoSize = true;
            labelBookingDetails.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBookingDetails.Location = new Point(164, 6);
            labelBookingDetails.Name = "labelBookingDetails";
            labelBookingDetails.Size = new Size(299, 46);
            labelBookingDetails.TabIndex = 42;
            labelBookingDetails.Text = "Booking Details";
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
            // ViewBookingDetails_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(624, 609);
            Controls.Add(labelBookingDetails);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
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
        private Label labelDate;
        private Label labelDesc;
        private Label labelOutlet;
        private Label labelBarber;
        private Label labelTimeslot;
        private Label labelStatus;
        private Label labelId;
        private Label lOutlet;
        private Label lTimeslot;
        private Label lStatus;
        private GroupBox groupBoxPhoto;
        private PictureBox pictureBoxBarber;
        private Label labelEmail;
        private Label labelToDo;
    }
}