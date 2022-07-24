using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormRental : Form
    {
        private DataAccess Da { get; set; }
        public FormRental()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            string sql = "select * from Rental;";
            this.PopulateGridView(sql);
        }

        private void PopulateGridView(string sql = "select * from Rental;")
        {
            DataAccess da = new DataAccess();
            DataSet ds = this.Da.ExecuteQuery(sql);
            this.dgbRental.DataSource = ds.Tables[0];
        }

        private void FormRental_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to close the Application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.ExitThread();
            }

            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnPrivious_Click(object sender, EventArgs e)
        {
            FormEmployeeAccount fEmployeeAccount = new FormEmployeeAccount();
            fEmployeeAccount.Visible = true;
            this.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            DialogResult dialog = MessageBox.Show("Are You sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                lg.Visible = true;
                this.Visible = false;
            }

            else if (dialog == DialogResult.No)
            {
                lg.Visible = false;
                this.Visible = true;
            }

        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select*from Rental where Customer_id = '" + this.txtSearch.Text + "';";

            this.PopulateGridView(sql);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!this.IsValidToAdd())
            {
                MessageBox.Show("Missing or Empty Box");
                return;
            }

            try
            {
                var txt = "select * from Rental where Id = '" + this.txtRentalId.Text + "';";
                var dt = this.Da.ExecuteQueryTable(txt);
                if (dt.Rows.Count == 1)
                {
                    //Update record
                    var sql = @"update Rental
                                set Car_Id = '" + this.txtCarId.Text + @"',
                                Customer_Id = '" + this.txtCustomerID.Text + @"',
                                Customer_Name = '" + this.txtCustomerName.Text + @"',
                                Rental_Fee = '" + this.txtRentalFee.Text + @"',
                                Date = '" + this.dtpDate.Text + @"',
                                Due_Date = '" + this.dtpDueDate.Text + @"',
                                Total_Fee = '" + this.txtCalculateFee.Text + @"',
                                where Id = '" + this.txtRentalId.Text + "';";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data update complete");
                    else
                        MessageBox.Show("Data update failed");
                }
                else
                {
                    //Insert record
                    string sql = "insert into Rental values('" + this.txtRentalId.Text + "','" + this.txtCarId.Text + "','" +
                         this.txtCustomerID.Text + "','" + this.txtCustomerName.Text + "','" + this.txtRentalFee.Text + "','" +
                         this.dtpDate.Text + "','" + this.dtpDueDate.Text + "','" + this.txtCalculateFee.Text + "');";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data insertion complete");
                    else
                        MessageBox.Show("Data insertion failed");
                }

                this.PopulateGridView();
                this.ClearContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private bool IsValidToAdd()
        {
            if (String.IsNullOrEmpty(this.txtCarId.Text) || String.IsNullOrWhiteSpace(this.txtCarId.Text) ||
                String.IsNullOrEmpty(this.txtCustomerID.Text) || String.IsNullOrWhiteSpace(this.txtCustomerID.Text) ||
                String.IsNullOrEmpty(this.txtCustomerName.Text) || String.IsNullOrWhiteSpace(this.txtCustomerName.Text) ||
                String.IsNullOrEmpty(this.txtRentalFee.Text) || String.IsNullOrWhiteSpace(this.txtRentalFee.Text) ||
                String.IsNullOrEmpty(this.dtpDate.Text) || String.IsNullOrWhiteSpace(this.dtpDate.Text) ||
                String.IsNullOrEmpty(this.dtpDueDate.Text) || String.IsNullOrWhiteSpace(this.dtpDueDate.Text) ||
                String.IsNullOrEmpty(this.txtCalculateFee.Text) || String.IsNullOrWhiteSpace(this.txtCalculateFee.Text))
            {
                return false;
            }

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }

        private void ClearContent()
        {
            this.txtRentalId.Clear();
            this.txtCarId.Clear();
            this.txtCustomerID.Clear();
            this.txtCustomerName.Clear();
            this.txtRentalFee.Clear();
            this.dtpDate.Text = "";
            this.dtpDueDate.Text = "";
            this.txtCalculateFee.Clear();
            this.AutoIdGenerator();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgbRental.SelectedRows.Count < 0)
            {
                MessageBox.Show("Please select a Row first");
                return;
            }

            var model = this.dgbRental.CurrentRow.Cells[0].Value.ToString();

            try
            {
                var sql = "delete from Rental where Id = '" + model + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(Name + " remove complete");
                else
                    MessageBox.Show("Data remove failed");

                this.PopulateGridView();
                this.ClearContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void CalculateRentalFee()
        {
            DateTime bookingDate = dtpDate.Value.Date;
            DateTime dueDate = dtpDueDate.Value.Date;

            TimeSpan ts = dueDate - bookingDate;//time span represents time interval
            int days = ts.Days;
            days = int.Parse(ts.Days.ToString());//parse convert string representation a number of 32-bit signed integer

            int rent = int.Parse(txtRentalFee.Text);

            int total = rent * days;

            txtCalculateFee.Text = total.ToString();

        }

        private void btnCalculateFee_Click(object sender, EventArgs e)
        {
            this.CalculateRentalFee();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.dgbRental.Width, this.dgbRental.Height);
            dgbRental.DrawToBitmap(objBmp, new Rectangle(0, 0, this.dgbRental.Width, this.dgbRental.Height));
            e.Graphics.DrawImage(objBmp, 250, 90);
        }

        private void AutoIdGenerator()
        {
            var sql = "select Id from Rental order by Id desc;";
            var dt = this.Da.ExecuteQueryTable(sql);
            string lastId = dt.Rows[0]["Id"].ToString();
            string[] data = lastId.Split('-');
            int temp = Convert.ToInt32(data[1]);
            string newId = temp.ToString();
            this.txtRentalId.Text = newId;
        }

        private void cmbSelectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSelectList.SelectedItem.ToString() == "Car Information")
                {
                    string sql = "Select*from Car";
                    DataAccess da = new DataAccess();
                    DataSet ds = da.ExecuteQuery(sql);

                    this.dgvShowInfromation.DataSource = ds.Tables[0];
                }

                else if (cmbSelectList.SelectedItem.ToString() == "Customer Information")
                {
                    string sql = "Select*from Customer";
                    DataAccess da = new DataAccess();
                    DataSet ds = da.ExecuteQuery(sql);

                    this.dgvShowInfromation.DataSource = ds.Tables[0];
                }

            }

            catch (Exception exc)
            {
                MessageBox.Show("Error" + exc);
            }
        }
    }
}
