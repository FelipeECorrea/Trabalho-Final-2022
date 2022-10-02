using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositorio.Migrations
{
    public partial class AtualizandoClienteMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "statusCliente",
                table: "clientes",
                type: "TINYINT",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "TINYINT");

            migrationBuilder.AlterColumn<byte>(
                name: "autorizacao",
                table: "clientes",
                type: "TINYINT",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "TINYINT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "statusCliente",
                table: "clientes",
                type: "TINYINT",
                nullable: false,
                defaultValue: (byte)0,
                oldClrType: typeof(byte),
                oldType: "TINYINT",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "autorizacao",
                table: "clientes",
                type: "TINYINT",
                nullable: false,
                defaultValue: (byte)0,
                oldClrType: typeof(byte),
                oldType: "TINYINT",
                oldNullable: true);
        }
    }
}
