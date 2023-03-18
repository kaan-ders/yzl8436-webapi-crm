﻿// <auto-generated />
using System;
using CRMBackend;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRMBackend.Migrations
{
    [DbContext(typeof(CrmDbContext))]
    [Migration("20230318080715_baslangic")]
    partial class baslangic
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CRMBackend.Models.Musteri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adresi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SehirId")
                        .HasColumnType("int");

                    b.Property<bool>("SilindiMi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("SehirId");

                    b.ToTable("Musteri");
                });

            modelBuilder.Entity("CRMBackend.Models.Personel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SilindiMi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Personel");
                });

            modelBuilder.Entity("CRMBackend.Models.Sehir", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SilindiMi")
                        .HasColumnType("bit");

                    b.Property<int>("UlkeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UlkeId");

                    b.ToTable("Sehir");
                });

            modelBuilder.Entity("CRMBackend.Models.Siparis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MusteriId")
                        .HasColumnType("int");

                    b.Property<string>("No")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SilindiMi")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Tutar")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("MusteriId");

                    b.ToTable("Siparis");
                });

            modelBuilder.Entity("CRMBackend.Models.SiparisUrun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<bool>("SilindiMi")
                        .HasColumnType("bit");

                    b.Property<int>("SiparisId")
                        .HasColumnType("int");

                    b.Property<decimal>("Tutar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UrunId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SiparisId");

                    b.HasIndex("UrunId");

                    b.ToTable("SiparisUrun");
                });

            modelBuilder.Entity("CRMBackend.Models.Ulke", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SilindiMi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Ulke");
                });

            modelBuilder.Entity("CRMBackend.Models.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("BirimFiyati")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("SilindiMi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Urun");
                });

            modelBuilder.Entity("CRMBackend.Models.Ziyaret", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MusteriId")
                        .HasColumnType("int");

                    b.Property<string>("Not")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.Property<bool>("SilindiMi")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Tarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MusteriId");

                    b.HasIndex("PersonelId");

                    b.ToTable("Ziyaret");
                });

            modelBuilder.Entity("CRMBackend.Models.Musteri", b =>
                {
                    b.HasOne("CRMBackend.Models.Sehir", "Sehir")
                        .WithMany()
                        .HasForeignKey("SehirId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sehir");
                });

            modelBuilder.Entity("CRMBackend.Models.Sehir", b =>
                {
                    b.HasOne("CRMBackend.Models.Ulke", "Ulke")
                        .WithMany()
                        .HasForeignKey("UlkeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ulke");
                });

            modelBuilder.Entity("CRMBackend.Models.Siparis", b =>
                {
                    b.HasOne("CRMBackend.Models.Musteri", "Musteri")
                        .WithMany()
                        .HasForeignKey("MusteriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Musteri");
                });

            modelBuilder.Entity("CRMBackend.Models.SiparisUrun", b =>
                {
                    b.HasOne("CRMBackend.Models.Siparis", "Siparis")
                        .WithMany("Urunler")
                        .HasForeignKey("SiparisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CRMBackend.Models.Urun", "Urun")
                        .WithMany()
                        .HasForeignKey("UrunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Siparis");

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("CRMBackend.Models.Ziyaret", b =>
                {
                    b.HasOne("CRMBackend.Models.Musteri", "Musteri")
                        .WithMany()
                        .HasForeignKey("MusteriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CRMBackend.Models.Personel", "Personel")
                        .WithMany()
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Musteri");

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("CRMBackend.Models.Siparis", b =>
                {
                    b.Navigation("Urunler");
                });
#pragma warning restore 612, 618
        }
    }
}
