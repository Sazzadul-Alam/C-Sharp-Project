using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            DataAccess da = new DataAccess();
        }
        //Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserid.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please Fill User ID and Password");
            }


           string sql = "select * from UserInfo where Id = '" + this.txtUserid.Text + "' and Password = '" + this.txtPassword.Text + "';";

            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);
           
             if (ds.Tables[0].Rows.Count == 1)
             {
                if(txtUserid.Text == "A-001")
                {
                    MessageBox.Show("Login confirmed");
                    FormAdminAccount fAdminacc = new FormAdminAccount();
                    fAdminacc.Visible = true;
                    this.Visible = false;
                }
                
                else
                {
                    MessageBox.Show("Login confirmed");
                    FormEmployeeAccount employee = new FormEmployeeAccount();
                    employee.Visible = true;
                    this.Visible = false;
                }
                
             }

             else
             {
                MessageBox.Show("User ID or Password is Incorrect");
             }
        }
        //Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtUserid.Clear();
            this.txtPassword.Clear();
        }
        //Form Close
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to close the Application ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
