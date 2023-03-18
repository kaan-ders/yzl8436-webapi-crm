using CRMBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRMBackend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SiparisController : ControllerBase
    {
        private CrmDbContext _context;
        public SiparisController(CrmDbContext context)
        {
            _context = context;
        }

        //sipariş kaydet
        //getir
        //listele

        //

        [HttpGet]
        public List<Urun> UrunleriGetir()
        {
            return _context.Urun.Where(x => x.SilindiMi == false).ToList();
        }

        [HttpGet]
        public decimal UrunFiyatiGetir(int id)
        {
            var model = _context.Urun.FirstOrDefault(x => x.Id == id);
            return model.BirimFiyati;
        }

        [HttpPost]
        public bool Kaydet(Siparis model)
        {
            if (ModelState.IsValid)
            {
                foreach (var item in model.Urunler)
                {
                    model.Tutar += item.Tutar;
                }

                _context.Siparis.Add(model);
                _context.SaveChanges();

                return true;
            }
            else
                return false;
        }

        [HttpGet]
        public List<Siparis> Listele()
        {
            return _context.Siparis.Include(x => x.Musteri).Where(x => x.SilindiMi == false).ToList();
        }
    }
}
