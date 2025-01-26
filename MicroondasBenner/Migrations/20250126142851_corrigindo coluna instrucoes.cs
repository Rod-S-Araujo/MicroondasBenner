using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MicroondasBenner.Migrations
{
    /// <inheritdoc />
    public partial class corrigindocolunainstrucoes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Instruções",
                table: "CookModes",
                newName: "instrucoes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "instrucoes",
                table: "CookModes",
                newName: "Instruções");
        }
    }
}
