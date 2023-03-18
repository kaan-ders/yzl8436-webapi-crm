using CRMBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRMBackend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MusteriController : ControllerBase
    {
        private CrmDbContext _context;
        public MusteriController(CrmDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public bool Kaydet(Musteri model)
        {
            _context.Musteri.Add(model);
            _context.SaveChanges();

            return true;
        }

        [HttpGet]
        public List<Musteri> Listele()
        {
            return _context.Musteri.Include("Sehir.Ulke").Where(x => x.SilindiMi == false).ToList();
        }

        [HttpGet]
        public List<Sehir> SehirGetir(int ulkeId)
        {
            return _context.Sehir.Where(x => x.UlkeId == ulkeId && x.SilindiMi == false).ToList();
        }
    }
}
