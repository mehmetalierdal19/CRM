using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CRM
{
    public class baglanti
    {
        public SqlConnection sqlbaglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source =DESKTOP-7EGS3RS\SQLEXPRESS; Initial Catalog=dbCRM; Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
