using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1

{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(765 ,322);

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tbNIM.Text == "")
            {
                epWrong.SetError(tbNIM, "");
                epWarning.SetError(tbNIM, "nomor Tidak Boleh Kosong");
                epCorrect.SetError(tbNIM, "");
            }
            else if (tbNIM.Text.Length < 8 || !tbNIM.Text.All(Char.IsDigit))
            {
                epWrong.SetError(tbNIM, "panjang angka harus lebih dari 8 digit angka");
                epWarning.SetError(tbNIM, "");
                epCorrect.SetError(tbNIM, "");
            }
            else
            {
                epWarning.SetError(tbNIM, "");
                epWrong.SetError(tbNIM, "");
                epCorrect.SetError(tbNIM, "Betul");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btMataKuliah_Click(object sender, EventArgs e)
        {
            string errorMassage = "";

            if (string.IsNullOrWhiteSpace(tbNIM.Text))
            {
                errorMassage += "NIM Belum Diisi\n";
            }

            if (string.IsNullOrWhiteSpace(tbNama.Text))
            {
                errorMassage += "Nama Belum Diisi\n";
            }
            if (!rbLaki.Checked && !rbCewe.Checked)
            {
                errorMassage += "Jenis Kelamin Belum Diisi\n";
            }
            if (string.IsNullOrWhiteSpace(miAlamat.Text))
            {
                errorMassage += "Alamat Belum Diisi\n";
            }
            if (string.IsNullOrWhiteSpace(cbPROGRAMSTUDI.Text))
            {
                errorMassage += "Program Studi Belum Diisi\n";
            }
            if (string.IsNullOrWhiteSpace(tbThnAkademik.Text))
            {
                errorMassage += "Tahun Akademik Belum Diisi\n";
            }


            if (string.IsNullOrEmpty(errorMassage))
            {
                MessageBox.Show("Lengkap Coy!!", "Informasi Data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Size = new Size(797, 561);
            }
            else
            {
                MessageBox.Show(errorMassage, "Informasi Data Submit",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbNama_TextChanged(object sender, EventArgs e)
        {
            if (tbNama.Text == "")
            {

                epWarning.SetError(tbNama, "Nama tidak boleh kosong !");
                epWrong.SetError(tbNama, "");
                epCorrect.SetError(tbNama, "");
            }
            else
            {
                if ((tbNama.Text).All(Char.IsUpper))
                {
                    epWarning.SetError(tbNama, "");
                    epWrong.SetError(tbNama, "");
                    epCorrect.SetError(tbNama, "Betul");

                }
                else if ((tbNama.Text).Any(char.IsLower))
                {
                    epWarning.SetError(tbNama, "");
                    epWrong.SetError(tbNama, "Harus menggunakan huruf besar");
                    epCorrect.SetError(tbNama, "");
                }
            }
        }

        private void txAlamat(object sender, EventArgs e)
        {
            if (miAlamat.Text == "")
            {
                epWarning.SetError(miAlamat, "Alamat tidak boleh kosong!");
                epWrong.SetError(miAlamat, "");
                epCorrect.SetError(miAlamat, "");
            }
            else
            {
                string alamat = miAlamat.Text.Replace(".", "-").ToUpper();

                if (Regex.IsMatch(alamat, @"^[A-Z]+(-[A-Z]+)+-\d+$"))
                {
                    epWarning.SetError(miAlamat, "");
                    epWrong.SetError(miAlamat, "");
                    epCorrect.SetError(miAlamat, "Betul");
                }
                else if (alamat.Any(char.IsLower))
                {
                    epWarning.SetError(miAlamat, "Format alamat tidak sesuai!");
                    epWrong.SetError(miAlamat, "");
                    epCorrect.SetError(miAlamat, "");
                }
                else
                {
                    epWarning.SetError(miAlamat, "Format alamat tidak sesuai!");
                    epWrong.SetError(miAlamat, "");
                    epCorrect.SetError(miAlamat, "");
                }
            }


        }

        private void cbPROGRAMSTUDI_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            {
                if (cbPROGRAMSTUDI.Text == "")
                {
                    epWarning.SetError(cbPROGRAMSTUDI, "");
                    epWrong.SetError(cbPROGRAMSTUDI, "Program studi tidak boleh kosong");
                    epCorrect.SetError(cbPROGRAMSTUDI, "");
                }
                else if (cbPROGRAMSTUDI.SelectedIndex != -1)
                {
                    epWarning.SetError(cbPROGRAMSTUDI, "");
                    epWrong.SetError(cbPROGRAMSTUDI, "");
                    epCorrect.SetError(cbPROGRAMSTUDI, "Betul");
                }
                else
                {
                    epWarning.SetError(cbPROGRAMSTUDI, "Pilih program studi!");
                    epWrong.SetError(cbPROGRAMSTUDI, "");
                    epCorrect.SetError(cbPROGRAMSTUDI, "");
                }

            }
        }

        private void tbSemester_TextChanged(object sender, EventArgs e)
        {
            if (tbSemester.Text == "")

            {
                epWarning.SetError(tbSemester, "");
                epWrong.SetError(tbSemester, "Semester Tidak Boleh Kosong");
                epCorrect.SetError(tbSemester, "");
            }
            else if (tbSemester.Text.Length != 1 || !tbSemester.Text.All(Char.IsDigit))
            {
                epWarning.SetError(tbSemester, " hanya 1 digit angka");
                epWrong.SetError(tbSemester, "");
                epCorrect.SetError(tbSemester, "");
            }
            else
            {
                epWarning.SetError(tbSemester, "");
                epWrong.SetError(tbSemester, "");
                epCorrect.SetError(tbSemester, "Betul");
            }
            int semester = int.Parse(tbSemester.Text);

            if (semester <= 9)
            {
                epWarning.SetError(tbSemester, "");
                epWrong.SetError(tbSemester, "");
                epCorrect.SetError(tbSemester, "Semester tidak lebih dari 9");
            }

        }

        private void tbThnAkademik_TextChanged(object sender, EventArgs e)
        {
            if (tbThnAkademik.Text == "")
            {
                epWarning.SetError(tbThnAkademik, "tahun Akaemik tidak boleh kosong!");
                epWrong.SetError(tbThnAkademik, "");
                epCorrect.SetError(tbThnAkademik, "");
            }
            else
            {
                if (Regex.IsMatch(tbThnAkademik.Text, @"^\d{4}-\d{4}$"))
                {
                    epWarning.SetError(tbThnAkademik, "");
                    epWrong.SetError(tbThnAkademik, "");
                    epCorrect.SetError(tbThnAkademik, "Benul!");
                }
                else
                {
                    epWrong.SetError(tbThnAkademik, "Format Tahun salah!\nContoh: ***/*** ");
                    epWarning.SetError(tbThnAkademik, "");
                    epCorrect.SetError(tbThnAkademik, "");
                }

            }
        }





        private void Kurik2006(object sender, EventArgs e)
        {
            if (kurikulum2006.Checked)
            {
                mataMatematika.Enabled = true; mataMatematika.Checked = true;
                mataPemrog1.Enabled = true; mataPemrog1.Checked = false;
                mataPemrog2.Enabled = true; mataPemrog2.Checked = false;
                mataPemrog3.Enabled = true; mataPemrog3.Checked = false;
                mataPemrog4.Enabled = true; mataPemrog4.Checked = false;
                mataFisika.Enabled = true; mataPenAgama.Checked = false;
                mataPenKewarganegaraan.Enabled = true; mataPenKewarganegaraan.Checked = false;
                mataPengantarL.Enabled = false; mataPengantarL.Checked = false;
                mataPenKewarganegaraan.Enabled = true; mataPenKewarganegaraan.Checked = false;
                matajaringanK.Enabled = true; matajaringanK.Checked = false;
                mataSistemO.Enabled = true; mataSistemO.Checked = false;
                mataManagement.Enabled = false; mataManagement.Checked = false;
            }

        }

        private void kurikulum2013_CheckedChanged(object sender, EventArgs e)
        {
            if (kurikulum2013.Checked)
            {
                mataMatematika.Enabled = true; mataMatematika.Checked = true;
                mataPemrog1.Enabled = true; mataPemrog1.Checked = false;
                mataPemrog2.Enabled = true; mataPemrog2.Checked = false;
                mataPemrog3.Enabled = true; mataPemrog3.Checked = false;
                mataPemrog4.Enabled = true; mataPemrog4.Checked = false;
                mataFisika.Enabled = false; mataPenAgama.Checked = false;;
                mataPengantarL.Enabled = true; mataPengantarL.Checked = false;
                mataPenKewarganegaraan.Enabled = false; mataPenKewarganegaraan.Checked = false;
                matajaringanK.Enabled = true; matajaringanK.Checked = false;
                mataSistemO.Enabled = true; mataSistemO.Checked = false;
                mataManagement.Enabled = true; mataManagement.Checked = false;
            }
        }

        private void kurikulumMerdeka_CheckedChanged(object sender, EventArgs e)
        {
            if (kurikulumMerdeka.Checked)
            {
                mataMatematika.Enabled = false; mataMatematika.Checked = false;
                mataPemrog1.Enabled = true; mataPemrog1.Checked = false;
                mataPemrog2.Enabled = true; mataPemrog2.Checked = false;
                mataPemrog3.Enabled = true; mataPemrog3.Checked = false;
                mataPemrog3.Enabled = true; mataPemrog3.Checked = false;
                mataFisika.Enabled = false; mataPenAgama.Checked = false;
                mataPenKewarganegaraan.Enabled = true; mataPenKewarganegaraan.Checked = false;
                mataPengantarL.Enabled = false; mataPengantarL.Checked = false;
                matajaringanK.Enabled = true; matajaringanK.Checked = false;
                mataSistemO.Enabled = true; mataSistemO.Checked = false;
                mataManagement.Enabled = true; mataManagement.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string matakuliahaja = "";
                string kurikulumaja = "";

                if (mataMatematika.Checked)
                {
                    matakuliahaja += "Matematika, ";
                }
                if (mataPemrog1.Checked)
                {
                    matakuliahaja += "Pemograman 1, ";
                }
                if (mataPemrog2.Checked)
                {
                    matakuliahaja += "Pemograman 2, ";
                }
                if (mataPemrog3.Checked)
                {
                    matakuliahaja += "Pemograman 3, ";
                }
                if (mataPemrog4.Checked)
                {
                    matakuliahaja += "Pemograman 4, ";
                }
                if (mataFisika.Checked)
                {
                    matakuliahaja += "Fisika, ";
                }
                if (mataPenAgama.Checked)
                {
                    matakuliahaja += "Agama, ";
                }
                if (mataPenKewarganegaraan.Checked)
                {
                    matakuliahaja += "Pendidikan Kewarganegaraan, ";
                }
                if (mataPengantarL.Checked)
                {
                    matakuliahaja += "Pengantar Logistik, ";
                }
                if (matajaringanK.Checked)
                {
                    matakuliahaja += "Jaringan Komputer, ";
                }
                if (mataSistemO.Checked)
                {
                    matakuliahaja += "Sistem Operasi, ";
                }
                if (mataManagement.Checked)
                {
                    matakuliahaja += "Manajemen Rantai Pasok, ";
                }

                if (!string.IsNullOrEmpty(matakuliahaja))
                {
                    matakuliahaja = matakuliahaja.TrimEnd(' ', ',');
                }

                if (kurikulum2006.Checked)
                {
                    kurikulumaja = "Kurikulum 2006";
                }
                else if (kurikulum2013.Checked)
                {
                    kurikulumaja = "Kurikulum 2013";
                }
                else if (kurikulumMerdeka.Checked)
                {
                    kurikulumaja = "Kurikulum Merdeka";
                }

                if (!string.IsNullOrEmpty(kurikulumaja))
                {
                    kurikulumaja = kurikulumaja.TrimEnd(' ', ',');
                }

                MessageBox.Show("NIM: " + tbNIM.Text +
                    "\nNama: " + tbNama.Text +
                    "\nJenis Kelamin: " + (rbLaki.Checked ? "Laki-laki" : "Perempuan") +
                    "\nAlamat: " + miAlamat.Text +
                    "\nProgram Studi: " + cbPROGRAMSTUDI.Text +
                    "\nSemester: " + tbSemester.Text +
                    "\nTahun Akademik: " + tbThnAkademik.Text +
                    "\nKurikulum: " + kurikulumaja +
                    "\nMatakuliah: " + matakuliahaja,
                    "Informasi Mahasiswa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            {
                foreach (Control control in Controls)
                {
                    ClearControl(control);
                }

                this.Size = new Size(765, 322);
            }
        }
            private void ClearControlsInGroupBox(GroupBox groupBox)
            {
            MessageBox.Show("Form Telah Direset", "Informasi", MessageBoxButtons.OK);

            foreach (Control groupControl in groupBox.Controls)
                {
                    ClearControl(groupControl);
                }
            }

        private void ClearControl(Control control)
        {
            if (control is System.Windows.Forms.TextBox textBox)
            {
                textBox.Text = string.Empty;
            }
            else if (control is RadioButton radioButton)
            {
                radioButton.Checked = false;
            }
            else if (control is CheckBox checkBox)
            {
                checkBox.Checked = false;
            }
            else if (control is System.Windows.Forms.ComboBox comboBox)
            {
                comboBox.SelectedIndex = -1;
            }
            else if (control is GroupBox groupBox)
            {
                ClearControlsInGroupBox(groupBox);
            }
           
        }



    }
}
        
    


