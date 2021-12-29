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

namespace CRM
{
    public partial class Depolar : Form
    {
        baglanti bgl = new baglanti();
        public Depolar()
        {
            InitializeComponent();
        }

        private void Depolar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbCRMDataSet4.TBLDEPOLAR' table. You can move, or remove it, as needed.
            this.tBLDEPOLARTableAdapter.Fill(this.dbCRMDataSet4.TBLDEPOLAR);

        }

        private void btnDepoEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO TBLDEPOLAR (DepoAd) VALUES (@DEPOAD) ", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@DEPOAD", SqlDbType.NVarChar).Value = txtDepoAd.Text;
            komut.ExecuteNonQuery();
            this.tBLDEPOLARTableAdapter.Fill(this.dbCRMDataSet4.TBLDEPOLAR);
        }
    }
}
