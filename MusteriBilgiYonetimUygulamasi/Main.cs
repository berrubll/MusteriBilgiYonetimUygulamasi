using System;
using System.Data;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MusteriBilgiYonetimUygulamasi;

public partial class Main : Form
{
    private MySqlConnection baglanti;
    private string loggedUserName;
    private int userID;
    private int userPermission;
    string cnnString;
    
    public Main(string kullaniciAdi, string connectionString)
    {
        InitializeComponent();
        baglanti = new MySqlConnection(connectionString);
        cnnString = connectionString;
        this.Text = "Müşteri Bilgi Yonetim Uygulamasi - Anasayfa";
        loggedUserName = kullaniciAdi;
        GetUserInfo();
        userLabelTxt.Text = "Hoşgeldin " + kullaniciAdi;
        UpdateMainDashboard();
    }

    private void GetUserInfo()
    {
        try
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            
            MySqlCommand komut = new MySqlCommand("SELECT * FROM Calisanlar WHERE KullaniciAdi = @KullaniciAdi", baglanti);
            komut.Parameters.AddWithValue("@KullaniciAdi", loggedUserName);
            MySqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                userID = dr.GetInt32(0);
                prfUsernameTxt.Text = loggedUserName;
                prfPassTxt.Text = dr.GetString(2);
                userPermission = dr.GetInt32(3);

                if (userPermission == 0)
                {
                    permissionTxt.Text = "Çalışan";
                }
                else if (userPermission == 1)
                {
                    permissionTxt.Text = "Yönetici";
                }
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

    private async Task UpdateMainDashboard()
    {
        Font nonPermissionFont = new Font("Poppins", 9);

        progressBar1.Minimum = 0;
        progressBar1.Maximum = 100;
        progressBar1.Value = 0;
        progressBar1.Step = 20;

        GetTotalCustomerCount();
        progressBar1.PerformStep();

        if (userPermission == 0)
        {
            totalBillCountTxt.Text = "Bu bilgiyi görme yetkiniz bulunmamaktadır!";
            totalBillCountTxt.Font = nonPermissionFont;
            totalSellAmountTxt.Text = "Bu bilgiyi görme yetkiniz bulunmamaktadır!";
            totalSellAmountTxt.Font = nonPermissionFont;
            totalWorkerCountTxt.Text = "Bu bilgiyi görme yetkiniz bulunmamaktadır!";
            totalWorkerCountTxt.Font = nonPermissionFont;
            managerCountTxt.Text = "Bu bilgiyi görme yetkiniz bulunmamaktadır!";
            managerCountTxt.Font = nonPermissionFont;
            workerCountTxt.Text = "Bu bilgiyi görme yetkiniz bulunmamaktadır!";
            workerCountTxt.Font = nonPermissionFont;
            cashBillTxt.Text = "Bu bilgiyi görme yetkiniz bulunmamaktadır!";
            cashBillTxt.Font = nonPermissionFont;

            progressBar1.Value = progressBar1.Maximum;
        }
        else
        {
            GetTotalWorkerCount();
            progressBar1.PerformStep();
            int activeCustomerCount = await GetActiveCustomerCount();
            progressBar1.PerformStep();
            int nonActiveCustomerCount = await GetNonActiveCustomerCount();
            progressBar1.PerformStep();
            int totalBillCount = await TotalBillCount();
            progressBar1.PerformStep();
            decimal totalBillsValue = await TotalBillsValue();
            progressBar1.PerformStep();
            int totalCashBill = await TotalCashBill();
            progressBar1.PerformStep();
            int totalCreditBill = await TotalCreditBill();
            progressBar1.PerformStep();
            int totalManagerCount = await TotalManagerCount();
            progressBar1.PerformStep();
            int totalWorkerCount = await TotalWorkerCount();
            progressBar1.PerformStep();
        }

        progressBar1.Value = progressBar1.Maximum;
    }
    
    private void LoadCustomerList()
    {
        custListPanel.Controls.Clear();
        GetTotalCustomerCount();
        
        try
        {
            string query = "SELECT * FROM Musteriler";
            MySqlCommand cmd = new MySqlCommand(query, baglanti);

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            MySqlDataReader reader = cmd.ExecuteReader();

            int yOffset = 0;

            while (reader.Read())
            {
                string customerId = reader["MusteriID"].ToString();
                string name = reader["Ad"].ToString() + " " + reader["Soyad"].ToString();
                string email = reader["Email"].ToString();
                string phone = reader["Telefon"].ToString();
                string address = reader["Adres"].ToString();
                int isActive = Convert.ToInt32(reader["Aktifmi"]);

                Panel customerPanel = new Panel
                {
                    Size = new Size(965, 60),
                    Location = new Point(10, yOffset),
                    BackColor = Color.LightGray
                };

                Label lblId = new Label
                {
                    Text = customerId,
                    Location = new Point(3, 12),
                    Size = new Size(50, 34),
                    Font = new Font("Poppins", 10)
                };
                customerPanel.Controls.Add(lblId);

                Label lblName = new Label
                {
                    Text = name,
                    Location = new Point(59, 12),
                    Size = new Size(173, 34),
                    Font = new Font("Poppins", 10)
                };
                customerPanel.Controls.Add(lblName);

                Label lblEmail = new Label
                {
                    Text = email,
                    Location = new Point(238, 12),
                    Size = new Size(198, 34),
                    Font = new Font("Poppins", 10)
                };
                customerPanel.Controls.Add(lblEmail);

                Label lblPhone = new Label
                {
                    Text = phone,
                    Location = new Point(442, 12),
                    Size = new Size(178, 34),
                    Font = new Font("Poppins", 10)
                };
                customerPanel.Controls.Add(lblPhone);

                Label lblAdress = new Label
                {
                    Text = address,
                    Location = new Point(626, 12),
                    Size = new Size(192, 34),
                    Font = new Font("Poppins", 10)
                };
                customerPanel.Controls.Add(lblAdress);

                CheckBox isActiveChckbox = new CheckBox
                {
                    AutoCheck = false,
                    CheckAlign = System.Drawing.ContentAlignment.MiddleCenter,
                    Location = new Point(816, 15),
                    Size = new Size(33, 29),
                    UseVisualStyleBackColor = true
                };
                customerPanel.Controls.Add(isActiveChckbox);

                if (isActive == 0)
                {
                    isActiveChckbox.Checked = false;
                }
                else
                {
                    isActiveChckbox.Checked = true;
                }

                System.Windows.Forms.Button btnDetails = new System.Windows.Forms.Button
                {
                    Text = "Detay",
                    Location = new Point(871, 7),
                    Size = new Size(94, 47),
                    BackColor = Color.FromArgb(5, 117, 230),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };
                btnDetails.FlatAppearance.BorderSize = 0;

                btnDetails.Click += (sender, e) => ShowCustomerDetails(customerId);

                customerPanel.Controls.Add(btnDetails);

                custListPanel.Controls.Add(customerPanel);

                yOffset += 70;
            }

            reader.Close();
            baglanti.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (baglanti.State == System.Data.ConnectionState.Open)
            {
                baglanti.Close();
            }
        }
    }
    
    private void GetTotalCustomerCount()
    {
        try
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        
            MySqlCommand komut = new MySqlCommand("SELECT COUNT(*) FROM Musteriler", baglanti);
        
            int totalCustomerCount = Convert.ToInt32(komut.ExecuteScalar());

            label20.Text = totalCustomerCount.ToString();

            baglanti.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Veritabanına bağlanılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task<int> GetActiveCustomerCount()
    {
        int activeCustomerCount = 0;

        try
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            MySqlCommand komut = new MySqlCommand("SELECT COUNT(*) FROM musteriler WHERE Aktifmi =" + 1, baglanti);

            activeCustomerCount = Convert.ToInt32(komut.ExecuteScalar());

            label22.Text = activeCustomerCount.ToString();

            baglanti.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Veritabanına bağlanılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return activeCustomerCount;
    }

    private async Task<int> GetNonActiveCustomerCount()
    {
        int nonActiveCustomerCount = 0;

        try
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            MySqlCommand komut = new MySqlCommand("SELECT COUNT(*) FROM musteriler WHERE Aktifmi =" + 0, baglanti);

            nonActiveCustomerCount = Convert.ToInt32(komut.ExecuteScalar());

            label25.Text = nonActiveCustomerCount.ToString();

            baglanti.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Veritabanına bağlanılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return nonActiveCustomerCount;
    }

    private async Task<int> TotalBillCount()
    {
        int totalBillCount = 0;

        try
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            MySqlCommand komut = new MySqlCommand("SELECT COUNT(*) FROM faturalar", baglanti);

            totalBillCount = Convert.ToInt32(komut.ExecuteScalar());

            totalBillCountTxt.Text = totalBillCount.ToString();

            baglanti.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Veritabanına bağlanılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return totalBillCount;
    }

    private async Task<decimal> TotalBillsValue()
    {
        decimal totalBills = 0;

        try
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                await baglanti.OpenAsync();
            }

            string query = "SELECT SUM(Tutar) FROM Faturalar";
            MySqlCommand komut = new MySqlCommand(query, baglanti);

            object result = await komut.ExecuteScalarAsync();

            if (result != DBNull.Value)
            {
                totalBills = Convert.ToDecimal(result);
                totalSellAmountTxt.Text = Convert.ToInt32(totalBills).ToString() + "TL";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            // Bağlantıyı kapat
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
        }

        return totalBills;
    }

    private async Task<int> TotalCashBill()
    {
        int totalBill = 0;

        try
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            MySqlCommand komut = new MySqlCommand("SELECT COUNT(*) FROM faturalar WHERE OdemeYontemi =" + 0, baglanti);

            totalBill = Convert.ToInt32(komut.ExecuteScalar());

            cashBillTxt.Text = totalBill.ToString();

            baglanti.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Veritabanına bağlanılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return totalBill;
    }

    private async Task<int> TotalCreditBill()
    {
        int totalBill = 0;

        try
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            MySqlCommand komut = new MySqlCommand("SELECT COUNT(*) FROM faturalar WHERE OdemeYontemi =" + 1, baglanti);

            totalBill = Convert.ToInt32(komut.ExecuteScalar());

            label37.Text = totalBill.ToString();

            baglanti.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Veritabanına bağlanılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return totalBill;
    }

    private async Task<int> TotalManagerCount()
    {
        int totalManagerCount = 0;

        try
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            MySqlCommand komut = new MySqlCommand("SELECT COUNT(*) FROM Calisanlar WHERE Yetki =" + 1, baglanti);

            totalManagerCount = Convert.ToInt32(komut.ExecuteScalar());

            managerCountTxt.Text = totalManagerCount.ToString();

            baglanti.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Veritabanına bağlanılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return totalManagerCount;
    }

    private async Task<int> TotalWorkerCount()
    {
        int totalWorker = 0;

        try
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            MySqlCommand komut = new MySqlCommand("SELECT COUNT(*) FROM Calisanlar WHERE Yetki =" + 0, baglanti);

            totalWorker = Convert.ToInt32(komut.ExecuteScalar());

            workerCountTxt.Text = totalWorker.ToString();

            baglanti.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Veritabanına bağlanılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return totalWorker;
    }
    
    private void GetTotalWorkerCount()
    {
        try
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        
            MySqlCommand komut = new MySqlCommand("SELECT COUNT(*) FROM Calisanlar", baglanti);
        
            int totalWorkerCount = Convert.ToInt32(komut.ExecuteScalar());

            totalWorkerCountTxt.Text = totalWorkerCount.ToString();

            baglanti.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Veritabanına bağlanılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
    private void ShowCustomerDetails(string customerId)
    {
        CustomerDetailsForm detailsForm = new CustomerDetailsForm(customerId, cnnString);
        detailsForm.FormClosed += CustomerDetailsForm_FormClosed;
        detailsForm.ShowDialog();
    }

    private void CustomerDetailsForm_FormClosed(object? sender, FormClosedEventArgs e)
    {
        LoadCustomerList();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        tabControl1.SelectedIndex = 0;
        this.Text = "Müşteri Bilgi Yonetim Uygulamasi - Anasayfa";
    }

    private void button2_Click(object sender, EventArgs e)
    {
        tabControl1.SelectedIndex = 1;
        this.Text = "Müşteri Bilgi Yonetim Uygulamasi - Müşteriler";
        LoadCustomerList();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        tabControl1.SelectedIndex = 2;
        this.Text = "Müşteri Bilgi Yonetim Uygulamasi - Profil";
        GetUserInfo();
    }

    private void button4_Click(object sender, EventArgs e)
    {
        logOut();
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        tabControl1.SelectedIndex = 0;
        this.Text = "Müşteri Bilgi Yonetim Uygulamasi - Anasayfa";
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {
        tabControl1.SelectedIndex = 1;
        this.Text = "Müşteri Bilgi Yonetim Uygulamasi - Müşteriler";
        LoadCustomerList();
    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {
        tabControl1.SelectedIndex = 2;
        this.Text = "Müşteri Bilgi Yonetim Uygulamasi - Profil";
        GetUserInfo();
    }

    private void pictureBox4_Click(object sender, EventArgs e)
    {
        logOut();
    }

    private void logOut()
    {
        LogOuOrExit logOuOrExit = new LogOuOrExit(cnnString);
        logOuOrExit.Show();
    }

    private void button5_Click(object sender, EventArgs e)
    {
        try
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            string query = "UPDATE Calisanlar SET Parola = @Parola, KullaniciAdi = @KullaniciAdi WHERE CalisanID = @UserID";
            MySqlCommand komut = new MySqlCommand(query, baglanti);

            komut.Parameters.AddWithValue("@Parola", prfPassTxt.Text);
            komut.Parameters.AddWithValue("@KullaniciAdi", prfUsernameTxt.Text);
            komut.Parameters.AddWithValue("@UserID", userID);

            int affectedRows = komut.ExecuteNonQuery();

            if (affectedRows > 0)
            {
                MessageBox.Show("Kullanıcı bilgileri başarıyla güncellendi.",
                    "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loggedUserName = prfUsernameTxt.Text;
            }
            else
            {
                MessageBox.Show("Kullanıcı bilgileri güncellenemedi. Kullanıcı bulunamadı.",
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

    private void button6_Click(object sender, EventArgs e)
    {
        NewCustomer newCustomer = new NewCustomer(cnnString);
        newCustomer.FormClosed += NewCustomer_FormClosed;
        newCustomer.Show();
    }
    
    private void NewCustomer_FormClosed(object sender, FormClosedEventArgs e)
    {
        LoadCustomerList();
    }

    private void button8_Click(object sender, EventArgs e)
    {
        ManagePanelLogin();
    }

    private void ManagePanelLogin()
    {
        if (userPermission == 0)
        {
            MessageBox.Show("Bu işlem için yetkiniz bulunmamaktadır!"
                , "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tabControl1.SelectedIndex = 0;
            this.Text = "Müşteri Bilgi Yonetim Uygulamasi - Anasayfa";
        }
        else if (userPermission == 1)
        {
            tabControl1.SelectedIndex = 3;
            this.Text = "Müşteri Bilgi Yonetim Uygulamasi - Yönetim Paneli";
            LoadWorkerList();
        }
    }

    private void pictureBox5_Click(object sender, EventArgs e)
    {
        ManagePanelLogin();
    }

    private void LoadWorkerList()
    {
        workerListPanel.Controls.Clear();

        try
        {
            string query = "SELECT * FROM Calisanlar";
            MySqlCommand cmd = new MySqlCommand(query, baglanti);

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            MySqlDataReader reader = cmd.ExecuteReader();

            int yOffset = 0;

            while (reader.Read())
            {
                string workerId = reader["CalisanId"].ToString();
                string userName = reader["KullaniciAdi"].ToString();
                string nameSurname = reader["AdSoyad"].ToString();
                int permission = Convert.ToInt32(reader["Yetki"]);

                Panel workerPanel = new Panel
                {
                    Size = new Size(627, 58),
                    Location = new Point(1, yOffset),
                    BackColor = Color.DimGray
                };

                Label lblId = new Label
                {
                    Text = workerId,
                    Location = new Point(0, 0),
                    Size = new Size(50, 58),
                    Font = new Font("Poppins", 10)
                };
                workerPanel.Controls.Add(lblId);

                Label lblName = new Label
                {
                    Text = nameSurname,
                    Location = new Point(55, 0),
                    Size = new Size(237, 58),
                    Font = new Font("Poppins", 10)
                };
                workerPanel.Controls.Add(lblName);

                Label lblUserName = new Label
                {
                    Text = userName,
                    Location = new Point(298, 0),
                    Size = new Size(244, 58),
                    Font = new Font("Poppins", 10)
                };
                workerPanel.Controls.Add(lblUserName);

                CheckBox permissionCheckbox = new CheckBox
                {
                    AutoCheck = false,
                    CheckAlign = System.Drawing.ContentAlignment.MiddleCenter,
                    Location = new Point(548, 0),
                    Size = new Size(76, 55),
                    UseVisualStyleBackColor = true
                };
                workerPanel.Controls.Add(permissionCheckbox);

                if (permission == 0)
                {
                    permissionCheckbox.Checked = false;
                }
                else
                {
                    permissionCheckbox.Checked = true;
                }

                workerListPanel.Controls.Add(workerPanel);

                yOffset += 70;
            }

            reader.Close();
            baglanti.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (baglanti.State == System.Data.ConnectionState.Open)
            {
                baglanti.Close();
            }
        }

        GetTotalWorkerCount();
    }

    private void button9_Click(object sender, EventArgs e)
    {
        NewWorker newWorker = new NewWorker(cnnString);
        newWorker.FormClosed += NewWorker_FormClosed;
        newWorker.Show();
    }

    private void NewWorker_FormClosed(object? sender, FormClosedEventArgs e)
    {
        LoadWorkerList();
    }
}