﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_714220062
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(369, 273);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CekButton_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(textBoxNama.Text))
            {
                errorMessage += "Nama Belum Di isi\n";
            }
            if (string.IsNullOrWhiteSpace(textBoxProdi.Text))
            {
                errorMessage += "Prodi Belum Di isi\n";
            }
            else if (!Regex.IsMatch(textBoxProdi.Text, @"^^[A-Za-z0-9]+-[A-Za-z0-9]+$"))
            {
                errorMessage += "Prodi hapus berformat [Strata]-[prodi]\n";

            }
            if (string.IsNullOrWhiteSpace(textBoxKelas.Text))
            {
                errorMessage += "Kelas Belum Di isi\n";
            }

            if (string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show("Lengkap", "Informasi Data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Size = new Size(365, 525);
            }
            else
            {
                MessageBox.Show(errorMessage, "Informasi Data Submit",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                CbKuliah.Enabled = true; CbKuliah.Checked = true;
                cbTravelling.Enabled = false; cbTravelling.Checked = false;
                cbTidur.Enabled = true; cbTidur.Checked = false;
            }
        }

        private void rbMinggu_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMinggu.Checked)
            {
                CbKuliah.Enabled = false;
                cbTravelling.Enabled = true;
                cbTidur.Enabled = true;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            // textBoxNama.Text = null;
            //textBoxProdi.Text = null;
            //textBoxKelas.Text = null;

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)

                    ((TextBox)control).Text = string.Empty;
                else if (control is RadioButton)

                    ((RadioButton)control).Checked = false;
                else if (control is RadioButton)

                    ((RadioButton)control).Checked = false;
                /*else if (control is ComboBox)

                        ((ComboBox)control).SelectedIndex = -1;*/
            }
            this.Size = new Size(400, 220);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(textBoxNama.Text))
            {
                errorMessage += "Nama harus di isi\n";
            }

            if (string.IsNullOrWhiteSpace(textBoxProdi.Text))
            {
                errorMessage += "Prodi harus di isi\n";
            }

            if (string.IsNullOrWhiteSpace(textBoxKelas.Text))
            {
                errorMessage += "Kelas harus di isi\n";
            }

            if (!Regex.IsMatch(textBoxProdi.Text, @"^[A-Za-z0-9]+-[A-Za-z0-9]+$"))
            {
                errorMessage += "Prodi harus berformat [Strata-Prodi]\n";
            }

            string HariSantai = radioButton1.Checked ? "Senin" : "Minggu";
            string AktivitasNanti = "";

            if (CbKuliah.Checked)
            {
                AktivitasNanti += "Kuliah, ";

            }

            if (cbTravelling.Checked)
            {
                AktivitasNanti += "Traveling, ";

            }

            if (cbTidur.Checked)
            {
                AktivitasNanti += "Tidur, ";


            }

            if (AktivitasNanti.Length > 0)
            {
                AktivitasNanti = AktivitasNanti.TrimEnd(' ', ',');
            }

            if (string.IsNullOrEmpty(errorMessage))
            {
                string infoMessage = $"Nama: {textBoxNama.Text}\nProdi: {textBoxProdi.Text}\nKelas: {textBoxKelas.Text}\nHari Yang Akan dilakukan: {HariSantai}\nAktivitas: {AktivitasNanti}";

                MessageBox.Show
                    (infoMessage,
                    "Informasi Data Cetak",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show
                   (errorMessage,
                    "Informasi Data Cetak",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

