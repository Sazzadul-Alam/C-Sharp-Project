
namespace WindowsFormsApp1
{
    partial class FormCarList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarList));
            this.pnlSearchInfo = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbCarType = new System.Windows.Forms.ComboBox();
            this.lblSelectList = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrivious = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCarRentalSystem = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dgvCarInformation = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlSearchInfo.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarInformation)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSearchInfo
            // 
            this.pnlSearchInfo.BackColor = System.Drawing.Color.White;
            this.pnlSearchInfo.Controls.Add(this.label9);
            this.pnlSearchInfo.Controls.Add(this.btnSearch);
            this.pnlSearchInfo.Controls.Add(this.txtSearch);
            this.pnlSearchInfo.Controls.Add(this.cmbCarType);
            this.pnlSearchInfo.Controls.Add(this.lblSelectList);
            this.pnlSearchInfo.Controls.Add(this.label2);
            this.pnlSearchInfo.Location = new System.Drawing.Point(318, 1);
            this.pnlSearchInfo.Name = "pnlSearchInfo";
            this.pnlSearchInfo.Size = new System.Drawing.Size(735, 183);
            this.pnlSearchInfo.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(130, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Search by Car Model";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // cmbCarType
            // 
            this.cmbCarType.FormattingEnabled = true;
            this.cmbCarType.Items.AddRange(new object[] {
            "MicroBus",
            "Private"});
            this.cmbCarType.Location = new System.Drawing.Point(538, 141);
            this.cmbCarType.Name = "cmbCarType";
            this.cmbCarType.Size = new System.Drawing.Size(160, 21);
            this.cmbCarType.TabIndex = 2;
            this.cmbCarType.SelectedIndexChanged += new System.EventHandler(this.cmbCarType_SelectedIndexChanged);
            // 
            // lblSelectList
            // 
            this.lblSelectList.AutoSize = true;
            this.lblSelectList.BackColor = System.Drawing.Color.White;
            this.lblSelectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectList.Location = new System.Drawing.Point(419, 143);
            this.lblSelectList.Name = "lblSelectList";
            this.lblSelectList.Size = new System.Drawing.Size(80, 16);
            this.lblSelectList.TabIndex = 1;
            this.lblSelectList.Text = "Select List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "CAR LIST";
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.BackColor = System.Drawing.Color.White;
            this.pnlUpdate.Controls.Add(this.pictureBox1);
            this.pnlUpdate.Controls.Add(this.btnPrivious);
            this.pnlUpdate.Controls.Add(this.label1);
            this.pnlUpdate.Controls.Add(this.lblCarRentalSystem);
            this.pnlUpdate.Controls.Add(this.btnLogout);
            this.pnlUpdate.Location = new System.Drawing.Point(2, 1);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(323, 621);
            this.pnlUpdate.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnPrivious
            // 
            this.btnPrivious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPrivious.FlatAppearance.BorderSize = 0;
            this.btnPrivious.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrivious.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrivious.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrivious.Location = new System.Drawing.Point(10, 520);
            this.btnPrivious.Name = "btnPrivious";
            this.btnPrivious.Size = new System.Drawing.Size(86, 26);
            this.btnPrivious.TabIndex = 8;
            this.btnPrivious.Text = "Previous";
            this.btnPrivious.UseVisualStyleBackColor = false;
            this.btnPrivious.Click += new System.EventHandler(this.btnPrivious_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(83, 31);
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
            this.lblCarRentalSystem.Location = new System.Drawing.Point(57, 82);
            this.lblCarRentalSystem.Name = "lblCarRentalSystem";
            this.lblCarRentalSystem.Size = new System.Drawing.Size(165, 25);
            this.lblCarRentalSystem.TabIndex = 6;
            this.lblCarRentalSystem.Text = "Car Rental system";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.Location = new System.Drawing.Point(231, 520);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(65, 26);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dgvCarInformation
            // 
            this.dgvCarInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCarInformation.Location = new System.Drawing.Point(0, 0);
            this.dgvCarInformation.Name = "dgvCarInformation";
            this.dgvCarInformation.ReadOnly = true;
            this.dgvCarInformation.Size = new System.Drawing.Size(735, 444);
            this.dgvCarInformation.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvCarInformation);
            this.panel2.Location = new System.Drawing.Point(318, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 444);
            this.panel2.TabIndex = 6;
            // 
            // FormCarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 622);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlUpdate);
            this.Controls.Add(this.pnlSearchInfo);
            this.Name = "FormCarList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCarList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCarList_FormClosing);
            this.pnlSearchInfo.ResumeLayout(false);
            this.pnlSearchInfo.PerformLayout();
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarInformation)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearchInfo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbCarType;
        private System.Windows.Forms.Label lblSelectList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dgvCarInformation;
        private System.Windows.Forms.Label lblCarRentalSystem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrivious;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
    }
}