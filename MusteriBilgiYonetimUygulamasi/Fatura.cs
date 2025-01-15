using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriBilgiYonetimUygulamasi
{
    public class Fatura
    {
        public int FaturaId { get; set; }
        public int MusteriId { get; set; }
        public DateTime Tarih { get; set; }
        public decimal ToplamTutar { get; set; }

        public virtual ICollection<Urun> Urunler { get; set; }
    }
}
