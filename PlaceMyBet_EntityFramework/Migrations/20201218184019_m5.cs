using Microsoft.EntityFrameworkCore.Migrations;

namespace PlaceMyBet_EntityFramework.Migrations
{
    public partial class m5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CuotaOver",
                table: "Mercados");

            migrationBuilder.DropColumn(
                name: "CuotaUnder",
                table: "Mercados");

            migrationBuilder.DropColumn(
                name: "DineroOver",
                table: "Mercados");

            migrationBuilder.DropColumn(
                name: "DineroUnder",
                table: "Mercados");

            migrationBuilder.DropColumn(
                name: "EquipoLocal",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "EquipoVisitante",
                table: "Eventos");

            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Mercados",
                newName: "tipo");

            migrationBuilder.AddColumn<double>(
                name: "cuota_over",
                table: "Mercados",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "cuota_under",
                table: "Mercados",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "dinero_over",
                table: "Mercados",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "dinero_under",
                table: "Mercados",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "eq_local",
                table: "Eventos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "eq_visitante",
                table: "Eventos",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "EventoId",
                keyValue: 1,
                columns: new[] { "eq_local", "eq_visitante" },
                values: new object[] { "Barça", "Madrid" });

            migrationBuilder.UpdateData(
                table: "Mercados",
                keyColumn: "MercadoId",
                keyValue: 1,
                columns: new[] { "cuota_over", "cuota_under", "dinero_over", "dinero_under" },
                values: new object[] { 1.5, 2.5, 100.0, 50.0 });

            migrationBuilder.UpdateData(
                table: "Mercados",
                keyColumn: "MercadoId",
                keyValue: 2,
                columns: new[] { "cuota_over", "cuota_under", "dinero_over", "dinero_under" },
                values: new object[] { 1.5, 1.5, 100.0, 100.0 });

            migrationBuilder.UpdateData(
                table: "Mercados",
                keyColumn: "MercadoId",
                keyValue: 3,
                columns: new[] { "cuota_over", "cuota_under", "dinero_over", "dinero_under" },
                values: new object[] { 2.5, 1.5, 50.0, 100.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cuota_over",
                table: "Mercados");

            migrationBuilder.DropColumn(
                name: "cuota_under",
                table: "Mercados");

            migrationBuilder.DropColumn(
                name: "dinero_over",
                table: "Mercados");

            migrationBuilder.DropColumn(
                name: "dinero_under",
                table: "Mercados");

            migrationBuilder.DropColumn(
                name: "eq_local",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "eq_visitante",
                table: "Eventos");

            migrationBuilder.RenameColumn(
                name: "tipo",
                table: "Mercados",
                newName: "Tipo");

            migrationBuilder.AddColumn<double>(
                name: "CuotaOver",
                table: "Mercados",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "CuotaUnder",
                table: "Mercados",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "DineroOver",
                table: "Mercados",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "DineroUnder",
                table: "Mercados",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "EquipoLocal",
                table: "Eventos",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EquipoVisitante",
                table: "Eventos",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "EventoId",
                keyValue: 1,
                columns: new[] { "EquipoLocal", "EquipoVisitante" },
                values: new object[] { "Barça", "Madrid" });

            migrationBuilder.UpdateData(
                table: "Mercados",
                keyColumn: "MercadoId",
                keyValue: 1,
                columns: new[] { "CuotaOver", "CuotaUnder", "DineroOver", "DineroUnder" },
                values: new object[] { 1.5, 2.5, 100.0, 50.0 });

            migrationBuilder.UpdateData(
                table: "Mercados",
                keyColumn: "MercadoId",
                keyValue: 2,
                columns: new[] { "CuotaOver", "CuotaUnder", "DineroOver", "DineroUnder" },
                values: new object[] { 1.5, 1.5, 100.0, 100.0 });

            migrationBuilder.UpdateData(
                table: "Mercados",
                keyColumn: "MercadoId",
                keyValue: 3,
                columns: new[] { "CuotaOver", "CuotaUnder", "DineroOver", "DineroUnder" },
                values: new object[] { 2.5, 1.5, 50.0, 100.0 });
        }
    }
}
