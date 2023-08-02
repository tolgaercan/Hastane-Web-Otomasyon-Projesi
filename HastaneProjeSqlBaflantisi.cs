using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Proje2
{
    class HastaneProjeSqlBaflantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-Q90HJ59;Initial Catalog=HastaneProje2;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
