namespace MusteriBilgiYonetimUygulamasi;

public class Urun
{
        public string UrunAdi { get; set; }
        public int Miktar { get; set; }
        public decimal BirimFiyat { get; set; }
        
        public decimal ToplamFiyat => Miktar * BirimFiyat;
}