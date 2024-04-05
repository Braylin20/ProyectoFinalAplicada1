using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectFinal.Migrations
{
    /// <inheritdoc />
    public partial class ArchivoSentencia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Sentencia",
                table: "Sentencias",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sentencia",
                table: "Sentencias");
        }
    }
}
