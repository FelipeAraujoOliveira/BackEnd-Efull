using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiProva.Migrations
{
    /// <inheritdoc />
    public partial class felipe2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Distancia",
                table: "Entregas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Distancia",
                table: "Entregas");
        }
    }
}
