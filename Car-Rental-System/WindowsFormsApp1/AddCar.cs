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
    public partial class AddCar : Form
    {
        private DataAccess Da { get; set; }
        public AddCar()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        //Populate Grid View
        private void PopulateGridView(string sql = "select * from Car;")
        {
            DataAccess da = new DataAccess();
            DataSet ds = this.Da.ExecuteQuery(sql);
            this.dgvAddCar.DataSource = ds.Tables[0];
        }
        //Show Details
        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }
        //Search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Car where Car_Id = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(sql);
        }
        //Auto Search
        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select*from Car where Car_Model like '" + this.txtAutoSearch.Text + "%';";

            this.PopulateGridView(sql);
        }
        //Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!this.IsValidToAdd())
            {
                MessageBox.Show("Missing or Empty Box");
                return;
            }

            try
            {
                var txt = "select * from Car where Car_Id = '" + this.txtCarId.Text + "';";
                var dt = this.Da.ExecuteQueryTable(txt);
                if (dt.Rows.Count == 1)
                {
                    //Update record
                    var sql = @"update Car
                                set Car_Type = '" + this.cmbCarType.Text + @"',
                                Car_Model = '" + this.txtCarModel.Text + @"',
                                Car_Color = '" + this.txtCarColor.Text + @"',
                                Car_Price= '" + this.txtCarPrice.Text + @"',
                                where Car_Id = '" + this.txtCarId.Text + "';";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data update complete");
                    else
                        MessageBox.Show("Data update failed");
                }
                else
                {
                    //Insert record
                    string sql = "insert into Car values('" + this.txtCarModel.Text + "','" + this.cmbCarType.Text + "','" +
                         this.txtCarColor.Text + "','" + this.txtCarPrice.Text + "','" + this.txtCarId.Text + "');";
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
        //Validation
        private bool IsValidToAdd()
        {
            if (String.IsNullOrEmpty(this.txtCarModel.Text) || String.IsNullOrWhiteSpace(this.txtCarModel.Text) ||
                String.IsNullOrEmpty(this.txtCarId.Text) || String.IsNullOrWhiteSpace(this.txtCarId.Text) ||
                String.IsNullOrEmpty(this.cmbCarType.Text) || String.IsNullOrWhiteSpace(this.cmbCarType.Text) ||
                String.IsNullOrEmpty(this.txtCarColor.Text) || String.IsNullOrWhiteSpace(this.txtCarColor.Text) ||
                String.IsNullOrEmpty(this.txtCarPrice.Text) || String.IsNullOrWhiteSpace(this.txtCarPrice.Text))
            {
                return false;
            }

            return true;
        }
        //Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }

        private void ClearContent()
        {
            this.txtCarModel.Clear();
            this.txtCarId.Clear();
            this.cmbCarType.Text = "";
            this.txtCarColor.Clear();
            this.txtCarPrice.Clear();
            this.txtSearch.Clear();
            this.dgvAddCar.ClearSelection();
        }
        //Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvAddCar.SelectedRows.Count < 0)
            {
                MessageBox.Show("Please select a Row first");
                return;
            }

            var model = this.dgvAddCar.CurrentRow.Cells[0].Value.ToString();

            try
            {
                var sql = "delete from Car where Car_Model = '" + model + "';";
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
        //Previous
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            FormAdminAccount formAdminAccount = new FormAdminAccount();
            formAdminAccount.Visible = true;
            this.Visible = false;

        }
        //Form Closing
        private void AddCar_FormClosing(object sender, FormClosingEventArgs e)
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
       
    }
}
