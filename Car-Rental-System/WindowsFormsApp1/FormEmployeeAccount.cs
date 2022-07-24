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
    public partial class FormEmployeeAccount : Form
    {
        public FormEmployeeAccount()
        {
            InitializeComponent();
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

        private void btnCarList_Click(object sender, EventArgs e)
        {
            FormCarList fCarList = new FormCarList();
            fCarList.Visible = true;
            this.Visible = false;
        }

        private void btnCustomerInfo_Click(object sender, EventArgs e)
        {
            FormCustomerInfo fCustomerInfo = new FormCustomerInfo();
            fCustomerInfo.Visible = true;
            this.Visible = false;
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            FormRental fRental = new FormRental();
            fRental.Visible = true;
            this.Visible = false;
        }

        private void FormEmployeeAccount_FormClosing(object sender, FormClosingEventArgs e)
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
