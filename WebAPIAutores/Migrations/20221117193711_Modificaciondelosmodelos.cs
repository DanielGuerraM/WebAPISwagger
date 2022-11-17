using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPIAutores.Migrations
{
    /// <inheritdoc />
    public partial class Modificaciondelosmodelos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Autores",
                newName: "SegundoApellido");

            migrationBuilder.AddColumn<string>(
                name: "Editorial",
                table: "Libros",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FechaPublicacion",
                table: "Libros",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumPaginas",
                table: "Libros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FechaNacimiento",
                table: "Autores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nacionalidad",
                table: "Autores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombres",
                table: "Autores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrimerApellido",
                table: "Autores",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Editorial",
                table: "Libros");

            migrationBuilder.DropColumn(
                name: "FechaPublicacion",
                table: "Libros");

            migrationBuilder.DropColumn(
                name: "NumPaginas",
                table: "Libros");

            migrationBuilder.DropColumn(
                name: "FechaNacimiento",
                table: "Autores");

            migrationBuilder.DropColumn(
                name: "Nacionalidad",
                table: "Autores");

            migrationBuilder.DropColumn(
                name: "Nombres",
                table: "Autores");

            migrationBuilder.DropColumn(
                name: "PrimerApellido",
                table: "Autores");

            migrationBuilder.RenameColumn(
                name: "SegundoApellido",
                table: "Autores",
                newName: "Nombre");
        }
    }
}
