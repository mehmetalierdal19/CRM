
namespace CRM
{
    partial class Ürünler
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunKategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisFiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLURUNLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbCRMDataSet1 = new CRM.dbCRMDataSet1();
            this.tBLURUNLERTableAdapter = new CRM.dbCRMDataSet1TableAdapters.TBLURUNLERTableAdapter();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.lblUrunKategori = new System.Windows.Forms.Label();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblSatisFiyati = new System.Windows.Forms.Label();
            this.lblDepo = new System.Windows.Forms.Label();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.cbMarka = new System.Windows.Forms.ComboBox();
            this.cbDepo = new System.Windows.Forms.ComboBox();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.txtSatisFiyat = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dbCRMDataSet5 = new CRM.dbCRMDataSet5();
            this.tBLURUNLERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tBLURUNLERTableAdapter1 = new CRM.dbCRMDataSet5TableAdapters.TBLURUNLERTableAdapter();
            this.dbCRMDataSet6 = new CRM.dbCRMDataSet6();
            this.tBLKATEGORILERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLKATEGORILERTableAdapter = new CRM.dbCRMDataSet6TableAdapters.TBLKATEGORILERTableAdapter();
            this.dbCRMDataSet7 = new CRM.dbCRMDataSet7();
            this.tBLMARKALARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLMARKALARTableAdapter = new CRM.dbCRMDataSet7TableAdapters.TBLMARKALARTableAdapter();
            this.dbCRMDataSet8 = new CRM.dbCRMDataSet8();
            this.tBLDEPOLARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLDEPOLARTableAdapter = new CRM.dbCRMDataSet8TableAdapters.TBLDEPOLARTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLURUNLERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLURUNLERBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLKATEGORILERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMARKALARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDEPOLARBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.urunKategoriDataGridViewTextBoxColumn,
            this.urunAdDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.satisFiyatiDataGridViewTextBoxColumn,
            this.depoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLURUNLERBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(807, 496);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunKategoriDataGridViewTextBoxColumn
            // 
            this.urunKategoriDataGridViewTextBoxColumn.DataPropertyName = "UrunKategori";
            this.urunKategoriDataGridViewTextBoxColumn.HeaderText = "UrunKategori";
            this.urunKategoriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunKategoriDataGridViewTextBoxColumn.Name = "urunKategoriDataGridViewTextBoxColumn";
            this.urunKategoriDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunAdDataGridViewTextBoxColumn
            // 
            this.urunAdDataGridViewTextBoxColumn.DataPropertyName = "UrunAd";
            this.urunAdDataGridViewTextBoxColumn.HeaderText = "UrunAd";
            this.urunAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunAdDataGridViewTextBoxColumn.Name = "urunAdDataGridViewTextBoxColumn";
            this.urunAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            this.markaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            this.markaDataGridViewTextBoxColumn.Width = 125;
            // 
            // satisFiyatiDataGridViewTextBoxColumn
            // 
            this.satisFiyatiDataGridViewTextBoxColumn.DataPropertyName = "SatisFiyati";
            this.satisFiyatiDataGridViewTextBoxColumn.HeaderText = "SatisFiyati";
            this.satisFiyatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.satisFiyatiDataGridViewTextBoxColumn.Name = "satisFiyatiDataGridViewTextBoxColumn";
            this.satisFiyatiDataGridViewTextBoxColumn.Width = 125;
            // 
            // depoDataGridViewTextBoxColumn
            // 
            this.depoDataGridViewTextBoxColumn.DataPropertyName = "Depo";
            this.depoDataGridViewTextBoxColumn.HeaderText = "Depo";
            this.depoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.depoDataGridViewTextBoxColumn.Name = "depoDataGridViewTextBoxColumn";
            this.depoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tBLURUNLERBindingSource
            // 
            this.tBLURUNLERBindingSource.DataMember = "TBLURUNLER";
            this.tBLURUNLERBindingSource.DataSource = this.dbCRMDataSet1;
            // 
            // dbCRMDataSet1
            // 
            this.dbCRMDataSet1.DataSetName = "dbCRMDataSet1";
            this.dbCRMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLURUNLERTableAdapter
            // 
            this.tBLURUNLERTableAdapter.ClearBeforeFill = true;
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriEkle.Location = new System.Drawing.Point(870, 628);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(151, 37);
            this.btnMusteriEkle.TabIndex = 1;
            this.btnMusteriEkle.Text = "Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // lblUrunKategori
            // 
            this.lblUrunKategori.AutoSize = true;
            this.lblUrunKategori.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunKategori.Location = new System.Drawing.Point(865, 169);
            this.lblUrunKategori.Name = "lblUrunKategori";
            this.lblUrunKategori.Size = new System.Drawing.Size(178, 25);
            this.lblUrunKategori.TabIndex = 2;
            this.lblUrunKategori.Text = "Ürün Kategorisi:";
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAd.Location = new System.Drawing.Point(865, 259);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(110, 25);
            this.lblUrunAd.TabIndex = 3;
            this.lblUrunAd.Text = "Ürün Adı:";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarka.Location = new System.Drawing.Point(865, 341);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(83, 25);
            this.lblMarka.TabIndex = 4;
            this.lblMarka.Text = "Marka:";
            // 
            // lblSatisFiyati
            // 
            this.lblSatisFiyati.AutoSize = true;
            this.lblSatisFiyati.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatisFiyati.Location = new System.Drawing.Point(865, 427);
            this.lblSatisFiyati.Name = "lblSatisFiyati";
            this.lblSatisFiyati.Size = new System.Drawing.Size(134, 25);
            this.lblSatisFiyati.TabIndex = 5;
            this.lblSatisFiyati.Text = "Satış Fiyatı:";
            this.lblSatisFiyati.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDepo
            // 
            this.lblDepo.AutoSize = true;
            this.lblDepo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepo.Location = new System.Drawing.Point(865, 528);
            this.lblDepo.Name = "lblDepo";
            this.lblDepo.Size = new System.Drawing.Size(72, 25);
            this.lblDepo.TabIndex = 6;
            this.lblDepo.Text = "Depo:";
            // 
            // cbKategori
            // 
            this.cbKategori.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tBLKATEGORILERBindingSource, "KategoriID", true));
            this.cbKategori.DataSource = this.tBLKATEGORILERBindingSource;
            this.cbKategori.DisplayMember = "KategoriAd";
            this.cbKategori.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(1118, 169);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(345, 28);
            this.cbKategori.TabIndex = 7;
            this.cbKategori.ValueMember = "KategoriID";
            // 
            // cbMarka
            // 
            this.cbMarka.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tBLMARKALARBindingSource, "MarkaID", true));
            this.cbMarka.DataSource = this.tBLMARKALARBindingSource;
            this.cbMarka.DisplayMember = "MarkaAd";
            this.cbMarka.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMarka.FormattingEnabled = true;
            this.cbMarka.Location = new System.Drawing.Point(1118, 342);
            this.cbMarka.Name = "cbMarka";
            this.cbMarka.Size = new System.Drawing.Size(345, 28);
            this.cbMarka.TabIndex = 8;
            this.cbMarka.ValueMember = "MarkaID";
            // 
            // cbDepo
            // 
            this.cbDepo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tBLDEPOLARBindingSource, "DepoID", true));
            this.cbDepo.DataSource = this.tBLDEPOLARBindingSource;
            this.cbDepo.DisplayMember = "DepoAd";
            this.cbDepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbDepo.FormattingEnabled = true;
            this.cbDepo.Location = new System.Drawing.Point(1118, 530);
            this.cbDepo.Name = "cbDepo";
            this.cbDepo.Size = new System.Drawing.Size(345, 28);
            this.cbDepo.TabIndex = 9;
            this.cbDepo.ValueMember = "DepoID";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAd.Location = new System.Drawing.Point(1118, 260);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(345, 28);
            this.txtUrunAd.TabIndex = 10;
            // 
            // txtSatisFiyat
            // 
            this.txtSatisFiyat.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatisFiyat.Location = new System.Drawing.Point(1118, 428);
            this.txtSatisFiyat.Name = "txtSatisFiyat";
            this.txtSatisFiyat.Size = new System.Drawing.Size(345, 28);
            this.txtSatisFiyat.TabIndex = 11;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(1090, 628);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(151, 37);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(1312, 628);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(151, 37);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // dbCRMDataSet5
            // 
            this.dbCRMDataSet5.DataSetName = "dbCRMDataSet5";
            this.dbCRMDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLURUNLERBindingSource1
            // 
            this.tBLURUNLERBindingSource1.DataMember = "TBLURUNLER";
            this.tBLURUNLERBindingSource1.DataSource = this.dbCRMDataSet5;
            // 
            // tBLURUNLERTableAdapter1
            // 
            this.tBLURUNLERTableAdapter1.ClearBeforeFill = true;
            // 
            // dbCRMDataSet6
            // 
            this.dbCRMDataSet6.DataSetName = "dbCRMDataSet6";
            this.dbCRMDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLKATEGORILERBindingSource
            // 
            this.tBLKATEGORILERBindingSource.DataMember = "TBLKATEGORILER";
            this.tBLKATEGORILERBindingSource.DataSource = this.dbCRMDataSet6;
            // 
            // tBLKATEGORILERTableAdapter
            // 
            this.tBLKATEGORILERTableAdapter.ClearBeforeFill = true;
            // 
            // dbCRMDataSet7
            // 
            this.dbCRMDataSet7.DataSetName = "dbCRMDataSet7";
            this.dbCRMDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLMARKALARBindingSource
            // 
            this.tBLMARKALARBindingSource.DataMember = "TBLMARKALAR";
            this.tBLMARKALARBindingSource.DataSource = this.dbCRMDataSet7;
            // 
            // tBLMARKALARTableAdapter
            // 
            this.tBLMARKALARTableAdapter.ClearBeforeFill = true;
            // 
            // dbCRMDataSet8
            // 
            this.dbCRMDataSet8.DataSetName = "dbCRMDataSet8";
            this.dbCRMDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLDEPOLARBindingSource
            // 
            this.tBLDEPOLARBindingSource.DataMember = "TBLDEPOLAR";
            this.tBLDEPOLARBindingSource.DataSource = this.dbCRMDataSet8;
            // 
            // tBLDEPOLARTableAdapter
            // 
            this.tBLDEPOLARTableAdapter.ClearBeforeFill = true;
            // 
            // Ürünler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1532, 677);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtSatisFiyat);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.cbDepo);
            this.Controls.Add(this.cbMarka);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.lblDepo);
            this.Controls.Add(this.lblSatisFiyati);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.lblUrunAd);
            this.Controls.Add(this.lblUrunKategori);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ürünler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Ürünler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLURUNLERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLURUNLERBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLKATEGORILERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMARKALARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDEPOLARBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbCRMDataSet1 dbCRMDataSet1;
        private System.Windows.Forms.BindingSource tBLURUNLERBindingSource;
        private dbCRMDataSet1TableAdapters.TBLURUNLERTableAdapter tBLURUNLERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisFiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Label lblUrunKategori;
        private System.Windows.Forms.Label lblUrunAd;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblSatisFiyati;
        private System.Windows.Forms.Label lblDepo;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.ComboBox cbMarka;
        private System.Windows.Forms.ComboBox cbDepo;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.TextBox txtSatisFiyat;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private dbCRMDataSet5 dbCRMDataSet5;
        private System.Windows.Forms.BindingSource tBLURUNLERBindingSource1;
        private dbCRMDataSet5TableAdapters.TBLURUNLERTableAdapter tBLURUNLERTableAdapter1;
        private dbCRMDataSet6 dbCRMDataSet6;
        private System.Windows.Forms.BindingSource tBLKATEGORILERBindingSource;
        private dbCRMDataSet6TableAdapters.TBLKATEGORILERTableAdapter tBLKATEGORILERTableAdapter;
        private dbCRMDataSet7 dbCRMDataSet7;
        private System.Windows.Forms.BindingSource tBLMARKALARBindingSource;
        private dbCRMDataSet7TableAdapters.TBLMARKALARTableAdapter tBLMARKALARTableAdapter;
        private dbCRMDataSet8 dbCRMDataSet8;
        private System.Windows.Forms.BindingSource tBLDEPOLARBindingSource;
        private dbCRMDataSet8TableAdapters.TBLDEPOLARTableAdapter tBLDEPOLARTableAdapter;
    }
}