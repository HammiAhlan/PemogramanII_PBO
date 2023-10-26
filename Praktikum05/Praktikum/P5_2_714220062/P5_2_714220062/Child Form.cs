using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_2_714220062
{
    public partial class Child_Form : Form
    {
        string outputText;
        public Child_Form()
        {
            InitializeComponent();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OutputLabel.Text = outputText;
        }

        private void DateOption_CheckedChanged(object sender, EventArgs e)
        {
            outputText = DateTime.Now.ToString("d");
        }

        private void TimeOption_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void OutputLabel_Click(object sender, EventArgs e)
        {

        }

        private void TImeOption2_CheckedChanged(object sender, EventArgs e)
        {
            outputText = DateTime.Now.ToString("t");
        }

        private void OutputGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
