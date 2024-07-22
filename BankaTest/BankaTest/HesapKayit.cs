using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BankaTest
{
    public partial class HesapKayit : Form
    {
        public HesapKayit()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=AHMET\SQLEXPRESS;Initial Catalog=BANKA;Integrated Security=True");

     

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("insert into Kisiler (Ad,Soyad,Tc,Telefon,HesapNo,Sıfre)" +
                " values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut1.Parameters.AddWithValue("@p1", textAd.Text);
            komut1.Parameters.AddWithValue("@p2", textSoyad.Text);
            komut1.Parameters.AddWithValue("@p3", mtextTc.Text);
            komut1.Parameters.AddWithValue("@p4", mtextTel.Text);
            komut1.Parameters.AddWithValue("@p5", mHesap.Text);
            komut1.Parameters.AddWithValue("@p6", textSifre.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi Kaydedildi");

            textAd.Text = "";
             textSoyad.Text = "";
            mtextTc.Text = "";
            mtextTel.Text = "";
            mHesap.Text = "";
            textSifre.Text = "";
            textAd.Focus();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi=rastgele.Next(100000,1000000);
            mHesap.Text=sayi.ToString();
            if (SayiKullanilmisMi(sayi))
            {
                MessageBox.Show("Bu hesap numarası daha önce kullanılmış. Lütfen tekrar deneyin.");
              
            }
        }
        private bool SayiKullanilmisMi(int sayi)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM Kisiler WHERE HESAPNO = @Sayi", baglanti);
            komut.Parameters.AddWithValue("@Sayi", sayi);
            int kayitSayisi = (int)komut.ExecuteScalar();
            baglanti.Close();

            return kayitSayisi > 0;
        }
    }
}
