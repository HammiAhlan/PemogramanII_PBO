﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10_1_714220062
{
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();

        public void Tampil()
        {
            //Query DB Get MGS
            DataMahasiswa.DataSource = koneksi.ShowData("Select * From t_mahasiswa");
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void DataMahasiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Memanggil method Tampil
            Tampil();
            DataMahasiswa.Columns[0].HeaderText = "NPM";
            DataMahasiswa.Columns[1].HeaderText = "Nama";
            DataMahasiswa.Columns[2].HeaderText = "Angkatan";
            DataMahasiswa.Columns[3].HeaderText = "Alamat";
            DataMahasiswa.Columns[4].HeaderText = "Email";
            DataMahasiswa.Columns[5].HeaderText = "No HP";
        }
    }
}
