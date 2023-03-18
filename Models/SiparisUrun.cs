namespace CRMBackend.Models
{
    public class SiparisUrun : ModelBase
    {
        public int SiparisId { get; set; }
        public Siparis? Siparis { get; set; }

        public int UrunId { get; set; }
        public Urun? Urun { get; set; }

        public int Adet { get; set; }
        public decimal Tutar { get; set; }
    }
}
