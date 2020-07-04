using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane_otomasyonu
{
    public partial class Anasayfa_frm : Form
    {
        public Anasayfa_frm()
        {
            InitializeComponent();
        }

        private void btnuyeekleme_Click(object sender, EventArgs e)
        {//üye ekleme işlemleri adlı butona tıklanıldığında üye ekleme sayfasına gönderen kod satırıdır 
            frm_uyeekle a = new frm_uyeekle();
            a.ShowDialog();
        }
    }
}
