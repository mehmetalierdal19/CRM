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
    public partial class ÜrünKategori : Form
    {
        // sql bağlantısı
        baglanti bgl = new baglanti();
        public ÜrünKategori()
        {
            InitializeComponent();
        }

        private void ÜrünKategori_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbCRMDataSet2.TBLKATEGORILER' table. You can move, or remove it, as needed.
            this.tBLKATEGORILERTableAdapter.Fill(this.dbCRMDataSet2.TBLKATEGORILER);

        }
        private void temizle()
        {
            txtKategoriAd.Text = "";
            txtKategoriid.Text = "";
            txtUrunSayisi.Text = "";
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            // kategori ekleme
            SqlCommand komut = new SqlCommand("Insert INTO TBLKATEGORILER (KategoriAD, UrunSayisi) VALUES (@KATEGORIAD, @URUNSAYISI)", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@KATEGORIAD", SqlDbType.NVarChar).Value = txtKategoriAd.Text;
            komut.Parameters.AddWithValue("@URUNSAYISI", SqlDbType.Int).Value = 0;
            komut.ExecuteNonQuery();
            this.tBLKATEGORILERTableAdapter.Fill(this.dbCRMDataSet2.TBLKATEGORILER);
            temizle();
        }

        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {
            // kategori güncelleme
            SqlCommand komut = new SqlCommand("Update TBLKATEGORILER set KategoriAd=@KATEGORIAD where KategoriID=@KATEGORIID", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@KATEGORIAD", SqlDbType.NVarChar).Value = txtKategoriAd.Text;
            komut.Parameters.AddWithValue("@KATEGORIID", SqlDbType.Int).Value = Convert.ToInt32(txtKategoriid.Text);
            komut.ExecuteNonQuery();
            this.tBLKATEGORILERTableAdapter.Fill(this.dbCRMDataSet2.TBLKATEGORILER);
            temizle();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // kayıt seçme
            txtKategoriid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtKategoriAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtUrunSayisi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            // kategori silme
            SqlCommand komut = new SqlCommand("Delete from TBLKATEGORILER where KategoriID=@KATEGORIID", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@KATEGORIID", SqlDbType.Int).Value = Convert.ToInt32(txtKategoriid.Text);
            komut.ExecuteNonQuery();
            this.tBLKATEGORILERTableAdapter.Fill(this.dbCRMDataSet2.TBLKATEGORILER);
            temizle();
        }

        private void txtKategoriArama_TextChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TBLKATEGORILER where KategoriAd like '%" + txtKategoriArama.Text + "%'", bgl.sqlbaglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            if(txtKategoriArama.Text == "")
            {
                this.tBLKATEGORILERTableAdapter.Fill(this.dbCRMDataSet2.TBLKATEGORILER);
            }
        }
    }
}
