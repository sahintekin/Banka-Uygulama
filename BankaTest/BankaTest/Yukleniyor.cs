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
    public partial class Yukleniyor : Form
    {
        public Yukleniyor()
        {
            InitializeComponent();
            progBar.Value = 0;
        }


        private void Yukleniyor_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            progBar.Value +=1;
            progBar.Text = progBar.Value.ToString() + "%";
            if (progBar.Value == 100)
            {
                timer1.Enabled = false;
                HesapKayit frm = new HesapKayit();
                frm.ShowDialog();
                this.Hide();
               ;
            }
        }

      
    }
}
