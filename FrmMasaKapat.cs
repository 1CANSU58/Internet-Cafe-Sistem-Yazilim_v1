﻿using System;
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
    public partial class FrmMasaKapat: Form
    {
        public FrmMasaKapat()
        {
            InitializeComponent();
        }

        private void btnMasaKapat_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into TBLSatis (KullaniciID, MasaID, AcilisTuru, BaslangicSaati, BitisSaati, Sure, Tutar, Aciklama, Tarih) values ('"+Kullanici.KullaniciID+"','"+int.Parse(txtMasaID.Text)+"','"+txtAcilisTuru.Text+"',@Baslangic, @Bitis, @Sure, @Tutar, 'YAPILMADI', @Tarih)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@Baslangic", DateTime.Parse(txtBaslamaSaati.Text));
            cmd.Parameters.AddWithValue("@Bitis", DateTime.Parse(txtBitisSaati.Text));
            cmd.Parameters.AddWithValue("@Sure", decimal.Parse(txtSure.Text));
            cmd.Parameters.AddWithValue("@Tutar", decimal.Parse(txtTutar.Text));
            cmd.Parameters.AddWithValue("@Tarih", DateTime.Parse(txtTarih.Text));
            Veritabani.ESG(cmd, sorgu);
            /*
            string sqlsorgu = "update TBLMasalar set Durumu = 'BOŞ' where MasaID = '"+txtMasaID.Text+"'";
            SqlCommand komut = new SqlCommand();
            Veritabani.ESG(komut, sqlsorgu);
            string sqlsorgu2 = "delete from TBLSepet where SepetID = '"+txtID.Text+"'";
            SqlCommand komut2 = new SqlCommand();
            Veritabani.ESG(komut2, sqlsorgu2);
            */
            this.Close();
            FrmSatis frm = (FrmSatis)Application.OpenForms["FrmSatis"];
            frm.Yenile();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
