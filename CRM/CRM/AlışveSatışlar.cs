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
    public partial class AlışveSatışlar : Form
    {
        baglanti bgl = new baglanti();
        string secilen;
        public AlışveSatışlar()
        {
            InitializeComponent();
        }

        private void AlışveSatışlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbCRMDataSet12.TBLURUNLER' table. You can move, or remove it, as needed.
            this.tBLURUNLERTableAdapter.Fill(this.dbCRMDataSet12.TBLURUNLER);
            // TODO: This line of code loads data into the 'dbCRMDataSet11.TBLISLEMLER' table. You can move, or remove it, as needed.
            this.tBLISLEMLERTableAdapter.Fill(this.dbCRMDataSet11.TBLISLEMLER);

        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert Into TBLISLEMLER (URUNID, MIKTAR, ALISFIYATI, SATISFIYATI, ISLEM) Values (@URUNID, @MIKTAR, @ALISFIYATI, @SATISFIYATI, @ISLEM)", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@URUNID", SqlDbType.NVarChar).Value = secilen;
            komut.Parameters.AddWithValue("@MIKTAR", SqlDbType.Float).Value = Convert.ToSingle(txtMiktar.Text);
            komut.Parameters.AddWithValue("@ALISFIYATI", SqlDbType.Float).Value = Convert.ToSingle(txtAlisFiyati.Text);
            komut.Parameters.AddWithValue("@SATISFIYATI", SqlDbType.Float).Value = Convert.ToSingle(txtSatisFiyati.Text);
            komut.Parameters.AddWithValue("@ISLEM", SqlDbType.NVarChar).Value = "Satış";
            komut.ExecuteNonQuery();
            bgl.sqlbaglanti().Close();
            this.tBLISLEMLERTableAdapter.Fill(this.dbCRMDataSet11.TBLISLEMLER);
        }

        private void cbUrunAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilen = cbUrunAd.SelectedValue.ToString();
            SqlCommand komut = new SqlCommand("Select * From TBLURUNLER Where id=@ID", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = Convert.ToInt32(secilen);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow satir in dt.Rows)
            {
                txtAlisFiyati.Text = satir["AlisFiyati"].ToString();
                txtSatisFiyati.Text = satir["SatisFiyati"].ToString();
            }
        }

        private void btnalis_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert Into TBLISLEMLER (URUNID, MIKTAR, ALISFIYATI, SATISFIYATI, ISLEM) Values (@URUNID, @MIKTAR, @ALISFIYATI, @SATISFIYATI, @ISLEM)", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@URUNID", SqlDbType.NVarChar).Value = secilen;
            komut.Parameters.AddWithValue("@MIKTAR", SqlDbType.Float).Value = Convert.ToSingle(txtMiktar.Text);
            komut.Parameters.AddWithValue("@ALISFIYATI", SqlDbType.Float).Value = Convert.ToSingle(txtAlisFiyati.Text);
            komut.Parameters.AddWithValue("@SATISFIYATI", SqlDbType.Float).Value = Convert.ToSingle(txtSatisFiyati.Text);
            komut.Parameters.AddWithValue("@ISLEM", SqlDbType.NVarChar).Value = "Alış";
            komut.ExecuteNonQuery();
            bgl.sqlbaglanti().Close();
            this.tBLISLEMLERTableAdapter.Fill(this.dbCRMDataSet11.TBLISLEMLER);
        }
    }
}
