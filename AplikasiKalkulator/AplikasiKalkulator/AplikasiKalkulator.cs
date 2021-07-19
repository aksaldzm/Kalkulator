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
    public partial class AplikasiKalkulator : Form
    {
        double bilkes, bilked, hasil;

        public AplikasiKalkulator()
        {
            InitializeComponent();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            bilkes = Convert.ToDouble(txt_bilkes.Text);
            bilked = Convert.ToDouble(txt_bilked.Text);
            hasil = bilkes + bilked;

            txt_hasil.Text = hasil.ToString();
        }

        private void btn_kurang_Click(object sender, EventArgs e)
        {
            bilkes = Convert.ToDouble(txt_bilkes.Text);
            bilked = Convert.ToDouble(txt_bilked.Text);
            hasil = bilkes - bilked;

            txt_hasil.Text = hasil.ToString();
        }

        private void btn_kali_Click(object sender, EventArgs e)
        {
            bilkes = Convert.ToDouble(txt_bilkes.Text);
            bilked = Convert.ToDouble(txt_bilked.Text);
            hasil = bilkes * bilked;

            txt_hasil.Text = hasil.ToString();
        }

        private void btn_bagi_Click(object sender, EventArgs e)
        {
            bilkes = Convert.ToDouble(txt_bilkes.Text);
            bilked = Convert.ToDouble(txt_bilked.Text);
            hasil = bilkes / bilked;

            txt_hasil.Text = hasil.ToString();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_bilkes.Clear();
            txt_bilked.Clear() ;
            txt_hasil.Clear();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_bilkes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_bilked.Focus();
            }
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_bilked_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void AplikasiKomputer_Load(object sender, EventArgs e)
        {

        }




    }
}
