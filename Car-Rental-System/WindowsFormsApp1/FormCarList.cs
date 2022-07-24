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
    public partial class FormCarList : Form
    {
        public FormCarList()
        {
            InitializeComponent();
            DataAccess da = new DataAccess();
            string sql = "select * from car";
            DataSet ds = da.ExecuteQuery(sql);

            this.dgvCarInformation.DataSource = ds.Tables[0];
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

        private void btnPrivious_Click(object sender, EventArgs e)
        {
            FormEmployeeAccount fEmployeeAccount = new FormEmployeeAccount();
            fEmployeeAccount.Visible = true;
            this.Visible = false;
        }

        private void cmbCarType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "Select * from Car where Car_Type = '"+this.cmbCarType .Text+ "'; ";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);

            this.dgvCarInformation.DataSource = ds.Tables[0];
        }
        


        private void FormCarList_FormClosing(object sender, FormClosingEventArgs e)
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
            string sql = "select * from car where Car_Model= '" + this.txtSearch.Text + "';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);

            this.dgvCarInformation.DataSource = ds.Tables[0];
        }

    }
}
