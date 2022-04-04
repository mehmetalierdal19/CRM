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
    public partial class Tedarikciler : Form
    {
        baglanti bgl = new baglanti();
        public Tedarikciler()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert Into TBLTEDARIKCI (TedarikciAd, Yetkili, Eposta, Telefon, Adres, VergiDairesi, VergiNo, ParaBirimi, Aciklama) values (@TEDARIKCI, @YETKILI, @POSTA, @TEL, @ADRES, @DAİRE, @VNO, @PARA, @ACIKLAMA)", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@TEDARIKCI", SqlDbType.NVarChar).Value = txtTedarikci.Text;
            komut.Parameters.AddWithValue("@YETKILI", SqlDbType.NVarChar).Value = txtYetkili.Text;
            komut.Parameters.AddWithValue("@POSTA", SqlDbType.NVarChar).Value = txtEposta.Text;
            komut.Parameters.AddWithValue("@TEL", SqlDbType.NVarChar).Value = txtTel.Text;
            komut.Parameters.AddWithValue("@ADRES", SqlDbType.NVarChar).Value = txtAdres.Text;
            komut.Parameters.AddWithValue("@DAİRE", SqlDbType.NVarChar).Value = txtDaire.Text;
            komut.Parameters.AddWithValue("@VNO", SqlDbType.NVarChar).Value = txtVergino.Text;
            komut.Parameters.AddWithValue("@PARA", SqlDbType.NVarChar).Value = cbPara.Text;
            komut.Parameters.AddWithValue("@ACIKLAMA", SqlDbType.NVarChar).Value = txtAciklama.Text;
            komut.ExecuteNonQuery();
        }
    }
}
