
namespace CRM
{
    partial class MusteriEkle
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
            this.lblMUSERIAD = new System.Windows.Forms.Label();
            this.LBLSEHIR = new System.Windows.Forms.Label();
            this.lblİletisim = new System.Windows.Forms.Label();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.LBLSOYAD = new System.Windows.Forms.Label();
            this.txtAD = new System.Windows.Forms.TextBox();
            this.txtSOYAD = new System.Windows.Forms.TextBox();
            this.txtSEHİR = new System.Windows.Forms.TextBox();
            this.txtILETISIM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMUSERIAD
            // 
            this.lblMUSERIAD.AutoSize = true;
            this.lblMUSERIAD.Location = new System.Drawing.Point(222, 111);
            this.lblMUSERIAD.Name = "lblMUSERIAD";
            this.lblMUSERIAD.Size = new System.Drawing.Size(82, 17);
            this.lblMUSERIAD.TabIndex = 0;
            this.lblMUSERIAD.Text = "Müşteri Adı:";
            this.lblMUSERIAD.Click += new System.EventHandler(this.label1_Click);
            // 
            // LBLSEHIR
            // 
            this.LBLSEHIR.AutoSize = true;
            this.LBLSEHIR.Location = new System.Drawing.Point(222, 219);
            this.LBLSEHIR.Name = "LBLSEHIR";
            this.LBLSEHIR.Size = new System.Drawing.Size(45, 17);
            this.LBLSEHIR.TabIndex = 2;
            this.LBLSEHIR.Text = "Şehir:";
            // 
            // lblİletisim
            // 
            this.lblİletisim.AutoSize = true;
            this.lblİletisim.Location = new System.Drawing.Point(222, 279);
            this.lblİletisim.Name = "lblİletisim";
            this.lblİletisim.Size = new System.Drawing.Size(54, 17);
            this.lblİletisim.TabIndex = 4;
            this.lblİletisim.Text = "İletişim:";
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(308, 324);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(106, 26);
            this.btnMusteriEkle.TabIndex = 6;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // LBLSOYAD
            // 
            this.LBLSOYAD.AutoSize = true;
            this.LBLSOYAD.Location = new System.Drawing.Point(222, 164);
            this.LBLSOYAD.Name = "LBLSOYAD";
            this.LBLSOYAD.Size = new System.Drawing.Size(105, 17);
            this.LBLSOYAD.TabIndex = 7;
            this.LBLSOYAD.Text = "Müşteri Soyadı:";
            // 
            // txtAD
            // 
            this.txtAD.Location = new System.Drawing.Point(361, 111);
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(166, 22);
            this.txtAD.TabIndex = 8;
            // 
            // txtSOYAD
            // 
            this.txtSOYAD.Location = new System.Drawing.Point(361, 164);
            this.txtSOYAD.Name = "txtSOYAD";
            this.txtSOYAD.Size = new System.Drawing.Size(166, 22);
            this.txtSOYAD.TabIndex = 9;
            // 
            // txtSEHİR
            // 
            this.txtSEHİR.Location = new System.Drawing.Point(361, 219);
            this.txtSEHİR.Name = "txtSEHİR";
            this.txtSEHİR.Size = new System.Drawing.Size(166, 22);
            this.txtSEHİR.TabIndex = 10;
            // 
            // txtILETISIM
            // 
            this.txtILETISIM.Location = new System.Drawing.Point(361, 276);
            this.txtILETISIM.Name = "txtILETISIM";
            this.txtILETISIM.Size = new System.Drawing.Size(166, 22);
            this.txtILETISIM.TabIndex = 11;
            // 
            // MusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtILETISIM);
            this.Controls.Add(this.txtSEHİR);
            this.Controls.Add(this.txtSOYAD);
            this.Controls.Add(this.txtAD);
            this.Controls.Add(this.LBLSOYAD);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.lblİletisim);
            this.Controls.Add(this.LBLSEHIR);
            this.Controls.Add(this.lblMUSERIAD);
            this.Name = "MusteriEkle";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMUSERIAD;
        private System.Windows.Forms.Label LBLSEHIR;
        private System.Windows.Forms.Label lblİletisim;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Label LBLSOYAD;
        private System.Windows.Forms.TextBox txtAD;
        private System.Windows.Forms.TextBox txtSOYAD;
        private System.Windows.Forms.TextBox txtSEHİR;
        private System.Windows.Forms.TextBox txtILETISIM;
    }
}