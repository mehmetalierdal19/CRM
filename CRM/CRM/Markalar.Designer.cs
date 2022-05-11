
namespace CRM
{
    partial class Markalar
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
            this.markaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLMARKALARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbCRMDataSet3 = new CRM.dbCRMDataSet3();
            this.tBLMARKALARTableAdapter = new CRM.dbCRMDataSet3TableAdapters.TBLMARKALARTableAdapter();
            this.lblMarkaAd = new System.Windows.Forms.Label();
            this.txtMarkaAd = new System.Windows.Forms.TextBox();
            this.btnMarkaEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMARKALARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.markaIDDataGridViewTextBoxColumn,
            this.markaAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLMARKALARBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(367, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(454, 285);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // markaIDDataGridViewTextBoxColumn
            // 
            this.markaIDDataGridViewTextBoxColumn.DataPropertyName = "MarkaID";
            this.markaIDDataGridViewTextBoxColumn.HeaderText = "MarkaID";
            this.markaIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.markaIDDataGridViewTextBoxColumn.Name = "markaIDDataGridViewTextBoxColumn";
            this.markaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.markaIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // markaAdDataGridViewTextBoxColumn
            // 
            this.markaAdDataGridViewTextBoxColumn.DataPropertyName = "MarkaAd";
            this.markaAdDataGridViewTextBoxColumn.HeaderText = "MarkaAd";
            this.markaAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.markaAdDataGridViewTextBoxColumn.Name = "markaAdDataGridViewTextBoxColumn";
            this.markaAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // tBLMARKALARBindingSource
            // 
            this.tBLMARKALARBindingSource.DataMember = "TBLMARKALAR";
            this.tBLMARKALARBindingSource.DataSource = this.dbCRMDataSet3;
            // 
            // dbCRMDataSet3
            // 
            this.dbCRMDataSet3.DataSetName = "dbCRMDataSet3";
            this.dbCRMDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLMARKALARTableAdapter
            // 
            this.tBLMARKALARTableAdapter.ClearBeforeFill = true;
            // 
            // lblMarkaAd
            // 
            this.lblMarkaAd.AutoSize = true;
            this.lblMarkaAd.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarkaAd.Location = new System.Drawing.Point(608, 390);
            this.lblMarkaAd.Name = "lblMarkaAd";
            this.lblMarkaAd.Size = new System.Drawing.Size(170, 34);
            this.lblMarkaAd.TabIndex = 1;
            this.lblMarkaAd.Text = "Marka Adı:";
            // 
            // txtMarkaAd
            // 
            this.txtMarkaAd.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMarkaAd.Location = new System.Drawing.Point(809, 395);
            this.txtMarkaAd.Name = "txtMarkaAd";
            this.txtMarkaAd.Size = new System.Drawing.Size(246, 28);
            this.txtMarkaAd.TabIndex = 2;
            // 
            // btnMarkaEkle
            // 
            this.btnMarkaEkle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMarkaEkle.Location = new System.Drawing.Point(360, 533);
            this.btnMarkaEkle.Name = "btnMarkaEkle";
            this.btnMarkaEkle.Size = new System.Drawing.Size(123, 37);
            this.btnMarkaEkle.TabIndex = 3;
            this.btnMarkaEkle.Text = "Ekle";
            this.btnMarkaEkle.UseVisualStyleBackColor = true;
            this.btnMarkaEkle.Click += new System.EventHandler(this.btnMarkaEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(590, 533);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(123, 37);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Marka ID:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Location = new System.Drawing.Point(237, 396);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(246, 28);
            this.txtID.TabIndex = 6;
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(186, 12);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(139, 22);
            this.txtArama.TabIndex = 7;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "*Marka Adı Giriniz";
            // 
            // Markalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1095, 639);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnMarkaEkle);
            this.Controls.Add(this.txtMarkaAd);
            this.Controls.Add(this.lblMarkaAd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Markalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Markalar";
            this.Load += new System.EventHandler(this.Markalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMARKALARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbCRMDataSet3 dbCRMDataSet3;
        private System.Windows.Forms.BindingSource tBLMARKALARBindingSource;
        private dbCRMDataSet3TableAdapters.TBLMARKALARTableAdapter tBLMARKALARTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblMarkaAd;
        private System.Windows.Forms.TextBox txtMarkaAd;
        private System.Windows.Forms.Button btnMarkaEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label label2;
    }
}