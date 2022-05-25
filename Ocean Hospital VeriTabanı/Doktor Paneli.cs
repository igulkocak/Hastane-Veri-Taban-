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
    public partial class Doktor_Paneli : Form
    {
        public Doktor_Paneli()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void Doktor_Paneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("insert into doktorlar (doktor_ad,doktor_soyad,doktor_brans,doktor_tc,doktor_sifre) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", ad.Text);
            komut.Parameters.AddWithValue("@d2", soyad.Text);
            komut.Parameters.AddWithValue("@d3", brans.Text);
            komut.Parameters.AddWithValue("@d4", tc.Text);
            komut.Parameters.AddWithValue("@d5", parola.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            brans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            tc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            parola.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Doktor Kaydı Silme
            SqlCommand komut= new SqlCommand("Delete from doktorlar where doktor_tc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",tc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Doktor Bilgileri Güncelleme
            SqlCommand komut = new SqlCommand("Update doktorlar set doktor_ad=@d1,doktor_soyad=@d2,doktor_brans=@d3,doktor_sifre=@d5 where doktor_tc=@d4", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", ad.Text);
            komut.Parameters.AddWithValue("@d2", soyad.Text);
            komut.Parameters.AddWithValue("@d3", brans.Text);
            komut.Parameters.AddWithValue("@d4", tc.Text);
            komut.Parameters.AddWithValue("@d5", parola.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Branşları Combobax'a Aktarma

            SqlCommand komut2 = new SqlCommand("Select brans_ad from branslartable", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                brans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }
    }
}
