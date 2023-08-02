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
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }
        HastaneProjeSqlBaflantisi bgl = new HastaneProjeSqlBaflantisi();

        private void FrmBrans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from Tbl_Branslar",bgl.baglanti());
            da.Fill(dt);
            dgrdvbranspaneli.DataSource = dt;

            
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Branslar (BransAd) values (@p1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtbransad.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Barnş Kaydı Başarıyla Oluşturuldu.");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Branslar where Bransİd=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtbransid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgrdvbranspaneli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgrdvbranspaneli.SelectedCells[0].RowIndex;
            txtbransid.Text = dgrdvbranspaneli.Rows[secilen].Cells[0].Value.ToString();
            txtbransad.Text = dgrdvbranspaneli.Rows[secilen].Cells[1].Value.ToString();
            
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Branslar set BransAd=@p1 where Bransİd=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtbransad.Text);
            komut.Parameters.AddWithValue("@p2",txtbransid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarıyla Güncellendi.");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmBrans fr = new FrmBrans();
            fr.Show();
            this.Hide();
        }
    }
}
