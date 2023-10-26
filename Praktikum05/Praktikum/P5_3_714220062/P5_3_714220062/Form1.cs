using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_3_714220062
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNTampilan_Click(object sender, EventArgs e)
        {
            string os = "";
            string status = "";
            if (RB_Android.Checked== true)
            {
                os = "Android"; 
            } else if (RB_IOS.Checked== true)

            {
                os = "IOS";
            }
            if (CBYA.Checked == true)
            {
                status = "Ya,Sudah diperbaiki";
            }
            MessageBox.Show(
                "Merk HP:" + TXTMerkHp +"\nsystem operasi: " + os + "\nstatus perbaikan:" + status, "informasi service hp",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BTNKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
