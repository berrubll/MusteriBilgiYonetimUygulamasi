namespace MusteriBilgiYonetimUygulamasi;

public partial class BillAddProductForm : Form
{
    private decimal totalValue;
    public Urun UrunBilgisi { get; private set; }

    public BillAddProductForm()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBox1.Text) ||
           !int.TryParse(miktarTxt.Text, out int miktar) ||
           !decimal.TryParse(valueTxt.Text, out decimal birimFiyat))
        {
            MessageBox.Show("Lütfen geçerli tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        UrunBilgisi = new Urun
        {
            UrunAdi = textBox1.Text,
            Miktar = miktar,
            BirimFiyat = birimFiyat
        };

        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private void valueTxt_TextChanged(object sender, EventArgs e)
    {

    }
}