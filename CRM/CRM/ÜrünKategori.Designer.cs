
namespace CRM
{
    partial class ÜrünKategori
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kategoriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunSayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLKATEGORILERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbCRMDataSet2 = new CRM.dbCRMDataSet2();
            this.tBLKATEGORILERTableAdapter = new CRM.dbCRMDataSet2TableAdapters.TBLKATEGORILERTableAdapter();
            this.lblKategoriAd = new System.Windows.Forms.Label();
            this.lblUrunSayisi = new System.Windows.Forms.Label();
            this.txtKategoriAd = new System.Windows.Forms.TextBox();
            this.txtUrunSayisi = new System.Windows.Forms.TextBox();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.btnKategoriSil = new System.Windows.Forms.Button();
            this.btnKategoriGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKategoriid = new System.Windows.Forms.TextBox();
            this.txtKategoriArama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLKATEGORILERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kategoriIDDataGridViewTextBoxColumn,
            this.kategoriAdDataGridViewTextBoxColumn,
            this.urunSayisiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLKATEGORILERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(486, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(636, 380);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // kategoriIDDataGridViewTextBoxColumn
            // 
            this.kategoriIDDataGridViewTextBoxColumn.DataPropertyName = "KategoriID";
            this.kategoriIDDataGridViewTextBoxColumn.HeaderText = "KategoriID";
            this.kategoriIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kategoriIDDataGridViewTextBoxColumn.Name = "kategoriIDDataGridViewTextBoxColumn";
            this.kategoriIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.kategoriIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // kategoriAdDataGridViewTextBoxColumn
            // 
            this.kategoriAdDataGridViewTextBoxColumn.DataPropertyName = "KategoriAd";
            this.kategoriAdDataGridViewTextBoxColumn.HeaderText = "KategoriAd";
            this.kategoriAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kategoriAdDataGridViewTextBoxColumn.Name = "kategoriAdDataGridViewTextBoxColumn";
            this.kategoriAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunSayisiDataGridViewTextBoxColumn
            // 
            this.urunSayisiDataGridViewTextBoxColumn.DataPropertyName = "UrunSayisi";
            this.urunSayisiDataGridViewTextBoxColumn.HeaderText = "UrunSayisi";
            this.urunSayisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunSayisiDataGridViewTextBoxColumn.Name = "urunSayisiDataGridViewTextBoxColumn";
            this.urunSayisiDataGridViewTextBoxColumn.Width = 125;
            // 
            // tBLKATEGORILERBindingSource
            // 
            this.tBLKATEGORILERBindingSource.DataMember = "TBLKATEGORILER";
            this.tBLKATEGORILERBindingSource.DataSource = this.dbCRMDataSet2;
            // 
            // dbCRMDataSet2
            // 
            this.dbCRMDataSet2.DataSetName = "dbCRMDataSet2";
            this.dbCRMDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLKATEGORILERTableAdapter
            // 
            this.tBLKATEGORILERTableAdapter.ClearBeforeFill = true;
            // 
            // lblKategoriAd
            // 
            this.lblKategoriAd.AutoSize = true;
            this.lblKategoriAd.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategoriAd.Location = new System.Drawing.Point(509, 505);
            this.lblKategoriAd.Name = "lblKategoriAd";
            this.lblKategoriAd.Size = new System.Drawing.Size(168, 29);
            this.lblKategoriAd.TabIndex = 1;
            this.lblKategoriAd.Text = "Kategori Adı:";
            // 
            // lblUrunSayisi
            // 
            this.lblUrunSayisi.AutoSize = true;
            this.lblUrunSayisi.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunSayisi.Location = new System.Drawing.Point(1010, 506);
            this.lblUrunSayisi.Name = "lblUrunSayisi";
            this.lblUrunSayisi.Size = new System.Drawing.Size(159, 29);
            this.lblUrunSayisi.TabIndex = 2;
            this.lblUrunSayisi.Text = "Ürün Sayısı:";
            // 
            // txtKategoriAd
            // 
            this.txtKategoriAd.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKategoriAd.Location = new System.Drawing.Point(696, 509);
            this.txtKategoriAd.Name = "txtKategoriAd";
            this.txtKategoriAd.Size = new System.Drawing.Size(255, 28);
            this.txtKategoriAd.TabIndex = 3;
            // 
            // txtUrunSayisi
            // 
            this.txtUrunSayisi.Enabled = false;
            this.txtUrunSayisi.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunSayisi.Location = new System.Drawing.Point(1204, 509);
            this.txtUrunSayisi.Name = "txtUrunSayisi";
            this.txtUrunSayisi.Size = new System.Drawing.Size(255, 28);
            this.txtUrunSayisi.TabIndex = 4;
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriEkle.Location = new System.Drawing.Point(502, 627);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(133, 43);
            this.btnKategoriEkle.TabIndex = 5;
            this.btnKategoriEkle.Text = "Ekle";
            this.btnKategoriEkle.UseVisualStyleBackColor = true;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // btnKategoriSil
            // 
            this.btnKategoriSil.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriSil.Location = new System.Drawing.Point(674, 627);
            this.btnKategoriSil.Name = "btnKategoriSil";
            this.btnKategoriSil.Size = new System.Drawing.Size(133, 43);
            this.btnKategoriSil.TabIndex = 6;
            this.btnKategoriSil.Text = "Sil";
            this.btnKategoriSil.UseVisualStyleBackColor = true;
            this.btnKategoriSil.Click += new System.EventHandler(this.btnKategoriSil_Click);
            // 
            // btnKategoriGuncelle
            // 
            this.btnKategoriGuncelle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriGuncelle.Location = new System.Drawing.Point(849, 627);
            this.btnKategoriGuncelle.Name = "btnKategoriGuncelle";
            this.btnKategoriGuncelle.Size = new System.Drawing.Size(133, 43);
            this.btnKategoriGuncelle.TabIndex = 7;
            this.btnKategoriGuncelle.Text = "Güncelle";
            this.btnKategoriGuncelle.UseVisualStyleBackColor = true;
            this.btnKategoriGuncelle.Click += new System.EventHandler(this.btnKategoriGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kategori ID:";
            // 
            // txtKategoriid
            // 
            this.txtKategoriid.Enabled = false;
            this.txtKategoriid.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKategoriid.Location = new System.Drawing.Point(202, 506);
            this.txtKategoriid.Name = "txtKategoriid";
            this.txtKategoriid.Size = new System.Drawing.Size(255, 28);
            this.txtKategoriid.TabIndex = 9;
            // 
            // txtKategoriArama
            // 
            this.txtKategoriArama.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKategoriArama.Location = new System.Drawing.Point(940, 33);
            this.txtKategoriArama.Name = "txtKategoriArama";
            this.txtKategoriArama.Size = new System.Drawing.Size(182, 23);
            this.txtKategoriArama.TabIndex = 10;
            this.txtKategoriArama.TextChanged += new System.EventHandler(this.txtKategoriArama_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(761, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "* Kategori Adı Giriniz";
            // 
            // ÜrünKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1497, 745);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKategoriArama);
            this.Controls.Add(this.txtKategoriid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKategoriGuncelle);
            this.Controls.Add(this.btnKategoriSil);
            this.Controls.Add(this.btnKategoriEkle);
            this.Controls.Add(this.txtUrunSayisi);
            this.Controls.Add(this.txtKategoriAd);
            this.Controls.Add(this.lblUrunSayisi);
            this.Controls.Add(this.lblKategoriAd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ÜrünKategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Kategori";
            this.Load += new System.EventHandler(this.ÜrünKategori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLKATEGORILERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbCRMDataSet2 dbCRMDataSet2;
        private System.Windows.Forms.BindingSource tBLKATEGORILERBindingSource;
        private dbCRMDataSet2TableAdapters.TBLKATEGORILERTableAdapter tBLKATEGORILERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunSayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblKategoriAd;
        private System.Windows.Forms.Label lblUrunSayisi;
        private System.Windows.Forms.TextBox txtKategoriAd;
        private System.Windows.Forms.TextBox txtUrunSayisi;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.Button btnKategoriSil;
        private System.Windows.Forms.Button btnKategoriGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKategoriid;
        private System.Windows.Forms.TextBox txtKategoriArama;
        private System.Windows.Forms.Label label2;
    }
}