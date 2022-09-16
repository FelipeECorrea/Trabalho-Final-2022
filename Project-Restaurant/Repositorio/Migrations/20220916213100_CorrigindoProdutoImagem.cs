using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositorio.Migrations
{
    public partial class CorrigindoProdutoImagem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "statusProduto",
                table: "produtos",
                type: "TINYINT",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.UpdateData(
                table: "mesas",
                keyColumn: "Id",
                keyValue: 1,
                column: "statusMesa",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "mesas",
                keyColumn: "Id",
                keyValue: 2,
                column: "statusMesa",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "mesas",
                keyColumn: "Id",
                keyValue: 3,
                column: "statusMesa",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "mesas",
                keyColumn: "Id",
                keyValue: 4,
                column: "statusMesa",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "mesas",
                keyColumn: "Id",
                keyValue: 5,
                column: "statusMesa",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "mesas",
                keyColumn: "Id",
                keyValue: 6,
                column: "statusMesa",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "produtos",
                keyColumn: "Id",
                keyValue: 1,
                column: "statusProduto",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "produtos",
                keyColumn: "Id",
                keyValue: 2,
                column: "statusProduto",
                value: (byte)1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "statusProduto",
                table: "produtos");

            migrationBuilder.UpdateData(
                table: "mesas",
                keyColumn: "Id",
                keyValue: 1,
                column: "statusMesa",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "mesas",
                keyColumn: "Id",
                keyValue: 2,
                column: "statusMesa",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "mesas",
                keyColumn: "Id",
                keyValue: 3,
                column: "statusMesa",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "mesas",
                keyColumn: "Id",
                keyValue: 4,
                column: "statusMesa",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "mesas",
                keyColumn: "Id",
                keyValue: 5,
                column: "statusMesa",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "mesas",
                keyColumn: "Id",
                keyValue: 6,
                column: "statusMesa",
                value: (byte)1);
        }
    }
}
