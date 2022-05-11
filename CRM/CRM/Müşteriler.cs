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
    public partial class Müşteriler : Form
    {
        baglanti bgl = new baglanti();
        public Müşteriler()
        {
            InitializeComponent();
        }

        private void Müşteriler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbMUSTERILERDataSet.TBLMUSTERILER' table. You can move, or remove it, as needed.
            this.tBLMUSTERILERTableAdapter1.Fill(this.dbMUSTERILERDataSet.TBLMUSTERILER);
            // TODO: This line of code loads data into the 'tBLPERSONELDATASET.TBLPERSONEL' table. You can move, or remove it, as needed.
            //this.tBLPERSONELTableAdapter.Fill(this.tBLPERSONELDATASET.TBLPERSONEL);
            // TODO: This line of code loads data into the 'dbCRMDataSet.TBLMUSTERILER' table. You can move, or remove it, as needed.
            //this.tBLMUSTERILERTableAdapter.Fill(this.dbCRMDataSet.TBLMUSTERILER);

        }
        private void temizle()
        {
            txtAd.Text = "";
            txtAdres.Text = "";
            txtEposta.Text = "";
            txtID.Text = "";
            txtPosition.Text = "";
            txtTel.Text = "";
            txtVergiD.Text = "";
            txtVergiNo.Text = "";
            txtYetkiliName.Text = "";
            cbMusteriAsama.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Müşteri Ekleme
            SqlCommand komut = new SqlCommand("Insert INTO TBLMUSTERILER (MUSTERIAD, MusteriYetkili, YetkiliEposta, YetkiliTel, YetkiliAdres, YetkiliPozisyon, VergiDairesi, VergiNo, MüsteriAsamasi) VALUES (@MUSTERI, @YETKILI, @EPOSTA, @ILETISIMNO, @ADRES, @POZ, @VERGİD, @VERGİNO, @ASAMA)", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@MUSTERI", SqlDbType.NVarChar).Value = txtAd.Text;
            komut.Parameters.AddWithValue("@YETKILI", SqlDbType.NVarChar).Value = txtYetkiliName.Text;
            komut.Parameters.AddWithValue("@EPOSTA", SqlDbType.NVarChar).Value = txtEposta.Text;
            komut.Parameters.AddWithValue("@ILETISIMNO", SqlDbType.NVarChar).Value = txtTel.Text;
            komut.Parameters.AddWithValue("@ADRES", SqlDbType.NVarChar).Value = txtAdres.Text;
            komut.Parameters.AddWithValue("@POZ", SqlDbType.NVarChar).Value = txtPosition.Text;
            komut.Parameters.AddWithValue("@VERGİD", SqlDbType.NVarChar).Value = txtVergiD.Text;
            komut.Parameters.AddWithValue("@VERGİNO", SqlDbType.NVarChar).Value = txtVergiNo.Text;
            komut.Parameters.AddWithValue("@ASAMA", SqlDbType.NVarChar).Value = cbMusteriAsama.Text;
            komut.ExecuteNonQuery();
            this.tBLMUSTERILERTableAdapter1.Fill(this.dbMUSTERILERDataSet.TBLMUSTERILER);
            temizle();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Tablodan Seçme
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtYetkiliName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtEposta.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtPosition.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtVergiD.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtVergiNo.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            cbMusteriAsama.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Müşteri Silme
            SqlCommand komut = new SqlCommand("Delete from TBLMUSTERILER where id=@ID", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text);
            komut.ExecuteNonQuery();
            this.tBLMUSTERILERTableAdapter1.Fill(this.dbMUSTERILERDataSet.TBLMUSTERILER);
            temizle();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBLMUSTERILER set MUSTERIAD = @MUSTERI, MusteriYetkili = @YETKILI, YetkiliEposta = @EPOSTA, YetkiliTel = @TEL, YetkiliAdres=@ADRES, YetkiliPozisyon = @POZ, VergiDairesi = @VERGID, VergiNo = @VERGINO, MüsteriAsamasi = @ASAMA WHERE id = @ID", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@MUSTERI", SqlDbType.NVarChar).Value = txtAd.Text;
            komut.Parameters.AddWithValue("@YETKILI", SqlDbType.NVarChar).Value = txtYetkiliName.Text;
            komut.Parameters.AddWithValue("@EPOSTA", SqlDbType.NVarChar).Value = txtEposta.Text;
            komut.Parameters.AddWithValue("@TEL", SqlDbType.NVarChar).Value = txtTel.Text;
            komut.Parameters.AddWithValue("@ADRES", SqlDbType.NVarChar).Value = txtAdres.Text;
            komut.Parameters.AddWithValue("@POZ", SqlDbType.NVarChar).Value = txtPosition.Text;
            komut.Parameters.AddWithValue("@VERGID", SqlDbType.NVarChar).Value = txtVergiD.Text;
            komut.Parameters.AddWithValue("@VERGINO", SqlDbType.NVarChar).Value = txtVergiNo.Text;
            komut.Parameters.AddWithValue("@ASAMA", SqlDbType.NVarChar).Value = cbMusteriAsama.Text;
            komut.Parameters.AddWithValue("ID", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text);
            komut.ExecuteNonQuery();
            this.tBLMUSTERILERTableAdapter1.Fill(this.dbMUSTERILERDataSet.TBLMUSTERILER);
            temizle();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TBLMUSTERILER WHERE MUSTERIAD like '%" + txtArama.Text + "%' or MusteriYetkili like '%"+txtArama.Text+"%'", bgl.sqlbaglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            if(txtArama.Text == "")
            {
                this.tBLMUSTERILERTableAdapter1.Fill(this.dbMUSTERILERDataSet.TBLMUSTERILER);
            }

        }
    }
}
