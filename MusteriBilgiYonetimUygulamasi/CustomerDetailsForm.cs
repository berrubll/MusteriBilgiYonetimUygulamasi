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

public partial class CustomerDetailsForm : Form
{
    private MySqlConnection baglanti;
    private int customerID;
    private string customerName;
    private string customerSurname;
    private string customerAddress;
    private string customerPhone;
    private string customerEmail;
    private bool isActive;
    
    public CustomerDetailsForm(string customerId, string connectionString)
    {
        InitializeComponent();
        baglanti = new MySqlConnection(connectionString);
        customerID = Int32.Parse(customerId);
        GetCustomerInfo();
        SetCustomerInfo();
    }

    private void SetCustomerInfo()
    {
        this.Text = "Müşteri Detay - " + customerName;
        nameTxt.Text = customerName;
        surnameTxt.Text = customerSurname;
        phoneTxt.Text = customerPhone;
        mailTxt.Text = customerEmail;
        adressTxt.Text = customerAddress;
        checkBox1.Checked = isActive;
        GetBills();
    }
    
    private void GetCustomerInfo()
    {
        try
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("SELECT * FROM Musteriler WHERE MusteriID = @musteriID", baglanti);
            komut.Parameters.AddWithValue("@musteriID", customerID);
            MySqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                customerName = dr.GetString(1);
                customerSurname = dr.GetString(2);
                customerAddress = dr.GetString(5);
                customerPhone = dr.GetString(3);
                customerEmail = dr.GetString(4);
                isActive = dr.GetBoolean(6);
            }
            else
            {
                MessageBox.Show("Kullanıcı bilgisi bulunamadı.", 
                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Sunucuya bağlanılamadı: " + ex.Message, 
                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            if (baglanti.State == System.Data.ConnectionState.Open)
            {
                baglanti.Close();
            }
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            baglanti.Open();

            string query = "UPDATE Musteriler SET Ad = @Name, Soyad = @Surname, Telefon = @Phone, Email = @Email, Adres = @Adress, Aktifmi = @Aktifmi WHERE MusteriID = @CustomerID";
            MySqlCommand komut = new MySqlCommand(query, baglanti);

            komut.Parameters.AddWithValue("@Name", nameTxt.Text);
            komut.Parameters.AddWithValue("@Surname", surnameTxt.Text);
            komut.Parameters.AddWithValue("@Phone", phoneTxt.Text);
            komut.Parameters.AddWithValue("@Email", mailTxt.Text);
            komut.Parameters.AddWithValue("@Adress", adressTxt.Text);
            komut.Parameters.AddWithValue("@CustomerID", customerID);
            komut.Parameters.AddWithValue("@Aktifmi", checkBox1.Checked);

            int affectedRows = komut.ExecuteNonQuery();

            if (affectedRows > 0)
            {
                MessageBox.Show("Müşteri bilgileri başarıyla güncellendi",
                    "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Müşteri bilgileri güncellenemedi. Müşteri bulunamadı.",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Bir hata oluştu: " + ex.Message,
                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            if (baglanti.State == System.Data.ConnectionState.Open)
            {
                baglanti.Close();
            }
        }
    }

    private void button2_Click_1(object sender, EventArgs e)
    {
        this.Close();
    }

    private void GetBills()
    {
        faturaListPanel.Controls.Clear();
        
        try
        {
            string query = "SELECT * FROM Faturalar WHERE MusteriID = " + customerID;
            MySqlCommand komut = new MySqlCommand(query, baglanti);

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            
            MySqlDataReader reader = komut.ExecuteReader();

            int yOffset = 0;

            while (reader.Read())
            {
                string faturaId = reader["FaturaId"].ToString();
                string faturaTutar = reader["Tutar"].ToString();
                int odemeYontemi = Convert.ToInt32(reader["OdemeYontemi"].ToString());

                Panel faturaPanel = new Panel
                {
                    Size = new Size(506, 51),
                    Location = new Point(3, yOffset),
                    BackColor = Color.DimGray
                };

                Label lblId = new Label
                {
                    Text = faturaId,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(0, 0),
                    Size = new Size(85, 51),
                    Font = new Font("SF Pro Rounded", 10)
                };
                faturaPanel.Controls.Add(lblId);

                Label lblTutar = new Label
                {
                    Text = faturaTutar + "TL",
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(91, 3),
                    Size = new Size(138, 51),
                    Font = new Font("SF Pro Rounded", 10)
                };
                faturaPanel.Controls.Add(lblTutar);

                Label lblOdemeYontemi = new Label
                {
                    Text = "Ödeme Yöntemi Bulunamadı",
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(235, 3),
                    Size = new Size(138, 51),
                    Font = new Font("SF Pro Rounded", 10)
                };
                faturaPanel.Controls.Add(lblOdemeYontemi);

                if (odemeYontemi == 0)
                {
                    lblOdemeYontemi.Text = "Nakit";
                }
                else if(odemeYontemi == 1)
                {
                    lblOdemeYontemi.Text = "Kredi Kartı";
                }
                
                Button btnDetails = new Button
                {
                    Text = "Detay Gör",
                    Location = new Point(379, 3),
                    Size = new Size(124, 45),
                    Font = new Font("SF Pro Rounded", 10),
                    BackColor = Color.FromArgb(0, 122, 204),
                    ForeColor = Color.White
                };
                btnDetails.Click += (sender, e) => ShowBillDetails(faturaId);
                faturaPanel.Controls.Add(btnDetails);
                
                faturaListPanel.Controls.Add(faturaPanel);

                yOffset += 60;
            }
            
            reader.Close();
            baglanti.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }
    
    private void ShowBillDetails(string faturaId)
    {
        BillDetailForm billDetailForm = new BillDetailForm(Convert.ToInt32(faturaId), baglanti.ConnectionString, this.customerName, this.customerPhone, this.customerEmail, this.customerAddress);
        billDetailForm.FormClosed += BillDetailForm_FormClosed;
        billDetailForm.Show();
    }

    private void BillDetailForm_FormClosed(object? sender, FormClosedEventArgs e)
    {
        GetBills();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        NewBillForm newBillForm = new NewBillForm(baglanti.ConnectionString, customerID, customerName, customerSurname, customerPhone, customerEmail, customerAddress);
        newBillForm.FormClosed += NewBillForm_FormClosed;
        newBillForm.Show();
    }
    
    private void NewBillForm_FormClosed(object? sender, FormClosedEventArgs e)
    {
        GetBills();
    }
}