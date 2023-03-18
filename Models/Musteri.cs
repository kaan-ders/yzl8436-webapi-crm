namespace CRMBackend.Models
{
    public class Musteri : ModelBase
    {
        public string Adi { get; set; }
        public string Adresi { get; set; }

        public int SehirId { get; set; }
        public Sehir? Sehir { get; set; }
    }
}