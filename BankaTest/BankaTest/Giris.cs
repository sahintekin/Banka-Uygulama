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


namespace BankaTest
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
            
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=AHMET\SQLEXPRESS;Initial Catalog=BANKA;Integrated Security=True");
       
      


        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Kisiler where HESAPNO=@P1 AND SIFRE=@P2", baglanti);
            komut.Parameters.AddWithValue("@P1", mTextHesap.Text);
            komut.Parameters.AddWithValue("@P2", textSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                string ad = dr["AD"].ToString();
                string soyad = dr["SOYAD"].ToString();
                AnaSayfa frm = new AnaSayfa();
              
                frm.hesap=mTextHesap.Text;
                MessageBox.Show($"{ad} {soyad} Giriş yaptı.", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm.ShowDialog();



            }
            else
            {
                MessageBox.Show("Hatalı Bilgi");
                mTextHesap.Text = "";
                textSifre.Text = "";
                mTextHesap.Focus();
            }
            baglanti.Close();
          
        }

        private void linkLabelKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           

            Yukleniyor frma = new Yukleniyor();
            frma.ShowDialog();
              
        }

        
    }
}
