namespace InternetCafeSistem
{
    partial class FrmSatislariListele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnIslemiGeriAl = new System.Windows.Forms.Button();
            this.SatisID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KullaniciID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MasaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcilisTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baslangic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bitis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SatisID,
            this.KullaniciID,
            this.MasaID,
            this.AcilisTuru,
            this.Baslangic,
            this.Bitis,
            this.Sure,
            this.Tutar,
            this.Aciklama,
            this.Tarih});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(918, 491);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnIslemiGeriAl
            // 
            this.btnIslemiGeriAl.BackColor = System.Drawing.Color.Yellow;
            this.btnIslemiGeriAl.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnIslemiGeriAl.FlatAppearance.BorderSize = 0;
            this.btnIslemiGeriAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIslemiGeriAl.Location = new System.Drawing.Point(794, 491);
            this.btnIslemiGeriAl.Name = "btnIslemiGeriAl";
            this.btnIslemiGeriAl.Size = new System.Drawing.Size(124, 43);
            this.btnIslemiGeriAl.TabIndex = 1;
            this.btnIslemiGeriAl.Text = " İşlemi Geri Al ";
            this.btnIslemiGeriAl.UseVisualStyleBackColor = false;
            this.btnIslemiGeriAl.Click += new System.EventHandler(this.btnIslemiGeriAl_Click);
            // 
            // SatisID
            // 
            this.SatisID.DataPropertyName = "SatisID";
            this.SatisID.HeaderText = "Satış ID";
            this.SatisID.Name = "SatisID";
            // 
            // KullaniciID
            // 
            this.KullaniciID.DataPropertyName = "KullaniciID";
            this.KullaniciID.HeaderText = "Kullanıcı ID";
            this.KullaniciID.Name = "KullaniciID";
            // 
            // MasaID
            // 
            this.MasaID.DataPropertyName = "MasaID";
            this.MasaID.HeaderText = "Masa ID";
            this.MasaID.Name = "MasaID";
            // 
            // AcilisTuru
            // 
            this.AcilisTuru.DataPropertyName = "AcilisTuru";
            this.AcilisTuru.HeaderText = "Açılış Türü";
            this.AcilisTuru.Name = "AcilisTuru";
            // 
            // Baslangic
            // 
            this.Baslangic.DataPropertyName = "BaslangicSaati";
            this.Baslangic.HeaderText = "Başlama Saati";
            this.Baslangic.Name = "Baslangic";
            // 
            // Bitis
            // 
            this.Bitis.DataPropertyName = "BitisSaati";
            this.Bitis.HeaderText = "Bitiş Saati";
            this.Bitis.Name = "Bitis";
            // 
            // Sure
            // 
            this.Sure.DataPropertyName = "Sure";
            this.Sure.HeaderText = "Süre";
            this.Sure.Name = "Sure";
            // 
            // Tutar
            // 
            this.Tutar.DataPropertyName = "Tutar";
            this.Tutar.HeaderText = "Tutar TL";
            this.Tutar.Name = "Tutar";
            // 
            // Aciklama
            // 
            this.Aciklama.DataPropertyName = "Aciklama";
            this.Aciklama.HeaderText = "Açıklama";
            this.Aciklama.Name = "Aciklama";
            // 
            // Tarih
            // 
            this.Tarih.DataPropertyName = "Tarih";
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.Name = "Tarih";
            // 
            // FrmSatislariListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(918, 534);
            this.Controls.Add(this.btnIslemiGeriAl);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSatislariListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satışları Listeleme Sayfası";
            this.Load += new System.EventHandler(this.FrmSatislariListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btnIslemiGeriAl;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatisID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KullaniciID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MasaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcilisTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn Baslangic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bitis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
    }
}