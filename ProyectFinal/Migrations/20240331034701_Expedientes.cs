using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectFinal.Migrations
{
    /// <inheritdoc />
    public partial class Expedientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Expedientes_Id",
                table: "Expedientes");

            migrationBuilder.CreateIndex(
                name: "IX_Expedientes_Id",
                table: "Expedientes",
                column: "Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Expedientes_Id",
                table: "Expedientes");

            migrationBuilder.CreateIndex(
                name: "IX_Expedientes_Id",
                table: "Expedientes",
                column: "Id");
        }
    }
}
