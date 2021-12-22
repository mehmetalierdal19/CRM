
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
            this.dbCRMDataSet2 = new CRM.dbCRMDataSet2();
            this.tBLKATEGORILERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLKATEGORILERTableAdapter = new CRM.dbCRMDataSet2TableAdapters.TBLKATEGORILERTableAdapter();
            this.kategoriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunSayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblKategoriAd = new System.Windows.Forms.Label();
            this.lblUrunSayisi = new System.Windows.Forms.Label();
            this.txtKategoriAd = new System.Windows.Forms.TextBox();
            this.txtUrunSayisi = new System.Windows.Forms.TextBox();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.btnKategoriSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLKATEGORILERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kategoriIDDataGridViewTextBoxColumn,
            this.kategoriAdDataGridViewTextBoxColumn,
            this.urunSayisiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLKATEGORILERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(636, 380);
            this.dataGridView1.TabIndex = 0;
            // 
            // dbCRMDataSet2
            // 
            this.dbCRMDataSet2.DataSetName = "dbCRMDataSet2";
            this.dbCRMDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLKATEGORILERBindingSource
            // 
            this.tBLKATEGORILERBindingSource.DataMember = "TBLKATEGORILER";
            this.tBLKATEGORILERBindingSource.DataSource = this.dbCRMDataSet2;
            // 
            // tBLKATEGORILERTableAdapter
            // 
            this.tBLKATEGORILERTableAdapter.ClearBeforeFill = true;
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
            // lblKategoriAd
            // 
            this.lblKategoriAd.AutoSize = true;
            this.lblKategoriAd.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategoriAd.Location = new System.Drawing.Point(759, 245);
            this.lblKategoriAd.Name = "lblKategoriAd";
            this.lblKategoriAd.Size = new System.Drawing.Size(168, 29);
            this.lblKategoriAd.TabIndex = 1;
            this.lblKategoriAd.Text = "Kategori Adı:";
            // 
            // lblUrunSayisi
            // 
            this.lblUrunSayisi.AutoSize = true;
            this.lblUrunSayisi.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunSayisi.Location = new System.Drawing.Point(759, 364);
            this.lblUrunSayisi.Name = "lblUrunSayisi";
            this.lblUrunSayisi.Size = new System.Drawing.Size(159, 29);
            this.lblUrunSayisi.TabIndex = 2;
            this.lblUrunSayisi.Text = "Ürün Sayısı:";
            // 
            // txtKategoriAd
            // 
            this.txtKategoriAd.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKategoriAd.Location = new System.Drawing.Point(989, 248);
            this.txtKategoriAd.Name = "txtKategoriAd";
            this.txtKategoriAd.Size = new System.Drawing.Size(255, 28);
            this.txtKategoriAd.TabIndex = 3;
            // 
            // txtUrunSayisi
            // 
            this.txtUrunSayisi.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunSayisi.Location = new System.Drawing.Point(989, 367);
            this.txtUrunSayisi.Name = "txtUrunSayisi";
            this.txtUrunSayisi.Size = new System.Drawing.Size(255, 28);
            this.txtUrunSayisi.TabIndex = 4;
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriEkle.Location = new System.Drawing.Point(764, 463);
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
            this.btnKategoriSil.Location = new System.Drawing.Point(1111, 463);
            this.btnKategoriSil.Name = "btnKategoriSil";
            this.btnKategoriSil.Size = new System.Drawing.Size(133, 43);
            this.btnKategoriSil.TabIndex = 6;
            this.btnKategoriSil.Text = "Sil";
            this.btnKategoriSil.UseVisualStyleBackColor = true;
            // 
            // ÜrünKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1497, 745);
            this.Controls.Add(this.btnKategoriSil);
            this.Controls.Add(this.btnKategoriEkle);
            this.Controls.Add(this.txtUrunSayisi);
            this.Controls.Add(this.txtKategoriAd);
            this.Controls.Add(this.lblUrunSayisi);
            this.Controls.Add(this.lblKategoriAd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ÜrünKategori";
            this.Text = "Ürün Kategori";
            this.Load += new System.EventHandler(this.ÜrünKategori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLKATEGORILERBindingSource)).EndInit();
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
    }
}