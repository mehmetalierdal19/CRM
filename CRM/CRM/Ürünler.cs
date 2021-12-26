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
            // TODO: This line of code loads data into the 'dbCRMDataSet10.TBLURUNLER' table. You can move, or remove it, as needed.
            this.tBLURUNLERTableAdapter3.Fill(this.dbCRMDataSet10.TBLURUNLER);
            // TODO: This line of code loads data into the 'dbCRMDataSet9.TBLURUNLER' table. You can move, or remove it, as needed.
            //this.tBLURUNLERTableAdapter2.Fill(this.dbCRMDataSet9.TBLURUNLER);
            // TODO: This line of code loads data into the 'dbCRMDataSet8.TBLDEPOLAR' table. You can move, or remove it, as needed.
            this.tBLDEPOLARTableAdapter.Fill(this.dbCRMDataSet8.TBLDEPOLAR);
            // TODO: This line of code loads data into the 'dbCRMDataSet7.TBLMARKALAR' table. You can move, or remove it, as needed.
            this.tBLMARKALARTableAdapter.Fill(this.dbCRMDataSet7.TBLMARKALAR);
            // TODO: This line of code loads data into the 'dbCRMDataSet6.TBLKATEGORILER' table. You can move, or remove it, as needed.
            this.tBLKATEGORILERTableAdapter.Fill(this.dbCRMDataSet6.TBLKATEGORILER);
            // TODO: This line of code loads data into the 'dbCRMDataSet5.TBLURUNLER' table. You can move, or remove it, as needed.
            //this.tBLURUNLERTableAdapter1.Fill(this.dbCRMDataSet5.TBLURUNLER);
            // TODO: This line of code loads data into the 'dbCRMDataSet1.TBLURUNLER' table. You can move, or remove it, as needed.
            //this.tBLURUNLERTableAdapter.Fill(this.dbCRMDataSet1.TBLURUNLER);

        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert INTO TBLURUNLER (UrunKategori, UrunAd, Marka, SatisFiyati, AlisFiyati, Depo) VALUES (@URUNKATEGORI, @URUNAD, @MARKA, @SATISFIYATI, @ALISFIYATI, @DEPO)", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@URUNKATEGORI", SqlDbType.NVarChar).Value =cbKategori.Text;
            komut.Parameters.AddWithValue("@URUNAD", SqlDbType.NVarChar).Value = txtUrunAd.Text;
            komut.Parameters.AddWithValue("@MARKA", SqlDbType.NVarChar).Value =cbMarka.Text;
            komut.Parameters.AddWithValue("@SATISFIYATI", SqlDbType.Float).Value = Convert.ToSingle(txtSatisFiyat.Text);
            komut.Parameters.AddWithValue("@ALISFIYATI", SqlDbType.Float).Value = Convert.ToSingle(txtAlisFiyat.Text);
            komut.Parameters.AddWithValue("@DEPO", SqlDbType.NVarChar).Value = cbDepo.Text;
            komut.ExecuteNonQuery();
            this.tBLURUNLERTableAdapter3.Fill(this.dbCRMDataSet10.TBLURUNLER);
        }
    }
}
