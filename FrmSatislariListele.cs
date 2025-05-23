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
    public partial class FrmSatislariListele: Form
    {
        public FrmSatislariListele()
        {
            InitializeComponent();
        }

        private void FrmSatislariListele_Load(object sender, EventArgs e)
        {
            Veritabani.Listele(dataGridView1, "select * from TBLSatis");
        }

        private void btnIslemiGeriAl_Click(object sender, EventArgs e)
        {
            int masaID = int.Parse(dataGridView1.CurrentRow.Cells["MasaID"].Value.ToString());
            int kullaniciID = int.Parse(dataGridView1.CurrentRow.Cells["KullaniciID"].Value.ToString());
            string masa = "Masa - " + masaID;
            string acilisturu = dataGridView1.CurrentRow.Cells["AcilisTuru"].Value.ToString();
            DateTime baslangic = DateTime.Parse(dataGridView1.CurrentRow.Cells["Baslangic"].Value.ToString());
            DateTime tarih = DateTime.Parse(dataGridView1.CurrentRow.Cells["Tarih"].Value.ToString());
            string sql = "insert into TBLSepet (MasaID, Masa, AcilisTuru, Baslangic, Tarih) values ( " + " '"+masaID+"','"+masa+"','"+acilisturu+"',@Baslangic,@Tarih)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@Baslangic", baslangic);
            cmd.Parameters.AddWithValue("@Tarih", tarih);
            Veritabani.ESG(cmd, sql);

            string sql2 = "delete from TBLSatis where SatisID = '" + int.Parse(dataGridView1.CurrentRow.Cells["SatisID"].Value.ToString())+"'";
            SqlCommand cmd2 = new SqlCommand();
            Veritabani.ESG(cmd2,sql2);

            this.Close();
            FrmSatis frm = (FrmSatis)Application.OpenForms["FrmSatis"];
            frm.Yenile();

        }
    }
}
