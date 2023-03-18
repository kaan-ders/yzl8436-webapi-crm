namespace CRMBackend.Models
{
    public class Ziyaret : ModelBase
    {
        public int MusteriId { get; set; }
        public Musteri Musteri { get; set; }

        public int PersonelId { get; set; }
        public Personel Personel { get; set; }

        public string Not { get; set; }
        public DateTime Tarihi { get; set; }
    }
}