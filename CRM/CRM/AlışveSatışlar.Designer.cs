
namespace CRM
{
    partial class AlışveSatışlar
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.txtAlisFiyati = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.lblSatisFiyati = new System.Windows.Forms.Label();
            this.lblAlisFiyati = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.cbUrunAd = new System.Windows.Forms.ComboBox();
            this.tBLURUNLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbCRMDataSet12 = new CRM.dbCRMDataSet12();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uRUNIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mIKTARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLISFIYATIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sATISFIYATIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıSLEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLISLEMLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbCRMDataSet11 = new CRM.dbCRMDataSet11();
            this.btnSatis = new System.Windows.Forms.Button();
            this.dbCRMDataSet1 = new CRM.dbCRMDataSet();
            this.tBLISLEMLERTableAdapter = new CRM.dbCRMDataSet11TableAdapters.TBLISLEMLERTableAdapter();
            this.tBLURUNLERTableAdapter = new CRM.dbCRMDataSet12TableAdapters.TBLURUNLERTableAdapter();
            this.btnalis = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBLURUNLERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLISLEMLERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1280, 642);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnalis);
            this.tabPage1.Controls.Add(this.txtSatisFiyati);
            this.tabPage1.Controls.Add(this.txtAlisFiyati);
            this.tabPage1.Controls.Add(this.txtMiktar);
            this.tabPage1.Controls.Add(this.lblSatisFiyati);
            this.tabPage1.Controls.Add(this.lblAlisFiyati);
            this.tabPage1.Controls.Add(this.lblMiktar);
            this.tabPage1.Controls.Add(this.cbUrunAd);
            this.tabPage1.Controls.Add(this.lblUrunAd);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnSatis);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1272, 613);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Satış İşlemi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatisFiyati.Location = new System.Drawing.Point(212, 350);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(220, 28);
            this.txtSatisFiyati.TabIndex = 10;
            this.txtSatisFiyati.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlisFiyati.Location = new System.Drawing.Point(212, 265);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(220, 28);
            this.txtAlisFiyati.TabIndex = 9;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktar.Location = new System.Drawing.Point(212, 187);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(220, 28);
            this.txtMiktar.TabIndex = 8;
            // 
            // lblSatisFiyati
            // 
            this.lblSatisFiyati.AutoSize = true;
            this.lblSatisFiyati.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatisFiyati.Location = new System.Drawing.Point(42, 353);
            this.lblSatisFiyati.Name = "lblSatisFiyati";
            this.lblSatisFiyati.Size = new System.Drawing.Size(134, 25);
            this.lblSatisFiyati.TabIndex = 7;
            this.lblSatisFiyati.Text = "Satış Fiyatı:";
            // 
            // lblAlisFiyati
            // 
            this.lblAlisFiyati.AutoSize = true;
            this.lblAlisFiyati.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlisFiyati.Location = new System.Drawing.Point(42, 268);
            this.lblAlisFiyati.Name = "lblAlisFiyati";
            this.lblAlisFiyati.Size = new System.Drawing.Size(120, 25);
            this.lblAlisFiyati.TabIndex = 6;
            this.lblAlisFiyati.Text = "Alış Fiyatı:";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMiktar.Location = new System.Drawing.Point(42, 190);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(85, 25);
            this.lblMiktar.TabIndex = 5;
            this.lblMiktar.Text = "Miktar:";
            // 
            // cbUrunAd
            // 
            this.cbUrunAd.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tBLURUNLERBindingSource, "id", true));
            this.cbUrunAd.DataSource = this.tBLURUNLERBindingSource;
            this.cbUrunAd.DisplayMember = "UrunAd";
            this.cbUrunAd.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbUrunAd.FormattingEnabled = true;
            this.cbUrunAd.Location = new System.Drawing.Point(212, 120);
            this.cbUrunAd.Name = "cbUrunAd";
            this.cbUrunAd.Size = new System.Drawing.Size(220, 28);
            this.cbUrunAd.TabIndex = 4;
            this.cbUrunAd.ValueMember = "id";
            this.cbUrunAd.SelectedIndexChanged += new System.EventHandler(this.cbUrunAd_SelectedIndexChanged);
            // 
            // tBLURUNLERBindingSource
            // 
            this.tBLURUNLERBindingSource.DataMember = "TBLURUNLER";
            this.tBLURUNLERBindingSource.DataSource = this.dbCRMDataSet12;
            // 
            // dbCRMDataSet12
            // 
            this.dbCRMDataSet12.DataSetName = "dbCRMDataSet12";
            this.dbCRMDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAd.Location = new System.Drawing.Point(42, 120);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(94, 25);
            this.lblUrunAd.TabIndex = 3;
            this.lblUrunAd.Text = "Ürün Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.uRUNIDDataGridViewTextBoxColumn,
            this.mIKTARDataGridViewTextBoxColumn,
            this.aLISFIYATIDataGridViewTextBoxColumn,
            this.sATISFIYATIDataGridViewTextBoxColumn,
            this.ıSLEMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLISLEMLERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(556, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(691, 390);
            this.dataGridView1.TabIndex = 2;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Width = 125;
            // 
            // uRUNIDDataGridViewTextBoxColumn
            // 
            this.uRUNIDDataGridViewTextBoxColumn.DataPropertyName = "URUNID";
            this.uRUNIDDataGridViewTextBoxColumn.HeaderText = "URUNID";
            this.uRUNIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uRUNIDDataGridViewTextBoxColumn.Name = "uRUNIDDataGridViewTextBoxColumn";
            this.uRUNIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // mIKTARDataGridViewTextBoxColumn
            // 
            this.mIKTARDataGridViewTextBoxColumn.DataPropertyName = "MIKTAR";
            this.mIKTARDataGridViewTextBoxColumn.HeaderText = "MIKTAR";
            this.mIKTARDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mIKTARDataGridViewTextBoxColumn.Name = "mIKTARDataGridViewTextBoxColumn";
            this.mIKTARDataGridViewTextBoxColumn.Width = 125;
            // 
            // aLISFIYATIDataGridViewTextBoxColumn
            // 
            this.aLISFIYATIDataGridViewTextBoxColumn.DataPropertyName = "ALISFIYATI";
            this.aLISFIYATIDataGridViewTextBoxColumn.HeaderText = "ALISFIYATI";
            this.aLISFIYATIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aLISFIYATIDataGridViewTextBoxColumn.Name = "aLISFIYATIDataGridViewTextBoxColumn";
            this.aLISFIYATIDataGridViewTextBoxColumn.Width = 125;
            // 
            // sATISFIYATIDataGridViewTextBoxColumn
            // 
            this.sATISFIYATIDataGridViewTextBoxColumn.DataPropertyName = "SATISFIYATI";
            this.sATISFIYATIDataGridViewTextBoxColumn.HeaderText = "SATISFIYATI";
            this.sATISFIYATIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sATISFIYATIDataGridViewTextBoxColumn.Name = "sATISFIYATIDataGridViewTextBoxColumn";
            this.sATISFIYATIDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıSLEMDataGridViewTextBoxColumn
            // 
            this.ıSLEMDataGridViewTextBoxColumn.DataPropertyName = "ISLEM";
            this.ıSLEMDataGridViewTextBoxColumn.HeaderText = "ISLEM";
            this.ıSLEMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıSLEMDataGridViewTextBoxColumn.Name = "ıSLEMDataGridViewTextBoxColumn";
            this.ıSLEMDataGridViewTextBoxColumn.Width = 125;
            // 
            // tBLISLEMLERBindingSource
            // 
            this.tBLISLEMLERBindingSource.DataMember = "TBLISLEMLER";
            this.tBLISLEMLERBindingSource.DataSource = this.dbCRMDataSet11;
            // 
            // dbCRMDataSet11
            // 
            this.dbCRMDataSet11.DataSetName = "dbCRMDataSet11";
            this.dbCRMDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSatis
            // 
            this.btnSatis.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatis.Location = new System.Drawing.Point(47, 468);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(117, 42);
            this.btnSatis.TabIndex = 1;
            this.btnSatis.Text = "Satış Yap";
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // dbCRMDataSet1
            // 
            this.dbCRMDataSet1.DataSetName = "dbCRMDataSet";
            this.dbCRMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLISLEMLERTableAdapter
            // 
            this.tBLISLEMLERTableAdapter.ClearBeforeFill = true;
            // 
            // tBLURUNLERTableAdapter
            // 
            this.tBLURUNLERTableAdapter.ClearBeforeFill = true;
            // 
            // btnalis
            // 
            this.btnalis.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnalis.Location = new System.Drawing.Point(317, 471);
            this.btnalis.Name = "btnalis";
            this.btnalis.Size = new System.Drawing.Size(115, 37);
            this.btnalis.TabIndex = 11;
            this.btnalis.Text = "Alış Yap";
            this.btnalis.UseVisualStyleBackColor = true;
            this.btnalis.Click += new System.EventHandler(this.btnalis_Click_1);
            // 
            // AlışveSatışlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 642);
            this.Controls.Add(this.tabControl1);
            this.Name = "AlışveSatışlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlışveSatışlar";
            this.Load += new System.EventHandler(this.AlışveSatışlar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBLURUNLERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLISLEMLERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSatis;
        private dbCRMDataSet dbCRMDataSet1;
        private dbCRMDataSet11 dbCRMDataSet11;
        private System.Windows.Forms.BindingSource tBLISLEMLERBindingSource;
        private dbCRMDataSet11TableAdapters.TBLISLEMLERTableAdapter tBLISLEMLERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uRUNIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIKTARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLISFIYATIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sATISFIYATIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıSLEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.TextBox txtAlisFiyati;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label lblSatisFiyati;
        private System.Windows.Forms.Label lblAlisFiyati;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.ComboBox cbUrunAd;
        private System.Windows.Forms.Label lblUrunAd;
        private dbCRMDataSet12 dbCRMDataSet12;
        private System.Windows.Forms.BindingSource tBLURUNLERBindingSource;
        private dbCRMDataSet12TableAdapters.TBLURUNLERTableAdapter tBLURUNLERTableAdapter;
        private System.Windows.Forms.Button btnalis;
    }
}