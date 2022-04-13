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
    public partial class Alislar : Form
    {
        baglanti bgl = new baglanti();
        public Alislar()
        {
            InitializeComponent();
        }
        private void Alislar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbTBLTEDARIKCIDataSet.TBLTEDARIKCI' table. You can move, or remove it, as needed.
            this.tBLTEDARIKCITableAdapter.Fill(this.dbTBLTEDARIKCIDataSet.TBLTEDARIKCI);
            // TODO: This line of code loads data into the 'dbCRMDataSet13.TBLKATEGORILER' table. You can move, or remove it, as needed.
            this.tBLKATEGORILERTableAdapter.Fill(this.dbCRMDataSet13.TBLKATEGORILER);

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int stokKodu = 0;
            double miktar = Convert.ToDouble(txtMiktar.Text);
            double birimFiyat = Convert.ToDouble(txtBirimFiyat.Text);
            double KDV = Convert.ToDouble(txtKDV.Text);
            double kdvMiktar;
            double toplam = birimFiyat * miktar;
            double satisToplam;
            string urunID = cbUrunKodu.Text;
            if(txtKDV.Text != "")
            {
                kdvMiktar = toplam * (KDV / 100);
                satisToplam = toplam + kdvMiktar;
                txtToplam.Text = Convert.ToString(satisToplam);
            }

            // ÜRÜN STOKKODU TUTMA
            SqlCommand komut = new SqlCommand("Select * from TBLURUNLER where UrunKodu=@UKOD", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@UKOD", SqlDbType.NVarChar).Value = urunID.ToString();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow satir in dt.Rows)
            {
                stokKodu = Convert.ToInt32(satir["StokKodu"].ToString());
            }

            SqlCommand komut2 = new SqlCommand("Insert Into TBLALISLAR (Tedarikci, UrunKategori, UrunKodu, BirimFiyati, Miktar, Birim, KDV, OdemeTipi, Teslimat, AlisTutari, ParaBirimi, AlisTarihi, Tahsilat, Aciklama) values (@TEDARIKCI, @URUNKATEGORI, @URUNKODU, @BIRIMFIYATI, @MIKTAR, @BIRIM, @KDV, @ODEMETIP, @TESLIMAT, @ALISTUTARI, @PARABIRIMI, @ALISTARIHI, @TAHSILAT, @ACIKLAMA)", bgl.sqlbaglanti());
            komut2.Parameters.AddWithValue("@TEDARIKCI", SqlDbType.NVarChar).Value = cbTedarikci.Text;
            komut2.Parameters.AddWithValue("@URUNKATEGORI", SqlDbType.NVarChar).Value = cbUrunKategori.Text;
            komut2.Parameters.AddWithValue("@URUNKODU", SqlDbType.NVarChar).Value = cbUrunKodu.Text;
            komut2.Parameters.AddWithValue("@BIRIMFIYATI", SqlDbType.NVarChar).Value = txtBirimFiyat.Text;
            komut2.Parameters.AddWithValue("@MIKTAR", SqlDbType.NVarChar).Value = txtMiktar.Text;
            komut2.Parameters.AddWithValue("@BIRIM", SqlDbType.NVarChar).Value = cbBirim.Text;
            komut2.Parameters.AddWithValue("@KDV", SqlDbType.NVarChar).Value = txtKDV.Text;
            komut2.Parameters.AddWithValue("@ODEMETIP", SqlDbType.NVarChar).Value = cbOdemeTipi.Text;
            komut2.Parameters.AddWithValue("@TESLIMAT", SqlDbType.NVarChar).Value = cbTeslimat.Text;
            komut2.Parameters.AddWithValue("@ALISTUTARI", SqlDbType.NVarChar).Value = txtToplam.Text;
            komut2.Parameters.AddWithValue("@PARABIRIMI", SqlDbType.NVarChar).Value = cbParaBirimi.Text;
            komut2.Parameters.AddWithValue("@ALISTARIHI", SqlDbType.Time).Value = dtAlisTarih.Value;
            komut2.Parameters.AddWithValue("@TAHSILAT", SqlDbType.NVarChar).Value = cbTahsilat.Text;
            komut2.Parameters.AddWithValue("@ACIKLAMA", SqlDbType.NVarChar).Value = txtAciklama.Text;
            komut2.ExecuteNonQuery();

            // urunler tablosundan stok azaltma
            SqlCommand komut3 = new SqlCommand("update TBLURUNLER set Stok = Stok + " + miktar + " where UrunKodu=@ID", bgl.sqlbaglanti());
            komut3.Parameters.AddWithValue("@ID", SqlDbType.NVarChar).Value = urunID.ToString();
            komut3.ExecuteNonQuery();

            // stoklar tablosundan stok azaltma
            SqlCommand komut4 = new SqlCommand("update TBLSTOKLAR set StokMiktari = StokMiktari + " + miktar + " where StokKodu =" + stokKodu, bgl.sqlbaglanti());
            komut4.ExecuteNonQuery();
        }

        

        private void cbUrunKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbUrunKodu.Items.Clear();
            string kategori = cbUrunKategori.Text;
            SqlCommand komut = new SqlCommand("Select * from TBLURUNLER where UrunKategori=@URUNK", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@URUNK", SqlDbType.NVarChar).Value = kategori.ToString();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow satir in dt.Rows)
            {
                cbUrunKodu.Items.Add(satir["UrunKodu"].ToString());
            }
        }
    }
}
