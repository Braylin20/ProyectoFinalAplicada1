using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectFinal.Migrations
{
    /// <inheritdoc />
    public partial class FotoCedula : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Archivo",
                table: "Demandas",
                newName: "FotoCedula");

            migrationBuilder.AddColumn<byte[]>(
                name: "Documento",
                table: "Demandas",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Documento",
                table: "Demandas");

            migrationBuilder.RenameColumn(
                name: "FotoCedula",
                table: "Demandas",
                newName: "Archivo");
        }
    }
}
