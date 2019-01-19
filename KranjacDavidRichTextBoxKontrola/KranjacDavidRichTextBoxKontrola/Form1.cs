using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KranjacDavidRichTextBoxKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(@"C:\Users\David\Documents\TempProba.rtf");
            MessageBox.Show("Tekst spremljen");
        }

        private void btnCitaj_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(@"C:\Users\David\Documents\TempProba.rtf");
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
