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
    public partial class FormAdminAccount : Form
    {
        private DataAccess Da { get; set;}
        public FormAdminAccount()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        //Logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            DialogResult dialog = MessageBox.Show("Are You sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                lg.Visible = true;
                this.Visible = false;
            }

            else if(dialog == DialogResult.No)
            {
                lg.Visible = false;
                this.Visible = true;
            }

        }
        //ComboBox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSelectList.SelectedItem.ToString() == "Employee Information")
                {
                    string sql = "Select*from Employee";
                    DataAccess da = new DataAccess();
                    DataSet ds = da.ExecuteQuery(sql);

                    this.dgvInformationList.DataSource = ds.Tables[0];
                }

                else if (cmbSelectList.SelectedItem.ToString() == "Customer Information")
                {
                    string sql = "Select*from Customer";
                    DataAccess da = new DataAccess();
                    DataSet ds = da.ExecuteQuery(sql);

                    this.dgvInformationList.DataSource = ds.Tables[0];
                }

                else if (cmbSelectList.SelectedItem.ToString() == "Car Information")
                {
                    string sql = "Select*from Car";
                    DataAccess da = new DataAccess();
                    DataSet ds = da.ExecuteQuery(sql);

                    this.dgvInformationList.DataSource = ds.Tables[0];
                }

                else if (cmbSelectList.SelectedItem.ToString() == "Rental Information")
                {
                    string sql = "Select*from Rental";
                    DataAccess da = new DataAccess();
                    DataSet ds = da.ExecuteQuery(sql);

                    this.dgvInformationList.DataSource = ds.Tables[0];

                }

            }

            catch (Exception exc)
            {
                MessageBox.Show("Error" + exc);
            }
        }
        //Windows Close Confrinmation
        private void FormAdminAccount_FormClosing(object sender, FormClosingEventArgs e)
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

        //Search by ID and Car Type
       private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbSelectList.SelectedItem.ToString() == "Employee Information")
            {
                string sql = "select*from Employee where Employee_Id = '" + this.txtSearch.Text + "';";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);
                this.dgvInformationList.DataSource = ds.Tables[0];
            }

            else if(cmbSelectList.SelectedItem.ToString() == "Customer Information")
            {
                string sql = "select*from Customer where Customer_Id = '" + this.txtSearch.Text + "';";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);
                this.dgvInformationList.DataSource = ds.Tables[0];
            }

            else if (cmbSelectList.SelectedItem.ToString() == "Car Information")
            {
                string sql = "select*from Car where Car_Type = '" + this.txtSearch.Text + "';";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);
                this.dgvInformationList.DataSource = ds.Tables[0];
            }
        }

        //Search by Name and Car Model
        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            if (cmbSelectList.SelectedItem.ToString() == "Employee Information")
            {
                string sql = "select*from Employee where Employee_Name like'" + this.txtAutoSearch.Text + "%';";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);
                this.dgvInformationList.DataSource = ds.Tables[0];
            }

            else if (cmbSelectList.SelectedItem.ToString() == "Customer Information")
            {
                string sql = "select*from Customer where Customer_Name like'" + this.txtAutoSearch.Text + "%';";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);
                this.dgvInformationList.DataSource = ds.Tables[0];
            }

            else if (cmbSelectList.SelectedItem.ToString() == "Car Information")
            {
                string sql = "select*from Car where Car_Model like'" + this.txtAutoSearch.Text + "%';";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);
                this.dgvInformationList.DataSource = ds.Tables[0];
            }
        }
        //Register Button
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterEmployee registerEmployee = new RegisterEmployee();
            registerEmployee.Visible = true;
            this.Visible = false;
        }
        //Add Car Button
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            AddCar addCar = new AddCar();
            addCar.Visible = true;
            this.Visible = false;
        }
    }
}
