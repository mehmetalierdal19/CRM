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
    public partial class Müşteriler : Form
    {
        baglanti bgl = new baglanti();
        public Müşteriler()
        {
            InitializeComponent();
        }

        private void Müşteriler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbCRMDataSet.TBLMUSTERILER' table. You can move, or remove it, as needed.
            this.tBLMUSTERILERTableAdapter.Fill(this.dbCRMDataSet.TBLMUSTERILER);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert INTO TBLMUSTERILER (MUSTERIAD, MUSTERISOYAD, SEHIR, ILETISIMNO) VALUES (@AD, @SOYAD, @SEHIR, @ILETISIMNO)", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@AD", SqlDbType.NVarChar).Value = txtAd.Text;
            komut.Parameters.AddWithValue("@SOYAD", SqlDbType.NVarChar).Value = txtSoyad.Text;
            komut.Parameters.AddWithValue("@SEHIR", SqlDbType.NVarChar).Value = txtSehir.Text;
            komut.Parameters.AddWithValue("@ILETISIMNO", SqlDbType.NVarChar).Value = txtTel.Text;
            komut.ExecuteNonQuery();
            this.tBLMUSTERILERTableAdapter.Fill(this.dbCRMDataSet.TBLMUSTERILER);
        }
    }
}
