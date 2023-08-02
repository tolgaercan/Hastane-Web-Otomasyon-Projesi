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
namespace Hastane_Proje2
{
    public partial class FrmDoktorBilgiDüzenle : Form
    {
        public FrmDoktorBilgiDüzenle()
        {
            InitializeComponent();
        }
        HastaneProjeSqlBaflantisi bgl = new HastaneProjeSqlBaflantisi();
        public string tc1;
        private void FrmDoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            msktc.Text = tc1;
            SqlCommand komut=new SqlCommand("SELECT * FROM Tbl_Doktorlar WHERE DoktorTc = @p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",msktc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
               txtdoktorad.Text = dr[1].ToString();
               txtdoktorsoyad.Text = dr[2].ToString();
               msktc.Text = dr[4].ToString();
               txtsifre.Text = dr[5].ToString();
                
            }
            bgl.baglanti().Close();
        }

        private void btnbilgiguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorSifre=@p4 where DoktorTc=@p3",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtdoktorad.Text);
            komut.Parameters.AddWithValue("@p2", txtdoktorsoyad.Text);
            komut.Parameters.AddWithValue("@p3",msktc.Text);
            komut.Parameters.AddWithValue("@p4", txtsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarıyla Güncellendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
