
namespace WindowsFormsApp1
{
    partial class FormEmployeeAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployeeAccount));
            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.lblCarRentalSystem = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnRental = new System.Windows.Forms.Button();
            this.btnCustomerInfo = new System.Windows.Forms.Button();
            this.btnCarList = new System.Windows.Forms.Button();
            this.pnlOption = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlWelcome.SuspendLayout();
            this.pnlOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.BackColor = System.Drawing.SystemColors.Window;
            this.pnlWelcome.Controls.Add(this.lblCarRentalSystem);
            this.pnlWelcome.Controls.Add(this.lblWelcome);
            this.pnlWelcome.Location = new System.Drawing.Point(0, 3);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(759, 93);
            this.pnlWelcome.TabIndex = 1;
            // 
            // lblCarRentalSystem
            // 
            this.lblCarRentalSystem.AutoSize = true;
            this.lblCarRentalSystem.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarRentalSystem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCarRentalSystem.Location = new System.Drawing.Point(276, 51);
            this.lblCarRentalSystem.Name = "lblCarRentalSystem";
            this.lblCarRentalSystem.Size = new System.Drawing.Size(165, 25);
            this.lblCarRentalSystem.TabIndex = 1;
            this.lblCarRentalSystem.Text = "Car Rental system";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWelcome.Location = new System.Drawing.Point(306, 6);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(115, 36);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.Location = new System.Drawing.Point(341, 505);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(64, 27);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnRental
            // 
            this.btnRental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRental.FlatAppearance.BorderSize = 0;
            this.btnRental.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRental.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRental.Location = new System.Drawing.Point(512, 8);
            this.btnRental.Name = "btnRental";
            this.btnRental.Size = new System.Drawing.Size(98, 36);
            this.btnRental.TabIndex = 4;
            this.btnRental.Text = "Rental";
            this.btnRental.UseVisualStyleBackColor = false;
            this.btnRental.Click += new System.EventHandler(this.btnRental_Click);
            // 
            // btnCustomerInfo
            // 
            this.btnCustomerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCustomerInfo.FlatAppearance.BorderSize = 0;
            this.btnCustomerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCustomerInfo.Location = new System.Drawing.Point(281, 8);
            this.btnCustomerInfo.Name = "btnCustomerInfo";
            this.btnCustomerInfo.Size = new System.Drawing.Size(152, 36);
            this.btnCustomerInfo.TabIndex = 3;
            this.btnCustomerInfo.Text = "Customer Info";
            this.btnCustomerInfo.UseVisualStyleBackColor = false;
            this.btnCustomerInfo.Click += new System.EventHandler(this.btnCustomerInfo_Click);
            // 
            // btnCarList
            // 
            this.btnCarList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCarList.FlatAppearance.BorderSize = 0;
            this.btnCarList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCarList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCarList.Location = new System.Drawing.Point(123, 8);
            this.btnCarList.Name = "btnCarList";
            this.btnCarList.Size = new System.Drawing.Size(94, 36);
            this.btnCarList.TabIndex = 2;
            this.btnCarList.Text = "Car List";
            this.btnCarList.UseVisualStyleBackColor = false;
            this.btnCarList.Click += new System.EventHandler(this.btnCarList_Click);
            // 
            // pnlOption
            // 
            this.pnlOption.BackColor = System.Drawing.Color.White;
            this.pnlOption.Controls.Add(this.btnCarList);
            this.pnlOption.Controls.Add(this.btnCustomerInfo);
            this.pnlOption.Controls.Add(this.btnRental);
            this.pnlOption.Location = new System.Drawing.Point(0, 94);
            this.pnlOption.Name = "pnlOption";
            this.pnlOption.Size = new System.Drawing.Size(759, 53);
            this.pnlOption.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(45, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(653, 299);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormEmployeeAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(765, 544);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlOption);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pnlWelcome);
            this.Name = "FormEmployeeAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmployeeAccount";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEmployeeAccount_FormClosing);
            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome.PerformLayout();
            this.pnlOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnRental;
        private System.Windows.Forms.Button btnCustomerInfo;
        private System.Windows.Forms.Button btnCarList;
        private System.Windows.Forms.Label lblCarRentalSystem;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlOption;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}