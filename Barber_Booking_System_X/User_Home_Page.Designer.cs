namespace Barber_Booking_System
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
            btnAddBooking = new Button();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            custIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            outletIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            barberIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            serviceIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeslotIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ratingDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reviewDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(257, 64);
            label1.TabIndex = 0;
            label1.Text = "Bookings";
            // 
            // btnAddBooking
            // 
            btnAddBooking.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddBooking.Location = new Point(1115, 825);
            btnAddBooking.Margin = new Padding(4, 5, 4, 5);
            btnAddBooking.Name = "btnAddBooking";
            btnAddBooking.Size = new Size(280, 78);
            btnAddBooking.TabIndex = 10;
            btnAddBooking.Text = "new booking";
            btnAddBooking.UseVisualStyleBackColor = true;
            btnAddBooking.Click += btnAddBooking_Click;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 9;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 175;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Date";
            dateDataGridViewTextBoxColumn.MinimumWidth = 9;
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.Width = 175;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 9;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.Width = 175;
            // 
            // custIdDataGridViewTextBoxColumn
            // 
            custIdDataGridViewTextBoxColumn.DataPropertyName = "Cust_Id";
            custIdDataGridViewTextBoxColumn.HeaderText = "Cust_Id";
            custIdDataGridViewTextBoxColumn.MinimumWidth = 9;
            custIdDataGridViewTextBoxColumn.Name = "custIdDataGridViewTextBoxColumn";
            custIdDataGridViewTextBoxColumn.Width = 175;
            // 
            // outletIdDataGridViewTextBoxColumn
            // 
            outletIdDataGridViewTextBoxColumn.DataPropertyName = "Outlet_Id";
            outletIdDataGridViewTextBoxColumn.HeaderText = "Outlet_Id";
            outletIdDataGridViewTextBoxColumn.MinimumWidth = 9;
            outletIdDataGridViewTextBoxColumn.Name = "outletIdDataGridViewTextBoxColumn";
            outletIdDataGridViewTextBoxColumn.Width = 175;
            // 
            // barberIdDataGridViewTextBoxColumn
            // 
            barberIdDataGridViewTextBoxColumn.DataPropertyName = "Barber_Id";
            barberIdDataGridViewTextBoxColumn.HeaderText = "Barber_Id";
            barberIdDataGridViewTextBoxColumn.MinimumWidth = 9;
            barberIdDataGridViewTextBoxColumn.Name = "barberIdDataGridViewTextBoxColumn";
            barberIdDataGridViewTextBoxColumn.Width = 175;
            // 
            // serviceIdDataGridViewTextBoxColumn
            // 
            serviceIdDataGridViewTextBoxColumn.DataPropertyName = "Service_Id";
            serviceIdDataGridViewTextBoxColumn.HeaderText = "Service_Id";
            serviceIdDataGridViewTextBoxColumn.MinimumWidth = 9;
            serviceIdDataGridViewTextBoxColumn.Name = "serviceIdDataGridViewTextBoxColumn";
            serviceIdDataGridViewTextBoxColumn.Width = 175;
            // 
            // timeslotIdDataGridViewTextBoxColumn
            // 
            timeslotIdDataGridViewTextBoxColumn.DataPropertyName = "Timeslot_Id";
            timeslotIdDataGridViewTextBoxColumn.HeaderText = "Timeslot_Id";
            timeslotIdDataGridViewTextBoxColumn.MinimumWidth = 9;
            timeslotIdDataGridViewTextBoxColumn.Name = "timeslotIdDataGridViewTextBoxColumn";
            timeslotIdDataGridViewTextBoxColumn.Width = 175;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 9;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.Width = 175;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            ratingDataGridViewTextBoxColumn.MinimumWidth = 9;
            ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            ratingDataGridViewTextBoxColumn.Width = 175;
            // 
            // reviewDataGridViewTextBoxColumn
            // 
            reviewDataGridViewTextBoxColumn.DataPropertyName = "Review";
            reviewDataGridViewTextBoxColumn.HeaderText = "Review";
            reviewDataGridViewTextBoxColumn.MinimumWidth = 9;
            reviewDataGridViewTextBoxColumn.Name = "reviewDataGridViewTextBoxColumn";
            reviewDataGridViewTextBoxColumn.Width = 175;
            // 
            // User_Home_Page
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1519, 980);
            Controls.Add(btnAddBooking);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "User_Home_Page";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outletIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barberIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeslotIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reviewDataGridViewTextBoxColumn;
    }
}