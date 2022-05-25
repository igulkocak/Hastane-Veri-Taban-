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
    public partial class Hasta_Profil : Form
    {
        public Hasta_Profil()
        {
            InitializeComponent();
        }
        public string tc;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Hasta_Profil_Load(object sender, EventArgs e)
        {
            tcno.Text = tc;

            //A Soyad Çekme
            SqlCommand komut = new SqlCommand("select hasta_ad,hasta_soyad from tbl_hastalar where hasta_tc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", adsoyad.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
               adsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            // Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Randevular where hasta_tc=" + tc, bgl.baglanti()); da.Fill(dt);
            dataGridView2.DataSource = dt;

            // Branşları Çekme
            SqlCommand komut2 = new SqlCommand("Select brans_ad from branslartable", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                branscombobox.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void branscombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            doktorcombobox.Items.Clear();

            SqlCommand komut3 = new SqlCommand("select doktor_ad,doktor_soyad from doktorlar where doktor_brans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", branscombobox.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                doktorcombobox.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();

        }

        private void doktorcomboox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Randevular where randevu_brans= '" + branscombobox.Text + "'", bgl.baglanti()); 
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hasta_Bilgi_Güncelleme fr = new Hasta_Bilgi_Güncelleme();
            fr.TCno = tcno.Text;
            fr.Show();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            idtextbox.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void randevuolustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Randevular set randevu_durum=1,hasta_tc=@p1,hasta_sikayet=@p2 where randevu_id=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tcno.Text);
            komut.Parameters.AddWithValue("@p2", sikayetrichbox.Text);
            komut.Parameters.AddWithValue("@p3", idtextbox.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


    }
}