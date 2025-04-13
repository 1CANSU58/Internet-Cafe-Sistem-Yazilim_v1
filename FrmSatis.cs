using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetCafeSistem
{
    public partial class FrmSatis: Form
    {


        public FrmSatis()
        {
            InitializeComponent();
        }

        //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6KIJ0IH\SQLEXPRESS;Initial Catalog=InternetCafe;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True");
        //TrustServerCertificate=True

        Button btn;

        private void SecileneGore(object sender, MouseEventArgs e)
        {
            //Button btn = sender as Button;
            //MessageBox.Show(btn + " tıklandı. ");
            btn = sender as Button;
            if (btn.BackColor == Color.OrangeRed)
            {
                süreliMasaAçmaİsteğiGönderToolStripMenuItem.Visible = false;
                süresizMasaAçmaİsteğiGönderToolStripMenuItem.Visible = false;
            }
            if (btn.BackColor == Color.LightGreen)
            {
                süreliMasaAçmaİsteğiGönderToolStripMenuItem.Visible = true;
                süresizMasaAçmaİsteğiGönderToolStripMenuItem.Visible = true;
            }
        }

        RadioButton radio;

        private void RadioButtonSeciliyeGore(object sender, EventArgs e)
        {
            radio = sender as RadioButton;
        }

        public void Yenile()
        {

            Veritabani.SepetListele(dataGridView1);
            Veritabani.ListviewdeKayitlariGoster(listView1);
            Veritabani.ComboyaBosMasaGetir(cbBosMasalar);

            /*
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from TBLMasalar where Durumu = 'BOŞ'", baglanti);
            DataTable tbl = new DataTable();
            adtr.Fill(tbl);
            cbBosMasalar.DataSource = tbl;
            cbBosMasalar.DisplayMember = "Masalar";
            cbBosMasalar.ValueMember = "MasaID";
            baglanti.Close();
            */
            foreach (Control item in Controls)
            {
                if(item is Button)
                {
                    if (item.Name != btnMasaAc.Name)
                    {
                        Veritabani.baglanti.Open();
                        SqlCommand komut = new SqlCommand("select * from TBLMasalar", Veritabani.baglanti);
                        SqlDataReader dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            if (dr["Durumu"].ToString() == "BOŞ" && dr["Masalar"].ToString() == item.Text)
                            {
                                item.BackColor = Color.LightGreen;
                            }
                            if (dr["Durumu"].ToString() == "DOLU" && dr["Masalar"].ToString() == item.Text)
                            {
                                item.BackColor = Color.OrangeRed;
                            }
                        }
                        Veritabani.baglanti.Close();
                    }
                }
            }
        }

        private void FrmSatis_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'internetCafeDataSet.TBLMasalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tBLMasalarTableAdapter.Fill(this.internetCafeDataSet.TBLMasalar);
            // TODO: Bu kod satırı 'internetCafeDataSet.TBLSaatUcreti' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLSaatUcretiTableAdapter.Fill(this.internetCafeDataSet.TBLSaatUcreti);
            rdSuresiz.Checked = true;
            Yenile();
            cbBosMasalar.Text = "";
            timer1.Start();
        }

        private void btnMasaAc_Click(object sender, EventArgs e)
        {
            if (Kullanici.KullaniciID == 1)
            {
                //string sqlsorgu = "insert into TBLSepet(MasaID, Masa, AcilisTuru, Baslangic, Tarih) values('" + cbBosMasalar.Text.Substring(6) + "', '" + cbBosMasalar.Text + "', '" + radio.Text + "', '" + DateTime.Parse(DateTime.Now.ToString()) + "', '" + DateTime.Parse(DateTime.Now.ToString()) + "')";
                string sqlsorgu = "insert into TBLSepet(MasaID, Masa, AcilisTuru, Baslangic, Tarih) values('" + cbBosMasalar.Text.Substring(6) + "', '" + cbBosMasalar.Text + "', '" + radio.Text + "', @Baslangic, @Tarih)";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.AddWithValue("@Baslangic", DateTime.Parse(DateTime.Now.ToString()));
                komut.Parameters.AddWithValue("@Tarih", DateTime.Parse(DateTime.Now.ToString()));
                Veritabani.ESG(komut, sqlsorgu);
                MessageBox.Show(cbBosMasalar.Text + " AÇILDI ", "BILGI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Yenile();
                rdSuresiz.Checked = true;
                
            }
            else
            {
                MessageBox.Show(" Yetkiniz Bulunmamaktadır ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmSatis_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Hesapla"].Index)
            {
                //MessageBox.Show("Hesaplama Yapılıyor");
                if (cbSaatUcreti.Text != "")
                {
                    DateTime BitisTarihi = DateTime.Now;
                    DateTime BaslangicTarihi = DateTime.Parse(dataGridView1.CurrentRow.Cells["BaslamaSaati"].Value.ToString());
                    TimeSpan saatfarki = BitisTarihi - BaslangicTarihi;
                    double saatfarki2 = saatfarki.TotalHours;
                    dataGridView1.CurrentRow.Cells["Sure"].Value = saatfarki2.ToString("0.00");
                    double toplamtutar = saatfarki2 * double.Parse(cbSaatUcreti.Text);
                    dataGridView1.CurrentRow.Cells["Tutar"].Value = toplamtutar.ToString("0.00");
                    dataGridView1.CurrentRow.Cells["BitisSaati"].Value = BitisTarihi;
                }
                if (cbSaatUcreti.Text == "")
                {
                    MessageBox.Show(" Saat Ücretini Belirt ","BILGI",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (e.ColumnIndex == dataGridView1.Columns["MasaKapat"].Index)
            {
                if (dataGridView1.CurrentRow.Cells["BitisSaati"].Value != null)
                {
                    FrmMasaKapat frm = new FrmMasaKapat();
                    frm.txtID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                    frm.txtMasaID.Text = dataGridView1.CurrentRow.Cells["Masa_ID"].Value.ToString();
                    frm.txtMasa.Text = dataGridView1.CurrentRow.Cells["_Masa"].Value.ToString();
                    frm.txtAcilisTuru.Text = dataGridView1.CurrentRow.Cells["AcilisTuru"].Value.ToString();
                    frm.txtBaslamaSaati.Text = dataGridView1.CurrentRow.Cells["BaslamaSaati"].Value.ToString();
                    frm.txtBitisSaati.Text = dataGridView1.CurrentRow.Cells["BitisSaati"].Value.ToString();
                    frm.txtSaatUcreti.Text = cbSaatUcreti.Text;
                    frm.txtSure.Text = dataGridView1.CurrentRow.Cells["Sure"].Value.ToString();
                    frm.txtTutar.Text = dataGridView1.CurrentRow.Cells["Tutar"].Value.ToString();
                    frm.txtTarih.Text = dataGridView1.CurrentRow.Cells["_Tarih"].Value.ToString();
                    frm.ShowDialog();
                }
                else if (dataGridView1.CurrentRow.Cells["BitisSaati"].Value == null)
                {
                    MessageBox.Show(" Öncelikle Hesaplama Yapınız ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        string istek = "";

        private void yöneticiÇağırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            istek = "Yöneticiyi Çağırıyor !..";
            Istekler();
        }

        private void Istekler()
        {
            string sqlsorgu = "insert into TBLHareketler (KullaniciID, MasaID, Masa, IstekTuru, Aciklama, Tarih) values('" + Kullanici.KullaniciID + "','" + btn.Text.Substring(6) + "','" + btn.Text + "','" + istek + "','YAPILMADI', @Tarih)";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.AddWithValue("@Tarih", DateTime.Parse(DateTime.Now.ToString()));
            Veritabani.ESG(komut, sqlsorgu);
            Veritabani.ListviewdeKayitlariGoster(listView1);
        }

        private void süresizMasaAçmaİsteğiGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            istek = "Süresiz Masa Açma İsteği Gönderdi !..";
            Istekler();
        }

        private void masaDeğiştirmeİsteğiGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            istek = "Masa Değiştirme İsteği Gönderdi !..";
            Istekler();
        }

        ToolStripMenuItem item;

        private void SureliIstekSecilirse(object sender, EventArgs e)
        {
            item = sender as ToolStripMenuItem;
            istek = item.Text + " Süre Masa Açma İsteği Gönderdi !.. ";
            Istekler();
        }

        int sayac = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac > 29)
            {
                if (cbSaatUcreti.Text != "")
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        DateTime BitisTarihi = DateTime.Now;
                        DateTime BaslangicTarihi = DateTime.Parse(dataGridView1.Rows[i].Cells["BaslamaSaati"].Value.ToString());
                        TimeSpan saatfarki = BitisTarihi - BaslangicTarihi;
                        double saatfarki2 = saatfarki.TotalHours;
                        dataGridView1.Rows[i].Cells["Sure"].Value = saatfarki2.ToString("0.00");
                        double toplamtutar = saatfarki2 * double.Parse(cbSaatUcreti.Text);
                        dataGridView1.Rows[i].Cells["Tutar"].Value = toplamtutar.ToString("0.00");
                        dataGridView1.Rows[i].Cells["BitisSaati"].Value = BitisTarihi; 
                    }
                }
                if (cbSaatUcreti.Text == "")
                {
                    MessageBox.Show(" Saat Ücretini Belirt ", "BILGI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnMasayiDegistir_Click(object sender, EventArgs e)
        {

            int SepetID = int.Parse(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
            int MasaID = int.Parse(dataGridView1.CurrentRow.Cells["Masa_ID"].Value.ToString());

            //ISLEM BIR
            string sql1 = "update TBLSepet set MasaID = '" + int.Parse(cbBosMasalar.Text.Substring(6)) + "', Masa = '" + cbBosMasalar.Text + "' where SepetID = '"+ SepetID +"'";
            SqlCommand cmd1 = new SqlCommand();
            Veritabani.ESG(cmd1, sql1);

            //ISLEM IKI
            string sql2 = "update TBLMasalar set Durumu = 'BOŞ' where MasaID = '" + MasaID + "'";
            SqlCommand cmd2 = new SqlCommand();
            Veritabani.ESG(cmd2, sql2);

            //ISLEM UC
            string sql3 = "update TBLMasalar set Durumu = 'DOLU' where MasaID = '" + int.Parse(cbBosMasalar.Text.Substring(6)) + "'";
            SqlCommand cmd3 = new SqlCommand();
            Veritabani.ESG(cmd3, sql3);
            Yenile();
            MessageBox.Show("Masa Değiştirme BAŞARILI", "BILGI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells["Sure"].Value != null)
                {
                    if (dataGridView1.Rows[i].Cells["AcilisTuru"].Value.ToString() != "Süresiz")
                    {
                        /*
                         * ACILIS TURU STRING VERI TIPI KAYNAKLI FARKLI COZUM YOLUNA GIDILMISTIR
                        double sure = double.Parse(dataGridView1.Rows[i].Cells["Sure"].Value.ToString()) * 60;
                        double Acilisturu = double.Parse(dataGridView1.Rows[i].Cells["AcilisTuru"].Value.ToString());
                        if (Acilisturu - sure <= 5.0)
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        }
                        */


                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightYellow;

                    }
                }
            }
        }

        private void btnGeriAl_Click(object sender, EventArgs e)
        {
            FrmSatislariListele frm = new FrmSatislariListele();
            frm.Enabled = true;
            frm.ShowDialog();
        }

        private void btnSatisRaporu_Click(object sender, EventArgs e)
        {
            FrmSatisRaporu frm = new FrmSatisRaporu();
            frm.ShowDialog();

        }

        private void btnHareketlerRaporu_Click(object sender, EventArgs e)
        {
            FrmHareketRaporu frm = new FrmHareketRaporu();
            frm.ShowDialog();
        }
    }
}
