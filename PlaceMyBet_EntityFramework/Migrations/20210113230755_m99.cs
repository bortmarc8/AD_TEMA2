using Microsoft.EntityFrameworkCore.Migrations;

namespace PlaceMyBet_EntityFramework.Migrations
{
    public partial class m99 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Apellidos", "Edad", "Nombre" },
                values: new object[,]
                {
                    { "maboto02@floridauniversitaria.es", "Burt", 20, "Merk" },
                    { "maboto03@floridauniversitaria.es", "Bart", 21, "Mirk" },
                    { "maboto04@floridauniversitaria.es", "Bert", 22, "Mork" },
                    { "maboto05@floridauniversitaria.es", "Birt", 23, "Murk" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "maboto02@floridauniversitaria.es");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "maboto03@floridauniversitaria.es");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "maboto04@floridauniversitaria.es");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "maboto05@floridauniversitaria.es");
        }
    }
}
