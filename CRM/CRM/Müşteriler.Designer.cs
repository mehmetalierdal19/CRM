
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tBLMUSTERILERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbCRMDataSet = new CRM.dbCRMDataSet();
            this.tBLMUSTERILERTableAdapter = new CRM.dbCRMDataSetTableAdapters.TBLMUSTERILERTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblSehir = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUSTERIADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUSTERISOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEHIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıLETISIMNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMUSTERILERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet)).BeginInit();
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
            this.mUSTERIADDataGridViewTextBoxColumn,
            this.mUSTERISOYADDataGridViewTextBoxColumn,
            this.sEHIRDataGridViewTextBoxColumn,
            this.ıLETISIMNODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLMUSTERILERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(757, 474);
            this.dataGridView1.TabIndex = 0;
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(912, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAd
            // 
            this.lblAd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(907, 148);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(51, 30);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(907, 242);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(83, 25);
            this.lblSoyad.TabIndex = 3;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSehir.Location = new System.Drawing.Point(907, 330);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(75, 25);
            this.lblSehir.TabIndex = 4;
            this.lblSehir.Text = "Şehir:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTel.Location = new System.Drawing.Point(907, 414);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(196, 25);
            this.lblTel.TabIndex = 5;
            this.lblTel.Text = "Telefon Numarası:";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(1147, 150);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(280, 28);
            this.txtAd.TabIndex = 6;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(1147, 243);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(280, 28);
            this.txtSoyad.TabIndex = 7;
            // 
            // txtSehir
            // 
            this.txtSehir.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSehir.Location = new System.Drawing.Point(1147, 331);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(280, 28);
            this.txtSehir.TabIndex = 8;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTel.Location = new System.Drawing.Point(1147, 415);
            this.txtTel.MaxLength = 11;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(280, 28);
            this.txtTel.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(1108, 512);
            this.button2.Name = "btnMusteriSil";
            this.button2.Size = new System.Drawing.Size(131, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(1296, 512);
            this.button3.Name = "btnMusteriGuncelle";
            this.button3.Size = new System.Drawing.Size(131, 38);
            this.button3.TabIndex = 11;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Müşteri ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mUSTERIADDataGridViewTextBoxColumn
            // 
            this.mUSTERIADDataGridViewTextBoxColumn.DataPropertyName = "MUSTERIAD";
            this.mUSTERIADDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.mUSTERIADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mUSTERIADDataGridViewTextBoxColumn.Name = "mUSTERIADDataGridViewTextBoxColumn";
            this.mUSTERIADDataGridViewTextBoxColumn.Width = 125;
            // 
            // mUSTERISOYADDataGridViewTextBoxColumn
            // 
            this.mUSTERISOYADDataGridViewTextBoxColumn.DataPropertyName = "MUSTERISOYAD";
            this.mUSTERISOYADDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.mUSTERISOYADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mUSTERISOYADDataGridViewTextBoxColumn.Name = "mUSTERISOYADDataGridViewTextBoxColumn";
            this.mUSTERISOYADDataGridViewTextBoxColumn.Width = 125;
            // 
            // sEHIRDataGridViewTextBoxColumn
            // 
            this.sEHIRDataGridViewTextBoxColumn.DataPropertyName = "SEHIR";
            this.sEHIRDataGridViewTextBoxColumn.HeaderText = "Şehir";
            this.sEHIRDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sEHIRDataGridViewTextBoxColumn.Name = "sEHIRDataGridViewTextBoxColumn";
            this.sEHIRDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıLETISIMNODataGridViewTextBoxColumn
            // 
            this.ıLETISIMNODataGridViewTextBoxColumn.DataPropertyName = "ILETISIMNO";
            this.ıLETISIMNODataGridViewTextBoxColumn.HeaderText = "Telefon Numarası";
            this.ıLETISIMNODataGridViewTextBoxColumn.MaxInputLength = 11;
            this.ıLETISIMNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıLETISIMNODataGridViewTextBoxColumn.Name = "ıLETISIMNODataGridViewTextBoxColumn";
            this.ıLETISIMNODataGridViewTextBoxColumn.Width = 125;
            // 
            // Müşteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1505, 680);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtSehir);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblSehir);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Müşteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.Müşteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMUSTERILERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbCRMDataSet dbCRMDataSet;
        private System.Windows.Forms.BindingSource tBLMUSTERILERBindingSource;
        private dbCRMDataSetTableAdapters.TBLMUSTERILERTableAdapter tBLMUSTERILERTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtSehir;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUSTERIADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUSTERISOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEHIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıLETISIMNODataGridViewTextBoxColumn;
    }
}