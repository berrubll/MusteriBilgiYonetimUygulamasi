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

public partial class NewCustomer : Form
{
    private string cnnString;
    
    public NewCustomer(string connectionString)
    {
        InitializeComponent();
        cnnString = connectionString;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        string name = nameTxt.Text;
        string surname = surnameTxt.Text;
        string email = mailTxt.Text;
        string phone = phoneTxt.Text;  
        string address = adressTxt.Text; 

        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(email) || 
            string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(address))
        {
            MessageBox.Show("Lütfen tüm alanları doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            MySqlConnection baglanti = new MySqlConnection(cnnString);
        
            string query = "INSERT INTO Musteriler (Ad, Soyad, Email, Telefon, Adres, Aktifmi) VALUES (@Name, @Surname, @Email, @Phone, @Address, @Aktifmi)";

            MySqlCommand cmd = new MySqlCommand(query, baglanti);

            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Surname", surname);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@Aktifmi", 1);

            baglanti.Open();
            cmd.ExecuteNonQuery(); 
            baglanti.Close();

            MessageBox.Show("Yeni müşteri başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Müşteri eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}