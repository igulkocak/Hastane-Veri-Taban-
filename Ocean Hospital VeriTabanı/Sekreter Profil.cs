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
    public partial class Sekreter_Profil : Form
    {
        public Sekreter_Profil()
        {
            InitializeComponent();
        }
        public string TCnumara;
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void Sekreter_Profil_Load(object sender, EventArgs e)
        {
            //TC'yi Çekme
            tcy.Text = TCnumara;

            //Ad ve Soyad'ı Çekme
            SqlCommand komut1 = new SqlCommand("Select sekreter_adsoyad from sekreterler where sekreter_tc=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",tcy.Text);
            SqlDataReader dr1=komut1.ExecuteReader();
            while(dr1.Read())
            {
                adsoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            //Branşları Datagrid'e Aktarma
            DataTable dt1=new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from branslartable", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktor Bilgilerini Aktarma
            DataTable dt2=new DataTable();
            SqlDataAdapter da2=new SqlDataAdapter("Select (doktor_ad + ' ' + doktor_soyad) as 'Doktorlar',doktor_brans from doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branşı Combobox'a Aktarma
            SqlCommand komut2 = new SqlCommand("Select brans_ad from branslartable", bgl.baglanti());
            SqlDataReader dr2=komut2.ExecuteReader();
            while( dr2.Read())
            {
                brans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Randevular (randevu_tarih,randevu_saat,randevu_brans,randevu_doktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1",tarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", saat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", brans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", doktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Listeye Eklendi");


        }

        private void brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            doktor.Items.Clear();

            SqlCommand komut = new SqlCommand("Select doktor_ad,doktor_soyad from doktorlar where doktor_brans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", brans.Text);
            SqlDataReader dr=komut.ExecuteReader();
            while(dr.Read())
            {
                doktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into duyurular (duyuru_metni) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", duyurumetni.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Panoya Eklendi");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Doktor_Paneli drp=new Doktor_Paneli();
            drp.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Branş_Paneli brns=new Branş_Paneli();
            brns.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Randevu_Listesi randevu_Listesi = new Randevu_Listesi();
            randevu_Listesi.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
