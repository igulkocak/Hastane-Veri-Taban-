using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ocean_Hospital_VeriTabanı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhastagirisi_Click(object sender, EventArgs e)
        {
            Hasta_Giriş_Paneli fr= new Hasta_Giriş_Paneli();
            fr.Show();
            this.Hide();
        }

        private void btndoktorgirisi_Click(object sender, EventArgs e)
        {
            Doktor_Giriş_Paneli fr = new Doktor_Giriş_Paneli();
            fr.Show();
            this.Hide();
        }

        private void btnsekretergirisi_Click(object sender, EventArgs e)
        {
            Sekreter_Giriş_Paneli fr = new Sekreter_Giriş_Paneli();
            fr.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
