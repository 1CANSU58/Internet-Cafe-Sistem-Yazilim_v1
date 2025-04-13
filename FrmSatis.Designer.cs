namespace InternetCafeSistem
{
    partial class FrmSatis
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSatis));
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yöneticiÇağırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.süresizMasaAçmaİsteğiGönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dkToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dkToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.dkToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.dkToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.dkToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.dkToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.dkToolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.dkToolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.masaDeğiştirmeİsteğiGönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.HareketID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KullaniciID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MasaID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Masa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IstekTuru = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbBosMasalar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rd180 = new System.Windows.Forms.RadioButton();
            this.rd150 = new System.Windows.Forms.RadioButton();
            this.rd120 = new System.Windows.Forms.RadioButton();
            this.rd90 = new System.Windows.Forms.RadioButton();
            this.rd60 = new System.Windows.Forms.RadioButton();
            this.rd165 = new System.Windows.Forms.RadioButton();
            this.rd135 = new System.Windows.Forms.RadioButton();
            this.rd105 = new System.Windows.Forms.RadioButton();
            this.rd75 = new System.Windows.Forms.RadioButton();
            this.rd45 = new System.Windows.Forms.RadioButton();
            this.rd30 = new System.Windows.Forms.RadioButton();
            this.rdSuresiz = new System.Windows.Forms.RadioButton();
            this.btnMasaAc = new System.Windows.Forms.Button();
            this.internetCafeDataSet = new InternetCafeSistem.InternetCafeDataSet();
            this.tBLSaatUcretiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLSaatUcretiTableAdapter = new InternetCafeSistem.InternetCafeDataSetTableAdapters.TBLSaatUcretiTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSaatUcreti = new System.Windows.Forms.ComboBox();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnMasayiDegistir = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Masa_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Masa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcilisTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaslamaSaati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitisSaati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hesapla = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MasaKapat = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnGeriAl = new System.Windows.Forms.Button();
            this.btnHareketlerRaporu = new System.Windows.Forms.Button();
            this.btnSatisRaporu = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.internetCafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSaatUcretiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ContextMenuStrip = this.contextMenuStrip1;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageKey = "imac.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 108);
            this.button1.TabIndex = 0;
            this.button1.Text = "Masa - 1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yöneticiÇağırToolStripMenuItem,
            this.süresizMasaAçmaİsteğiGönderToolStripMenuItem,
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem,
            this.masaDeğiştirmeİsteğiGönderToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(249, 92);
            // 
            // yöneticiÇağırToolStripMenuItem
            // 
            this.yöneticiÇağırToolStripMenuItem.Name = "yöneticiÇağırToolStripMenuItem";
            this.yöneticiÇağırToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.yöneticiÇağırToolStripMenuItem.Text = "Yönetici Çağır";
            this.yöneticiÇağırToolStripMenuItem.Click += new System.EventHandler(this.yöneticiÇağırToolStripMenuItem_Click);
            // 
            // süresizMasaAçmaİsteğiGönderToolStripMenuItem
            // 
            this.süresizMasaAçmaİsteğiGönderToolStripMenuItem.Name = "süresizMasaAçmaİsteğiGönderToolStripMenuItem";
            this.süresizMasaAçmaİsteğiGönderToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.süresizMasaAçmaİsteğiGönderToolStripMenuItem.Text = "Süresiz Masa Açma İsteği Gönder";
            this.süresizMasaAçmaİsteğiGönderToolStripMenuItem.Click += new System.EventHandler(this.süresizMasaAçmaİsteğiGönderToolStripMenuItem_Click);
            // 
            // süreliMasaAçmaİsteğiGönderToolStripMenuItem
            // 
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dkToolStripMenuItem,
            this.dkToolStripMenuItem1,
            this.dkToolStripMenuItem2,
            this.dkToolStripMenuItem3,
            this.toolStripMenuItem5,
            this.dkToolStripMenuItem5,
            this.dkToolStripMenuItem6,
            this.dkToolStripMenuItem7,
            this.dkToolStripMenuItem8,
            this.dkToolStripMenuItem9,
            this.dkToolStripMenuItem10});
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem.Name = "süreliMasaAçmaİsteğiGönderToolStripMenuItem";
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.süreliMasaAçmaİsteğiGönderToolStripMenuItem.Text = "Süreli Masa Açma İsteği Gönder";
            // 
            // dkToolStripMenuItem
            // 
            this.dkToolStripMenuItem.Name = "dkToolStripMenuItem";
            this.dkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dkToolStripMenuItem.Text = "30 dk";
            this.dkToolStripMenuItem.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // dkToolStripMenuItem1
            // 
            this.dkToolStripMenuItem1.Name = "dkToolStripMenuItem1";
            this.dkToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.dkToolStripMenuItem1.Text = "45 dk";
            this.dkToolStripMenuItem1.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // dkToolStripMenuItem2
            // 
            this.dkToolStripMenuItem2.Name = "dkToolStripMenuItem2";
            this.dkToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.dkToolStripMenuItem2.Text = "60 dk";
            this.dkToolStripMenuItem2.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // dkToolStripMenuItem3
            // 
            this.dkToolStripMenuItem3.Name = "dkToolStripMenuItem3";
            this.dkToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.dkToolStripMenuItem3.Text = "75 dk";
            this.dkToolStripMenuItem3.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // dkToolStripMenuItem5
            // 
            this.dkToolStripMenuItem5.Name = "dkToolStripMenuItem5";
            this.dkToolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.dkToolStripMenuItem5.Text = "105 dk";
            this.dkToolStripMenuItem5.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // dkToolStripMenuItem6
            // 
            this.dkToolStripMenuItem6.Name = "dkToolStripMenuItem6";
            this.dkToolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.dkToolStripMenuItem6.Text = "120 dk";
            this.dkToolStripMenuItem6.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // dkToolStripMenuItem7
            // 
            this.dkToolStripMenuItem7.Name = "dkToolStripMenuItem7";
            this.dkToolStripMenuItem7.Size = new System.Drawing.Size(180, 22);
            this.dkToolStripMenuItem7.Text = "135 dk";
            this.dkToolStripMenuItem7.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // dkToolStripMenuItem8
            // 
            this.dkToolStripMenuItem8.Name = "dkToolStripMenuItem8";
            this.dkToolStripMenuItem8.Size = new System.Drawing.Size(180, 22);
            this.dkToolStripMenuItem8.Text = "150 dk";
            this.dkToolStripMenuItem8.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // dkToolStripMenuItem9
            // 
            this.dkToolStripMenuItem9.Name = "dkToolStripMenuItem9";
            this.dkToolStripMenuItem9.Size = new System.Drawing.Size(180, 22);
            this.dkToolStripMenuItem9.Text = "165 dk";
            this.dkToolStripMenuItem9.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // dkToolStripMenuItem10
            // 
            this.dkToolStripMenuItem10.Name = "dkToolStripMenuItem10";
            this.dkToolStripMenuItem10.Size = new System.Drawing.Size(180, 22);
            this.dkToolStripMenuItem10.Text = "180 dk";
            this.dkToolStripMenuItem10.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // masaDeğiştirmeİsteğiGönderToolStripMenuItem
            // 
            this.masaDeğiştirmeİsteğiGönderToolStripMenuItem.Name = "masaDeğiştirmeİsteğiGönderToolStripMenuItem";
            this.masaDeğiştirmeİsteğiGönderToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.masaDeğiştirmeİsteğiGönderToolStripMenuItem.Text = "Masa Değiştirme İsteği Gönder";
            this.masaDeğiştirmeİsteğiGönderToolStripMenuItem.Click += new System.EventHandler(this.masaDeğiştirmeİsteğiGönderToolStripMenuItem_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "imac.png");
            // 
            // button2
            // 
            this.button2.ContextMenuStrip = this.contextMenuStrip1;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageKey = "imac.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(107, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 108);
            this.button2.TabIndex = 1;
            this.button2.Text = "Masa - 2";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button3
            // 
            this.button3.ContextMenuStrip = this.contextMenuStrip1;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ImageKey = "imac.png";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(202, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 108);
            this.button3.TabIndex = 2;
            this.button3.Text = "Masa - 3";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button4
            // 
            this.button4.ContextMenuStrip = this.contextMenuStrip1;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ImageKey = "imac.png";
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(297, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 108);
            this.button4.TabIndex = 3;
            this.button4.Text = "Masa - 4";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button5
            // 
            this.button5.ContextMenuStrip = this.contextMenuStrip1;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ImageKey = "imac.png";
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(392, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 108);
            this.button5.TabIndex = 4;
            this.button5.Text = "Masa - 5";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button6
            // 
            this.button6.ContextMenuStrip = this.contextMenuStrip1;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ImageKey = "imac.png";
            this.button6.ImageList = this.ımageList1;
            this.button6.Location = new System.Drawing.Point(487, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 108);
            this.button6.TabIndex = 5;
            this.button6.Text = "Masa - 6";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button7
            // 
            this.button7.ContextMenuStrip = this.contextMenuStrip1;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ImageKey = "imac.png";
            this.button7.ImageList = this.ımageList1;
            this.button7.Location = new System.Drawing.Point(582, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 108);
            this.button7.TabIndex = 6;
            this.button7.Text = "Masa - 7";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button8
            // 
            this.button8.ContextMenuStrip = this.contextMenuStrip1;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ImageKey = "imac.png";
            this.button8.ImageList = this.ımageList1;
            this.button8.Location = new System.Drawing.Point(677, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(89, 108);
            this.button8.TabIndex = 7;
            this.button8.Text = "Masa - 8";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button9
            // 
            this.button9.ContextMenuStrip = this.contextMenuStrip1;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ImageKey = "imac.png";
            this.button9.ImageList = this.ımageList1;
            this.button9.Location = new System.Drawing.Point(772, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(89, 108);
            this.button9.TabIndex = 8;
            this.button9.Text = "Masa - 9";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button10
            // 
            this.button10.ContextMenuStrip = this.contextMenuStrip1;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ImageKey = "imac.png";
            this.button10.ImageList = this.ımageList1;
            this.button10.Location = new System.Drawing.Point(867, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(89, 108);
            this.button10.TabIndex = 9;
            this.button10.Text = "Masa - 10";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button11
            // 
            this.button11.ContextMenuStrip = this.contextMenuStrip1;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ImageKey = "imac.png";
            this.button11.ImageList = this.ımageList1;
            this.button11.Location = new System.Drawing.Point(867, 590);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(89, 108);
            this.button11.TabIndex = 19;
            this.button11.Text = "Masa - 20";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button12
            // 
            this.button12.ContextMenuStrip = this.contextMenuStrip1;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ImageKey = "imac.png";
            this.button12.ImageList = this.ımageList1;
            this.button12.Location = new System.Drawing.Point(772, 590);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(89, 108);
            this.button12.TabIndex = 18;
            this.button12.Text = "Masa - 19";
            this.button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button13
            // 
            this.button13.ContextMenuStrip = this.contextMenuStrip1;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ImageKey = "imac.png";
            this.button13.ImageList = this.ımageList1;
            this.button13.Location = new System.Drawing.Point(677, 590);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(89, 108);
            this.button13.TabIndex = 17;
            this.button13.Text = "Masa - 18";
            this.button13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button14
            // 
            this.button14.ContextMenuStrip = this.contextMenuStrip1;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.ImageKey = "imac.png";
            this.button14.ImageList = this.ımageList1;
            this.button14.Location = new System.Drawing.Point(582, 590);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(89, 108);
            this.button14.TabIndex = 16;
            this.button14.Text = "Masa - 17";
            this.button14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button15
            // 
            this.button15.ContextMenuStrip = this.contextMenuStrip1;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.ImageKey = "imac.png";
            this.button15.ImageList = this.ımageList1;
            this.button15.Location = new System.Drawing.Point(487, 590);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(89, 108);
            this.button15.TabIndex = 15;
            this.button15.Text = "Masa - 16";
            this.button15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button16
            // 
            this.button16.ContextMenuStrip = this.contextMenuStrip1;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.ImageKey = "imac.png";
            this.button16.ImageList = this.ımageList1;
            this.button16.Location = new System.Drawing.Point(392, 590);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(89, 108);
            this.button16.TabIndex = 14;
            this.button16.Text = "Masa - 15";
            this.button16.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button17
            // 
            this.button17.ContextMenuStrip = this.contextMenuStrip1;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.ImageKey = "imac.png";
            this.button17.ImageList = this.ımageList1;
            this.button17.Location = new System.Drawing.Point(297, 590);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(89, 108);
            this.button17.TabIndex = 13;
            this.button17.Text = "Masa - 14";
            this.button17.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button17.UseVisualStyleBackColor = true;
            this.button17.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button18
            // 
            this.button18.ContextMenuStrip = this.contextMenuStrip1;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.ImageKey = "imac.png";
            this.button18.ImageList = this.ımageList1;
            this.button18.Location = new System.Drawing.Point(202, 590);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(89, 108);
            this.button18.TabIndex = 12;
            this.button18.Text = "Masa - 13";
            this.button18.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button18.UseVisualStyleBackColor = true;
            this.button18.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button19
            // 
            this.button19.ContextMenuStrip = this.contextMenuStrip1;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.ImageKey = "imac.png";
            this.button19.ImageList = this.ımageList1;
            this.button19.Location = new System.Drawing.Point(107, 590);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(89, 108);
            this.button19.TabIndex = 11;
            this.button19.Text = "Masa - 12";
            this.button19.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button19.UseVisualStyleBackColor = true;
            this.button19.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // button20
            // 
            this.button20.ContextMenuStrip = this.contextMenuStrip1;
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.ImageKey = "imac.png";
            this.button20.ImageList = this.ımageList1;
            this.button20.Location = new System.Drawing.Point(12, 590);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(89, 108);
            this.button20.TabIndex = 10;
            this.button20.Text = "Masa - 11";
            this.button20.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button20.UseVisualStyleBackColor = true;
            this.button20.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecileneGore);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HareketID,
            this.KullaniciID,
            this.MasaID,
            this.Masa,
            this.IstekTuru,
            this.Aciklama,
            this.Tarih});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 126);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(754, 155);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // HareketID
            // 
            this.HareketID.Text = "Istek ID";
            // 
            // KullaniciID
            // 
            this.KullaniciID.Text = "Kullanici ID";
            this.KullaniciID.Width = 90;
            // 
            // MasaID
            // 
            this.MasaID.Text = "Masa ID";
            this.MasaID.Width = 75;
            // 
            // Masa
            // 
            this.Masa.Text = "Masa";
            this.Masa.Width = 98;
            // 
            // IstekTuru
            // 
            this.IstekTuru.Text = "İstek Türü";
            this.IstekTuru.Width = 108;
            // 
            // Aciklama
            // 
            this.Aciklama.Text = "Açıklama";
            this.Aciklama.Width = 155;
            // 
            // Tarih
            // 
            this.Tarih.Text = "Tarih";
            this.Tarih.Width = 155;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Masa_ID,
            this._Masa,
            this.AcilisTuru,
            this.BaslamaSaati,
            this.BitisSaati,
            this.Sure,
            this.Tutar,
            this._Tarih,
            this.Hesapla,
            this.MasaKapat});
            this.dataGridView1.DataSource = this.internetCafeDataSet;
            this.dataGridView1.Location = new System.Drawing.Point(12, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(754, 297);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // cbBosMasalar
            // 
            this.cbBosMasalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbBosMasalar.FormattingEnabled = true;
            this.cbBosMasalar.Location = new System.Drawing.Point(772, 201);
            this.cbBosMasalar.Name = "cbBosMasalar";
            this.cbBosMasalar.Size = new System.Drawing.Size(184, 23);
            this.cbBosMasalar.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(772, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Boş Masalar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rd180);
            this.panel1.Controls.Add(this.rd150);
            this.panel1.Controls.Add(this.rd120);
            this.panel1.Controls.Add(this.rd90);
            this.panel1.Controls.Add(this.rd60);
            this.panel1.Controls.Add(this.rd165);
            this.panel1.Controls.Add(this.rd135);
            this.panel1.Controls.Add(this.rd105);
            this.panel1.Controls.Add(this.rd75);
            this.panel1.Controls.Add(this.rd45);
            this.panel1.Controls.Add(this.rd30);
            this.panel1.Controls.Add(this.rdSuresiz);
            this.panel1.Location = new System.Drawing.Point(772, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 175);
            this.panel1.TabIndex = 24;
            // 
            // rd180
            // 
            this.rd180.AutoSize = true;
            this.rd180.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd180.Location = new System.Drawing.Point(116, 153);
            this.rd180.Name = "rd180";
            this.rd180.Size = new System.Drawing.Size(64, 17);
            this.rd180.TabIndex = 11;
            this.rd180.TabStop = true;
            this.rd180.Text = "180 dk";
            this.rd180.UseVisualStyleBackColor = true;
            this.rd180.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // rd150
            // 
            this.rd150.AutoSize = true;
            this.rd150.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd150.Location = new System.Drawing.Point(116, 122);
            this.rd150.Name = "rd150";
            this.rd150.Size = new System.Drawing.Size(64, 17);
            this.rd150.TabIndex = 10;
            this.rd150.TabStop = true;
            this.rd150.Text = "150 dk";
            this.rd150.UseVisualStyleBackColor = true;
            this.rd150.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // rd120
            // 
            this.rd120.AutoSize = true;
            this.rd120.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd120.Location = new System.Drawing.Point(116, 92);
            this.rd120.Name = "rd120";
            this.rd120.Size = new System.Drawing.Size(64, 17);
            this.rd120.TabIndex = 9;
            this.rd120.TabStop = true;
            this.rd120.Text = "120 dk";
            this.rd120.UseVisualStyleBackColor = true;
            this.rd120.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // rd90
            // 
            this.rd90.AutoSize = true;
            this.rd90.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd90.Location = new System.Drawing.Point(116, 62);
            this.rd90.Name = "rd90";
            this.rd90.Size = new System.Drawing.Size(57, 17);
            this.rd90.TabIndex = 8;
            this.rd90.TabStop = true;
            this.rd90.Text = "90 dk";
            this.rd90.UseVisualStyleBackColor = true;
            this.rd90.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // rd60
            // 
            this.rd60.AutoSize = true;
            this.rd60.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd60.Location = new System.Drawing.Point(116, 31);
            this.rd60.Name = "rd60";
            this.rd60.Size = new System.Drawing.Size(57, 17);
            this.rd60.TabIndex = 7;
            this.rd60.TabStop = true;
            this.rd60.Text = "60 dk";
            this.rd60.UseVisualStyleBackColor = true;
            this.rd60.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // rd165
            // 
            this.rd165.AutoSize = true;
            this.rd165.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd165.Location = new System.Drawing.Point(5, 154);
            this.rd165.Name = "rd165";
            this.rd165.Size = new System.Drawing.Size(64, 17);
            this.rd165.TabIndex = 6;
            this.rd165.TabStop = true;
            this.rd165.Text = "165 dk";
            this.rd165.UseVisualStyleBackColor = true;
            this.rd165.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // rd135
            // 
            this.rd135.AutoSize = true;
            this.rd135.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd135.Location = new System.Drawing.Point(5, 123);
            this.rd135.Name = "rd135";
            this.rd135.Size = new System.Drawing.Size(64, 17);
            this.rd135.TabIndex = 5;
            this.rd135.TabStop = true;
            this.rd135.Text = "135 dk";
            this.rd135.UseVisualStyleBackColor = true;
            this.rd135.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // rd105
            // 
            this.rd105.AutoSize = true;
            this.rd105.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd105.Location = new System.Drawing.Point(4, 93);
            this.rd105.Name = "rd105";
            this.rd105.Size = new System.Drawing.Size(64, 17);
            this.rd105.TabIndex = 4;
            this.rd105.TabStop = true;
            this.rd105.Text = "105 dk";
            this.rd105.UseVisualStyleBackColor = true;
            this.rd105.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // rd75
            // 
            this.rd75.AutoSize = true;
            this.rd75.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd75.Location = new System.Drawing.Point(4, 63);
            this.rd75.Name = "rd75";
            this.rd75.Size = new System.Drawing.Size(57, 17);
            this.rd75.TabIndex = 3;
            this.rd75.TabStop = true;
            this.rd75.Text = "75 dk";
            this.rd75.UseVisualStyleBackColor = true;
            this.rd75.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // rd45
            // 
            this.rd45.AutoSize = true;
            this.rd45.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd45.Location = new System.Drawing.Point(4, 31);
            this.rd45.Name = "rd45";
            this.rd45.Size = new System.Drawing.Size(57, 17);
            this.rd45.TabIndex = 2;
            this.rd45.TabStop = true;
            this.rd45.Text = "45 dk";
            this.rd45.UseVisualStyleBackColor = true;
            this.rd45.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // rd30
            // 
            this.rd30.AutoSize = true;
            this.rd30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rd30.Location = new System.Drawing.Point(116, 6);
            this.rd30.Name = "rd30";
            this.rd30.Size = new System.Drawing.Size(57, 17);
            this.rd30.TabIndex = 1;
            this.rd30.TabStop = true;
            this.rd30.Text = "30 dk";
            this.rd30.UseVisualStyleBackColor = true;
            this.rd30.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // rdSuresiz
            // 
            this.rdSuresiz.AutoSize = true;
            this.rdSuresiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdSuresiz.Location = new System.Drawing.Point(4, 3);
            this.rdSuresiz.Name = "rdSuresiz";
            this.rdSuresiz.Size = new System.Drawing.Size(76, 20);
            this.rdSuresiz.TabIndex = 0;
            this.rdSuresiz.TabStop = true;
            this.rdSuresiz.Text = "Süresiz";
            this.rdSuresiz.UseVisualStyleBackColor = true;
            this.rdSuresiz.CheckedChanged += new System.EventHandler(this.RadioButtonSeciliyeGore);
            // 
            // btnMasaAc
            // 
            this.btnMasaAc.BackColor = System.Drawing.Color.Lime;
            this.btnMasaAc.FlatAppearance.BorderSize = 0;
            this.btnMasaAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasaAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasaAc.Location = new System.Drawing.Point(772, 414);
            this.btnMasaAc.Name = "btnMasaAc";
            this.btnMasaAc.Size = new System.Drawing.Size(184, 38);
            this.btnMasaAc.TabIndex = 25;
            this.btnMasaAc.Text = "Masa Aç";
            this.btnMasaAc.UseVisualStyleBackColor = false;
            this.btnMasaAc.Click += new System.EventHandler(this.btnMasaAc_Click);
            // 
            // internetCafeDataSet
            // 
            this.internetCafeDataSet.DataSetName = "InternetCafeDataSet";
            this.internetCafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLSaatUcretiBindingSource
            // 
            this.tBLSaatUcretiBindingSource.DataMember = "TBLSaatUcreti";
            this.tBLSaatUcretiBindingSource.DataSource = this.internetCafeDataSet;
            // 
            // tBLSaatUcretiTableAdapter
            // 
            this.tBLSaatUcretiTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(772, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Saat Ücreti";
            // 
            // cbSaatUcreti
            // 
            this.cbSaatUcreti.DataSource = this.tBLSaatUcretiBindingSource;
            this.cbSaatUcreti.DisplayMember = "SaatUcreti";
            this.cbSaatUcreti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSaatUcreti.FormattingEnabled = true;
            this.cbSaatUcreti.Location = new System.Drawing.Point(772, 152);
            this.cbSaatUcreti.Name = "cbSaatUcreti";
            this.cbSaatUcreti.Size = new System.Drawing.Size(184, 23);
            this.cbSaatUcreti.TabIndex = 27;
            this.cbSaatUcreti.ValueMember = "SaatUcretiID";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem5.Text = "90 dk";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.SureliIstekSecilirse);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnMasayiDegistir
            // 
            this.btnMasayiDegistir.BackColor = System.Drawing.Color.HotPink;
            this.btnMasayiDegistir.FlatAppearance.BorderSize = 0;
            this.btnMasayiDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasayiDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasayiDegistir.Location = new System.Drawing.Point(772, 460);
            this.btnMasayiDegistir.Name = "btnMasayiDegistir";
            this.btnMasayiDegistir.Size = new System.Drawing.Size(184, 28);
            this.btnMasayiDegistir.TabIndex = 29;
            this.btnMasayiDegistir.Text = " Masayı Değiştir ";
            this.btnMasayiDegistir.UseVisualStyleBackColor = false;
            this.btnMasayiDegistir.Click += new System.EventHandler(this.btnMasayiDegistir_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "SepetID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Masa_ID
            // 
            this.Masa_ID.DataPropertyName = "MasaID";
            this.Masa_ID.HeaderText = "Masa ID";
            this.Masa_ID.Name = "Masa_ID";
            this.Masa_ID.ReadOnly = true;
            // 
            // _Masa
            // 
            this._Masa.DataPropertyName = "Masa";
            this._Masa.HeaderText = "Masa";
            this._Masa.Name = "_Masa";
            this._Masa.ReadOnly = true;
            // 
            // AcilisTuru
            // 
            this.AcilisTuru.DataPropertyName = "AcilisTuru";
            this.AcilisTuru.HeaderText = "Açılış Türü(dk)";
            this.AcilisTuru.Name = "AcilisTuru";
            this.AcilisTuru.ReadOnly = true;
            // 
            // BaslamaSaati
            // 
            this.BaslamaSaati.DataPropertyName = "Baslangic";
            this.BaslamaSaati.HeaderText = "Başlama Saati";
            this.BaslamaSaati.Name = "BaslamaSaati";
            this.BaslamaSaati.ReadOnly = true;
            this.BaslamaSaati.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BaslamaSaati.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BitisSaati
            // 
            this.BitisSaati.HeaderText = "Bitiş Saati";
            this.BitisSaati.Name = "BitisSaati";
            this.BitisSaati.ReadOnly = true;
            // 
            // Sure
            // 
            this.Sure.HeaderText = "Süre(Saat)";
            this.Sure.Name = "Sure";
            this.Sure.ReadOnly = true;
            // 
            // Tutar
            // 
            this.Tutar.HeaderText = "Tutar(TL)";
            this.Tutar.Name = "Tutar";
            this.Tutar.ReadOnly = true;
            // 
            // _Tarih
            // 
            this._Tarih.DataPropertyName = "Tarih";
            this._Tarih.HeaderText = "Tarih";
            this._Tarih.Name = "_Tarih";
            this._Tarih.ReadOnly = true;
            // 
            // Hesapla
            // 
            this.Hesapla.HeaderText = "Hesapla";
            this.Hesapla.Name = "Hesapla";
            this.Hesapla.ReadOnly = true;
            this.Hesapla.Text = "Hesapla";
            this.Hesapla.ToolTipText = "Hesaplama Yapar";
            this.Hesapla.UseColumnTextForButtonValue = true;
            // 
            // MasaKapat
            // 
            this.MasaKapat.HeaderText = "Masa Kapat";
            this.MasaKapat.Name = "MasaKapat";
            this.MasaKapat.ReadOnly = true;
            this.MasaKapat.Text = "Masa Kapat";
            this.MasaKapat.ToolTipText = "Masayı Kapatır";
            this.MasaKapat.UseColumnTextForButtonValue = true;
            // 
            // btnGeriAl
            // 
            this.btnGeriAl.BackColor = System.Drawing.Color.Yellow;
            this.btnGeriAl.FlatAppearance.BorderSize = 0;
            this.btnGeriAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriAl.Location = new System.Drawing.Point(772, 493);
            this.btnGeriAl.Name = "btnGeriAl";
            this.btnGeriAl.Size = new System.Drawing.Size(184, 28);
            this.btnGeriAl.TabIndex = 30;
            this.btnGeriAl.Text = " Geri Al ";
            this.btnGeriAl.UseVisualStyleBackColor = false;
            this.btnGeriAl.Click += new System.EventHandler(this.btnGeriAl_Click);
            // 
            // btnHareketlerRaporu
            // 
            this.btnHareketlerRaporu.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHareketlerRaporu.FlatAppearance.BorderSize = 0;
            this.btnHareketlerRaporu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHareketlerRaporu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHareketlerRaporu.Location = new System.Drawing.Point(772, 531);
            this.btnHareketlerRaporu.Name = "btnHareketlerRaporu";
            this.btnHareketlerRaporu.Size = new System.Drawing.Size(184, 24);
            this.btnHareketlerRaporu.TabIndex = 31;
            this.btnHareketlerRaporu.Text = "Hareketler Raporu";
            this.btnHareketlerRaporu.UseVisualStyleBackColor = false;
            this.btnHareketlerRaporu.Click += new System.EventHandler(this.btnHareketlerRaporu_Click);
            // 
            // btnSatisRaporu
            // 
            this.btnSatisRaporu.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSatisRaporu.FlatAppearance.BorderSize = 0;
            this.btnSatisRaporu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatisRaporu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisRaporu.Location = new System.Drawing.Point(772, 560);
            this.btnSatisRaporu.Name = "btnSatisRaporu";
            this.btnSatisRaporu.Size = new System.Drawing.Size(184, 24);
            this.btnSatisRaporu.TabIndex = 32;
            this.btnSatisRaporu.Text = "Satış Raporu";
            this.btnSatisRaporu.UseVisualStyleBackColor = false;
            this.btnSatisRaporu.Click += new System.EventHandler(this.btnSatisRaporu_Click);
            // 
            // FrmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(964, 710);
            this.Controls.Add(this.btnSatisRaporu);
            this.Controls.Add(this.btnHareketlerRaporu);
            this.Controls.Add(this.btnGeriAl);
            this.Controls.Add(this.btnMasayiDegistir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSaatUcreti);
            this.Controls.Add(this.btnMasaAc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBosMasalar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Sayfası";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSatis_FormClosing);
            this.Load += new System.EventHandler(this.FrmSatis_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.internetCafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSaatUcretiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbBosMasalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rd30;
        private System.Windows.Forms.RadioButton rdSuresiz;
        private System.Windows.Forms.Button btnMasaAc;
        private System.Windows.Forms.RadioButton rd180;
        private System.Windows.Forms.RadioButton rd150;
        private System.Windows.Forms.RadioButton rd120;
        private System.Windows.Forms.RadioButton rd90;
        private System.Windows.Forms.RadioButton rd60;
        private System.Windows.Forms.RadioButton rd165;
        private System.Windows.Forms.RadioButton rd135;
        private System.Windows.Forms.RadioButton rd105;
        private System.Windows.Forms.RadioButton rd75;
        private System.Windows.Forms.RadioButton rd45;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yöneticiÇağırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem süresizMasaAçmaİsteğiGönderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem süreliMasaAçmaİsteğiGönderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dkToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dkToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dkToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem dkToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem dkToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem dkToolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem dkToolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem dkToolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem dkToolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem masaDeğiştirmeİsteğiGönderToolStripMenuItem;
        private InternetCafeDataSet internetCafeDataSet;
        private System.Windows.Forms.BindingSource tBLSaatUcretiBindingSource;
        private InternetCafeDataSetTableAdapters.TBLSaatUcretiTableAdapter tBLSaatUcretiTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSaatUcreti;
        private System.Windows.Forms.ColumnHeader HareketID;
        private System.Windows.Forms.ColumnHeader KullaniciID;
        private System.Windows.Forms.ColumnHeader MasaID;
        private System.Windows.Forms.ColumnHeader Masa;
        private System.Windows.Forms.ColumnHeader IstekTuru;
        private System.Windows.Forms.ColumnHeader Aciklama;
        private System.Windows.Forms.ColumnHeader Tarih;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnMasayiDegistir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masa_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Masa;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcilisTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaslamaSaati;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitisSaati;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Tarih;
        private System.Windows.Forms.DataGridViewButtonColumn Hesapla;
        private System.Windows.Forms.DataGridViewButtonColumn MasaKapat;
        private System.Windows.Forms.Button btnGeriAl;
        private System.Windows.Forms.Button btnHareketlerRaporu;
        private System.Windows.Forms.Button btnSatisRaporu;
    }
}

