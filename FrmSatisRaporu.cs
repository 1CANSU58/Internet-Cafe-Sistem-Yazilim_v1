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
    public partial class FrmSatisRaporu: Form
    {
        public FrmSatisRaporu()
        {
            InitializeComponent();
        }

        private void FrmSatisRaporu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'InternetCafeDataSet.TBLSatis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.TBLSatisTableAdapter.Fill(this.InternetCafeDataSet.TBLSatis);

            this.reportViewer1.RefreshReport();
        }
    }
}
