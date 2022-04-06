﻿using System;
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
            this.tBLURUNLERTableAdapter.Fill(this.dbURUNLERDataSet14.TBLURUNLER);
            // TODO: This line of code loads data into the 'dbCRMDataSet13.TBLKATEGORILER' table. You can move, or remove it, as needed.
            this.tBLKATEGORILERTableAdapter.Fill(this.dbCRMDataSet13.TBLKATEGORILER);
            // TODO: This line of code loads data into the 'dbMUSTERILERDataSet.TBLMUSTERILER' table. You can move, or remove it, as needed.
            this.tBLMUSTERILERTableAdapter.Fill(this.dbMUSTERILERDataSet.TBLMUSTERILER);

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
            int urunID = Convert.ToInt32(cbUrun.SelectedValue);
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


            // Stok Miktarı tutma
            SqlCommand komut4 = new SqlCommand("Select * from TBLURUNLER where id=@ID", bgl.sqlbaglanti());
            komut4.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = urunID;
            SqlDataAdapter da = new SqlDataAdapter(komut4);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow satir in dt.Rows)
            {
                stokMiktar =Convert.ToInt32( satir["Stok"].ToString());
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
                SqlCommand komut2 = new SqlCommand("update TBLURUNLER set Stok = Stok - " + miktar + " where id=@ID", bgl.sqlbaglanti());
                komut2.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = urunID;
                komut2.ExecuteNonQuery();

                // stoklar tablosundan stok azaltma
                SqlCommand komut3 = new SqlCommand("update TBLSTOKLAR set StokMiktari = StokMiktari - " + miktar + " where id =" + urunID, bgl.sqlbaglanti());
                komut3.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Stok Miktarını Aştınız!!");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}