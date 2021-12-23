
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
            this.dbCRMDataSet3 = new CRM.dbCRMDataSet3();
            this.tBLMARKALARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLMARKALARTableAdapter = new CRM.dbCRMDataSet3TableAdapters.TBLMARKALARTableAdapter();
            this.markaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMarkaAd = new System.Windows.Forms.Label();
            this.txtMarkaAd = new System.Windows.Forms.TextBox();
            this.btnMarkaEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMARKALARBindingSource)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(411, 299);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dbCRMDataSet3
            // 
            this.dbCRMDataSet3.DataSetName = "dbCRMDataSet3";
            this.dbCRMDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLMARKALARBindingSource
            // 
            this.tBLMARKALARBindingSource.DataMember = "TBLMARKALAR";
            this.tBLMARKALARBindingSource.DataSource = this.dbCRMDataSet3;
            // 
            // tBLMARKALARTableAdapter
            // 
            this.tBLMARKALARTableAdapter.ClearBeforeFill = true;
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
            // lblMarkaAd
            // 
            this.lblMarkaAd.AutoSize = true;
            this.lblMarkaAd.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarkaAd.Location = new System.Drawing.Point(497, 270);
            this.lblMarkaAd.Name = "lblMarkaAd";
            this.lblMarkaAd.Size = new System.Drawing.Size(141, 29);
            this.lblMarkaAd.TabIndex = 1;
            this.lblMarkaAd.Text = "Marka Adı:";
            // 
            // txtMarkaAd
            // 
            this.txtMarkaAd.Location = new System.Drawing.Point(693, 277);
            this.txtMarkaAd.Name = "txtMarkaAd";
            this.txtMarkaAd.Size = new System.Drawing.Size(246, 22);
            this.txtMarkaAd.TabIndex = 2;
            // 
            // btnMarkaEkle
            // 
            this.btnMarkaEkle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMarkaEkle.Location = new System.Drawing.Point(502, 401);
            this.btnMarkaEkle.Name = "btnMarkaEkle";
            this.btnMarkaEkle.Size = new System.Drawing.Size(123, 37);
            this.btnMarkaEkle.TabIndex = 3;
            this.btnMarkaEkle.Text = "Ekle";
            this.btnMarkaEkle.UseVisualStyleBackColor = true;
            this.btnMarkaEkle.Click += new System.EventHandler(this.btnMarkaEkle_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(816, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Markalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1095, 639);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMarkaEkle);
            this.Controls.Add(this.txtMarkaAd);
            this.Controls.Add(this.lblMarkaAd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Markalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Markalar";
            this.Load += new System.EventHandler(this.Markalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMARKALARBindingSource)).EndInit();
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
        private System.Windows.Forms.Button button1;
    }
}