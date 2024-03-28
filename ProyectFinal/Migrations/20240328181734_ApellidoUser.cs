using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectFinal.Migrations
{
    /// <inheritdoc />
    public partial class ApellidoUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "AspNetUsers");
        }
    }
}
