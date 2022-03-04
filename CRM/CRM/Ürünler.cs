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

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            //Ürün Ekleme
            SqlCommand komut = new SqlCommand("Insert INTO TBLURUNLER (UrunKategori, UrunAd, Marka, SatisFiyati, AlisFiyati, Depo) VALUES (@URUNKATEGORI, @URUNAD, @MARKA, @SATISFIYATI, @ALISFIYATI, @DEPO)", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@URUNKATEGORI", SqlDbType.NVarChar).Value =cbKategori.Text;
            komut.Parameters.AddWithValue("@URUNAD", SqlDbType.NVarChar).Value = txtUrunAd.Text;
            komut.Parameters.AddWithValue("@MARKA", SqlDbType.NVarChar).Value =cbMarka.Text;
            komut.Parameters.AddWithValue("@SATISFIYATI", SqlDbType.Float).Value = Convert.ToSingle(txtSatisFiyat.Text);
            komut.Parameters.AddWithValue("@ALISFIYATI", SqlDbType.Float).Value = Convert.ToSingle(txtAlisFiyat.Text);
            komut.Parameters.AddWithValue("@DEPO", SqlDbType.NVarChar).Value = cbDepo.Text;
            komut.ExecuteNonQuery();
            this.tBLURUNLERTableAdapter3.Fill(this.dbCRMDataSet10.TBLURUNLER);

            // Kategori Sayısı Arttırma
            SqlCommand komut2 = new SqlCommand("Update TBLKATEGORILER set UrunSayisi=UrunSayisi+1 where KategoriID=@p1", bgl.sqlbaglanti());
            komut2.Parameters.AddWithValue("@p1", cbKategori.SelectedValue);
            komut2.ExecuteNonQuery();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // Ürün Silme
            SqlCommand komut = new SqlCommand("Delete From TBLURUNLER Where id=@ID", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = txtUrunId.Text;
            komut.ExecuteNonQuery();
            this.tBLURUNLERTableAdapter3.Fill(this.dbCRMDataSet10.TBLURUNLER);

            // Kategori Sayısı Azaltma
            SqlCommand komut3 = new SqlCommand("Update TBLKATEGORILER set UrunSayisi=UrunSayisi-1 where KategoriID=@p2", bgl.sqlbaglanti());
            komut3.Parameters.AddWithValue("@p2", cbKategori.SelectedValue);
            komut3.ExecuteNonQuery();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // kayıt seçme
            txtUrunId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbKategori.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtUrunAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cbMarka.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtSatisFiyat.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtAlisFiyat.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cbDepo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Ürün güncelleme
            SqlCommand komut = new SqlCommand("Update TBLURUNLER set UrunKategori= @URUNKATEGORI, UrunAd= @URUNAD, Marka= @MARKA, SatisFiyati= @SATISFIYATI, AlisFiyati= @ALISFIYATI, Depo=@DEPO where id= @ID", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@URUNKATEGORI", SqlDbType.NVarChar).Value = cbKategori.Text;
            komut.Parameters.AddWithValue("@URUNAD", SqlDbType.NVarChar).Value = txtUrunAd.Text;
            komut.Parameters.AddWithValue("@MARKA", SqlDbType.NVarChar).Value = cbMarka.Text;
            komut.Parameters.AddWithValue("@SATISFIYATI", SqlDbType.Float).Value = Convert.ToSingle(txtSatisFiyat.Text);
            komut.Parameters.AddWithValue("@ALISFIYATI", SqlDbType.Float).Value = Convert.ToSingle(txtAlisFiyat.Text);
            komut.Parameters.AddWithValue("@DEPO", SqlDbType.NVarChar).Value = cbDepo.Text;
            komut.Parameters.AddWithValue("@ID", SqlDbType.Int).Value =Convert.ToInt32(txtUrunId.Text);
            komut.ExecuteNonQuery();
            this.tBLURUNLERTableAdapter3.Fill(this.dbCRMDataSet10.TBLURUNLER);
        }
    }
}
