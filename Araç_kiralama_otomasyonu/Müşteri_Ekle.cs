using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araç_kiralama_otomasyonu
{
    public partial class Müşteri_Ekle : Form
    {
        public Müşteri_Ekle()
        {
            InitializeComponent();
        }

    
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Anasayfa getir = new Anasayfa();
            getir.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
