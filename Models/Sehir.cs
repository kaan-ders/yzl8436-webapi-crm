namespace CRMBackend.Models
{
    public class Sehir : ModelBase
    {
        public int UlkeId { get; set; }
        public Ulke Ulke { get; set; }

        public string Adi { get; set; }
    }
}
