using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositorio.Migrations
{
    public partial class AdicionarClientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "clientes",
                keyColumn: "Id",
                keyValue: 1,
                column: "senha",
                value: "admin001");

            migrationBuilder.UpdateData(
                table: "clientes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "autorizacao", "senha" },
                values: new object[] { (byte)0, "admin002" });

            migrationBuilder.InsertData(
                table: "clientes",
                columns: new[] { "Id", "autorizacao", "cpf", "email", "nome", "senha", "statusCliente", "telefone" },
                values: new object[,]
                {
                    { 3, (byte)0, "11073394999", "alan786k@gmail.com", "Alan", "admin003", (byte)2, "47996250612" },
                    { 4, (byte)0, "10687634507", "marina@gmail.com", "Marina", "admin004", (byte)2, "47991785490" },
                    { 5, (byte)0, "10167898534", "joão@gmail.com", "João", "admin005", (byte)2, "47999674309" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "clientes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "clientes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "clientes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "clientes",
                keyColumn: "Id",
                keyValue: 1,
                column: "senha",
                value: "admin123");

            migrationBuilder.UpdateData(
                table: "clientes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "autorizacao", "senha" },
                values: new object[] { (byte)1, "admin123" });
        }
    }
}
