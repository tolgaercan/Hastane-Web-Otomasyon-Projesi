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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string TCno;
        HastaneProjeSqlBaflantisi bgl = new HastaneProjeSqlBaflantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            //ad soyad verisi çekme
            lbltc.Text = TCno;
            SqlCommand komut = new SqlCommand("select SekreterAdSoyad from Tbl_Sekreterler where SekreterTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0].ToString();
            }

            dr.Close();
            bgl.baglanti().Close();



            // Data Grid branş verisi çekme

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select BransAd from Tbl_Branslar", bgl.baglanti());
            da1.Fill(dt1);
            dgrdwbranslar.DataSource = dt1;

            //data grid doktor verisi çekme
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select  (DoktorAd+' '+DoktorSoyad) as 'Doktorlar',DoktorBrans from Tbl_Doktorlar ", bgl.baglanti());
            da2.Fill(dt2);
            dgrdwdoktorlar.DataSource = dt2;

            //cmbx branş ismi çekme
            cmbdoktor.Items.Clear();
            SqlCommand komutbrans = new SqlCommand("select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr4 = komutbrans.ExecuteReader();
            while (dr4.Read())
            {
                cmbbrans.Items.Add(dr4[0]);
            }
            bgl.baglanti().Close();



        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular(RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@p1,@p2,@p3,@p4)",bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", msktxttarih.Text);
            komutkaydet.Parameters.AddWithValue("@p2", msktxtsaat.Text);
            komutkaydet.Parameters.AddWithValue("@p3", cmbbrans.Text);
            komutkaydet.Parameters.AddWithValue("@p4", cmbdoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu.");

        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
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

        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnduyuruolustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular(Duyuru) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",rchtxtduyurular.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu.");
        }

        private void btndoktorpaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli fr = new FrmDoktorPaneli();
            fr.Show();
            
        }

        private void btnbranspaneli_Click(object sender, EventArgs e)
        {
            FrmBrans fr = new FrmBrans();
            fr.Show();
            
        }

        private void btnrandevulistesi_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi fr = new FrmRandevuListesi();
            fr.Show();
            
        }

        private void dgrdwdoktorlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAnaGiris fr = new FrmAnaGiris();
            fr.Show();
            this.Hide();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dgrdwbranslar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

