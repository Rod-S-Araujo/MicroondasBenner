using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MicroondasBenner.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoColunaStringAquecimento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "stringAquecimento",
                table: "CookModes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "stringAquecimento",
                table: "CookModes");
        }
    }
}
