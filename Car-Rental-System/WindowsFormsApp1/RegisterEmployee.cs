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
    public partial class RegisterEmployee : Form
    {
        private DataAccess Da { get; set; }
        public RegisterEmployee()
        {
            InitializeComponent(); 
            this.Da = new DataAccess();
        }

        private void PopulateGridView(string sql = "select * from Employee;")
        {
            DataAccess da = new DataAccess();
            DataSet ds = this.Da.ExecuteQuery(sql);
            this.dgvEmployeeList.DataSource = ds.Tables[0];
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
           
            this.PopulateGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Employee where Employee_Id = '" + this.txtSearch.Text + "';";
            
            this.PopulateGridView(sql);
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select*from Employee where Employee_Name like '" + this.txtAutoSearch.Text + "%';";
            
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
                var txt = "select * from Employee where Employee_Id = '" + this.txtEmployeeId.Text + "';";
                var dt = this.Da.ExecuteQueryTable(txt);
                if (dt.Rows.Count == 1)
                {
                    //Update record
                    var sql = @"update Employee
                                set Emplyee_Name = '" + this.txtEmployeeName.Text + @"',
                                Employee_Address = '" + this.txtEmployeeAddress.Text + @"',
                                Emplyee_NID = '" + this.txtEmployeeNID.Text + @"',
                                Employee_Salary = '" + this.txtEmployeeSalary.Text + @"',
                                Joining_Date = '" + this.dtJoiningDate.Text + @"',
                                where Employee_Id = '" + this.txtEmployeeId.Text + "';";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data update complete");
                    else
                        MessageBox.Show("Data update failed");
                }
                else
                {
                    //Insert record
                    string sql = "insert into Employee values('" + this.txtEmployeeId.Text + "','" + this.txtEmployeeName.Text + "','" +
                         this.txtEmployeeAddress.Text + "','" + this.txtEmployeeNID.Text + "','" + this.txtEmployeeSalary.Text + "','"+
                         this.dtJoiningDate.Text + "');";
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
            if (String.IsNullOrEmpty(this.txtEmployeeId.Text) || String.IsNullOrWhiteSpace(this.txtEmployeeId.Text) ||
                String.IsNullOrEmpty(this.txtEmployeeName.Text) || String.IsNullOrWhiteSpace(this.txtEmployeeName.Text) ||
                String.IsNullOrEmpty(this.txtEmployeeAddress.Text) || String.IsNullOrWhiteSpace(this.txtEmployeeAddress.Text) ||
                String.IsNullOrEmpty(this.txtEmployeeNID.Text) || String.IsNullOrWhiteSpace(this.txtEmployeeNID.Text) ||
                String.IsNullOrEmpty(this.txtEmployeeSalary.Text) || String.IsNullOrWhiteSpace(this.txtEmployeeSalary.Text))
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
            this.txtEmployeeId.Clear();
            this.txtEmployeeName.Clear();
            this.txtEmployeeAddress.Clear();
            this.txtEmployeeNID.Clear();
            this.txtEmployeeSalary.Clear();
            this.dtJoiningDate.Text = " ";
            this.txtSearch.Clear();
            this.txtAutoSearch.Clear();
            this.dgvEmployeeList.ClearSelection();
            this.AutoIdGenerator();
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            if (this.dgvEmployeeList.SelectedRows.Count < 0)
            {
                MessageBox.Show("Please select a Row first");
                return;
            }

            var id = this.dgvEmployeeList.CurrentRow.Cells[0].Value.ToString();
            var Name = this.dgvEmployeeList.CurrentRow.Cells[1].Value.ToString();

            try
            {
                var sql = "delete from Employee where Employee_Id = '" + id + "';";
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

        private void AutoIdGenerator()
        {
            var sql = "select Employee_Id from Employee order by Employee_Id desc;";
            var dt = this.Da.ExecuteQueryTable(sql);
            string lastId = dt.Rows[0]["Employee_Id"].ToString();
            string[] data = lastId.Split('-');
            int temp = Convert.ToInt32(data[1]);
            string newId = "U-" + (++temp).ToString("d3");
            this.txtEmployeeId.Text = newId;
        }




        private void btnPrevious_Click(object sender, EventArgs e)
        {
            FormAdminAccount formAdminAccount = new FormAdminAccount();
            formAdminAccount.Visible = true;
            this.Visible = false;
        }

        private void RegisterEmployee_FormClosing(object sender, FormClosingEventArgs e)
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
