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
    public partial class Müşteri_Lİstele : Form
    {
        public Müşteri_Lİstele()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Anasayfa getir2 = new Anasayfa();
            getir2.Show();
            this.Hide();
        }
    }
}
