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
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }
        int startPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 2;
            pbLoadingScreen.Value = startPoint;

            if(pbLoadingScreen.Value == 100)
            {
                pbLoadingScreen.Value = 0;
                timer1.Stop();
                Login login = new Login();
                login.Visible = true;
                this.Visible = false;
            }
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
