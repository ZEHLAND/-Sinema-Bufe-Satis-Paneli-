using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        int kasaToplam= 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, cay, bilet,toplam;
            misir = Convert.ToInt16(Textmisir.Text);
            su = Convert.ToInt16(Textsu.Text);
            cay = Convert.ToInt16(Textcay.Text);
            bilet = Convert.ToInt16(Textbilet.Text);
            toplam = misir * 4 + su * 1 + cay * 4 + bilet * 8;
            Texttoplam.Text = toplam.ToString()+"$";
            kasaToplam = kasaToplam + toplam;
            Textkasa.Text= kasaToplam.ToString()+"$";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Textmisir.Text = "";
            Textsu.Text = "";
            Textcay.Text = "";
            Textbilet.Text = "";
            Texttoplam.Text = "";
            Textmisir.Focus();
        }
    }
}
