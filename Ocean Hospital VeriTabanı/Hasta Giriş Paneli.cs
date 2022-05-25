using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ocean_Hospital_VeriTabanı
{
    public partial class Hasta_Giriş_Paneli : Form
    {
        public Hasta_Giriş_Paneli()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from tbl_hastalar where hasta_tc=@p3 and hasta_parola=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p3", tc.Text);
            komut.Parameters.AddWithValue("@p5", parola.Text);
            SqlDataReader dr= komut.ExecuteReader();
            if (dr.Read())
            {
                Hasta_Profil fr = new Hasta_Profil();
                fr.tc = tc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre");
            }
            bgl.baglanti().Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hasta_Üye_Kayıt fr=new Hasta_Üye_Kayıt();
            fr.Show();          
        }

        private void Hasta_Giriş_Paneli_Load(object sender, EventArgs e)
        {

        }
    }
}
