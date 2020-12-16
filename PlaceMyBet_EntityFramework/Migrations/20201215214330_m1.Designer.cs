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
    [Migration("20201215214330_m1")]
    partial class m1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PlaceMyBet.Models.Apuesta", b =>
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
                });

            modelBuilder.Entity("PlaceMyBet.Models.Banco", b =>
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
                });

            modelBuilder.Entity("PlaceMyBet.Models.Evento", b =>
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

            modelBuilder.Entity("PlaceMyBet.Models.Mercado", b =>
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

                    b.Property<string>("Tipo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("MercadoId");

                    b.HasIndex("EventoId");

                    b.ToTable("Mercados");
                });

            modelBuilder.Entity("PlaceMyBet.Models.Usuario", b =>
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
                });

            modelBuilder.Entity("PlaceMyBet.Models.Apuesta", b =>
                {
                    b.HasOne("PlaceMyBet.Models.Mercado", "Mercado")
                        .WithMany()
                        .HasForeignKey("MercadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PlaceMyBet.Models.Usuario", "Usuario")
                        .WithMany("Apuestas")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("PlaceMyBet.Models.Banco", b =>
                {
                    b.HasOne("PlaceMyBet.Models.Usuario", "Usuario")
                        .WithOne("Banco")
                        .HasForeignKey("PlaceMyBet.Models.Banco", "UsuarioId");
                });

            modelBuilder.Entity("PlaceMyBet.Models.Mercado", b =>
                {
                    b.HasOne("PlaceMyBet.Models.Evento", "Evento")
                        .WithMany("Mercados")
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}