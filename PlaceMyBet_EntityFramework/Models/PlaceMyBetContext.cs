using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages;

namespace PlaceMyBet_EntityFramework.Models
{
    public class PlaceMyBetContext : DbContext
    {
        public DbSet<Apuesta> Apuestas { get; set; }
        public DbSet<Banco> Bancos { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Mercado> Mercados { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public PlaceMyBetContext()
        {

        }

        public PlaceMyBetContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseMySql("Server=127.0.0.1;Database=PlaceMyBet_EF;Uid=root;Pwd=''; SslMode = none");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mercado>().HasData(new Mercado(1, 1.5, 1.43, 2.85, 100, 50, 1));
            modelBuilder.Entity<Mercado>().HasData(new Mercado(2, 2.5, 1.9, 1.9, 100, 100, 1));
            modelBuilder.Entity<Mercado>().HasData(new Mercado(3, 3.5, 2.85, 1.43, 50, 100, 1));
            modelBuilder.Entity<Usuario>().HasData(new Usuario("maboto01@floridauniversitaria.es", "Mark", "Bort", 19));
            modelBuilder.Entity<Banco>().HasData(new Banco(1, 500, "Santander", 12456, "maboto01@floridauniversitaria.es"));
            modelBuilder.Entity<Apuesta>().HasData(new Apuesta(2, 100, 1.75, true, "2020-12-16".AsDateTime().Date, 1, "maboto01@floridauniversitaria.es"));

        }

    }
}