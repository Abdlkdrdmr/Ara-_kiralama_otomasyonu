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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Müşteri_Ekle geçmek = new Müşteri_Ekle();
            geçmek.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Müşteri_Lİstele geçmek2=new Müşteri_Lİstele();
            geçmek2.Show();
            this.Hide();
        }
    }
}
