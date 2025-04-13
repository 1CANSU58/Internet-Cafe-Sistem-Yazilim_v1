namespace InternetCafeSistem
{
    partial class FrmKullanici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullanici));
            this.txtKullaniciID = new System.Windows.Forms.TextBox();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblKullaniciFrmKapat = new System.Windows.Forms.Label();
            this.chkbBeniHatirla = new System.Windows.Forms.CheckBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSifremiUnuttum = new System.Windows.Forms.Button();
            this.lblzaman = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKullaniciID
            // 
            this.txtKullaniciID.Location = new System.Drawing.Point(15, 180);
            this.txtKullaniciID.Name = "txtKullaniciID";
            this.txtKullaniciID.Size = new System.Drawing.Size(240, 20);
            this.txtKullaniciID.TabIndex = 0;
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.Location = new System.Drawing.Point(15, 243);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.PasswordChar = '*';
            this.txtKullaniciSifre.Size = new System.Drawing.Size(240, 20);
            this.txtKullaniciSifre.TabIndex = 1;
            this.txtKullaniciSifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı ID ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kullanıcı Şifre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblKullaniciFrmKapat
            // 
            this.lblKullaniciFrmKapat.AutoSize = true;
            this.lblKullaniciFrmKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciFrmKapat.ForeColor = System.Drawing.Color.Red;
            this.lblKullaniciFrmKapat.Location = new System.Drawing.Point(239, 9);
            this.lblKullaniciFrmKapat.Name = "lblKullaniciFrmKapat";
            this.lblKullaniciFrmKapat.Size = new System.Drawing.Size(21, 20);
            this.lblKullaniciFrmKapat.TabIndex = 5;
            this.lblKullaniciFrmKapat.Text = "X";
            this.lblKullaniciFrmKapat.Click += new System.EventHandler(this.lblKullaniciFrmKapat_Click);
            // 
            // chkbBeniHatirla
            // 
            this.chkbBeniHatirla.AutoSize = true;
            this.chkbBeniHatirla.Checked = true;
            this.chkbBeniHatirla.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbBeniHatirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkbBeniHatirla.Location = new System.Drawing.Point(18, 280);
            this.chkbBeniHatirla.Name = "chkbBeniHatirla";
            this.chkbBeniHatirla.Size = new System.Drawing.Size(92, 17);
            this.chkbBeniHatirla.TabIndex = 6;
            this.chkbBeniHatirla.Text = "Beni Hatırla";
            this.chkbBeniHatirla.UseVisualStyleBackColor = true;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGirisYap.FlatAppearance.BorderSize = 0;
            this.btnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.Location = new System.Drawing.Point(15, 322);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(240, 23);
            this.btnGirisYap.TabIndex = 7;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.DarkOrange;
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Location = new System.Drawing.Point(15, 357);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(240, 23);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSifremiUnuttum
            // 
            this.btnSifremiUnuttum.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSifremiUnuttum.FlatAppearance.BorderSize = 0;
            this.btnSifremiUnuttum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifremiUnuttum.Location = new System.Drawing.Point(139, 276);
            this.btnSifremiUnuttum.Name = "btnSifremiUnuttum";
            this.btnSifremiUnuttum.Size = new System.Drawing.Size(116, 23);
            this.btnSifremiUnuttum.TabIndex = 9;
            this.btnSifremiUnuttum.Text = "Şifremi Unuttum";
            this.btnSifremiUnuttum.UseVisualStyleBackColor = false;
            // 
            // lblzaman
            // 
            this.lblzaman.AutoSize = true;
            this.lblzaman.Location = new System.Drawing.Point(15, 412);
            this.lblzaman.Name = "lblzaman";
            this.lblzaman.Size = new System.Drawing.Size(47, 13);
            this.lblzaman.TabIndex = 10;
            this.lblzaman.Text = "zaman : ";
            // 
            // FrmKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(268, 434);
            this.Controls.Add(this.lblzaman);
            this.Controls.Add(this.btnSifremiUnuttum);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.chkbBeniHatirla);
            this.Controls.Add(this.lblKullaniciFrmKapat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKullaniciSifre);
            this.Controls.Add(this.txtKullaniciID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKullanici";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKullaniciID;
        private System.Windows.Forms.TextBox txtKullaniciSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblKullaniciFrmKapat;
        private System.Windows.Forms.CheckBox chkbBeniHatirla;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSifremiUnuttum;
        private System.Windows.Forms.Label lblzaman;
    }
}