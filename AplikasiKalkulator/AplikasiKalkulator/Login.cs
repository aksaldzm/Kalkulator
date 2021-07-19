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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txt_uname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_pw.Focus();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin akan keluar ?",
                "KONFIRMASI",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();   
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_uname.Text == "aksal" && txt_pw.Text == "aksal")
            {
                Utama utama = new Utama();
                utama.Show();
                this.Hide();
            }
            else{
                MessageBox.Show("User Name & Password Salah.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txt_uname.SelectAll();
            txt_uname.Focus();
        }

        private void Login_Activated(object sender, EventArgs e)
        {
            txt_uname.Focus();
        }

        private void txt_pw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btn_login.PerformClick();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }




    }
}
