using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlaceMyBet_EntityFramework.Migrations
{
    public partial class m4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "EventoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2020, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Mercados",
                keyColumn: "MercadoId",
                keyValue: 1,
                columns: new[] { "CuotaOver", "CuotaUnder" },
                values: new object[] { 1.5, 2.5 });

            migrationBuilder.UpdateData(
                table: "Mercados",
                keyColumn: "MercadoId",
                keyValue: 2,
                columns: new[] { "CuotaOver", "CuotaUnder" },
                values: new object[] { 1.5, 1.5 });

            migrationBuilder.UpdateData(
                table: "Mercados",
                keyColumn: "MercadoId",
                keyValue: 3,
                columns: new[] { "CuotaOver", "CuotaUnder" },
                values: new object[] { 2.5, 1.5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "EventoId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2020, 12, 18, 16, 31, 26, 745, DateTimeKind.Local).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "Mercados",
                keyColumn: "MercadoId",
                keyValue: 1,
                columns: new[] { "CuotaOver", "CuotaUnder" },
                values: new object[] { 1.4299999999999999, 2.8500000000000001 });

            migrationBuilder.UpdateData(
                table: "Mercados",
                keyColumn: "MercadoId",
                keyValue: 2,
                columns: new[] { "CuotaOver", "CuotaUnder" },
                values: new object[] { 1.8999999999999999, 1.8999999999999999 });

            migrationBuilder.UpdateData(
                table: "Mercados",
                keyColumn: "MercadoId",
                keyValue: 3,
                columns: new[] { "CuotaOver", "CuotaUnder" },
                values: new object[] { 2.8500000000000001, 1.4299999999999999 });
        }
    }
}
