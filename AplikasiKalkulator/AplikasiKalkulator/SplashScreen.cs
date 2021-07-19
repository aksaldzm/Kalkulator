using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AplikasiKalkulator
{
    public partial class SplashScreen : Form
    {
        int a = 0;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a++;
            if (a == 5)
            {
                timer1.Enabled = false;
                this.Hide();

                Login login = new Login();
                login.Show();
            }

        }




    }
}
