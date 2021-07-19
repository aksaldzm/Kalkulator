namespace AplikasiKalkulator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>D:\Akshal_2C\AplikasiKalkulator\AplikasiKalkulator\Form1.cs
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_nim = new System.Windows.Forms.TextBox();
            this.rbn_laki = new System.Windows.Forms.RadioButton();
            this.cmb_agama = new System.Windows.Forms.ComboBox();
            this.lsb_kota = new System.Windows.Forms.ListBox();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.lbl_nim = new System.Windows.Forms.Label();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.lbl_jk = new System.Windows.Forms.Label();
            this.rbn_perempuan = new System.Windows.Forms.RadioButton();
            this.lbl_agama = new System.Windows.Forms.Label();
            this.cmb_jurusan = new System.Windows.Forms.ComboBox();
            this.lbl_jurusan = new System.Windows.Forms.Label();
            this.cmb_js = new System.Windows.Forms.ComboBox();
            this.lbl_js = new System.Windows.Forms.Label();
            this.txt_alamat = new System.Windows.Forms.TextBox();
            this.lbl_alamat = new System.Windows.Forms.Label();
            this.lbl_kota = new System.Windows.Forms.Label();
            this.txt_telepon = new System.Windows.Forms.TextBox();
            this.btn_tampil = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.btn_keluar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Black;
            this.lbl_title.Location = new System.Drawing.Point(108, 23);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(174, 15);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "ENTRY DATA MAHASISWA";
            // 
            // txt_nim
            // 
            this.txt_nim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nim.Location = new System.Drawing.Point(132, 51);
            this.txt_nim.MaxLength = 9;
            this.txt_nim.Name = "txt_nim";
            this.txt_nim.Size = new System.Drawing.Size(100, 21);
            this.txt_nim.TabIndex = 1;
            this.txt_nim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nim_KeyPress);
            // 
            // rbn_laki
            // 
            this.rbn_laki.AutoSize = true;
            this.rbn_laki.Location = new System.Drawing.Point(132, 104);
            this.rbn_laki.Name = "rbn_laki";
            this.rbn_laki.Size = new System.Drawing.Size(64, 17);
            this.rbn_laki.TabIndex = 2;
            this.rbn_laki.TabStop = true;
            this.rbn_laki.Text = "Laki-laki";
            this.rbn_laki.UseVisualStyleBackColor = true;
            // 
            // cmb_agama
            // 
            this.cmb_agama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_agama.FormattingEnabled = true;
            this.cmb_agama.Items.AddRange(new object[] {
            "BUDDHA",
            "HINDU",
            "ISLAM",
            "KATOLIK",
            "KONGHUCU",
            "KRISTEN"});
            this.cmb_agama.Location = new System.Drawing.Point(132, 127);
            this.cmb_agama.Name = "cmb_agama";
            this.cmb_agama.Size = new System.Drawing.Size(121, 21);
            this.cmb_agama.TabIndex = 3;
            this.cmb_agama.SelectedIndexChanged += new System.EventHandler(this.cmb_agama_SelectedIndexChanged);
            // 
            // lsb_kota
            // 
            this.lsb_kota.FormattingEnabled = true;
            this.lsb_kota.Items.AddRange(new object[] {
            "BANDUNG",
            "JAKARTA",
            "BOYOLOLALI",
            "KUALA LUMPUR",
            "BANGKOK",
            "CALIFORNIA"});
            this.lsb_kota.Location = new System.Drawing.Point(131, 277);
            this.lsb_kota.Name = "lsb_kota";
            this.lsb_kota.Size = new System.Drawing.Size(120, 108);
            this.lsb_kota.TabIndex = 4;
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(262, 303);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(126, 23);
            this.btn_simpan.TabIndex = 5;
            this.btn_simpan.Text = "SIMPAN";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // lbl_nim
            // 
            this.lbl_nim.AutoSize = true;
            this.lbl_nim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nim.Location = new System.Drawing.Point(98, 59);
            this.lbl_nim.Name = "lbl_nim";
            this.lbl_nim.Size = new System.Drawing.Size(31, 13);
            this.lbl_nim.TabIndex = 6;
            this.lbl_nim.Text = "*NIM";
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(132, 78);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(182, 20);
            this.txt_nama.TabIndex = 7;
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nama.Location = new System.Drawing.Point(18, 81);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(111, 13);
            this.lbl_nama.TabIndex = 8;
            this.lbl_nama.Text = "*NAMA MAHASISWA";
            // 
            // lbl_jk
            // 
            this.lbl_jk.AutoSize = true;
            this.lbl_jk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jk.Location = new System.Drawing.Point(39, 104);
            this.lbl_jk.Name = "lbl_jk";
            this.lbl_jk.Size = new System.Drawing.Size(87, 13);
            this.lbl_jk.TabIndex = 9;
            this.lbl_jk.Text = "JENIS KELAMIN";
            // 
            // rbn_perempuan
            // 
            this.rbn_perempuan.AutoSize = true;
            this.rbn_perempuan.Location = new System.Drawing.Point(224, 104);
            this.rbn_perempuan.Name = "rbn_perempuan";
            this.rbn_perempuan.Size = new System.Drawing.Size(79, 17);
            this.rbn_perempuan.TabIndex = 10;
            this.rbn_perempuan.TabStop = true;
            this.rbn_perempuan.Text = "Perempuan";
            this.rbn_perempuan.UseVisualStyleBackColor = true;
            // 
            // lbl_agama
            // 
            this.lbl_agama.AutoSize = true;
            this.lbl_agama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_agama.Location = new System.Drawing.Point(80, 130);
            this.lbl_agama.Name = "lbl_agama";
            this.lbl_agama.Size = new System.Drawing.Size(45, 13);
            this.lbl_agama.TabIndex = 11;
            this.lbl_agama.Text = "AGAMA";
            // 
            // cmb_jurusan
            // 
            this.cmb_jurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_jurusan.FormattingEnabled = true;
            this.cmb_jurusan.Location = new System.Drawing.Point(131, 154);
            this.cmb_jurusan.Name = "cmb_jurusan";
            this.cmb_jurusan.Size = new System.Drawing.Size(121, 21);
            this.cmb_jurusan.TabIndex = 12;
            // 
            // lbl_jurusan
            // 
            this.lbl_jurusan.AutoSize = true;
            this.lbl_jurusan.Location = new System.Drawing.Point(67, 157);
            this.lbl_jurusan.Name = "lbl_jurusan";
            this.lbl_jurusan.Size = new System.Drawing.Size(58, 13);
            this.lbl_jurusan.TabIndex = 13;
            this.lbl_jurusan.Text = "JURUSAN";
            // 
            // cmb_js
            // 
            this.cmb_js.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_js.FormattingEnabled = true;
            this.cmb_js.Items.AddRange(new object[] {
            "S2",
            "S1",
            "D4",
            "D3"});
            this.cmb_js.Location = new System.Drawing.Point(131, 181);
            this.cmb_js.Name = "cmb_js";
            this.cmb_js.Size = new System.Drawing.Size(121, 21);
            this.cmb_js.TabIndex = 14;
            // 
            // lbl_js
            // 
            this.lbl_js.AutoSize = true;
            this.lbl_js.Location = new System.Drawing.Point(32, 184);
            this.lbl_js.Name = "lbl_js";
            this.lbl_js.Size = new System.Drawing.Size(91, 13);
            this.lbl_js.TabIndex = 15;
            this.lbl_js.Text = "JENJANG STUDI";
            // 
            // txt_alamat
            // 
            this.txt_alamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_alamat.Location = new System.Drawing.Point(131, 208);
            this.txt_alamat.Multiline = true;
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_alamat.Size = new System.Drawing.Size(257, 63);
            this.txt_alamat.TabIndex = 16;
            // 
            // lbl_alamat
            // 
            this.lbl_alamat.AutoSize = true;
            this.lbl_alamat.Location = new System.Drawing.Point(75, 213);
            this.lbl_alamat.Name = "lbl_alamat";
            this.lbl_alamat.Size = new System.Drawing.Size(50, 13);
            this.lbl_alamat.TabIndex = 17;
            this.lbl_alamat.Text = "ALAMAT";
            // 
            // lbl_kota
            // 
            this.lbl_kota.AutoSize = true;
            this.lbl_kota.Location = new System.Drawing.Point(32, 287);
            this.lbl_kota.Name = "lbl_kota";
            this.lbl_kota.Size = new System.Drawing.Size(94, 13);
            this.lbl_kota.TabIndex = 18;
            this.lbl_kota.Text = "KOTA - NO. TELP";
            // 
            // txt_telepon
            // 
            this.txt_telepon.Location = new System.Drawing.Point(262, 277);
            this.txt_telepon.Name = "txt_telepon";
            this.txt_telepon.Size = new System.Drawing.Size(126, 20);
            this.txt_telepon.TabIndex = 19;
            this.txt_telepon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telepon_KeyPress);
            // 
            // btn_tampil
            // 
            this.btn_tampil.Location = new System.Drawing.Point(262, 332);
            this.btn_tampil.Name = "btn_tampil";
            this.btn_tampil.Size = new System.Drawing.Size(60, 23);
            this.btn_tampil.TabIndex = 20;
            this.btn_tampil.Text = "TAMPIL";
            this.btn_tampil.UseVisualStyleBackColor = true;
            this.btn_tampil.Click += new System.EventHandler(this.btn_tampil_Click);
            // 
            // btn_tambah
            // 
            this.btn_tambah.Location = new System.Drawing.Point(328, 332);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(60, 23);
            this.btn_tambah.TabIndex = 21;
            this.btn_tambah.Text = "TAMBAH";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // btn_keluar
            // 
            this.btn_keluar.Location = new System.Drawing.Point(262, 361);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(126, 23);
            this.btn_keluar.TabIndex = 22;
            this.btn_keluar.Text = "KELUAR";
            this.btn_keluar.UseVisualStyleBackColor = true;
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(410, 25);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 403);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btn_keluar);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.btn_tampil);
            this.Controls.Add(this.txt_telepon);
            this.Controls.Add(this.lbl_kota);
            this.Controls.Add(this.lbl_alamat);
            this.Controls.Add(this.txt_alamat);
            this.Controls.Add(this.lbl_js);
            this.Controls.Add(this.cmb_js);
            this.Controls.Add(this.lbl_jurusan);
            this.Controls.Add(this.cmb_jurusan);
            this.Controls.Add(this.lbl_agama);
            this.Controls.Add(this.rbn_perempuan);
            this.Controls.Add(this.lbl_jk);
            this.Controls.Add(this.lbl_nama);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.lbl_nim);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.lsb_kota);
            this.Controls.Add(this.cmb_agama);
            this.Controls.Add(this.rbn_laki);
            this.Controls.Add(this.txt_nim);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DATA MAHASISWA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_nim;
        private System.Windows.Forms.RadioButton rbn_laki;
        private System.Windows.Forms.ComboBox cmb_agama;
        private System.Windows.Forms.ListBox lsb_kota;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Label lbl_nim;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.Label lbl_jk;
        private System.Windows.Forms.RadioButton rbn_perempuan;
        private System.Windows.Forms.Label lbl_agama;
        private System.Windows.Forms.ComboBox cmb_jurusan;
        private System.Windows.Forms.Label lbl_jurusan;
        private System.Windows.Forms.ComboBox cmb_js;
        private System.Windows.Forms.Label lbl_js;
        private System.Windows.Forms.TextBox txt_alamat;
        private System.Windows.Forms.Label lbl_alamat;
        private System.Windows.Forms.Label lbl_kota;
        private System.Windows.Forms.TextBox txt_telepon;
        private System.Windows.Forms.Button btn_tampil;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Button btn_keluar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

