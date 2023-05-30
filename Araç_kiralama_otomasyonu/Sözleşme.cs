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
    public partial class Sözleşme : Form
    {
        public Sözleşme()
        {
            InitializeComponent();
        }

 
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Anasayfa getir4 = new Anasayfa();
            getir4.Show();
            this.Hide();
        }
    }
}
