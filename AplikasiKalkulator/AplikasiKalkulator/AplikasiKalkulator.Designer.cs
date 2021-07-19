namespace AplikasiKalkulator
{
    partial class AplikasiKalkulator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
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
            this.gb_dabil = new System.Windows.Forms.GroupBox();
            this.txt_hasil = new System.Windows.Forms.TextBox();
            this.txt_bilked = new System.Windows.Forms.TextBox();
            this.txt_bilkes = new System.Windows.Forms.TextBox();
            this.lbl_hasil = new System.Windows.Forms.Label();
            this.lbl_bilked = new System.Windows.Forms.Label();
            this.lbl_bilkes = new System.Windows.Forms.Label();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.btn_kurang = new System.Windows.Forms.Button();
            this.btn_kali = new System.Windows.Forms.Button();
            this.btn_bagi = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.gb_dabil.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_dabil
            // 
            this.gb_dabil.Controls.Add(this.txt_hasil);
            this.gb_dabil.Controls.Add(this.txt_bilked);
            this.gb_dabil.Controls.Add(this.txt_bilkes);
            this.gb_dabil.Controls.Add(this.lbl_hasil);
            this.gb_dabil.Controls.Add(this.lbl_bilked);
            this.gb_dabil.Controls.Add(this.lbl_bilkes);
            this.gb_dabil.Location = new System.Drawing.Point(28, 39);
            this.gb_dabil.Name = "gb_dabil";
            this.gb_dabil.Size = new System.Drawing.Size(377, 178);
            this.gb_dabil.TabIndex = 0;
            this.gb_dabil.TabStop = false;
            this.gb_dabil.Text = "Data Bilangan";
            // 
            // txt_hasil
            // 
            this.txt_hasil.Location = new System.Drawing.Point(176, 103);
            this.txt_hasil.Name = "txt_hasil";
            this.txt_hasil.ReadOnly = true;
            this.txt_hasil.Size = new System.Drawing.Size(100, 20);
            this.txt_hasil.TabIndex = 5;
            // 
            // txt_bilked
            // 
            this.txt_bilked.Location = new System.Drawing.Point(176, 71);
            this.txt_bilked.Name = "txt_bilked";
            this.txt_bilked.Size = new System.Drawing.Size(100, 20);
            this.txt_bilked.TabIndex = 4;
            this.txt_bilked.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_bilked_KeyPress);
            // 
            // txt_bilkes
            // 
            this.txt_bilkes.Location = new System.Drawing.Point(176, 33);
            this.txt_bilkes.Name = "txt_bilkes";
            this.txt_bilkes.Size = new System.Drawing.Size(100, 20);
            this.txt_bilkes.TabIndex = 3;
            this.txt_bilkes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_bilkes_KeyPress);
            // 
            // lbl_hasil
            // 
            this.lbl_hasil.AutoSize = true;
            this.lbl_hasil.Location = new System.Drawing.Point(52, 103);
            this.lbl_hasil.Name = "lbl_hasil";
            this.lbl_hasil.Size = new System.Drawing.Size(30, 13);
            this.lbl_hasil.TabIndex = 2;
            this.lbl_hasil.Text = "Hasil";
            // 
            // lbl_bilked
            // 
            this.lbl_bilked.AutoSize = true;
            this.lbl_bilked.Location = new System.Drawing.Point(52, 71);
            this.lbl_bilked.Name = "lbl_bilked";
            this.lbl_bilked.Size = new System.Drawing.Size(82, 13);
            this.lbl_bilked.TabIndex = 1;
            this.lbl_bilked.Text = "Bilangan Kedua";
            // 
            // lbl_bilkes
            // 
            this.lbl_bilkes.AutoSize = true;
            this.lbl_bilkes.Location = new System.Drawing.Point(52, 41);
            this.lbl_bilkes.Name = "lbl_bilkes";
            this.lbl_bilkes.Size = new System.Drawing.Size(84, 13);
            this.lbl_bilkes.TabIndex = 0;
            this.lbl_bilkes.Text = "Bilangan Kesatu";
            // 
            // btn_tambah
            // 
            this.btn_tambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tambah.Location = new System.Drawing.Point(34, 223);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(50, 35);
            this.btn_tambah.TabIndex = 1;
            this.btn_tambah.Text = "+";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // btn_kurang
            // 
            this.btn_kurang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kurang.Location = new System.Drawing.Point(90, 222);
            this.btn_kurang.Name = "btn_kurang";
            this.btn_kurang.Size = new System.Drawing.Size(50, 35);
            this.btn_kurang.TabIndex = 2;
            this.btn_kurang.Text = "-";
            this.btn_kurang.UseVisualStyleBackColor = true;
            this.btn_kurang.Click += new System.EventHandler(this.btn_kurang_Click);
            // 
            // btn_kali
            // 
            this.btn_kali.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kali.Location = new System.Drawing.Point(146, 222);
            this.btn_kali.Name = "btn_kali";
            this.btn_kali.Size = new System.Drawing.Size(50, 35);
            this.btn_kali.TabIndex = 3;
            this.btn_kali.Text = "*";
            this.btn_kali.UseVisualStyleBackColor = true;
            this.btn_kali.Click += new System.EventHandler(this.btn_kali_Click);
            // 
            // btn_bagi
            // 
            this.btn_bagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bagi.Location = new System.Drawing.Point(202, 222);
            this.btn_bagi.Name = "btn_bagi";
            this.btn_bagi.Size = new System.Drawing.Size(50, 35);
            this.btn_bagi.TabIndex = 4;
            this.btn_bagi.Text = "/";
            this.btn_bagi.UseVisualStyleBackColor = true;
            this.btn_bagi.Click += new System.EventHandler(this.btn_bagi_Click);
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(275, 222);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(57, 35);
            this.btn_new.TabIndex = 5;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(348, 222);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(57, 35);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // AplikasiKomputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 300);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_bagi);
            this.Controls.Add(this.btn_kali);
            this.Controls.Add(this.btn_kurang);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.gb_dabil);
            this.Name = "AplikasiKomputer";
            this.Text = "Aplikasi Kalkulator";
            this.Load += new System.EventHandler(this.AplikasiKomputer_Load);
            this.gb_dabil.ResumeLayout(false);
            this.gb_dabil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_dabil;
        private System.Windows.Forms.Label lbl_hasil;
        private System.Windows.Forms.Label lbl_bilked;
        private System.Windows.Forms.Label lbl_bilkes;
        private System.Windows.Forms.TextBox txt_hasil;
        private System.Windows.Forms.TextBox txt_bilked;
        private System.Windows.Forms.TextBox txt_bilkes;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Button btn_kurang;
        private System.Windows.Forms.Button btn_kali;
        private System.Windows.Forms.Button btn_bagi;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_close;
    }
}

