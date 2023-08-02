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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public string tc;
        HastaneProjeSqlBaflantisi bgl = new HastaneProjeSqlBaflantisi();
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tc;
         

            //lbladsoyad table ına doktor ismini çekme
            SqlCommand komut = new SqlCommand("select (DoktorAd+' '+DoktorSoyad) as 'doktor' from Tbl_Doktorlar where DoktorTc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
            //datagrid veri çekme
           
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Randevular WHERE RandevuDoktor = @adSoyad", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@adSoyad", lbladsoyad.Text);
            da.Fill(dt);
            dataGridView2.DataSource = dt;

           

        }

        private void lbladsoyad_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //şikayet bilgisi çekme
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            rchsikayet.Text = dataGridView2.Rows[secilen].Cells[7].Value.ToString();
        }
        public string tc1;
        private void btnbilgidüzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDüzenle fr = new FrmDoktorBilgiDüzenle();
            fr.tc1 = lbltc.Text;
            fr.Show();
        }

        private void btnduyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            FrmAnaGiris fr = new FrmAnaGiris();
            fr.Show();
            this.Hide();
        }
    }
}
