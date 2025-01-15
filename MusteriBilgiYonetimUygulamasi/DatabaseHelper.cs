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

namespace MusteriBilgiYonetimUygulamasi;

public partial class DatabaseHelper : Form
{
    public string connectionString;
    
    public DatabaseHelper()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        MySqlConnectionStringBuilder connectionString = new MySqlConnectionStringBuilder();
        connectionString.Server = sqlServerIpTxt.Text;
        connectionString.Port = 3306;
        connectionString.UserID = sqlServerUsernameTxt.Text;
        connectionString.Password = sqlServerPassTxt.Text;
        connectionString.Database = "MusteriYonetim";
        
        MySqlConnection cnn = new MySqlConnection(connectionString.ToString());
        
        try
        {
            cnn.Open();
            MessageBox.Show ("Bağlantı Başarılı");
            cnn.Close();
            
            this.Hide();
            
            LoginScreen loginScreen = new LoginScreen(connectionString.ToString());
            loginScreen.Show();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Bağlantı Başarısız! " + ex.Message);
        }
    }
}