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
    public partial class Araç_EKLE_SİL : Form
    {
        public Araç_EKLE_SİL()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Anasayfa getir3 = new Anasayfa();
            getir3.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
