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
    public partial class Doktor_Giriş_Paneli : Form
    {
        public Doktor_Giriş_Paneli()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void Doktor_Giriş_Paneli_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from doktorlar where doktor_tc=@p1 and doktor_sifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tc.Text);
            komut.Parameters.AddWithValue("@p2", parola.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Doktor_Profil fr = new Doktor_Profil();
                fr.TC=tc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC ya da Parola!");
            }
            bgl.baglanti().Close();
        }
    }
}
