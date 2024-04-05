using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectFinal.Migrations
{
    /// <inheritdoc />
    public partial class Sentencia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DemandaId",
                table: "Sentencias",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "FotoCedula",
                table: "Demandas",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Documento",
                table: "Demandas",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Cedula",
                table: "Demandas",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NombreDemandado",
                table: "DemandaDetalles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sentencias_DemandaId",
                table: "Sentencias",
                column: "DemandaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sentencias_Demandas_DemandaId",
                table: "Sentencias",
                column: "DemandaId",
                principalTable: "Demandas",
                principalColumn: "DemandaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sentencias_Demandas_DemandaId",
                table: "Sentencias");

            migrationBuilder.DropIndex(
                name: "IX_Sentencias_DemandaId",
                table: "Sentencias");

            migrationBuilder.DropColumn(
                name: "DemandaId",
                table: "Sentencias");

            migrationBuilder.AlterColumn<byte[]>(
                name: "FotoCedula",
                table: "Demandas",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Documento",
                table: "Demandas",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AlterColumn<long>(
                name: "Cedula",
                table: "Demandas",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "NombreDemandado",
                table: "DemandaDetalles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
