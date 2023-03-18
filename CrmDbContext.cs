using CRMBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace CRMBackend
{
    public class CrmDbContext : DbContext
    {
        public CrmDbContext(DbContextOptions<CrmDbContext> options)
            : base(options)
        {
        }

        public DbSet<Ulke> Ulke { get; set; }
        public DbSet<Sehir> Sehir { get; set; }
        public DbSet<Personel> Personel { get; set; }
        public DbSet<Musteri> Musteri { get; set; }
        public DbSet<Ziyaret> Ziyaret { get; set; }
        public DbSet<Urun> Urun { get; set; }
        public DbSet<Siparis> Siparis { get; set; }
        public DbSet<SiparisUrun> SiparisUrun { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ulke>()
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();

            modelBuilder.Entity<Sehir>()
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();

            modelBuilder.Entity<Personel>()
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();

            modelBuilder.Entity<Musteri>()
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();

            modelBuilder.Entity<Ziyaret>()
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();

            modelBuilder.Entity<Urun>()
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();

            modelBuilder.Entity<Siparis>()
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();

            modelBuilder.Entity<SiparisUrun>()
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();
        }
    }
}