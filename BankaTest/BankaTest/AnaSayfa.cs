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
using System.Data.SqlClient;


namespace BankaTest
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=AHMET\SQLEXPRESS;Initial Catalog=BANKA;Integrated Security=True");
        public string hesap;



        private void AnaSayfa_Load(object sender, EventArgs e)
        {
           
            baglanti.Open();
            lblHesap.Text = hesap;
            SqlCommand komut = new SqlCommand("select * from Kisiler where hesapno=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1", hesap);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAd.Text = dr[1] + " " + dr[2];
                lblTc.Text = dr[3].ToString();
                lblTel.Text = dr[4].ToString();
            }
            dr.Close();
            baglanti.Close();

            // bakiye okuma 

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from HesapTest ", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            if (dr2.Read())
            {
                lblBakiye.Text = dr2["BAKIYE"].ToString();
            }
            dr2.Close();
            baglanti.Close();

        }

        private void btnGonder_Click(object sender, EventArgs e)
        {

            try
            {
                // göndereilen hesabın para artışı 
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update HesapTest set bakıye=bakıye+@p1 where hesapno=@p2", baglanti);
                komut.Parameters.AddWithValue("@p1", decimal.Parse(texTutar.Text));
                komut.Parameters.AddWithValue("@p2", mHesap.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();


                // göndereilen hesabın para artışı 
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update HesapTest set bakıye=bakıye-@k1 where hesapno=@k2", baglanti);
                komut2.Parameters.AddWithValue("@k1", decimal.Parse(texTutar.Text));
                komut2.Parameters.AddWithValue("@k2", hesap);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Havale Gerçekleştirildi");

                // Hareketleri
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("insert into Hareket (gonderen,alıcı,tutar) values (@p1,@p2,@p3) ", baglanti);
                komut3.Parameters.AddWithValue("@p1", hesap);
                komut3.Parameters.AddWithValue("@p2", mHesap.Text);
                komut3.Parameters.AddWithValue("@p3", decimal.Parse(texTutar.Text));
                komut3.ExecuteNonQuery();
                baglanti.Close();


            }
            catch (Exception)
            {

                MessageBox.Show("Alanlar bpş bırakılamaz");
            }
            
            
           


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hareketler frm= new Hareketler();
            frm.ShowDialog();
        }
    }
}
