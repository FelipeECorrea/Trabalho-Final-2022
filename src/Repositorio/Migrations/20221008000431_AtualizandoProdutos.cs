using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositorio.Migrations
{
    public partial class AtualizandoProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "produtos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "categoria", "descricao", "nome", "produto_caminho", "valor" },
                values: new object[] { "Tradicionais", "X-Salada Tradicional da Casa", "X-Salada Tradicional", "X-Burguer.png", 19.50m });

            migrationBuilder.UpdateData(
                table: "produtos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "categoria", "descricao", "nome", "produto_caminho", "valor" },
                values: new object[] { "Massas", "Yakissoba Tradicional", "Yakissoba", "yakisoba.jpg", 21.63m });

            migrationBuilder.InsertData(
                table: "produtos",
                columns: new[] { "Id", "categoria", "descricao", "nome", "produto_caminho", "statusProduto", "valor" },
                values: new object[,]
                {
                    { 3, "Bebidas", "Coca-Cola 600ml", "Coca-Cola 600ml", "Coca-Cola600ml.jpg", (byte)1, 6.99m },
                    { 4, "Sobremesas", "Pudim de Leite 400g", "Pudim de Leite", "pudim.jpg", (byte)1, 8.60m },
                    { 5, "Extras", "Batata Rústica com Alecrim", "Batata Rústica com Alecrim", "batata-rustica.jpg", (byte)1, 14.80m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "produtos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "produtos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "produtos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "produtos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "categoria", "descricao", "nome", "produto_caminho", "valor" },
                values: new object[] { "Massas", "Yakissoba de frango e legumes", "Yakissoba", "favicon.ico", 20m });

            migrationBuilder.UpdateData(
                table: "produtos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "categoria", "descricao", "nome", "produto_caminho", "valor" },
                values: new object[] { "Bebidas", "Coca-cola 600ml", "Coca-cola 600ml", "favicon.ico", 6m });
        }
    }
}
