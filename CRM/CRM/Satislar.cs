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
            satislistele();
            urunlistele();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int stokMiktar = 0;
            double miktar = Convert.ToDouble(txtMiktar.Text);
            double birimFiyat = Convert.ToDouble(txtBirimFiyat.Text);
            double KDV = Convert.ToDouble(txtKDV.Text);
            double kdvMiktar;
            double toplam = birimFiyat * miktar;
            double indirimMiktar;
            double satisToplam;
            string urunID = txtUrunKodu.Text;
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
            SqlCommand komut4 = new SqlCommand("Select * from TBLSTOKLAR where UrunKodu=@UKOD", bgl.sqlbaglanti());
            komut4.Parameters.AddWithValue("@UKOD", SqlDbType.NVarChar).Value = urunID.ToString();
            SqlDataAdapter da = new SqlDataAdapter(komut4);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow satir in dt.Rows)
            {
                stokMiktar =Convert.ToInt32( satir["StokMiktari"].ToString());
            }

            if(miktar < stokMiktar)
            {
                SqlCommand komut = new SqlCommand("Insert Into TBLSATIS (Musteri, UrunKategori, Urun, BirimFiyati, Miktar, Birim, KDV, Indirim, OdemeTip, Teslimat, SatisTutari, ParaBirimi, SatisTarihi, Aciklama) values (@MUS, @UK, @UKOD, @BF, @M, @B, @KDV, @I, @OT, @T, @STUTAR, @PB, @ST, @A)", bgl.sqlbaglanti());
                komut.Parameters.AddWithValue("@MUS", SqlDbType.NVarChar).Value = cbMusteri.Text;
                komut.Parameters.AddWithValue("@UK", SqlDbType.NVarChar).Value = txtKategori.Text;
                komut.Parameters.AddWithValue("@UKOD", SqlDbType.NVarChar).Value = txtUrunKodu.Text;
                komut.Parameters.AddWithValue("@BF", SqlDbType.NVarChar).Value = txtBirimFiyat.Text;
                komut.Parameters.AddWithValue("@M", SqlDbType.NVarChar).Value = txtMiktar.Text;
                komut.Parameters.AddWithValue("@B", SqlDbType.NVarChar).Value = txtBirim.Text;
                komut.Parameters.AddWithValue("@KDV", SqlDbType.NVarChar).Value = txtKDV.Text;
                komut.Parameters.AddWithValue("@I", SqlDbType.NVarChar).Value = txtIndirim.Text;
                komut.Parameters.AddWithValue("@OT", SqlDbType.NVarChar).Value = cbOdemeTip.Text;
                komut.Parameters.AddWithValue("@T", SqlDbType.NVarChar).Value = cbTeslimat.Text;
                komut.Parameters.AddWithValue("@STUTAR", SqlDbType.NVarChar).Value = txtSatisTutar.Text;
                komut.Parameters.AddWithValue("@PB", SqlDbType.NVarChar).Value = cbParaBirim.Text;
                komut.Parameters.AddWithValue("@ST", SqlDbType.Time).Value = dtSatisTarih.Value;
                komut.Parameters.AddWithValue("@A", SqlDbType.NVarChar).Value = txtAciklama.Text;
                komut.ExecuteNonQuery();

                // stoklar tablosundan stok azaltma
                SqlCommand komut3 = new SqlCommand("update TBLSTOKLAR set StokMiktari = StokMiktari - " + miktar + " where UrunKodu =" + urunID, bgl.sqlbaglanti());
                komut3.ExecuteNonQuery();

                satislistele();
                temizle();
            }
            else
            {
                MessageBox.Show("Stok Miktarını Aştınız!!");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
                // Satış güncelleme
                SqlCommand komut = new SqlCommand("update TBLSATIS set, OdemeTip=@OT, Teslimat=@T, ParaBirimi=@PB, SatisTarihi=@ST, Aciklama=@A where ID=@id", bgl.sqlbaglanti());
                komut.Parameters.AddWithValue("@OT", SqlDbType.NVarChar).Value = cbOdemeTip.Text;
                komut.Parameters.AddWithValue("@T", SqlDbType.NVarChar).Value = cbTeslimat.Text;
                komut.Parameters.AddWithValue("@PB", SqlDbType.NVarChar).Value = cbParaBirim.Text;
                komut.Parameters.AddWithValue("@ST", SqlDbType.Time).Value = dtSatisTarih.Value;
                komut.Parameters.AddWithValue("@A", SqlDbType.NVarChar).Value = txtAciklama.Text;
                komut.ExecuteNonQuery();
            
        }

        private void cbUrunK_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbUrun.Items.Clear();
            //string kategori = cbUrunK.Text;
            //SqlCommand komut2 = new SqlCommand("Select * from TBLURUNLER where UrunKategori=@URUNK", bgl.sqlbaglanti());
            //komut2.Parameters.AddWithValue("@URUNK", SqlDbType.NVarChar).Value = kategori.ToString();
            //SqlDataAdapter da = new SqlDataAdapter(komut2);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //foreach (DataRow satir in dt.Rows)
            //{
            //    cbUrun.Items.Add(satir["UrunKodu"].ToString() + " - " + satir["UrunAd"].ToString());
                
            //}
        }
        private void satislistele()
        {
            SqlCommand komut = new SqlCommand("Select * from TBLSATIS", bgl.sqlbaglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void urunlistele()
        {
            SqlCommand komut = new SqlCommand("Select UrunKodu, UrunAd, UrunKategori, Birim  from TBLURUNLER", bgl.sqlbaglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void temizle()
        {
            txtID.Text = "";
            cbMusteri.Text = "";
            txtKategori.Text = "";
            txtUrunKodu.Text = "";
            txtBirimFiyat.Text = "";
            txtMiktar.Text = "";
            txtBirim.Text = "";
            txtKDV.Text = "";
            txtIndirim.Text = "";
            cbOdemeTip.Text = "";
            cbTeslimat.Text = "";
            txtSatisTutar.Text = "";
            cbParaBirim.Text = "";
            dtSatisTarih.Value = DateTime.Now;
        }
        private void txtSatisArama_TextChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TBLSATIS where Urun Like '%" + txtSatisArama.Text + "%'", bgl.sqlbaglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            if(txtSatisArama.Text == "")
            {
                satislistele();
            }
        }

        private void txtUrunArama_TextChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select UrunKodu, UrunAd, UrunKategori, Birim from TBLURUNLER where UrunKodu like '%" + txtUrunArama.Text + "%' or UrunAd like '%" + txtUrunArama.Text + "%'", bgl.sqlbaglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            if(txtUrunArama.Text == "")
            {
                urunlistele();
            }
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtKategori.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txtUrunKodu.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txtBirim.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                cbMusteri.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtKategori.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtUrunKodu.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtBirimFiyat.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtMiktar.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtBirim.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtKDV.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txtIndirim.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                cbOdemeTip.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                cbTeslimat.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                txtSatisTutar.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                cbParaBirim.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                dtSatisTarih.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[13].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Uygun Bir Veri Seçiniz.");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string urunID = txtUrunKodu.Text;
            double miktar = Convert.ToDouble(txtMiktar.Text);

            // satış iptal etme
            SqlCommand komut = new SqlCommand("Delete from TBLSATIS where ID=@id", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@id", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text);
            komut.ExecuteNonQuery();
            

            // stoklar tablosundan stok ekleme
            SqlCommand komut3 = new SqlCommand("update TBLSTOKLAR set StokMiktari = StokMiktari + " + miktar + " where UrunKodu =" + urunID, bgl.sqlbaglanti());
            komut3.ExecuteNonQuery();

            satislistele();
            temizle();

        }
    }
}