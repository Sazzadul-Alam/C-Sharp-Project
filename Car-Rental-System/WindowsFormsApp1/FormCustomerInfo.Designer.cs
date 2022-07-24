
namespace WindowsFormsApp1
{
    partial class FormCustomerInfo
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
            this.pnlCustomerInformation = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCustomerLicense = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblCustomerNID = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtCustomerLicense = new System.Windows.Forms.TextBox();
            this.txtCustomerNID = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.btnPrivious = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCarRentalSystem = new System.Windows.Forms.Label();
            this.pnlSearchInfo = new System.Windows.Forms.Panel();
            this.lblAutoSearch = new System.Windows.Forms.Label();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.btnShowdetails = new System.Windows.Forms.Button();
            this.lblSearchCustomerID = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvCustomerInformation = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlCustomerInformation.SuspendLayout();
            this.pnlSearchInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInformation)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCustomerInformation
            // 
            this.pnlCustomerInformation.BackColor = System.Drawing.Color.White;
            this.pnlCustomerInformation.Controls.Add(this.btnClear);
            this.pnlCustomerInformation.Controls.Add(this.btnDELETE);
            this.pnlCustomerInformation.Controls.Add(this.btnAdd);
            this.pnlCustomerInformation.Controls.Add(this.lblCustomerLicense);
            this.pnlCustomerInformation.Controls.Add(this.lblContactNumber);
            this.pnlCustomerInformation.Controls.Add(this.lblCustomerName);
            this.pnlCustomerInformation.Controls.Add(this.lblCustomerAddress);
            this.pnlCustomerInformation.Controls.Add(this.lblCustomerNID);
            this.pnlCustomerInformation.Controls.Add(this.lblCustomerID);
            this.pnlCustomerInformation.Controls.Add(this.txtContactNumber);
            this.pnlCustomerInformation.Controls.Add(this.txtCustomerLicense);
            this.pnlCustomerInformation.Controls.Add(this.txtCustomerNID);
            this.pnlCustomerInformation.Controls.Add(this.txtCustomerID);
            this.pnlCustomerInformation.Controls.Add(this.txtCustomerName);
            this.pnlCustomerInformation.Controls.Add(this.txtCustomerAddress);
            this.pnlCustomerInformation.Controls.Add(this.btnPrivious);
            this.pnlCustomerInformation.Controls.Add(this.label2);
            this.pnlCustomerInformation.Controls.Add(this.btnLogout);
            this.pnlCustomerInformation.Location = new System.Drawing.Point(671, 2);
            this.pnlCustomerInformation.Name = "pnlCustomerInformation";
            this.pnlCustomerInformation.Size = new System.Drawing.Size(381, 621);
            this.pnlCustomerInformation.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(280, 442);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(76, 21);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.FlatAppearance.BorderSize = 0;
            this.btnDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELETE.Location = new System.Drawing.Point(169, 442);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(76, 21);
            this.btnDELETE.TabIndex = 22;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.UseVisualStyleBackColor = true;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(63, 442);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 21);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCustomerLicense
            // 
            this.lblCustomerLicense.AutoSize = true;
            this.lblCustomerLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerLicense.Location = new System.Drawing.Point(45, 321);
            this.lblCustomerLicense.Name = "lblCustomerLicense";
            this.lblCustomerLicense.Size = new System.Drawing.Size(131, 16);
            this.lblCustomerLicense.TabIndex = 20;
            this.lblCustomerLicense.Text = "Customer License";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumber.Location = new System.Drawing.Point(49, 358);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(118, 16);
            this.lblContactNumber.TabIndex = 19;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(44, 202);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(118, 16);
            this.lblCustomerName.TabIndex = 18;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAddress.Location = new System.Drawing.Point(44, 243);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(135, 16);
            this.lblCustomerAddress.TabIndex = 17;
            this.lblCustomerAddress.Text = "Customer Address";
            // 
            // lblCustomerNID
            // 
            this.lblCustomerNID.AutoSize = true;
            this.lblCustomerNID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerNID.Location = new System.Drawing.Point(44, 285);
            this.lblCustomerNID.Name = "lblCustomerNID";
            this.lblCustomerNID.Size = new System.Drawing.Size(103, 16);
            this.lblCustomerNID.TabIndex = 16;
            this.lblCustomerNID.Text = "Customer NID";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(44, 157);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(92, 16);
            this.lblCustomerID.TabIndex = 15;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(182, 355);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(162, 20);
            this.txtContactNumber.TabIndex = 14;
            // 
            // txtCustomerLicense
            // 
            this.txtCustomerLicense.Location = new System.Drawing.Point(182, 318);
            this.txtCustomerLicense.Name = "txtCustomerLicense";
            this.txtCustomerLicense.Size = new System.Drawing.Size(162, 20);
            this.txtCustomerLicense.TabIndex = 13;
            // 
            // txtCustomerNID
            // 
            this.txtCustomerNID.Location = new System.Drawing.Point(182, 282);
            this.txtCustomerNID.Name = "txtCustomerNID";
            this.txtCustomerNID.Size = new System.Drawing.Size(162, 20);
            this.txtCustomerNID.TabIndex = 12;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(182, 156);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(162, 20);
            this.txtCustomerID.TabIndex = 11;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(182, 201);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(162, 20);
            this.txtCustomerName.TabIndex = 10;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(182, 240);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(162, 20);
            this.txtCustomerAddress.TabIndex = 9;
            // 
            // btnPrivious
            // 
            this.btnPrivious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPrivious.FlatAppearance.BorderSize = 0;
            this.btnPrivious.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrivious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrivious.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrivious.Location = new System.Drawing.Point(8, 582);
            this.btnPrivious.Name = "btnPrivious";
            this.btnPrivious.Size = new System.Drawing.Size(86, 26);
            this.btnPrivious.TabIndex = 8;
            this.btnPrivious.Text = "Previous";
            this.btnPrivious.UseVisualStyleBackColor = false;
            this.btnPrivious.Click += new System.EventHandler(this.btnPrivious_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Information";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.Location = new System.Drawing.Point(306, 582);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(65, 26);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(242, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome";
            // 
            // lblCarRentalSystem
            // 
            this.lblCarRentalSystem.AutoSize = true;
            this.lblCarRentalSystem.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarRentalSystem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCarRentalSystem.Location = new System.Drawing.Point(221, 52);
            this.lblCarRentalSystem.Name = "lblCarRentalSystem";
            this.lblCarRentalSystem.Size = new System.Drawing.Size(165, 25);
            this.lblCarRentalSystem.TabIndex = 6;
            this.lblCarRentalSystem.Text = "Car Rental system";
            // 
            // pnlSearchInfo
            // 
            this.pnlSearchInfo.BackColor = System.Drawing.Color.White;
            this.pnlSearchInfo.Controls.Add(this.lblAutoSearch);
            this.pnlSearchInfo.Controls.Add(this.txtAutoSearch);
            this.pnlSearchInfo.Controls.Add(this.btnShowdetails);
            this.pnlSearchInfo.Controls.Add(this.lblCarRentalSystem);
            this.pnlSearchInfo.Controls.Add(this.label1);
            this.pnlSearchInfo.Controls.Add(this.lblSearchCustomerID);
            this.pnlSearchInfo.Controls.Add(this.btnSearch);
            this.pnlSearchInfo.Controls.Add(this.txtSearch);
            this.pnlSearchInfo.Location = new System.Drawing.Point(1, 2);
            this.pnlSearchInfo.Name = "pnlSearchInfo";
            this.pnlSearchInfo.Size = new System.Drawing.Size(672, 170);
            this.pnlSearchInfo.TabIndex = 7;
            // 
            // lblAutoSearch
            // 
            this.lblAutoSearch.AutoSize = true;
            this.lblAutoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoSearch.Location = new System.Drawing.Point(337, 121);
            this.lblAutoSearch.Name = "lblAutoSearch";
            this.lblAutoSearch.Size = new System.Drawing.Size(98, 15);
            this.lblAutoSearch.TabIndex = 14;
            this.lblAutoSearch.Text = "Search by Name";
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAutoSearch.Location = new System.Drawing.Point(330, 139);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(134, 20);
            this.txtAutoSearch.TabIndex = 13;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // btnShowdetails
            // 
            this.btnShowdetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnShowdetails.FlatAppearance.BorderSize = 0;
            this.btnShowdetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowdetails.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowdetails.Location = new System.Drawing.Point(575, 141);
            this.btnShowdetails.Name = "btnShowdetails";
            this.btnShowdetails.Size = new System.Drawing.Size(94, 23);
            this.btnShowdetails.TabIndex = 12;
            this.btnShowdetails.Text = "Show Details";
            this.btnShowdetails.UseVisualStyleBackColor = false;
            this.btnShowdetails.Click += new System.EventHandler(this.btnShowdetails_Click);
            // 
            // lblSearchCustomerID
            // 
            this.lblSearchCustomerID.AutoSize = true;
            this.lblSearchCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCustomerID.Location = new System.Drawing.Point(127, 123);
            this.lblSearchCustomerID.Name = "lblSearchCustomerID";
            this.lblSearchCustomerID.Size = new System.Drawing.Size(132, 15);
            this.lblSearchCustomerID.TabIndex = 11;
            this.lblSearchCustomerID.Text = "Search by Customer ID";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.Location = new System.Drawing.Point(25, 139);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(115, 141);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(162, 20);
            this.txtSearch.TabIndex = 4;
            // 
            // dgvCustomerInformation
            // 
            this.dgvCustomerInformation.AllowUserToAddRows = false;
            this.dgvCustomerInformation.AllowUserToDeleteRows = false;
            this.dgvCustomerInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerInformation.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomerInformation.Name = "dgvCustomerInformation";
            this.dgvCustomerInformation.ReadOnly = true;
            this.dgvCustomerInformation.Size = new System.Drawing.Size(672, 456);
            this.dgvCustomerInformation.TabIndex = 8;
            this.dgvCustomerInformation.DoubleClick += new System.EventHandler(this.dgvCustomerInformation_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvCustomerInformation);
            this.panel2.Location = new System.Drawing.Point(1, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 456);
            this.panel2.TabIndex = 10;
            // 
            // FormCustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 622);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlSearchInfo);
            this.Controls.Add(this.pnlCustomerInformation);
            this.Name = "FormCustomerInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCustomerInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCustomerInfo_FormClosing);
            this.pnlCustomerInformation.ResumeLayout(false);
            this.pnlCustomerInformation.PerformLayout();
            this.pnlSearchInfo.ResumeLayout(false);
            this.pnlSearchInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInformation)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCustomerInformation;
        private System.Windows.Forms.Button btnPrivious;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCarRentalSystem;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlSearchInfo;
        private System.Windows.Forms.Label lblSearchCustomerID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCustomerInformation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnShowdetails;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.Label lblAutoSearch;
        private System.Windows.Forms.Label lblCustomerLicense;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerNID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtCustomerLicense;
        private System.Windows.Forms.TextBox txtCustomerNID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Button btnAdd;
    }
}