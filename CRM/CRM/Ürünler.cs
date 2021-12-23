using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CRM
{
    public partial class Ürünler : Form
    {
        baglanti bgl = new baglanti();
        public Ürünler()
        {
            InitializeComponent();
        }

        private void Ürünler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbCRMDataSet1.TBLURUNLER' table. You can move, or remove it, as needed.
            this.tBLURUNLERTableAdapter.Fill(this.dbCRMDataSet1.TBLURUNLER);

        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert INTO TBLURUNLER (UrunKategori, UrunAd, Marka, SatisFiyati, Depo) VALUES (@URUNKATEGORI, @URUNAD, @MARKA, @SATISFIYATI, @DEPO)", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@URUNKATEGORI", SqlDbType.Int).Value =Convert.ToInt32(cbKategori.Text);
            komut.Parameters.AddWithValue("@URUNAD", SqlDbType.NVarChar).Value = txtUrunAd.Text;
            komut.Parameters.AddWithValue("@MARKA", SqlDbType.Int).Value =Convert.ToInt32(cbMarka.Text);
            komut.Parameters.AddWithValue("@SATISFIYATI", SqlDbType.Int).Value = Convert.ToInt32(txtSatisFiyat.Text);
            komut.Parameters.AddWithValue("@DEPO", SqlDbType.Int).Value = Convert.ToInt32(cbDepo.Text);
            komut.ExecuteNonQuery();
            this.tBLURUNLERTableAdapter.Fill(this.dbCRMDataSet1.TBLURUNLER);
        }
    }
}
