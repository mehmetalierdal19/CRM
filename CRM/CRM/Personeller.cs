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
    public partial class Personeller : Form
    {
        baglanti bgl = new baglanti();
        public Personeller()
        {
            InitializeComponent();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            // Personel Ekleme
            SqlCommand komut = new SqlCommand("Insert Into TBLPERSONEL (PersonelAd, Pozisyon, PersonelTelNo, PersonelAdres, PersonelEposta) values (@AD, @POZİSYON, @TEL, @ADRES, @EPOSTA)", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@AD", SqlDbType.NVarChar).Value = txtPersonelAd.Text;
            komut.Parameters.AddWithValue("@POZİSYON", SqlDbType.NVarChar).Value = txtPozisyon.Text;
            komut.Parameters.AddWithValue("@TEL", SqlDbType.NVarChar).Value = mtxtTelNo.Text;
            komut.Parameters.AddWithValue("@ADRES", SqlDbType.NVarChar).Value = txtAdres.Text;
            komut.Parameters.AddWithValue("@EPOSTA", SqlDbType.NVarChar).Value = txtEposta.Text;
            komut.ExecuteNonQuery();
        }
    }
}
