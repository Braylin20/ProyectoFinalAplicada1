using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectFinal.Migrations
{
    /// <inheritdoc />
    public partial class EliminandoTelefono : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "TelefonoDetalles",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TelefonoDetalles_Id",
                table: "TelefonoDetalles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TelefonoDetalles_AspNetUsers_Id",
                table: "TelefonoDetalles",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TelefonoDetalles_AspNetUsers_Id",
                table: "TelefonoDetalles");

            migrationBuilder.DropIndex(
                name: "IX_TelefonoDetalles_Id",
                table: "TelefonoDetalles");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "TelefonoDetalles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Telefono",
                table: "AspNetUsers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
