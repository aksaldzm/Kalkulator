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
    public partial class Form1 : Form
    {
        string nim, nama, alamat, jns_kel, agama, jurusan, jenjang;
        string telp, kota;

        Mahasiswa mahasiswa = new Mahasiswa();

        public Form1()
        {
            InitializeComponent();
        }


        private void btn_keluar_Click(object sender, EventArgs e)
        {
            //menutup form
            Close();
            //menutup aplikasi
            //Application.Exit();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            txt_nim.Text = "";
            txt_nama.Text = "";
            rbn_laki.Checked = false;
            rbn_perempuan.Checked = false;
            cmb_agama.SelectedIndex = -1;
            cmb_js.SelectedIndex= -1;
            cmb_jurusan.SelectedIndex = -1;
            lsb_kota.Text = "";
            txt_telepon.Clear();
            txt_alamat.Clear();
            txt_nim.Focus();

        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (txt_nim.Text != "" && txt_nama.Text != "")
            {
                if (MessageBox.Show("Sudah yakin data yang di isi benar ?",
                "KONFIRMASI",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                mahasiswa.nim = txt_nim.Text;
                mahasiswa.nama = txt_nama.Text;
                mahasiswa.alamat = txt_alamat.Text;
                mahasiswa.telp = txt_telepon.Text;
                mahasiswa.agama = cmb_agama.Text;
                mahasiswa.jurusan = cmb_jurusan.Text;
                mahasiswa.jenjang = cmb_js.Text;
                if (rbn_laki.Checked == true)
                {
                    mahasiswa.jns_kel = rbn_laki.Text;
                }
                else if (rbn_perempuan.Checked == true)
                {
                    mahasiswa.jns_kel = rbn_perempuan.Text;
                }
                mahasiswa.kota = lsb_kota.Text;
                MessageBox.Show("Data Berhasil Disimpan.", "SIMPAN DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else {
                MessageBox.Show("Data Harus di isi.", "SIMPAN DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_tampil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NIM\t : " + mahasiswa.nim +
                           "\nNAMA\t : " + mahasiswa.nama +
                           "\nAGAMA\t : " + mahasiswa.agama +
                           "\nJNS.KEL\t : " + mahasiswa.jns_kel +
                           "\nJURUSAN\t : " + mahasiswa.jurusan +
                           "\nJENJANG\t : " + mahasiswa.jenjang +
                           "\nKOTA\t : " + mahasiswa.kota +
                           "\nTELEPON\t : " + mahasiswa.telp +
                           "\nALAMAT\t : " + mahasiswa.alamat,
                           "BIODATA",MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
        }

        private void txt_nim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_nama.Focus();
            }
            if (!char.IsNumber(e.KeyChar) && e.KeyChar!=8 && e.KeyChar!='.')
            {
                e.Handled = true;
            }
        }

        private void txt_telepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '+')
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                btn_simpan.PerformClick();
            }
        }

        private void cmb_agama_SelectedIndexChanged(object sender, EventArgs e)
        {
           cmb_jurusan.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //mengisi itrm combo box jurusan
            cmb_jurusan.Items.Clear();
            cmb_jurusan.Items.Add("TEKNIK INFORMATIKA");
            cmb_jurusan.Items.Add("TEKNIK NUKLIR");
            cmb_jurusan.Items.Add("TEKNIK MENABUNG");
            cmb_jurusan.Items.Add("TEKNIK KEBERSIHAN");
        }

     

    }
}
