using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714220062
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string GroupKelasBox = "";
            string GroupJadwalBox = "";
            DateTime tanggalaja = TanggalWaktu.Value;
            string tanggalaja2 = tanggalaja.ToString("dd - MMMM - yyyy");
            string JenisKelamin = JenisKelamin1.GetItemText(JenisKelamin1.SelectedItem);


            //Kelas Box
            if (Biola1.Checked)
            {
                GroupKelasBox = "Biola, ";
            }
            if (Saxophone1.Checked)
            {
                GroupKelasBox = "Saxophone, ";
            }
            if (Gitar1.Checked)
                {
                    GroupKelasBox = "Gitar1, ";
                }
                if (Konduktor1.Checked)
            {
                GroupKelasBox = "Konduktor, ";
            }
            if (Piano1.Checked)
            {
                GroupKelasBox = "Piano, ";
            }
            if (Drum1.Checked)
            {
                GroupKelasBox = "Drum, ";
            }
            if (Vokal1.Checked)
            {
                GroupKelasBox = "Vokal, ";
            }
            if (Komposer1.Checked)
            {
                GroupKelasBox = "Komposer, ";
            }

            if (!string.IsNullOrEmpty(GroupKelasBox))
            {
                GroupKelasBox = GroupKelasBox.TrimEnd(' ', ',');
            }
            //Group Pilihan Waktu

            if (SeninKamis.Checked)
            {
                GroupJadwalBox = "Senin-Kamis, 14.00 - 16.00";
            }
                else if (SelasaKamis.Checked)
            {
                GroupJadwalBox = "Selasa-Kamis, 14.00 - 16.00";
            }
                else if(SabtuMinggu.Checked)
            {
                GroupJadwalBox = "Sabtu-Minggu, 09.00-11.00";
            }
                else if (Minggu1.Checked)
            {
                GroupJadwalBox = "Minggu, 13.00 - 19.00";
            }


            if (GroupKelasBox != "" && GroupJadwalBox != "")
            {
                MessageBox.Show("Nama : " + txtNama.Text + "\nJenis Kelamin : " + JenisKelamin + "\nTanggal Lahir : " + tanggalaja2 + "\nPilihan Kelas : " + GroupKelasBox + "\nPilihan Jadwal : " + GroupJadwalBox, "Informasi Pendaftaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtNama.Text == "")
            {
                MessageBox.Show("Masukkan nama anda, tidak boleh kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (JenisKelamin == "")
            {
                MessageBox.Show("Pilih jenis kelamin anda, tidak boleh kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (GroupKelasBox == "")
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan kelas", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (GroupJadwalBox == "")
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan jadwal", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void KelasGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void TanggalWaktu_ValueChanged(object sender, EventArgs e)
        {

        }

        private void JenisKelamin1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
