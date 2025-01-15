using global::System;
using global::System.Windows.Forms;

namespace MusteriBilgiYonetimUygulamasi;

public partial class LogOuOrExit : Form
{
    private string cnnString;
    
    public LogOuOrExit(string connectionString)
    {
        InitializeComponent();
        cnnString = connectionString;
    }

    private void button2_Click(object sender, EventArgs e)
    {
        foreach (Form form in Application.OpenForms)
        {
            form.Hide();
        }
        LoginScreen loginScreen = new LoginScreen(cnnString);
        loginScreen.Show();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}