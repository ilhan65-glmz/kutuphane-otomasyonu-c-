using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane_otomasyonu
{
    public partial class frm_uyeekle : Form
    {
        public frm_uyeekle()
        {
            InitializeComponent();
        }

        // veri tabanı bağlantısını yapan kod satırıdır
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\bin\Debug\kutuphaneotomasyonu.accdb");

        public void listele()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from uyeler",baglanti);
            da.Fill(dt);
            datagrr
        }
        private void frm_uyeekle_Load(object sender, EventArgs e)
        {

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open(); //veri tabanı bağlantısını açan kod satırıdır.
            OleDbCommand komut1 = new OleDbCommand("insert into tbl_uyeler" +
                " (tc,adsoyad,yas,cinsiyet,telefon,adres,mail,okudugu_kitap_sayısı)" +
                "values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti);
            komut1.Parameters.AddWithValue("@p1",txttc.Text);
            komut1.Parameters.AddWithValue("@p2", txtad.Text);
            komut1.Parameters.AddWithValue("@p3", txtyas.Text);
            komut1.Parameters.AddWithValue("@p4", comcinsiyet.Text);
            komut1.Parameters.AddWithValue("@p5", txttel.Text);
            komut1.Parameters.AddWithValue("@p6", txtadres.Text);
            komut1.Parameters.AddWithValue("@p7", txtmail.Text);
            komut1.Parameters.AddWithValue("@p8", txtkitapsayısı.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("işlem Başarılı");
       
        }
    }
}
