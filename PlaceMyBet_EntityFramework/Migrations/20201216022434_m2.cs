using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlaceMyBet_EntityFramework.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Tipo",
                table: "Mercados",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Mercados",
                columns: new[] { "MercadoId", "CuotaOver", "CuotaUnder", "DineroOver", "DineroUnder", "EventoId", "Tipo" },
                values: new object[,]
                {
                    { 1, 1.4299999999999999, 2.8500000000000001, 100.0, 50.0, 1, 1.5 },
                    { 2, 1.8999999999999999, 1.8999999999999999, 100.0, 100.0, 1, 2.5 },
                    { 3, 2.8500000000000001, 1.4299999999999999, 50.0, 100.0, 1, 3.5 }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Apellidos", "Edad", "Nombre" },
                values: new object[] { "maboto01@floridauniversitaria.es", "Bort", 19, "Mark" });

            migrationBuilder.InsertData(
                table: "Apuestas",
                columns: new[] { "ApuestaId", "Cuota", "Dinero", "Fecha", "MercadoId", "TipoApuesta", "UsuarioId" },
                values: new object[] { 2, 1.75, 100.0, new DateTime(2020, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "maboto01@floridauniversitaria.es" });

            migrationBuilder.InsertData(
                table: "Bancos",
                columns: new[] { "BancoId", "Nombre", "NumTarjeta", "Saldo", "UsuarioId" },
                values: new object[] { 1, "Santander", 12456, 500.0, "maboto01@floridauniversitaria.es" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Apuestas",
                keyColumn: "ApuestaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bancos",
                keyColumn: "BancoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Mercados",
                keyColumn: "MercadoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Mercados",
                keyColumn: "MercadoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Mercados",
                keyColumn: "MercadoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "maboto01@floridauniversitaria.es");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Mercados",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(double));
        }
    }
}
