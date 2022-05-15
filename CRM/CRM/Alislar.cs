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
            alislsitele();
            urunlistele();

        }
        private void alislsitele()
        {
            SqlCommand komut = new SqlCommand("Select * from TBLALISLAR", bgl.sqlbaglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
        }
        private void urunlistele()
        {
            SqlCommand komut = new SqlCommand("Select UrunKodu, UrunAd, UrunKategori, Birim from TBLURUNLER", bgl.sqlbaglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void temizle()
        {
            cbTedarikci.Text = "";
            dtAlisTarih.Value = DateTime.Now;
            txtUrunKategori.Text = "";
            txtUrunKodu.Text = "";
            txtBirimFiyat.Text = "";
            txtMiktar.Text = "";
            txtBirim.Text = "";
            txtKDV.Text = "";
            txtToplam.Text = "";
            cbParaBirimi.Text = "";
            cbOdemeTipi.Text = "";
            cbTahsilat.Text = "";
            cbTeslimat.Text = "";
            txtID.Text = "";
            txtAciklama.Text = "";
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            double miktar = Convert.ToDouble(txtMiktar.Text);
            double birimFiyat = Convert.ToDouble(txtBirimFiyat.Text);
            double KDV = Convert.ToDouble(txtKDV.Text);
            double kdvMiktar;
            double toplam = birimFiyat * miktar;
            double satisToplam;
            string urunID = txtUrunKodu.Text;
            if(txtKDV.Text != "")
            {
                kdvMiktar = toplam * (KDV / 100);
                satisToplam = toplam + kdvMiktar;
                txtToplam.Text = Convert.ToString(satisToplam);
            }

            // Alış Ekleme
            SqlCommand komut2 = new SqlCommand("Insert Into TBLALISLAR (Tedarikci, UrunKategori, UrunKodu, BirimFiyati, Miktar, Birim, KDV, OdemeTipi, Teslimat, AlisTutari, ParaBirimi, AlisTarihi, Tahsilat, Aciklama) values (@TEDARIKCI, @URUNKATEGORI, @URUNKODU, @BIRIMFIYATI, @MIKTAR, @BIRIM, @KDV, @ODEMETIP, @TESLIMAT, @ALISTUTARI, @PARABIRIMI, @ALISTARIHI, @TAHSILAT, @ACIKLAMA)", bgl.sqlbaglanti());
            komut2.Parameters.AddWithValue("@TEDARIKCI", SqlDbType.NVarChar).Value = cbTedarikci.Text;
            komut2.Parameters.AddWithValue("@URUNKATEGORI", SqlDbType.NVarChar).Value = txtUrunKategori.Text;
            komut2.Parameters.AddWithValue("@URUNKODU", SqlDbType.NVarChar).Value = txtUrunKodu.Text;
            komut2.Parameters.AddWithValue("@BIRIMFIYATI", SqlDbType.NVarChar).Value = txtBirimFiyat.Text;
            komut2.Parameters.AddWithValue("@MIKTAR", SqlDbType.NVarChar).Value = txtMiktar.Text;
            komut2.Parameters.AddWithValue("@BIRIM", SqlDbType.NVarChar).Value = txtBirim.Text;
            komut2.Parameters.AddWithValue("@KDV", SqlDbType.NVarChar).Value = txtKDV.Text;
            komut2.Parameters.AddWithValue("@ODEMETIP", SqlDbType.NVarChar).Value = cbOdemeTipi.Text;
            komut2.Parameters.AddWithValue("@TESLIMAT", SqlDbType.NVarChar).Value = cbTeslimat.Text;
            komut2.Parameters.AddWithValue("@ALISTUTARI", SqlDbType.NVarChar).Value = txtToplam.Text;
            komut2.Parameters.AddWithValue("@PARABIRIMI", SqlDbType.NVarChar).Value = cbParaBirimi.Text;
            komut2.Parameters.AddWithValue("@ALISTARIHI", SqlDbType.Time).Value = dtAlisTarih.Value;
            komut2.Parameters.AddWithValue("@TAHSILAT", SqlDbType.NVarChar).Value = cbTahsilat.Text;
            komut2.Parameters.AddWithValue("@ACIKLAMA", SqlDbType.NVarChar).Value = txtAciklama.Text;
            komut2.ExecuteNonQuery();

            // stoklar tablosundan stok arttırma
            SqlCommand komut4 = new SqlCommand("update TBLSTOKLAR set StokMiktari = StokMiktari + " + miktar + " where UrunKodu =" + urunID, bgl.sqlbaglanti());
            komut4.ExecuteNonQuery();

            alislsitele();
            temizle();

        }
        private void cbUrunKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbUrunKodu.Items.Clear();
            //string kategori = cbUrunKategori.Text;
            //SqlCommand komut = new SqlCommand("Select * from TBLURUNLER where UrunKategori=@URUNK", bgl.sqlbaglanti());
            //komut.Parameters.AddWithValue("@URUNK", SqlDbType.NVarChar).Value = kategori.ToString();
            //SqlDataAdapter da = new SqlDataAdapter(komut);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //foreach (DataRow satir in dt.Rows)
            //{
            //    cbUrunKodu.Items.Add(satir["UrunKodu"].ToString() + " - " + satir["UrunAd"].ToString());
            //}
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            double miktar = Convert.ToDouble(txtMiktar.Text);
            string urunID = txtUrunKodu.Text;

            //alış iptal etme
            SqlCommand komut = new SqlCommand("Delete from TBLALISLAR where ID=@id", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@id", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text);
            komut.ExecuteNonQuery();
            alislsitele();
            temizle();

            // stoklar tablosundan stok azaltma
            SqlCommand komut4 = new SqlCommand("update TBLSTOKLAR set StokMiktari = StokMiktari - " + miktar + " where UrunKodu =" + urunID, bgl.sqlbaglanti());
            komut4.ExecuteNonQuery();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBLALISLAR set Tedarikci=@TEDARIKCI, ParaBirimi=@PARABIRIMI, AlisTarihi=@ALISTARIHI, Tahsilat=@TAHSILAT, OdemeTipi=@ODEMETIP, Teslimat=@TESLIMAT, Aciklama=@ACIKLAMA where ID=@id", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@PARABIRIMI", SqlDbType.NVarChar).Value = cbParaBirimi.Text;
            komut.Parameters.AddWithValue("@ALISTARIHI", SqlDbType.Time).Value = dtAlisTarih.Value;
            komut.Parameters.AddWithValue("@TAHSILAT", SqlDbType.NVarChar).Value = cbTahsilat.Text;
            komut.Parameters.AddWithValue("@TESLIMAT", SqlDbType.NVarChar).Value = cbTeslimat.Text;
            komut.Parameters.AddWithValue("@ODEMETIP", SqlDbType.NVarChar).Value = cbOdemeTipi.Text;
            komut.Parameters.AddWithValue("@ACIKLAMA", SqlDbType.NVarChar).Value = txtAciklama.Text;
            komut.Parameters.AddWithValue("@id", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text);
            komut.ExecuteNonQuery();
            alislsitele();
            temizle();
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtUrunKodu.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txtUrunKategori.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txtBirim.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
        }

        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtID.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
                cbTedarikci.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
                txtUrunKodu.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
                txtUrunKategori.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
                txtBirimFiyat.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
                txtMiktar.Text = dataGridView3.CurrentRow.Cells[5].Value.ToString();
                txtBirim.Text = dataGridView3.CurrentRow.Cells[6].Value.ToString();
                txtKDV.Text = dataGridView3.CurrentRow.Cells[7].Value.ToString();
                txtToplam.Text = dataGridView3.CurrentRow.Cells[8].Value.ToString();
                cbParaBirimi.Text = dataGridView3.CurrentRow.Cells[9].Value.ToString();
                dtAlisTarih.Value = Convert.ToDateTime(dataGridView3.CurrentRow.Cells[10].Value.ToString());
                cbTahsilat.Text = dataGridView3.CurrentRow.Cells[11].Value.ToString();
                cbOdemeTipi.Text = dataGridView3.CurrentRow.Cells[12].Value.ToString();
                cbTeslimat.Text = dataGridView3.CurrentRow.Cells[13].Value.ToString();
                txtAciklama.Text = dataGridView3.CurrentRow.Cells[14].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Uygun Bir Veri Giriniz.");
            }
            
        }

        private void txtAlisArama_TextChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TBLALISLAR where UrunKodu Like '%" + txtAlisArama.Text + "%'", bgl.sqlbaglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;

            if(txtAlisArama.Text == "")
            {
                alislsitele();
            }
        }

        private void txtUrunArama_TextChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select UrunKodu, UrunAd, UrunKategori, Birim from TBLURUNLER where UrunKodu like '%" + txtUrunArama.Text + "%' or UrunAd like '%" + txtUrunArama.Text + "%'", bgl.sqlbaglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            if (txtUrunArama.Text == "")
            {
                urunlistele();
            }
        }
    }
}
