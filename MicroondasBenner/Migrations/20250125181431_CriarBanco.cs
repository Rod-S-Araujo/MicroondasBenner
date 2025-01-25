using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MicroondasBenner.Migrations
{
    /// <inheritdoc />
    public partial class CriarBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CookModes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Alimento = table.Column<string>(type: "TEXT", nullable: false),
                    Tempo = table.Column<decimal>(type: "TEXT", nullable: false),
                    Potencia = table.Column<int>(type: "INTEGER", nullable: false),
                    Instruções = table.Column<string>(type: "TEXT", nullable: false),
                    Alteravel = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CookModes", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CookModes");
        }
    }
}
