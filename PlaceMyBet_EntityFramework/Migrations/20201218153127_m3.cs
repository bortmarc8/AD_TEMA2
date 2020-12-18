using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlaceMyBet_EntityFramework.Migrations
{
    public partial class m3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "EventoId", "EquipoLocal", "EquipoVisitante", "Fecha", "Goles" },
                values: new object[] { 1, "Barça", "Madrid", new DateTime(2020, 12, 18, 16, 31, 26, 745, DateTimeKind.Local).AddTicks(1826), 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Apuestas",
                keyColumn: "ApuestaId",
                keyValue: 2);

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
                table: "Eventos",
                keyColumn: "EventoId",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Mercados",
                columns: new[] { "MercadoId", "CuotaOver", "CuotaUnder", "DineroOver", "DineroUnder", "EventoId", "Tipo" },
                values: new object[] { 1, 1.4299999999999999, 2.8500000000000001, 100.0, 50.0, 1, 1.5 });

            migrationBuilder.InsertData(
                table: "Mercados",
                columns: new[] { "MercadoId", "CuotaOver", "CuotaUnder", "DineroOver", "DineroUnder", "EventoId", "Tipo" },
                values: new object[] { 2, 1.8999999999999999, 1.8999999999999999, 100.0, 100.0, 1, 2.5 });

            migrationBuilder.InsertData(
                table: "Mercados",
                columns: new[] { "MercadoId", "CuotaOver", "CuotaUnder", "DineroOver", "DineroUnder", "EventoId", "Tipo" },
                values: new object[] { 3, 2.8500000000000001, 1.4299999999999999, 50.0, 100.0, 1, 3.5 });

            migrationBuilder.InsertData(
                table: "Apuestas",
                columns: new[] { "ApuestaId", "Cuota", "Dinero", "Fecha", "MercadoId", "TipoApuesta", "UsuarioId" },
                values: new object[] { 2, 1.75, 100.0, new DateTime(2020, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "maboto01@floridauniversitaria.es" });
        }
    }
}
