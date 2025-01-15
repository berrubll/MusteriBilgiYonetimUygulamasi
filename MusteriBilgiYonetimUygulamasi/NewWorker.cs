using System;
using System.Data;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MusteriBilgiYonetimUygulamasi;

public partial class NewWorker : Form
{
    private string cnnString;
    private bool permission;
    
    public NewWorker(string connectionString)
    {
        InitializeComponent();
        cnnString = connectionString;
    }

    private void workerRdrBtn_CheckedChanged(object sender, EventArgs e)
    {
        if (workerRdrBtn.Checked == true)
        {
            managerRdrBtn.Checked = false;
            permission = false;
        }
    }

    private void managerRdrBtn_CheckedChanged(object sender, EventArgs e)
    {
        if (managerRdrBtn.Checked == true)
        {
            workerRdrBtn.Checked = false;
            permission = true;
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string name = nameTxt.Text;
        string username = usernameTxt.Text;
        string password = passTxt.Text; 

        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        {
            MessageBox.Show("Lütfen tüm alanları doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        
        try
        {
            MySqlConnection baglanti = new MySqlConnection(cnnString);
        
            string query = "INSERT INTO Calisanlar (KullaniciAdi, Parola, Yetki, AdSoyad) VALUES (@KullaniciAdi, @Parola, @Yetki, @AdSoyad)";

            MySqlCommand cmd = new MySqlCommand(query, baglanti);

            cmd.Parameters.AddWithValue("@KullaniciAdi", username);
            cmd.Parameters.AddWithValue("@Parola", password);
            cmd.Parameters.AddWithValue("@Yetki", Convert.ToInt32(permission));
            cmd.Parameters.AddWithValue("@AdSoyad", name);

            baglanti.Open();
            cmd.ExecuteNonQuery(); 
            baglanti.Close();

            MessageBox.Show("Yeni çalışan başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Çalışan eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}