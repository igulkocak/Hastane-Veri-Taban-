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
    public partial class Hasta_Bilgi_Güncelleme : Form
    {
        public Hasta_Bilgi_Güncelleme()
        {
            InitializeComponent();
        }
        public string TCno;

        sqlbaglantisi bgl=new sqlbaglantisi();
        private void Hasta_Bilgi_Güncelleme_Load(object sender, EventArgs e)
        {
            msktc.Text =TCno;
            SqlCommand komut = new SqlCommand("Select * from tbl_hastalar where hasta_tc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            SqlDataReader dr=komut.ExecuteReader();
            while(dr.Read())
            {
                ad.Text=dr[1].ToString();
                soyad.Text=dr[2].ToString();
                mskcep.Text=dr[4].ToString();
                parola.Text=dr[5].ToString();
                cinsiyet.Text=dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update tbl_hastalar set hasta_ad=@p1,hasta_soyad=@p2,hasta_cep=@p3,hasta_parola=@p4,hasta_cinsiyet=@p5 where hasta_tc=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", ad.Text);
            komut2.Parameters.AddWithValue("@p2", soyad.Text);
            komut2.Parameters.AddWithValue("@p3", mskcep.Text);
            komut2.Parameters.AddWithValue("@p4", parola.Text);
            komut2.Parameters.AddWithValue("@p5", cinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", msktc.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
