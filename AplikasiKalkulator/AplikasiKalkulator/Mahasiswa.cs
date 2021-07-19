using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplikasiKalkulator
{
    class Mahasiswa
    {
        //atribute
        private string _nim;
        private string _nama;
        private string _alamat;
        private string _agama;
        private string _jurusan;
        private string _jenjang;
        private string _kota;
        private string _jns_kel;
        private string _telp;
        

        //constructor
        public Mahasiswa()
        {
            _nim = "";
            _nama = "";
            _alamat = "";
            _agama = "";
            _jurusan = "";
            _jenjang = "";
            _kota = "";
            _jns_kel = "";
            _telp = "";

        }

        //property
        public string nim
        {
            //aksesor
            get { return _nim; }
            //mutator
            set { _nim = value; }
        }

        public string nama
        {
            //aksesor
            get { return _nama; }
            //mutator
            set { _nama = value; }
        }

        public string alamat
        {
            //aksesor
            get { return _alamat; }
            //mutator
            set { _alamat = value; }
        }

        public string agama
        {
            //aksesor
            get { return _agama; }
            //mutator
            set { _agama = value; }
        }

        public string jurusan
        {
            //aksesor
            get { return _jurusan; }
            //mutator
            set { _jurusan = value; }
        }

        public string jenjang
        {
            //aksesor
            get { return _jenjang; }
            //mutator
            set { _jenjang = value; }
        }

        public string kota
        {
            //aksesor
            get { return _kota; }
            //mutator
            set { _kota = value; }
        }

        public string jns_kel
        {
            //aksesor
            get { return _jns_kel; }
            //mutator
            set { _jns_kel = value; }
        }

        public string telp
        {
            //aksesor
            get { return _telp; }
            //mutator
            set { _telp = value; }
        }
    }
}
