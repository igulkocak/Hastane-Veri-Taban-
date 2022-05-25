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
    public partial class Doktor_Profil : Form
    {
        public Doktor_Profil()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        public string TC;
              private void Doktor_Profil_Load(object sender, EventArgs e)
        {
            tclb.Text = TC;

            //Ad Soyad
          SqlCommand komut=new SqlCommand("select doktor_ad,doktor_soyad from doktorlar where doktor_tc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tclb.Text);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                adsoyad.Text = dr[0] + "  " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Randevular where randevu_doktor='" + adsoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        } 
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
