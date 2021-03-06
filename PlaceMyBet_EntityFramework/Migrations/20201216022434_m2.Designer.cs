﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlaceMyBet_EntityFramework.Models;

namespace PlaceMyBet_EntityFramework.Migrations
{
    [DbContext(typeof(PlaceMyBetContext))]
    [Migration("20201216022434_m2")]
    partial class m2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PlaceMyBet_EntityFramework.Models.Apuesta", b =>
                {
                    b.Property<int>("ApuestaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Cuota")
                        .HasColumnType("double");

                    b.Property<double>("Dinero")
                        .HasColumnType("double");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("MercadoId")
                        .HasColumnType("int");

                    b.Property<bool>("TipoApuesta")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UsuarioId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("ApuestaId");

                    b.HasIndex("MercadoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Apuestas");

                    b.HasData(
                        new
                        {
                            ApuestaId = 2,
                            Cuota = 1.75,
                            Dinero = 100.0,
                            Fecha = new DateTime(2020, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MercadoId = 1,
                            TipoApuesta = true,
                            UsuarioId = "maboto01@floridauniversitaria.es"
                        });
                });

            modelBuilder.Entity("PlaceMyBet_EntityFramework.Models.Banco", b =>
                {
                    b.Property<int>("BancoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("NumTarjeta")
                        .HasColumnType("int");

                    b.Property<double>("Saldo")
                        .HasColumnType("double");

                    b.Property<string>("UsuarioId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("BancoId");

                    b.HasIndex("UsuarioId")
                        .IsUnique();

                    b.ToTable("Bancos");

                    b.HasData(
                        new
                        {
                            BancoId = 1,
                            Nombre = "Santander",
                            NumTarjeta = 12456,
                            Saldo = 500.0,
                            UsuarioId = "maboto01@floridauniversitaria.es"
                        });
                });

            modelBuilder.Entity("PlaceMyBet_EntityFramework.Models.Evento", b =>
                {
                    b.Property<int>("EventoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("EquipoLocal")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("EquipoVisitante")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Goles")
                        .HasColumnType("int");

                    b.HasKey("EventoId");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("PlaceMyBet_EntityFramework.Models.Mercado", b =>
                {
                    b.Property<int>("MercadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("CuotaOver")
                        .HasColumnType("double");

                    b.Property<double>("CuotaUnder")
                        .HasColumnType("double");

                    b.Property<double>("DineroOver")
                        .HasColumnType("double");

                    b.Property<double>("DineroUnder")
                        .HasColumnType("double");

                    b.Property<int>("EventoId")
                        .HasColumnType("int");

                    b.Property<double>("Tipo")
                        .HasColumnType("double");

                    b.HasKey("MercadoId");

                    b.HasIndex("EventoId");

                    b.ToTable("Mercados");

                    b.HasData(
                        new
                        {
                            MercadoId = 1,
                            CuotaOver = 1.4299999999999999,
                            CuotaUnder = 2.8500000000000001,
                            DineroOver = 100.0,
                            DineroUnder = 50.0,
                            EventoId = 1,
                            Tipo = 1.5
                        },
                        new
                        {
                            MercadoId = 2,
                            CuotaOver = 1.8999999999999999,
                            CuotaUnder = 1.8999999999999999,
                            DineroOver = 100.0,
                            DineroUnder = 100.0,
                            EventoId = 1,
                            Tipo = 2.5
                        },
                        new
                        {
                            MercadoId = 3,
                            CuotaOver = 2.8500000000000001,
                            CuotaUnder = 1.4299999999999999,
                            DineroOver = 50.0,
                            DineroUnder = 100.0,
                            EventoId = 1,
                            Tipo = 3.5
                        });
                });

            modelBuilder.Entity("PlaceMyBet_EntityFramework.Models.Usuario", b =>
                {
                    b.Property<string>("UsuarioId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Apellidos")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            UsuarioId = "maboto01@floridauniversitaria.es",
                            Apellidos = "Bort",
                            Edad = 19,
                            Nombre = "Mark"
                        });
                });

            modelBuilder.Entity("PlaceMyBet_EntityFramework.Models.Apuesta", b =>
                {
                    b.HasOne("PlaceMyBet_EntityFramework.Models.Mercado", "Mercado")
                        .WithMany()
                        .HasForeignKey("MercadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PlaceMyBet_EntityFramework.Models.Usuario", "Usuario")
                        .WithMany("Apuestas")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("PlaceMyBet_EntityFramework.Models.Banco", b =>
                {
                    b.HasOne("PlaceMyBet_EntityFramework.Models.Usuario", "Usuario")
                        .WithOne("Banco")
                        .HasForeignKey("PlaceMyBet_EntityFramework.Models.Banco", "UsuarioId");
                });

            modelBuilder.Entity("PlaceMyBet_EntityFramework.Models.Mercado", b =>
                {
                    b.HasOne("PlaceMyBet_EntityFramework.Models.Evento", "Evento")
                        .WithMany("Mercados")
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
