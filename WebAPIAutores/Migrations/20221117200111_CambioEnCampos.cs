using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPIAutores.Migrations
{
    /// <inheritdoc />
    public partial class CambioEnCampos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumPaginas",
                table: "Libros");

            migrationBuilder.RenameColumn(
                name: "Editorial",
                table: "Libros",
                newName: "IdiomaOriginal");

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Libros",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Libros");

            migrationBuilder.RenameColumn(
                name: "IdiomaOriginal",
                table: "Libros",
                newName: "Editorial");

            migrationBuilder.AddColumn<int>(
                name: "NumPaginas",
                table: "Libros",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
