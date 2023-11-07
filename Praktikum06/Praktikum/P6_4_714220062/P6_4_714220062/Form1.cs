using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_4_714220062
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBerat_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBerat.Text))
            {
                WpWarning.SetError(txtBerat, "Text Box tidak boleh kosong");
                WpWrong.SetError(txtBerat, "");
                WpCorrect.SetError(txtBerat, "");
            }
            else
            {
                if (decimal.TryParse(txtBerat.Text, out decimal berat))
                {
                    txtBerat.Text = berat.ToString("#,#0"); // Mengatur nilai teks ke dalam TextBox yang sudah diformat
                    WpWarning.SetError(txtBerat, "");
                    WpWrong.SetError(txtBerat, "");
                    WpCorrect.SetError(txtBerat, "Format angka benar");
                }
                else
                {
                    WpWarning.SetError(txtBerat, "Format angka salah\nContoh: 5,5");
                    WpWrong.SetError(txtBerat, "");
                    WpCorrect.SetError(txtBerat, "");
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nama: " + txtNama.Text + "\nTinggi: " + txtTinggi.Text + "\nBerat: " + txtBerat.Text + "\nEmail: " + txtEmail.Text + "\nUmur: " + txtAngka.Text + "\nNo. KTP: " + txtAngka2.Text, "Output bdo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAngka2_Leave(object sender, EventArgs e)
        {
            if ((txtAngka2.Text).All(Char.IsNumber))
            {
                WpWarning.SetError(txtAngka2, "");
                WpWrong.SetError(txtAngka2, "");
                WpCorrect.SetError(txtAngka2, "Benul");
            }
            else
            {
                WpWarning.SetError(txtAngka2, "");
                WpWrong.SetError(txtAngka2, "Salah");
                WpCorrect.SetError(txtAngka2, "");
            }

            if ((txtAngka2.Text == ""))
            {
                WpWarning.SetError(txtAngka2, "Text Box tidak boleh kosong");
                WpWrong.SetError(txtAngka2, "");
                WpCorrect.SetError(txtAngka2, "");
            }
        }

        private void txtAngka_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAngka.Text))
            {
                WpWarning.SetError(txtAngka, "Text Box tidak boleh kosong");
                WpWrong.SetError(txtAngka, "");
                WpCorrect.SetError(txtAngka, "");
            }
            else
            {
                if (txtAngka.Text.Length == 2 && txtAngka.Text.All(char.IsDigit))
                {
                    WpWarning.SetError(txtAngka, "");
                    WpWrong.SetError(txtAngka, "");
                    WpCorrect.SetError(txtAngka, "Benerr");
                }
                else
                {
                    WpWarning.SetError(txtAngka, "");
                    WpWrong.SetError(txtAngka, "Salah");
                    WpCorrect.SetError(txtAngka, "");
                }
            }
        }

        private void txtNama_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                WpWarning.SetError(txtNama, "Text box huruf tidak boleh kosong");
                WpWrong.SetError(txtNama, "");
                WpCorrect.SetError(txtNama, "");
            }
            else
            {
                bool isValid = true;
                string inputText = txtNama.Text;


                if (!char.IsUpper(inputText[0]))
                {
                    WpWrong.SetError(txtNama, "Huruf pertama harus besar");
                    WpWarning.SetError(txtNama, "");
                    WpCorrect.SetError(txtNama, "");
                    isValid = false;
                }


                for (int i = 1; i < inputText.Length; i++)
                {
                    if (!char.IsLetter(inputText[i]) && inputText[i] != ' ')
                    {
                        WpWrong.SetError(txtNama, "Inputan hanya boleh berisi huruf dan spasi dengan huruf pertama besar");
                        WpWarning.SetError(txtNama, "");
                        WpCorrect.SetError(txtNama, "");
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    WpWrong.SetError(txtNama, "");
                    WpWarning.SetError(txtNama, "");
                    WpCorrect.SetError(txtNama, "Betul!");
                }
            }

        }

        private void txtTinggi_Leave(object sender, EventArgs e)
        {
            if (txtTinggi.Text == "")
            {
                WpWarning.SetError(txtTinggi, "Text Box tidak boleh kosong");
                WpWrong.SetError(txtTinggi, "");
                WpCorrect.SetError(txtTinggi, "");
            }
            else
            {
                if ((txtTinggi.Text).All(Char.IsNumber))
                {
                    WpWarning.SetError(txtTinggi, "");
                    WpWrong.SetError(txtTinggi, "");
                    WpCorrect.SetError(txtTinggi, "Benerr");
                }
                else
                {
                    WpWarning.SetError(txtTinggi, "");
                    WpWrong.SetError(txtTinggi, "Inputan Hanya boleh angka");
                    WpCorrect.SetError(txtTinggi, "");
                }
            }
        }

        private void txtBerat_Leave(object sender, EventArgs e)
        {

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                WpWarning.SetError(txtEmail, "Textbox Email tidak boleh kosong!");
                WpWrong.SetError(txtEmail, "");
                WpCorrect.SetError(txtEmail, "");
            }
            else
            {
                if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    WpWarning.SetError(txtEmail, "");
                    WpWrong.SetError(txtEmail, "");
                    WpCorrect.SetError(txtEmail, "Betul!");
                }
                else
                {
                    WpWrong.SetError(txtEmail, "Format email salah!\nContoh: a@b.c");
                    WpWarning.SetError(txtEmail, "");
                    WpCorrect.SetError(txtEmail, "");
                }
            }
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHarusBesar_Leave(object sender, EventArgs e)
        {
           

        }

        private void txtBesar_TextChanged(object sender, EventArgs e)
        {
            if (txtBesar.Text == "")
            {
                WpWarning.SetError(txtBesar, "Huruf tidak boleh kosong!");
                WpWrong.SetError(txtBesar, "");
                WpCorrect.SetError(txtBesar, "");
            }
            else
            {
                if ((txtBesar.Text).All(Char.IsUpper))
                {
                    WpWarning.SetError(txtBesar, "");
                    WpWrong.SetError(txtBesar, "");
                    WpCorrect.SetError(txtBesar, "Benul");
                }
                else if ((txtBesar.Text).Any(Char.IsLower))
                {
                    WpWarning.SetError(txtBesar, "");
                    WpWrong.SetError(txtBesar, "Harus Pakai huruf Besar!");
                    WpCorrect.SetError(txtBesar, "");
                }
            }
        }

        private void txtKecil_TextChanged(object sender, EventArgs e)
        {
            if (txtKecil.Text == "")
            {
                WpWarning.SetError(txtKecil, "Huruf tidak boleh kosong!");
                WpWrong.SetError(txtKecil, "");
                WpCorrect.SetError(txtKecil, "");
            }
            else
            {
                if ((txtKecil.Text).Any(Char.IsUpper))
                {
                    WpWarning.SetError(txtKecil, "");
                    WpWrong.SetError(txtKecil, "Tidak boleh menggunakan huruf kapital!");
                    WpCorrect.SetError(txtKecil, "");
                }
                else if ((txtKecil.Text).All(Char.IsLower))
                {
                    WpWarning.SetError(txtKecil, "");
                    WpWrong.SetError(txtKecil, "");
                    WpCorrect.SetError(txtKecil, "Benul");
                }
            }
        }
    }
   
}







