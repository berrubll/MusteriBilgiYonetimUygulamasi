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
using Microsoft.VisualBasic.ApplicationServices;
using System.Security;

namespace MusteriBilgiYonetimUygulamasi;

public partial class BillDetailForm : Form
{
    private MySqlConnection baglanti;
    private string customerNameSurname;
    private string customerPhone;
    private string customerEmail;
    private string customerAdress;
    private decimal totalValue;
    private int paymentMethod;
    private int faturaID;
    private decimal value;
    private decimal tax;
    private List<Urun> urunListesi = new List<Urun>();

    public BillDetailForm(int faturaId, string cnnString, string customerName, string phone, string email, string adress)
    {
        InitializeComponent();
        baglanti = new MySqlConnection(cnnString);
        customerNameSurname = customerName;
        customerPhone = phone;
        customerEmail = email;
        customerAdress = adress;
        faturaID = faturaId;
        GetBillInfo();
        label1.Text = faturaId.ToString() + " Nolu Fatura";
        this.Text = faturaId.ToString() + " Nolu " + customerNameSurname + " İsimli Kişiye Ait Fatura";

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
    }

    private void GetBillInfo()
    {
        if (baglanti.State == ConnectionState.Closed)
        {
            baglanti.Open();
        }

        MySqlCommand komut = new MySqlCommand("SELECT * FROM faturalar WHERE FaturaId = @FaturaId", baglanti);
        komut.Parameters.AddWithValue("@FaturaId", faturaID);
        MySqlDataReader dr = komut.ExecuteReader();

        if (dr.Read())
        {
            totalValue = dr.GetDecimal(2);
            paymentMethod = dr.GetInt32(3);
        }
        else
        {
            MessageBox.Show("Fatura Bulunamadı.",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        baglanti.Close();
        UpdateBillInfo();
    }

    private void UpdateBillInfo()
    {
        nameTxt.Text = customerNameSurname.ToString();
        phoneTxt.Text = customerPhone.ToString();
        mailTxt.Text = customerEmail.ToString();
        adressTxt.Text = customerAdress.ToString();

        GetProducts();

        if (paymentMethod == 0)
        {
            radioButton1.Checked = true;
        }
        else if (paymentMethod == 1)
        {
            radioButton2.Checked = true;
        }

        dataGridViewUrunler.DataSource = urunListesi;

        billValueTxt.Text = value.ToString();
        taxValueTxt.Text = (value * 20 / 100).ToString();
        totalValueTxt.Text = totalValue.ToString();
    }

    private void GetProducts()
    {
        try
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            MySqlCommand komut = new MySqlCommand("SELECT * FROM fatura_icerigi WHERE FaturaId = @FaturaId", baglanti);
            komut.Parameters.AddWithValue("@FaturaId", faturaID);
            MySqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                string urunIsmi = reader["UrunIsmi"].ToString();
                decimal UrunFiyati = Convert.ToDecimal(reader["UrunFiyati"]);
                int UrunAdedi = Convert.ToInt32(reader["UrunAdedi"]);
                decimal toplam = UrunFiyati * UrunAdedi;

                value += toplam;

                urunListesi.Add(new Urun
                {
                    UrunAdi = urunIsmi,
                    Miktar = UrunAdedi,
                    BirimFiyat = UrunFiyati
                });
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
}