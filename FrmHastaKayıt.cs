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
    public partial class FrmHastaKayıt : Form
    {
        public FrmHastaKayıt()
        {
            InitializeComponent();
        }
        HastaneProjeSqlBaflantisi bgl = new HastaneProjeSqlBaflantisi();
        private void btnkayıtyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTc,HastaTelefon,HastaCinsiyet,HastaSifre) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txthastaad.Text);
            komut.Parameters.AddWithValue("@p2", txthastasoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktc.Text);
            komut.Parameters.AddWithValue("@p4", msktxttelefon.Text);
            komut.Parameters.AddWithValue("@p5", cmbhastacinsiyet.Text);
            komut.Parameters.AddWithValue("p6", txtsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir. Şifreniz:" + txtsifre.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }

        private void FrmHastaKayıt_Load(object sender, EventArgs e)
        {

        }
    }
}
