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
    public partial class Hareketler : Form
    {
        public Hareketler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=AHMET\SQLEXPRESS;Initial Catalog=BANKA;Integrated Security=True");



        private void Hareketler_Load(object sender, EventArgs e)
        {
        
            this.hareketDüzeniTableAdapter.Fill(this.bANKADataSet1.HareketDüzeni);
          
        
          /*  baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Hareket", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();  */
        }
    }
}
