 using System;
 using System.Data;
 using System.Collections.Generic;
 using System.Drawing;
 using System.IO;
 using System.Linq;
 using System.Net.Http;
 using System.Threading;
 using System.Threading.Tasks;
 using System.Windows.Forms;
 using MySql.Data.MySqlClient;

namespace MusteriBilgiYonetimUygulamasi
{
    public partial class LoginScreen : Form
    {
        private string cnnString;
        private MySqlConnection baglanti;
        
        public LoginScreen(string connectionString)
        {
            InitializeComponent();
            cnnString = connectionString;
            baglanti = new MySqlConnection(cnnString);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string kullaniciAdi = textBox1.Text;
                string parola = textBox2.Text;

                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("SELECT * FROM Calisanlar WHERE KullaniciAdi = @KullaniciAdi AND Parola = @Parola", baglanti);
                komut.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                komut.Parameters.AddWithValue("@Parola", parola);
                
                MySqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    this.Hide();
                    baglanti.Close();
                    Main mainForm = new Main(kullaniciAdi, cnnString);
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya parola yanlış", 
                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sunucuya bağlanılamadı " + ex.Message, 
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
