using System.ComponentModel.DataAnnotations;

namespace CRMBackend.Models
{
    public class Siparis : ModelBase
    {
        [Required]
        public int MusteriId { get; set; }
        public Musteri? Musteri { get; set; }

        [Required]
        public string No { get; set; }

        [Required]
        public DateTime Tarih { get; set; }

        [Required]
        public decimal Tutar { get; set; }

        public List<SiparisUrun> Urunler { get; set; } = new List<SiparisUrun>();
    }
}
