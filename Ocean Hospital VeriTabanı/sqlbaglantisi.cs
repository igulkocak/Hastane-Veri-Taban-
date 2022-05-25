using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ocean_Hospital_VeriTabanı
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-M9GAS1M\\MSSQLSERVER01;Initial Catalog=Ocean;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
