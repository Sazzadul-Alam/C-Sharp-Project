
namespace WindowsFormsApp1
{
    partial class FormRental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRental));
            this.pnlRental = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtRentalId = new System.Windows.Forms.TextBox();
            this.lblRentalId = new System.Windows.Forms.Label();
            this.txtCarId = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtRentalFee = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.lblRentalFee = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblCarID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.txtCalculateFee = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCalculateFee = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgbRental = new System.Windows.Forms.DataGridView();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvShowInfromation = new System.Windows.Forms.DataGridView();
            this.cmbSelectList = new System.Windows.Forms.ComboBox();
            this.lblSelectList = new System.Windows.Forms.Label();
            this.pnlRental.SuspendLayout();
            this.pnlWelcome.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbRental)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowInfromation)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRental
            // 
            this.pnlRental.BackColor = System.Drawing.Color.White;
            this.pnlRental.Controls.Add(this.panel1);
            this.pnlRental.Controls.Add(this.btnPrint);
            this.pnlRental.Controls.Add(this.txtRentalId);
            this.pnlRental.Controls.Add(this.lblRentalId);
            this.pnlRental.Controls.Add(this.txtCarId);
            this.pnlRental.Controls.Add(this.btnLogout);
            this.pnlRental.Controls.Add(this.btnPrevious);
            this.pnlRental.Controls.Add(this.dtpDueDate);
            this.pnlRental.Controls.Add(this.dtpDate);
            this.pnlRental.Controls.Add(this.txtRentalFee);
            this.pnlRental.Controls.Add(this.txtCustomerName);
            this.pnlRental.Controls.Add(this.txtCustomerID);
            this.pnlRental.Controls.Add(this.lblDueDate);
            this.pnlRental.Controls.Add(this.lblBookingDate);
            this.pnlRental.Controls.Add(this.lblRentalFee);
            this.pnlRental.Controls.Add(this.lblCustomerName);
            this.pnlRental.Controls.Add(this.lblCustomerID);
            this.pnlRental.Controls.Add(this.lblCarID);
            this.pnlRental.Controls.Add(this.label2);
            this.pnlRental.Location = new System.Drawing.Point(1, 2);
            this.pnlRental.Name = "pnlRental";
            this.pnlRental.Size = new System.Drawing.Size(345, 557);
            this.pnlRental.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(153, 445);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(76, 21);
            this.btnPrint.TabIndex = 26;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtRentalId
            // 
            this.txtRentalId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRentalId.Location = new System.Drawing.Point(153, 93);
            this.txtRentalId.Name = "txtRentalId";
            this.txtRentalId.Size = new System.Drawing.Size(143, 20);
            this.txtRentalId.TabIndex = 25;
            // 
            // lblRentalId
            // 
            this.lblRentalId.AutoSize = true;
            this.lblRentalId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalId.Location = new System.Drawing.Point(43, 96);
            this.lblRentalId.Name = "lblRentalId";
            this.lblRentalId.Size = new System.Drawing.Size(61, 13);
            this.lblRentalId.TabIndex = 24;
            this.lblRentalId.Text = "Rental ID";
            // 
            // txtCarId
            // 
            this.txtCarId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCarId.Location = new System.Drawing.Point(153, 129);
            this.txtCarId.Name = "txtCarId";
            this.txtCarId.Size = new System.Drawing.Size(143, 20);
            this.txtCarId.TabIndex = 23;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.Location = new System.Drawing.Point(264, 521);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(65, 26);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrevious.Location = new System.Drawing.Point(3, 521);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(73, 26);
            this.btnPrevious.TabIndex = 14;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrivious_Click);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDueDate.Location = new System.Drawing.Point(153, 371);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(143, 20);
            this.dtpDueDate.TabIndex = 13;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(153, 322);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(143, 20);
            this.dtpDate.TabIndex = 12;
            // 
            // txtRentalFee
            // 
            this.txtRentalFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRentalFee.Location = new System.Drawing.Point(153, 277);
            this.txtRentalFee.Name = "txtRentalFee";
            this.txtRentalFee.Size = new System.Drawing.Size(143, 20);
            this.txtRentalFee.TabIndex = 11;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Location = new System.Drawing.Point(153, 224);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(143, 20);
            this.txtCustomerName.TabIndex = 10;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerID.Location = new System.Drawing.Point(153, 175);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(143, 20);
            this.txtCustomerID.TabIndex = 9;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(43, 377);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(61, 13);
            this.lblDueDate.TabIndex = 7;
            this.lblDueDate.Text = "Due Date";
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDate.Location = new System.Drawing.Point(43, 328);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(84, 13);
            this.lblBookingDate.TabIndex = 6;
            this.lblBookingDate.Text = "Booking Date";
            // 
            // lblRentalFee
            // 
            this.lblRentalFee.AutoSize = true;
            this.lblRentalFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalFee.Location = new System.Drawing.Point(43, 280);
            this.lblRentalFee.Name = "lblRentalFee";
            this.lblRentalFee.Size = new System.Drawing.Size(69, 13);
            this.lblRentalFee.TabIndex = 5;
            this.lblRentalFee.Text = "Rental Fee";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(43, 227);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(95, 13);
            this.lblCustomerName.TabIndex = 4;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(43, 178);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(76, 13);
            this.lblCustomerID.TabIndex = 3;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // lblCarID
            // 
            this.lblCarID.AutoSize = true;
            this.lblCarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarID.Location = new System.Drawing.Point(43, 132);
            this.lblCarID.Name = "lblCarID";
            this.lblCarID.Size = new System.Drawing.Size(43, 13);
            this.lblCarID.TabIndex = 2;
            this.lblCarID.Text = "Car ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rental";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(3, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 21);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.BackColor = System.Drawing.Color.White;
            this.pnlWelcome.Controls.Add(this.lblSelectList);
            this.pnlWelcome.Controls.Add(this.cmbSelectList);
            this.pnlWelcome.Controls.Add(this.txtCalculateFee);
            this.pnlWelcome.Controls.Add(this.btnSearch);
            this.pnlWelcome.Controls.Add(this.btnCalculateFee);
            this.pnlWelcome.Controls.Add(this.txtSearch);
            this.pnlWelcome.Controls.Add(this.btnClear);
            this.pnlWelcome.Controls.Add(this.btnShowDetails);
            this.pnlWelcome.Controls.Add(this.btnDelete);
            this.pnlWelcome.Controls.Add(this.btnAdd);
            this.pnlWelcome.Location = new System.Drawing.Point(339, 2);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(1077, 136);
            this.pnlWelcome.TabIndex = 1;
            // 
            // txtCalculateFee
            // 
            this.txtCalculateFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCalculateFee.Location = new System.Drawing.Point(274, 93);
            this.txtCalculateFee.Name = "txtCalculateFee";
            this.txtCalculateFee.ReadOnly = true;
            this.txtCalculateFee.Size = new System.Drawing.Size(143, 20);
            this.txtCalculateFee.TabIndex = 27;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.Location = new System.Drawing.Point(158, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 21);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCalculateFee
            // 
            this.btnCalculateFee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculateFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateFee.Location = new System.Drawing.Point(143, 88);
            this.btnCalculateFee.Name = "btnCalculateFee";
            this.btnCalculateFee.Size = new System.Drawing.Size(108, 26);
            this.btnCalculateFee.TabIndex = 26;
            this.btnCalculateFee.Text = "Calculate Fee";
            this.btnCalculateFee.UseVisualStyleBackColor = true;
            this.btnCalculateFee.Click += new System.EventHandler(this.btnCalculateFee_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(274, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(143, 20);
            this.txtSearch.TabIndex = 27;
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(3, 92);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(76, 21);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnShowDetails.FlatAppearance.BorderSize = 0;
            this.btnShowDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDetails.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowDetails.Location = new System.Drawing.Point(463, 108);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(97, 22);
            this.btnShowDetails.TabIndex = 26;
            this.btnShowDetails.Text = "Show Details";
            this.btnShowDetails.UseVisualStyleBackColor = false;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(3, 47);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 21);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgbRental);
            this.panel3.Location = new System.Drawing.Point(342, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(557, 419);
            this.panel3.TabIndex = 2;
            // 
            // dgbRental
            // 
            this.dgbRental.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgbRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbRental.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgbRental.Location = new System.Drawing.Point(0, 0);
            this.dgbRental.Name = "dgbRental";
            this.dgbRental.ReadOnly = true;
            this.dgbRental.Size = new System.Drawing.Size(557, 419);
            this.dgbRental.TabIndex = 0;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(341, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 162);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvShowInfromation);
            this.panel2.Location = new System.Drawing.Point(905, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(511, 419);
            this.panel2.TabIndex = 3;
            // 
            // dgvShowInfromation
            // 
            this.dgvShowInfromation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowInfromation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowInfromation.Location = new System.Drawing.Point(0, 0);
            this.dgvShowInfromation.Name = "dgvShowInfromation";
            this.dgvShowInfromation.Size = new System.Drawing.Size(511, 419);
            this.dgvShowInfromation.TabIndex = 0;
            // 
            // cmbSelectList
            // 
            this.cmbSelectList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectList.FormattingEnabled = true;
            this.cmbSelectList.Items.AddRange(new object[] {
            "Car Information",
            "Customer Information"});
            this.cmbSelectList.Location = new System.Drawing.Point(932, 105);
            this.cmbSelectList.Name = "cmbSelectList";
            this.cmbSelectList.Size = new System.Drawing.Size(134, 21);
            this.cmbSelectList.TabIndex = 29;
            this.cmbSelectList.SelectedIndexChanged += new System.EventHandler(this.cmbSelectList_SelectedIndexChanged);
            // 
            // lblSelectList
            // 
            this.lblSelectList.AutoSize = true;
            this.lblSelectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectList.Location = new System.Drawing.Point(859, 108);
            this.lblSelectList.Name = "lblSelectList";
            this.lblSelectList.Size = new System.Drawing.Size(67, 13);
            this.lblSelectList.TabIndex = 30;
            this.lblSelectList.Text = "Select List";
            // 
            // FormRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1417, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlWelcome);
            this.Controls.Add(this.pnlRental);
            this.Name = "FormRental";
            this.Text = "FormRental";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRental_FormClosing);
            this.pnlRental.ResumeLayout(false);
            this.pnlRental.PerformLayout();
            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgbRental)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowInfromation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRental;
        private System.Windows.Forms.Panel pnlWelcome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgbRental;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtRentalFee;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.Label lblRentalFee;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCarID;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtCarId;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtRentalId;
        private System.Windows.Forms.Label lblRentalId;
        private System.Windows.Forms.TextBox txtCalculateFee;
        private System.Windows.Forms.Button btnCalculateFee;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSelectList;
        private System.Windows.Forms.ComboBox cmbSelectList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvShowInfromation;
    }
}