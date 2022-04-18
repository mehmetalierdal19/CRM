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
    public partial class Satislar : Form
    {
        baglanti bgl = new baglanti();
        public Satislar()
        {
            InitializeComponent();
        }

        private void Satislar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbURUNLERDataSet14.TBLURUNLER' table. You can move, or remove it, as needed.
            //this.tBLURUNLERTableAdapter.Fill(this.dbURUNLERDataSet14.TBLURUNLER);
            // TODO: This line of code loads data into the 'dbCRMDataSet13.TBLKATEGORILER' table. You can move, or remove it, as needed.
            this.tBLKATEGORILERTableAdapter.Fill(this.dbCRMDataSet13.TBLKATEGORILER);
            // TODO: This line of code loads data into the 'dbMUSTERILERDataSet.TBLMUSTERILER' table. You can move, or remove it, as needed.
            this.tBLMUSTERILERTableAdapter.Fill(this.dbMUSTERILERDataSet.TBLMUSTERILER);
            kayitGetir();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int stokMiktar = 0;
            int stokKodu = 0;
            double miktar = Convert.ToDouble(txtMiktar.Text);
            double birimFiyat = Convert.ToDouble(txtBirimFiyat.Text);
            double KDV = Convert.ToDouble(txtKDV.Text);
            double kdvMiktar;
            double toplam = birimFiyat * miktar;
            double indirimMiktar;
            double satisToplam;
            string urunID = cbUrun.Text;
            if (txtKDV.Text != "" && txtIndirim.Text == "")
            {
                kdvMiktar = toplam * (KDV / 100);
                satisToplam = toplam + kdvMiktar;
                txtSatisTutar.Text = Convert.ToString(satisToplam);
            }else if(txtKDV.Text != "" && txtIndirim.Text != "")
            {
                double indirim = int.Parse(txtIndirim.Text);
                kdvMiktar = toplam * (KDV / 100);
                indirimMiktar = (toplam + kdvMiktar) * (indirim / 100);
                satisToplam = (toplam + kdvMiktar) - indirimMiktar;
                txtSatisTutar.Text = Convert.ToString(satisToplam);
               
            }


            // ürünler tablosundan Stok Miktarı ve kodu tutma
            SqlCommand komut4 = new SqlCommand("Select * from TBLURUNLER where UrunKodu=@UAD", bgl.sqlbaglanti());
            komut4.Parameters.AddWithValue("@UAD", SqlDbType.NVarChar).Value = urunID.ToString();
            SqlDataAdapter da = new SqlDataAdapter(komut4);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow satir in dt.Rows)
            {
                stokMiktar =Convert.ToInt32( satir["Stok"].ToString());
                stokKodu = Convert.ToInt32(satir["StokKodu"].ToString());
            }

            if(miktar < stokMiktar)
            {
                SqlCommand komut = new SqlCommand("Insert Into TBLSATIS (Musteri, UrunKategori, Urun, BirimFiyati, Miktar, Birim, KDV, Indirim, OdemeTip, Teslimat, SatisTutari, ParaBirimi, SatisTarihi) values (@MUS, @UK, @U, @BF, @M, @B, @KDV, @I, @OT, @T, @STUTAR, @PB, @ST)", bgl.sqlbaglanti());
                komut.Parameters.AddWithValue("@MUS", SqlDbType.NVarChar).Value = cbMusteri.Text;
                komut.Parameters.AddWithValue("@UK", SqlDbType.NVarChar).Value = cbUrunK.Text;
                komut.Parameters.AddWithValue("@U", SqlDbType.NVarChar).Value = cbUrun.Text;
                komut.Parameters.AddWithValue("@BF", SqlDbType.NVarChar).Value = txtBirimFiyat.Text;
                komut.Parameters.AddWithValue("@M", SqlDbType.NVarChar).Value = txtMiktar.Text;
                komut.Parameters.AddWithValue("@B", SqlDbType.NVarChar).Value = cbBirim.Text;
                komut.Parameters.AddWithValue("@KDV", SqlDbType.NVarChar).Value = txtKDV.Text;
                komut.Parameters.AddWithValue("@I", SqlDbType.NVarChar).Value = txtIndirim.Text;
                komut.Parameters.AddWithValue("@OT", SqlDbType.NVarChar).Value = cbOdemeTip.Text;
                komut.Parameters.AddWithValue("@T", SqlDbType.NVarChar).Value = cbTeslimat.Text;
                komut.Parameters.AddWithValue("@STUTAR", SqlDbType.NVarChar).Value = txtSatisTutar.Text;
                komut.Parameters.AddWithValue("@PB", SqlDbType.NVarChar).Value = cbParaBirim.Text;
                komut.Parameters.AddWithValue("@ST", SqlDbType.Time).Value = dtSatisTarih.Value;
                komut.ExecuteNonQuery();

                // urunler tablosundan stok azaltma
                SqlCommand komut2 = new SqlCommand("update TBLURUNLER set Stok = Stok - " + miktar + " where UrunKodu=@ID", bgl.sqlbaglanti());
                komut2.Parameters.AddWithValue("@ID", SqlDbType.NVarChar).Value = urunID.ToString();
                komut2.ExecuteNonQuery();
                // stoklar tablosundan stok azaltma
                SqlCommand komut3 = new SqlCommand("update TBLSTOKLAR set StokMiktari = StokMiktari - " + miktar + " where StokKodu =" + stokKodu, bgl.sqlbaglanti());
                komut3.ExecuteNonQuery();

                kayitGetir();
            }
            else
            {
                MessageBox.Show("Stok Miktarını Aştınız!!");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void cbUrunK_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbUrun.Items.Clear();
            string kategori = cbUrunK.Text;
            SqlCommand komut2 = new SqlCommand("Select * from TBLURUNLER where UrunKategori=@URUNK", bgl.sqlbaglanti());
            komut2.Parameters.AddWithValue("@URUNK", SqlDbType.NVarChar).Value = kategori.ToString();
            SqlDataAdapter da = new SqlDataAdapter(komut2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow satir in dt.Rows)
            {
                cbUrun.Items.Add(satir["UrunKodu"].ToString() + " - " + satir["UrunAd"].ToString());
            }
        }
        private void kayitGetir()
        {
            SqlCommand komut = new SqlCommand("Select * from TBLSATIS", bgl.sqlbaglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}