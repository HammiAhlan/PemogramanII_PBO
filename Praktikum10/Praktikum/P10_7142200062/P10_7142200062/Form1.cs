using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10_7142200062
{
    public partial class Form1 : Form
    {
        Koneksi koneksi= new Koneksi();

    public void Tampil()
        {
            DataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_mahasiswa");
            DataMahasiswa.Columns[0].HeaderText = "NPM";
            DataMahasiswa.Columns[1].HeaderText = "NAMA";
            DataMahasiswa.Columns[2].HeaderText = "ANGKATAN";
            DataMahasiswa.Columns[3].HeaderText = "ALAMAT";
            DataMahasiswa.Columns[4].HeaderText = "EMAIL";
            DataMahasiswa.Columns[5].HeaderText = "NOHP";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tampil();

        }
    }
}
