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
    public partial class FrmRandevuListesi : Form
    {
        public FrmRandevuListesi()
        {
            InitializeComponent();
        }
        HastaneProjeSqlBaflantisi bgl = new HastaneProjeSqlBaflantisi();
        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,RandevuDurum,HastaTc,HastaSikayet from Tbl_Randevular", bgl.baglanti());
            da.Fill(dt);
            dgrdvRandevuList.DataSource = dt;
            // Verileri DataTable'dan bir DataView nesnesine aktaralım
            DataView dv = dt.DefaultView;

            // "RandevuTarih" sütununa göre verileri sıralayalım (Artan olarak)
            dv.Sort = "RandevuTarih ASC";

            // Sıralanmış verileri DataGridView'a yükleyelim
            dgrdvRandevuList.DataSource = dv;

            //data grid stünları boyutlandıralım
            dgrdvRandevuList.Columns["RandevuTarih"].Width = 125;
            dgrdvRandevuList.Columns["RandevuSaat"].Width = 125;
            dgrdvRandevuList.Columns["RandevuBrans"].Width = 125;
            dgrdvRandevuList.Columns["RandevuDoktor"].Width = 125;
            dgrdvRandevuList.Columns["RandevuDurum"].Width = 125;
            dgrdvRandevuList.Columns["HastaTc"].Width = 125;
            dgrdvRandevuList.Columns["HastaSikayet"].Width = 250;
        }
    }
}
