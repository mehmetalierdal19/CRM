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
    public partial class Ürünler : Form
    {
        // sql bağlantısı
        baglanti bgl = new baglanti();
        public Ürünler()
        {
            InitializeComponent();
        }

        private void Ürünler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbCRMDataSet10.TBLURUNLER' table. You can move, or remove it, as needed.
           //SON this.tBLURUNLERTableAdapter3.Fill(this.dbCRMDataSet10.TBLURUNLER);
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
            kayitGetir();

        }
        private void kayitGetir()
        {
            SqlCommand komut = new SqlCommand("Select * from TBLURUNLER", bgl.sqlbaglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void temizle()
        {
            txtUrunId.Text = "";
            txtUrunAd.Text = "";
            txtUrunKodu.Text = "";
            cbBirim.Text = "";
            cbDepo.Text = "";
            cbKategori.Text = "";
            cbMarka.Text = "";
        }
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            //Ürün Ekleme
            SqlCommand komut = new SqlCommand("Insert INTO TBLURUNLER (UrunKategori, UrunAd, Marka, Birim, Depo, UrunKodu) VALUES (@URUNKATEGORI, @URUNAD, @MARKA, @BIRIM, @DEPO, @UKOD)", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@URUNKATEGORI", SqlDbType.NVarChar).Value =cbKategori.Text;
            komut.Parameters.AddWithValue("@URUNAD", SqlDbType.NVarChar).Value = txtUrunAd.Text;
            komut.Parameters.AddWithValue("@MARKA", SqlDbType.NVarChar).Value =cbMarka.Text;
            komut.Parameters.AddWithValue("@BIRIM", SqlDbType.Float).Value = cbBirim.Text;
            komut.Parameters.AddWithValue("@DEPO", SqlDbType.NVarChar).Value = cbDepo.Text;
            komut.Parameters.AddWithValue("@UKOD", SqlDbType.NVarChar).Value = txtUrunKodu.Text;
            komut.ExecuteNonQuery();
            kayitGetir();
            

            // Kategori Sayısı Arttırma
            SqlCommand komut2 = new SqlCommand("Update TBLKATEGORILER set UrunSayisi=UrunSayisi+1 where KategoriID=@p1", bgl.sqlbaglanti());
            komut2.Parameters.AddWithValue("@p1", cbKategori.SelectedValue);
            komut2.ExecuteNonQuery();
            
            // Stok Ekleme
            SqlCommand komut3 = new SqlCommand("Insert Into TBLSTOKLAR (UrunAd, StokMiktari, Birim, UrunKodu) values (@URUNAD, @STOK, @BIRIM, @URUNKOD)", bgl.sqlbaglanti());
            komut3.Parameters.AddWithValue("@URUNAD", SqlDbType.NVarChar).Value = txtUrunAd.Text;
            komut3.Parameters.AddWithValue("@STOK", SqlDbType.Float).Value = 0;
            komut3.Parameters.AddWithValue("@BIRIM", SqlDbType.NVarChar).Value = cbBirim.Text;
            komut3.Parameters.AddWithValue("@URUNKOD", SqlDbType.NVarChar).Value =Convert.ToString( txtUrunKodu.Text);
            komut3.ExecuteNonQuery();
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // Ürün Silme
            SqlCommand komut = new SqlCommand("Delete From TBLURUNLER Where id=@ID", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = txtUrunId.Text;
            komut.ExecuteNonQuery();
            kayitGetir();
            

            // Kategori Sayısı Azaltma
            SqlCommand komut3 = new SqlCommand("Update TBLKATEGORILER set UrunSayisi=UrunSayisi-1 where KategoriID=@p2", bgl.sqlbaglanti());
            komut3.Parameters.AddWithValue("@p2", cbKategori.SelectedValue);
            komut3.ExecuteNonQuery();
            
            // stok silme
            SqlCommand komut2 = new SqlCommand("Delete from TBLSTOKLAR where UrunKodu=@kod", bgl.sqlbaglanti());
            komut2.Parameters.AddWithValue("@kod", SqlDbType.NVarChar).Value = txtUrunKodu.Text;
            komut2.ExecuteNonQuery();
            temizle();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // kayıt seçme
            txtUrunId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbKategori.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtUrunAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtUrunKodu.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cbMarka.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cbBirim.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cbDepo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Ürün güncelleme
            SqlCommand komut = new SqlCommand("Update TBLURUNLER set UrunKategori= @URUNKATEGORI, UrunAd= @URUNAD, UrunKodu=@KOD, Marka= @MARKA, Birim= @BIRIM, Depo=@DEPO where id= @ID", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@URUNKATEGORI", SqlDbType.NVarChar).Value = cbKategori.Text;
            komut.Parameters.AddWithValue("@URUNAD", SqlDbType.NVarChar).Value = txtUrunAd.Text;
            komut.Parameters.AddWithValue("@MARKA", SqlDbType.NVarChar).Value = cbMarka.Text;
            komut.Parameters.AddWithValue("@BIRIM", SqlDbType.NVarChar).Value = cbBirim.Text;
            komut.Parameters.AddWithValue("@DEPO", SqlDbType.NVarChar).Value = cbDepo.Text;
            komut.Parameters.AddWithValue("@KOD", SqlDbType.NVarChar).Value = txtUrunKodu.Text;
            komut.Parameters.AddWithValue("@ID", SqlDbType.Int).Value =Convert.ToInt32(txtUrunId.Text);
            komut.ExecuteNonQuery();
            kayitGetir();
            temizle();
        }

        Random rndm = new Random();
        //private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    int sayi = rndm.Next(100, 9999999);
        //    SqlCommand komut = new SqlCommand("Select StokKodu from TBLURUNLER", bgl.sqlbaglanti());
        //    SqlDataAdapter da = new SqlDataAdapter(komut);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    foreach (DataRow satir in dt.Rows)
        //    {
        //        if (satir["StokKodu"].ToString() == Convert.ToString(sayi))
        //        {
        //            MessageBox.Show("Stok kodu aynı. Lütfen tekrar deneyiniz!");
        //        }
        //        if(satir["StokKodu"].ToString() != Convert.ToString(sayi))
        //        {
        //            txtStokKodu.Text = Convert.ToString(sayi);
        //        }
        //    }
            
        //}

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int sayi = rndm.Next(100, 9999999);
            SqlCommand komut = new SqlCommand("Select UrunKodu from TBLURUNLER", bgl.sqlbaglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow satir in dt.Rows)
            {
                if (Convert.ToString(sayi) == satir["UrunKodu"].ToString())
                {
                    MessageBox.Show("Ürün kodu aynı. Lütfen tekrar deneyiniz!");
                }
                else
                {
                    txtUrunKodu.Text = Convert.ToString(sayi);
                }
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TBLURUNLER where UrunKategori Like '%" + txtArama.Text + "%' or UrunAd Like '%" + txtArama.Text + "%' or UrunKodu Like '%" + txtArama.Text + "%'", bgl.sqlbaglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            if(txtArama.Text == "")
            {
                kayitGetir();
            }
        }
    }
}
