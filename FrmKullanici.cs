using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetCafeSistem
{
    public partial class FrmKullanici: Form
    {
        public FrmKullanici()
        {
            InitializeComponent();
            zgoster();
        }

        public void zgoster()
        {
            lblzaman.Text = DateTime.Now.ToString();
        }


        private void lblKullaniciFrmKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtKullaniciID.Text = "";
            txtKullaniciSifre.Text = "";
            chkbBeniHatirla.Checked = true;
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtKullaniciID.Text == "" || txtKullaniciSifre.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakılamaz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                Kullanici.KullaniciGirisi(txtKullaniciID, txtKullaniciSifre);
                {
                    if (Kullanici.durum == true)
                    {
                        FrmSatis frm = new FrmSatis();
                        frm.Show();
                        this.Hide();
                    }
                    else if (Kullanici.durum == false)
                    {
                        MessageBox.Show("Kullanıcı ID veya Kullanıcı Şifre Hatalı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
        }
    }
}
