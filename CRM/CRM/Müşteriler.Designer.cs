
namespace CRM
{
    partial class Müşteriler
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
            this.tBLMUSTERILERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbCRMDataSet = new CRM.dbCRMDataSet();
            this.tBLMUSTERILERTableAdapter = new CRM.dbCRMDataSetTableAdapters.TBLMUSTERILERTableAdapter();
            this.tBLMUSTERILERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbCRMDataSet1 = new CRM.dbCRMDataSet1();
            this.tBLMUSTERILERTableAdapter1 = new CRM.dbCRMDataSet1TableAdapters.TBLMUSTERILERTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbCRMDataSet2 = new CRM.dbCRMDataSet2();
            this.tBLMUSTERILERBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tBLMUSTERILERTableAdapter2 = new CRM.dbCRMDataSet2TableAdapters.TBLMUSTERILERTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUSTERIADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUSTERISOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEHIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıLETISIMNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMUSTERILERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMUSTERILERBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMUSTERILERBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tBLMUSTERILERBindingSource
            // 
            this.tBLMUSTERILERBindingSource.DataMember = "TBLMUSTERILER";
            this.tBLMUSTERILERBindingSource.DataSource = this.dbCRMDataSet;
            // 
            // dbCRMDataSet
            // 
            this.dbCRMDataSet.DataSetName = "dbCRMDataSet";
            this.dbCRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLMUSTERILERTableAdapter
            // 
            this.tBLMUSTERILERTableAdapter.ClearBeforeFill = true;
            // 
            // tBLMUSTERILERBindingSource1
            // 
            this.tBLMUSTERILERBindingSource1.DataMember = "TBLMUSTERILER";
            this.tBLMUSTERILERBindingSource1.DataSource = this.dbCRMDataSet1;
            // 
            // dbCRMDataSet1
            // 
            this.dbCRMDataSet1.DataSetName = "dbCRMDataSet1";
            this.dbCRMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLMUSTERILERTableAdapter1
            // 
            this.tBLMUSTERILERTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.mUSTERIADDataGridViewTextBoxColumn,
            this.mUSTERISOYADDataGridViewTextBoxColumn,
            this.sEHIRDataGridViewTextBoxColumn,
            this.ıLETISIMNODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLMUSTERILERBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(786, 449);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dbCRMDataSet2
            // 
            this.dbCRMDataSet2.DataSetName = "dbCRMDataSet2";
            this.dbCRMDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLMUSTERILERBindingSource2
            // 
            this.tBLMUSTERILERBindingSource2.DataMember = "TBLMUSTERILER";
            this.tBLMUSTERILERBindingSource2.DataSource = this.dbCRMDataSet2;
            // 
            // tBLMUSTERILERTableAdapter2
            // 
            this.tBLMUSTERILERTableAdapter2.ClearBeforeFill = true;
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
            // mUSTERIADDataGridViewTextBoxColumn
            // 
            this.mUSTERIADDataGridViewTextBoxColumn.DataPropertyName = "MUSTERIAD";
            this.mUSTERIADDataGridViewTextBoxColumn.HeaderText = "MUSTERIAD";
            this.mUSTERIADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mUSTERIADDataGridViewTextBoxColumn.Name = "mUSTERIADDataGridViewTextBoxColumn";
            this.mUSTERIADDataGridViewTextBoxColumn.Width = 125;
            // 
            // mUSTERISOYADDataGridViewTextBoxColumn
            // 
            this.mUSTERISOYADDataGridViewTextBoxColumn.DataPropertyName = "MUSTERISOYAD";
            this.mUSTERISOYADDataGridViewTextBoxColumn.HeaderText = "MUSTERISOYAD";
            this.mUSTERISOYADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mUSTERISOYADDataGridViewTextBoxColumn.Name = "mUSTERISOYADDataGridViewTextBoxColumn";
            this.mUSTERISOYADDataGridViewTextBoxColumn.Width = 125;
            // 
            // sEHIRDataGridViewTextBoxColumn
            // 
            this.sEHIRDataGridViewTextBoxColumn.DataPropertyName = "SEHIR";
            this.sEHIRDataGridViewTextBoxColumn.HeaderText = "SEHIR";
            this.sEHIRDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sEHIRDataGridViewTextBoxColumn.Name = "sEHIRDataGridViewTextBoxColumn";
            this.sEHIRDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıLETISIMNODataGridViewTextBoxColumn
            // 
            this.ıLETISIMNODataGridViewTextBoxColumn.DataPropertyName = "ILETISIMNO";
            this.ıLETISIMNODataGridViewTextBoxColumn.HeaderText = "ILETISIMNO";
            this.ıLETISIMNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıLETISIMNODataGridViewTextBoxColumn.Name = "ıLETISIMNODataGridViewTextBoxColumn";
            this.ıLETISIMNODataGridViewTextBoxColumn.Width = 125;
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(12, 458);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(96, 34);
            this.btnMusteriEkle.TabIndex = 1;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // Müşteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 532);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Müşteriler";
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.Müşteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLMUSTERILERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMUSTERILERBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMUSTERILERBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private dbCRMDataSet dbCRMDataSet;
        private System.Windows.Forms.BindingSource tBLMUSTERILERBindingSource;
        private dbCRMDataSetTableAdapters.TBLMUSTERILERTableAdapter tBLMUSTERILERTableAdapter;
        private dbCRMDataSet1 dbCRMDataSet1;
        private System.Windows.Forms.BindingSource tBLMUSTERILERBindingSource1;
        private dbCRMDataSet1TableAdapters.TBLMUSTERILERTableAdapter tBLMUSTERILERTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dbCRMDataSet2 dbCRMDataSet2;
        private System.Windows.Forms.BindingSource tBLMUSTERILERBindingSource2;
        private dbCRMDataSet2TableAdapters.TBLMUSTERILERTableAdapter tBLMUSTERILERTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUSTERIADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUSTERISOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEHIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıLETISIMNODataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnMusteriEkle;
    }
}