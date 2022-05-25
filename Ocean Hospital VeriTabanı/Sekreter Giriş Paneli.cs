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
    public partial class Sekreter_Giriş_Paneli : Form
    {
        public Sekreter_Giriş_Paneli()
        {
            InitializeComponent();
        }
         sqlbaglantisi bgl=new sqlbaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("Select * from sekreterler where sekreter_tc=@p1 and sekreter_parola=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tc.Text);
            komut.Parameters.AddWithValue("@p2", parola.Text);
            SqlDataReader dr= komut.ExecuteReader();
            if(dr.Read())
            {
                Sekreter_Profil frs=new Sekreter_Profil();
                frs.TCnumara = tc.Text;
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre");
            }
            bgl.baglanti().Close();
        }
    }
}
