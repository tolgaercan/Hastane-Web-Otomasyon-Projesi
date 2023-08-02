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
    public partial class FrmHastaBilgiGüncelle : Form
    {
        public FrmHastaBilgiGüncelle()
        {
            InitializeComponent();
        }
        public string TCno;
        HastaneProjeSqlBaflantisi bgl = new HastaneProjeSqlBaflantisi();
        private void FrmHastaBilgiGüncelle_Load(object sender, EventArgs e)
        {
            msktc.Text = TCno;
            SqlCommand komut = new SqlCommand("select * from Tbl_Hastalar where HastaTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txthastaad.Text = dr[1].ToString();
                txthastasoyad.Text = dr[2].ToString();
                msktxttelefon.Text = dr[4].ToString();
                txtsifre.Text = dr[5].ToString();
                cmbhastacinsiyet.Text = dr[6].ToString();
               

            }
            bgl.baglanti().Close();

             
        }

        private void btnbilgiguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTc=@p6",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1",txthastaad.Text);
            komut2.Parameters.AddWithValue("@p2", txthastasoyad.Text);
            komut2.Parameters.AddWithValue("@p3", msktxttelefon.Text);
            komut2.Parameters.AddWithValue("@p4", txtsifre.Text);
            komut2.Parameters.AddWithValue("@p5", cmbhastacinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", msktc.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz  Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
    }
}
