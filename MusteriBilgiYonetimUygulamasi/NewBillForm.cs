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

public partial class NewBillForm : Form
{
    private MySqlConnection baglanti;
    private int customerID;
    private string customerName;
    private string customerPhone;
    private string customerEmail;
    private string customerAddress;
    private List<Urun> urunListesi = new List<Urun>();
    private decimal taxValue;
    private decimal billValue;
    private decimal totalValue;
    private int odemeYontemi;

    public NewBillForm(string cnnString, int customerId, string customerName, string customerSurname, string customerPhone, string customerEmail, string customerAddress)
    {
        InitializeComponent();
        nameTxt.Text = customerName + " " + customerSurname;
        this.customerName = customerName + "" + customerSurname;
        phoneTxt.Text = customerPhone;
        this.customerPhone = customerPhone;
        mailTxt.Text = customerEmail;
        this.customerEmail = customerEmail;
        adressTxt.Text = customerAddress;
        this.customerAddress = customerAddress;
        baglanti = new MySqlConnection(cnnString);
        customerID = customerId;
        this.Text = "Yeni Fatura - " + this.customerName;

        dataGridViewUrunler.AutoGenerateColumns = false;
        dataGridViewUrunler.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Ürün Adı",
            DataPropertyName = "UrunAdi"
        });
        dataGridViewUrunler.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Miktar",
            DataPropertyName = "Miktar"
        });
        dataGridViewUrunler.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "Birim Fiyat",
            DataPropertyName = "BirimFiyat"
        });
        dataGridViewUrunler.Columns.Add(new DataGridViewTextBoxColumn
        {
            HeaderText = "ToplamFiyat",
            DataPropertyName = "ToplamFiyat"
        });
        dataGridViewUrunler.DataSource = urunListesi;

    }

    private void button1_Click(object sender, EventArgs e)
    {
        BillAddProductForm billAddProductForm = new BillAddProductForm();
        if (billAddProductForm.ShowDialog() == DialogResult.OK)
        {
            Urun urun = billAddProductForm.UrunBilgisi;
            urunListesi.Add(urun);
            dataGridViewUrunler.DataSource = null;
            dataGridViewUrunler.DataSource = urunListesi;
            CalculateValues();
        }
    }

    private void CalculateValues()
    {
        billValue = urunListesi.Sum(Urun => Urun.ToplamFiyat);
        taxValue = billValue * 20 / 100;
        totalValue = billValue + taxValue;

        billValueTxt.Text = billValue.ToString() + "TL";
        taxValueTxt.Text = taxValue.ToString() + "TL";
        totalValueTxt.Text = totalValue.ToString() + "TL";
    }

    private void button2_Click(object sender, EventArgs e)
    {
        baglanti.Open();
        using (var transaction = baglanti.BeginTransaction())
        {
            try
            {
                // 1. Faturayı Kaydet
                var faturaQuery = "INSERT INTO faturalar (MusteriId, Tutar, OdemeYontemi) VALUES (@MusteriId, @Tutar, @OdemeYontemi); SELECT LAST_INSERT_ID();";
                int faturaId;

                using (var faturaCommand = new MySqlCommand(faturaQuery, baglanti, transaction))
                {
                    faturaCommand.Parameters.AddWithValue("@MusteriId", customerID);
                    faturaCommand.Parameters.AddWithValue("@Tutar", totalValue);
                    faturaCommand.Parameters.AddWithValue("@OdemeYontemi", odemeYontemi);

                    faturaId = Convert.ToInt32(faturaCommand.ExecuteScalar());
                    Console.WriteLine($"Fatura başarıyla kaydedildi. Fatura ID: {faturaId}");
                }

                // 2. Ürünleri Kaydet
                var urunQuery = "INSERT INTO fatura_icerigi (FaturaId, UrunIsmi, UrunFiyati, UrunAdedi) VALUES (@FaturaId, @UrunIsmi, @UrunFiyati, @UrunAdedi);";

                foreach (var urun in urunListesi)
                {
                    using (var urunCommand = new MySqlCommand(urunQuery, baglanti, transaction))
                    {
                        urunCommand.Parameters.AddWithValue("@FaturaId", faturaId);
                        urunCommand.Parameters.AddWithValue("@UrunIsmi", urun.UrunAdi);
                        urunCommand.Parameters.AddWithValue("@UrunFiyati", urun.BirimFiyat);
                        urunCommand.Parameters.AddWithValue("@UrunAdedi", urun.Miktar);

                        urunCommand.ExecuteNonQuery();
                    }
                }

                // İşlemleri onayla
                transaction.Commit();
                MessageBox.Show("Fatura Başarılı Bir Şekilde Kaydedildi");
                this.Close();
            }
            catch (Exception ex)
            {
                // Hata durumunda işlemleri geri al
                transaction.Rollback();
                Console.WriteLine($"Hata oluştu: {ex.Message}");
            }
        }
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
        if (radioButton1.Checked)
        {
            radioButton2.Checked = false;
            odemeYontemi = 0;
        }
    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
        if (radioButton2.Checked)
        {
            radioButton1.Checked = false;
            odemeYontemi = 1;
        }
    }
}