using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormCustomerInfo : Form
    {
      
        private DataAccess Da { get; set; }

        public FormCustomerInfo()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            string sql = "select * from Customer;";
            this.PopulateGridView(sql);

        }
        private void PopulateGridView(string sql = "select * from Customer;")
        {
            DataSet ds = this.Da.ExecuteQuery(sql);
            this.dgvCustomerInformation.DataSource = ds.Tables[0];
            this.dgvCustomerInformation.AutoGenerateColumns = false;
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

        private void FormCustomerInfo_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Customer where Customer_Id= '" + this.txtSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void btnShowdetails_Click(object sender, EventArgs e)
        {
            string sql = "select * from Customer;";
            this.PopulateGridView(sql);
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from Customer where Customer_Name like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!this.IsValidToSave())
            {
                MessageBox.Show("Missing or Empty Box");
                return;
            }

            try
            {
                var txt = "select * from Customer where Customer_Id = '" + this.txtCustomerID.Text + "';";
                var dt = this.Da.ExecuteQueryTable(txt);
                if (dt.Rows.Count == 1)
                {
                    //Update record
                    var sql = @"update Customer
                                set Customer_Name = '" + this.txtCustomerName.Text + @"',
                                Customer_Address = " + this.txtCustomerAddress.Text + @",
                                Customer_NID= " + this.txtCustomerNID.Text + @",
                                Customer_License = '" + this.txtCustomerLicense.Text + @"',
                                Contact_Number = '" + this.txtContactNumber.Text + @"'
                                where Customer_Id = '" + this.txtCustomerID.Text + "';";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data update complete");
                    else
                        MessageBox.Show("Data update failed");
                }
                else
                {
                    //Insert record
                    string sql = "insert into Customer values('" + this.txtCustomerID.Text + "','" + this.txtCustomerName.Text + "','" +
                         this.txtCustomerAddress.Text + "','" + this.txtCustomerNID.Text + "','" + this.txtCustomerLicense.Text + "','" +
                         this.txtContactNumber.Text + "');";
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
        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtCustomerID.Text) || String.IsNullOrWhiteSpace(this.txtCustomerID.Text) ||
                String.IsNullOrEmpty(this.txtCustomerName.Text) || String.IsNullOrWhiteSpace(this.txtCustomerName.Text) ||
                String.IsNullOrEmpty(this.txtCustomerAddress.Text) || String.IsNullOrWhiteSpace(this.txtCustomerAddress.Text) ||
                String.IsNullOrEmpty(this.txtCustomerNID.Text) || String.IsNullOrWhiteSpace(this.txtCustomerNID.Text) ||
                String.IsNullOrEmpty(this.txtCustomerLicense.Text) || String.IsNullOrWhiteSpace(this.txtCustomerLicense.Text) ||
                String.IsNullOrEmpty(this.txtContactNumber.Text) || String.IsNullOrWhiteSpace(this.txtContactNumber.Text))
            {
                return false;
            }

            return true;
        }
        private void ClearContent()
        {
            this.txtCustomerID.Clear();
            this.txtCustomerName.Clear();
            this.txtCustomerAddress.Clear();
            this.txtCustomerNID.Clear();
            this.txtCustomerLicense.Clear(); 
            this.txtContactNumber.Clear();

            this.txtSearch.Clear();
            this.txtAutoSearch.Clear();
            this.dgvCustomerInformation.ClearSelection();
            this.AutoIdGenerator();


        }

        private void dgvCustomerInformation_DoubleClick(object sender, EventArgs e)
        {
            this.txtCustomerID.Text = this.dgvCustomerInformation.CurrentRow.Cells[0].Value.ToString();
            this.txtCustomerName.Text = this.dgvCustomerInformation.CurrentRow.Cells["Customer_Name"].Value.ToString();
            this.txtCustomerAddress.Text = this.dgvCustomerInformation.CurrentRow.Cells["Customer_Address"].Value.ToString();
            this.txtCustomerNID.Text = this.dgvCustomerInformation.CurrentRow.Cells["Customer_NID"].Value.ToString();
            this.txtCustomerLicense.Text = this.dgvCustomerInformation.CurrentRow.Cells["Customer_License"].Value.ToString();
            this.txtContactNumber.Text = this.dgvCustomerInformation.CurrentRow.Cells["Contact_Number"].Value.ToString();

            this.txtCustomerID.ReadOnly = true;
        }
        private void AutoIdGenerator()
        {
            var sql = "select Customer_Id from Customer order by Customer_Id desc;";
            var dt = this.Da.ExecuteQueryTable(sql);
            string lastId = dt.Rows[0]["Customer_Id"].ToString();
            string[] data = lastId.Split('-');
            int temp = Convert.ToInt32(data[1]);
            string newId = "C-" + (++temp).ToString("d3");
            this.txtCustomerID.Text = newId;
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            if (this.dgvCustomerInformation.SelectedRows.Count < 0)
            {
                MessageBox.Show("Please select a Row first");
                return;
            }

            var id = this.dgvCustomerInformation.CurrentRow.Cells[0].Value.ToString();
            var Name = this.dgvCustomerInformation.CurrentRow.Cells[1].Value.ToString();

            try
            {
                var sql = "delete from Customer where Customer_Id = '" + id + "';";
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();

        }
    }
}
