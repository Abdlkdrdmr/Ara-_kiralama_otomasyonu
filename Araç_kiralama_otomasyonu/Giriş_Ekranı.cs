using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Araç_kiralama_otomasyonu
{
    public partial class Giriş_Ekranı : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;
        public Giriş_Ekranı()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            string user= textBox1.Text;
            string sifre= textBox2.Text;
            con= new SqlConnection("Data Source=DESKTOP-35DQS5A;Initial Catalog=Araç_KİRALAMA;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection= con;
            cmd.CommandText = "Select* From KULLANICI where kullanıcı_adı= '" + textBox1.Text + "'And sifre='" + textBox2.Text + "'";
            dr= cmd.ExecuteReader();
            if (dr.Read())
            {
                Anasayfa geçiş =new Anasayfa();
                geçiş.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre hatalı.");
            }
            
            con.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar= false;
            }
        }
    }
}
