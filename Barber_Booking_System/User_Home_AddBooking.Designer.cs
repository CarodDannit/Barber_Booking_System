namespace Barber_Booking_System
{
    partial class User_Home_AddBooking
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Home_AddBooking));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label cust_IdLabel;
            System.Windows.Forms.Label outlet_IdLabel;
            System.Windows.Forms.Label barber_IdLabel;
            System.Windows.Forms.Label service_IdLabel;
            System.Windows.Forms.Label timeslot_IdLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label ratingLabel;
            System.Windows.Forms.Label reviewLabel;
            this.bekasIceCream = new Barber_Booking_System.BekasIceCream();
            this.bOOKINGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKINGTableAdapter = new Barber_Booking_System.BekasIceCreamTableAdapters.BOOKINGTableAdapter();
            this.tableAdapterManager = new Barber_Booking_System.BekasIceCreamTableAdapters.TableAdapterManager();
            this.bOOKINGBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bOOKINGBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.cust_IdTextBox = new System.Windows.Forms.TextBox();
            this.outlet_IdTextBox = new System.Windows.Forms.TextBox();
            this.barber_IdTextBox = new System.Windows.Forms.TextBox();
            this.service_IdTextBox = new System.Windows.Forms.TextBox();
            this.timeslot_IdTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.reviewTextBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            cust_IdLabel = new System.Windows.Forms.Label();
            outlet_IdLabel = new System.Windows.Forms.Label();
            barber_IdLabel = new System.Windows.Forms.Label();
            service_IdLabel = new System.Windows.Forms.Label();
            timeslot_IdLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            reviewLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bekasIceCream)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKINGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKINGBindingNavigator)).BeginInit();
            this.bOOKINGBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bekasIceCream
            // 
            this.bekasIceCream.DataSetName = "BekasIceCream";
            this.bekasIceCream.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOOKINGBindingSource
            // 
            this.bOOKINGBindingSource.DataMember = "BOOKING";
            this.bOOKINGBindingSource.DataSource = this.bekasIceCream;
            // 
            // bOOKINGTableAdapter
            // 
            this.bOOKINGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BARBER_SERVICETableAdapter = null;
            this.tableAdapterManager.BARBERTableAdapter = null;
            this.tableAdapterManager.BOOKINGTableAdapter = this.bOOKINGTableAdapter;
            this.tableAdapterManager.CUSTOMERTableAdapter = null;
            this.tableAdapterManager.OUTLETTableAdapter = null;
            this.tableAdapterManager.SCHEDULETableAdapter = null;
            this.tableAdapterManager.SERVICETableAdapter = null;
            this.tableAdapterManager.TIMESLOTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Barber_Booking_System.BekasIceCreamTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bOOKINGBindingNavigator
            // 
            this.bOOKINGBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bOOKINGBindingNavigator.BindingSource = this.bOOKINGBindingSource;
            this.bOOKINGBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bOOKINGBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bOOKINGBindingNavigator.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.bOOKINGBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bOOKINGBindingNavigatorSaveItem});
            this.bOOKINGBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bOOKINGBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bOOKINGBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bOOKINGBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bOOKINGBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bOOKINGBindingNavigator.Name = "bOOKINGBindingNavigator";
            this.bOOKINGBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bOOKINGBindingNavigator.Size = new System.Drawing.Size(854, 38);
            this.bOOKINGBindingNavigator.TabIndex = 0;
            this.bOOKINGBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 35);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(61, 32);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bOOKINGBindingNavigatorSaveItem
            // 
            this.bOOKINGBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bOOKINGBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bOOKINGBindingNavigatorSaveItem.Image")));
            this.bOOKINGBindingNavigatorSaveItem.Name = "bOOKINGBindingNavigatorSaveItem";
            this.bOOKINGBindingNavigatorSaveItem.Size = new System.Drawing.Size(40, 32);
            this.bOOKINGBindingNavigatorSaveItem.Text = "Save Data";
            this.bOOKINGBindingNavigatorSaveItem.Click += new System.EventHandler(this.bOOKINGBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(125, 157);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(34, 25);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKINGBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(246, 154);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 29);
            this.idTextBox.TabIndex = 2;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(125, 193);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(59, 25);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "Date:";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bOOKINGBindingSource, "Date", true));
            this.dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDateTimePicker.Location = new System.Drawing.Point(246, 189);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.dateDateTimePicker.TabIndex = 4;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(125, 227);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(115, 25);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKINGBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(246, 224);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 29);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // cust_IdLabel
            // 
            cust_IdLabel.AutoSize = true;
            cust_IdLabel.Location = new System.Drawing.Point(125, 262);
            cust_IdLabel.Name = "cust_IdLabel";
            cust_IdLabel.Size = new System.Drawing.Size(80, 25);
            cust_IdLabel.TabIndex = 7;
            cust_IdLabel.Text = "Cust Id:";
            // 
            // cust_IdTextBox
            // 
            this.cust_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKINGBindingSource, "Cust_Id", true));
            this.cust_IdTextBox.Location = new System.Drawing.Point(246, 259);
            this.cust_IdTextBox.Name = "cust_IdTextBox";
            this.cust_IdTextBox.Size = new System.Drawing.Size(200, 29);
            this.cust_IdTextBox.TabIndex = 8;
            // 
            // outlet_IdLabel
            // 
            outlet_IdLabel.AutoSize = true;
            outlet_IdLabel.Location = new System.Drawing.Point(125, 297);
            outlet_IdLabel.Name = "outlet_IdLabel";
            outlet_IdLabel.Size = new System.Drawing.Size(91, 25);
            outlet_IdLabel.TabIndex = 9;
            outlet_IdLabel.Text = "Outlet Id:";
            // 
            // outlet_IdTextBox
            // 
            this.outlet_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKINGBindingSource, "Outlet_Id", true));
            this.outlet_IdTextBox.Location = new System.Drawing.Point(246, 294);
            this.outlet_IdTextBox.Name = "outlet_IdTextBox";
            this.outlet_IdTextBox.Size = new System.Drawing.Size(200, 29);
            this.outlet_IdTextBox.TabIndex = 10;
            // 
            // barber_IdLabel
            // 
            barber_IdLabel.AutoSize = true;
            barber_IdLabel.Location = new System.Drawing.Point(125, 332);
            barber_IdLabel.Name = "barber_IdLabel";
            barber_IdLabel.Size = new System.Drawing.Size(97, 25);
            barber_IdLabel.TabIndex = 11;
            barber_IdLabel.Text = "Barber Id:";
            // 
            // barber_IdTextBox
            // 
            this.barber_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKINGBindingSource, "Barber_Id", true));
            this.barber_IdTextBox.Location = new System.Drawing.Point(246, 329);
            this.barber_IdTextBox.Name = "barber_IdTextBox";
            this.barber_IdTextBox.Size = new System.Drawing.Size(200, 29);
            this.barber_IdTextBox.TabIndex = 12;
            // 
            // service_IdLabel
            // 
            service_IdLabel.AutoSize = true;
            service_IdLabel.Location = new System.Drawing.Point(125, 367);
            service_IdLabel.Name = "service_IdLabel";
            service_IdLabel.Size = new System.Drawing.Size(105, 25);
            service_IdLabel.TabIndex = 13;
            service_IdLabel.Text = "Service Id:";
            // 
            // service_IdTextBox
            // 
            this.service_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKINGBindingSource, "Service_Id", true));
            this.service_IdTextBox.Location = new System.Drawing.Point(246, 364);
            this.service_IdTextBox.Name = "service_IdTextBox";
            this.service_IdTextBox.Size = new System.Drawing.Size(200, 29);
            this.service_IdTextBox.TabIndex = 14;
            // 
            // timeslot_IdLabel
            // 
            timeslot_IdLabel.AutoSize = true;
            timeslot_IdLabel.Location = new System.Drawing.Point(125, 402);
            timeslot_IdLabel.Name = "timeslot_IdLabel";
            timeslot_IdLabel.Size = new System.Drawing.Size(113, 25);
            timeslot_IdLabel.TabIndex = 15;
            timeslot_IdLabel.Text = "Timeslot Id:";
            // 
            // timeslot_IdTextBox
            // 
            this.timeslot_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKINGBindingSource, "Timeslot_Id", true));
            this.timeslot_IdTextBox.Location = new System.Drawing.Point(246, 399);
            this.timeslot_IdTextBox.Name = "timeslot_IdTextBox";
            this.timeslot_IdTextBox.Size = new System.Drawing.Size(200, 29);
            this.timeslot_IdTextBox.TabIndex = 16;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(125, 437);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(74, 25);
            statusLabel.TabIndex = 17;
            statusLabel.Text = "Status:";
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKINGBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(246, 434);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(200, 29);
            this.statusTextBox.TabIndex = 18;
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new System.Drawing.Point(125, 472);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(73, 25);
            ratingLabel.TabIndex = 19;
            ratingLabel.Text = "Rating:";
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKINGBindingSource, "Rating", true));
            this.ratingTextBox.Location = new System.Drawing.Point(246, 469);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(200, 29);
            this.ratingTextBox.TabIndex = 20;
            // 
            // reviewLabel
            // 
            reviewLabel.AutoSize = true;
            reviewLabel.Location = new System.Drawing.Point(125, 507);
            reviewLabel.Name = "reviewLabel";
            reviewLabel.Size = new System.Drawing.Size(81, 25);
            reviewLabel.TabIndex = 21;
            reviewLabel.Text = "Review:";
            // 
            // reviewTextBox
            // 
            this.reviewTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKINGBindingSource, "Review", true));
            this.reviewTextBox.Location = new System.Drawing.Point(246, 504);
            this.reviewTextBox.Name = "reviewTextBox";
            this.reviewTextBox.Size = new System.Drawing.Size(200, 29);
            this.reviewTextBox.TabIndex = 22;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(650, 507);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 45);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "sav";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // User_Home_AddBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 668);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(cust_IdLabel);
            this.Controls.Add(this.cust_IdTextBox);
            this.Controls.Add(outlet_IdLabel);
            this.Controls.Add(this.outlet_IdTextBox);
            this.Controls.Add(barber_IdLabel);
            this.Controls.Add(this.barber_IdTextBox);
            this.Controls.Add(service_IdLabel);
            this.Controls.Add(this.service_IdTextBox);
            this.Controls.Add(timeslot_IdLabel);
            this.Controls.Add(this.timeslot_IdTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(ratingLabel);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(reviewLabel);
            this.Controls.Add(this.reviewTextBox);
            this.Controls.Add(this.bOOKINGBindingNavigator);
            this.Name = "User_Home_AddBooking";
            this.Text = "User_Home_AddBooking";
            this.Load += new System.EventHandler(this.User_Home_AddBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bekasIceCream)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKINGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKINGBindingNavigator)).EndInit();
            this.bOOKINGBindingNavigator.ResumeLayout(false);
            this.bOOKINGBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BekasIceCream bekasIceCream;
        private System.Windows.Forms.BindingSource bOOKINGBindingSource;
        private BekasIceCreamTableAdapters.BOOKINGTableAdapter bOOKINGTableAdapter;
        private BekasIceCreamTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bOOKINGBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bOOKINGBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox cust_IdTextBox;
        private System.Windows.Forms.TextBox outlet_IdTextBox;
        private System.Windows.Forms.TextBox barber_IdTextBox;
        private System.Windows.Forms.TextBox service_IdTextBox;
        private System.Windows.Forms.TextBox timeslot_IdTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.TextBox reviewTextBox;
        private System.Windows.Forms.Button btnSave;
    }
}