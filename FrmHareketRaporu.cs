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
    public partial class FrmHareketRaporu: Form
    {
        public FrmHareketRaporu()
        {
            InitializeComponent();
        }

        private void FrmHareketRaporu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'InternetCafeDataSet.TBLHareketler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.TBLHareketlerTableAdapter.Fill(this.InternetCafeDataSet.TBLHareketler);
            // TODO: Bu kod satırı 'InternetCafeDataSet.TBLKullanici' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.TBLKullaniciTableAdapter.Fill(this.InternetCafeDataSet.TBLKullanici);

            this.reportViewer1.RefreshReport();
        }
    }
}
