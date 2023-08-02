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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        //hasta ad soyad-tc çekme------------------------
        
        public string tc;
        HastaneProjeSqlBaflantisi bgl = new HastaneProjeSqlBaflantisi();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tc;
            SqlCommand komut = new SqlCommand("select HastaAd,HastaSoyad from Tbl_Hastalar where HastaTc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();
            // randevu geçmişi öekme------------------------------
            //data gridde bağlantı aç kapaya gerek yok.
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where HastaTc="+tc,bgl.baglanti());
            da.Fill(dt);
            dgrdwrandevugecmisi.DataSource = dt;

            //branşları çekme
            SqlCommand komut2 = new SqlCommand("select BransAd from Tbl_Branslar ",bgl.baglanti());
            SqlDataReader dr2 =komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            //aktif randevuları çekme
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select*from Tbl_Randevular where RandevuDurum='1'and HastaTc=@p1 ", bgl.baglanti());
            da1.SelectCommand.Parameters.AddWithValue("@p1",lbltc.Text);
            da1.Fill(dt1);
            dgrdwaktifrandevular.DataSource = dt1;
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbdoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();

        }

        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Tbl_Randevular where RandevuBrans='"+ cmbbrans.Text +"'"+"and RandevuDoktor='"+cmbdoktor.Text+"'and RandevuDurum=0", bgl.baglanti());
            da2.Fill(dt2);
            dgrdwaktifrandevular.DataSource = dt2;
        }
        public string TCno;
        private void linklblbilgidüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaBilgiGüncelle fr = new FrmHastaBilgiGüncelle();
            fr.TCno = lbltc.Text;
            fr.Show();

        }

        private void dgrdwaktifrandevular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgrdwaktifrandevular.SelectedCells[0].RowIndex;
            txtid.Text = dgrdwaktifrandevular.Rows[secilen].Cells[0].Value.ToString();
            msktxttarih.Text = dgrdwaktifrandevular.Rows[secilen].Cells[1].Value.ToString();
            msktxtsaat.Text = dgrdwaktifrandevular.Rows[secilen].Cells[2].Value.ToString();
            cmbbrans.Text = dgrdwaktifrandevular.Rows[secilen].Cells[3].Value.ToString();
            cmbdoktor.Text = dgrdwaktifrandevular.Rows[secilen].Cells[4].Value.ToString();
            radioButton1.Text = dgrdwaktifrandevular.Rows[secilen].Cells[5].Value.ToString();
            rtxtsikayet.Text = dgrdwaktifrandevular.Rows[secilen].Cells[7].Value.ToString();


        }

        private void btnrandevual_Click(object sender, EventArgs e)
        {
            bool radioButton1Value = radioButton1.Checked;
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular(RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,RandevuDurum,HastaTc,HastaSikayet) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", msktxttarih.Text);
            komutkaydet.Parameters.AddWithValue("@p2", msktxtsaat.Text);
            komutkaydet.Parameters.AddWithValue("@p3", cmbbrans.Text);
            komutkaydet.Parameters.AddWithValue("@p4", cmbdoktor.Text);
            komutkaydet.Parameters.AddWithValue("@p5",radioButton1Value);
            komutkaydet.Parameters.AddWithValue("@p6",lbltc.Text);
            komutkaydet.Parameters.AddWithValue("@p7",rtxtsikayet.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu.");
        }

      

        private void cmbdoktor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void dgrdwaktifrandevular_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbbrans_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            //cmbx a doktor ismi çekme
            SqlCommand komutdoktor = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komutdoktor.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr5 = komutdoktor.ExecuteReader();
            while (dr5.Read())
            {
                cmbdoktor.Items.Add(dr5[0] + " " + dr5[1]);
            }
            bgl.baglanti().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool radioButton1Value = radioButton1.Checked;
            SqlCommand komutkaydet = new SqlCommand("update Tbl_Randevular set RandevuTarih=@p1,RandevuSaat=@p2,RandevuBrans=@p3,RandevuDoktor=@p4,RandevuDurum=@p5,HastaTc=@p6,HastaSikayet=@p7 where RandevuİD=@p8", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", msktxttarih.Text);
            komutkaydet.Parameters.AddWithValue("@p2", msktxtsaat.Text);
            komutkaydet.Parameters.AddWithValue("@p3", cmbbrans.Text);
            komutkaydet.Parameters.AddWithValue("@p4", cmbdoktor.Text);
            komutkaydet.Parameters.AddWithValue("@p5", radioButton1Value);
            komutkaydet.Parameters.AddWithValue("@p6", lbltc.Text);
            komutkaydet.Parameters.AddWithValue("@p7", rtxtsikayet.Text);
            komutkaydet.Parameters.AddWithValue("@p8", txtid.Text);

            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Güncellendi.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmAnaGiris fr = new FrmAnaGiris();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Randevular where RandevuİD=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {
            // Mevcut formun verilerini yeniden yükleme işlemi yapılacak
            // Yani verileri tekrar çekecek ve kontrolleri güncelleyeceğiz.

            // randevu geçmişi öekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where HastaTc=@p1", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", tc);
            da.Fill(dt);
            dgrdwrandevugecmisi.DataSource = dt;

            // aktif randevuları çekme
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Tbl_Randevular where RandevuDurum='1' and HastaTc=@p1", bgl.baglanti());
            da1.SelectCommand.Parameters.AddWithValue("@p1", lbltc.Text);
            da1.Fill(dt1);
            dgrdwaktifrandevular.DataSource = dt1;
        }

    }
}
