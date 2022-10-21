using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositorio.Migrations
{
    public partial class AdicionarProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "produtos",
                keyColumn: "Id",
                keyValue: 4,
                column: "valor",
                value: 12.50m);

            migrationBuilder.UpdateData(
                table: "produtos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "descricao", "nome", "produto_caminho" },
                values: new object[] { "Batata Frita - Porção Media", "Batata Frita Media", "BatataFritaM.png" });

            migrationBuilder.UpdateData(
                table: "produtos",
                keyColumn: "Id",
                keyValue: 6,
                column: "produto_caminho",
                value: "BatataFritaG.png");

            migrationBuilder.UpdateData(
                table: "produtos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "categoria", "descricao", "nome", "produto_caminho" },
                values: new object[] { "Tradicionais", "Feijoada Brasileirinha, Porção para 2 pessoas.", "Feijoada Brasileira", "FeijoadaBrasileira.png" });

            migrationBuilder.UpdateData(
                table: "produtos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "descricao", "produto_caminho" },
                values: new object[] { "Pepsi Twist 200ml", "PepsiTwistLata.png" });

            migrationBuilder.UpdateData(
                table: "produtos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "categoria", "descricao", "produto_caminho" },
                values: new object[] { "Tradicionais", "Salpicão de Frango", "Salpicao-Frango.png" });

            migrationBuilder.UpdateData(
                table: "produtos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "categoria", "produto_caminho", "valor" },
                values: new object[] { "Sobremesas", "TortaMorango.png", 14.99m });

            migrationBuilder.UpdateData(
                table: "produtos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "descricao", "nome", "produto_caminho", "valor" },
                values: new object[] { "Pina Coloda c/ Vodka e Laranja", "Pina Coloda c/ Vodka", "PinaColada.png", 16.50m });

            migrationBuilder.InsertData(
                table: "produtos",
                columns: new[] { "Id", "categoria", "descricao", "nome", "produto_caminho", "statusProduto", "valor" },
                values: new object[] { 12, "Bebidas", "Cerveja Capivara Pilsen 400ml", "Cerveja Capivara Pilsen 400ml", "CervejaBlumenau.png", (byte)1, 12.50m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "produtos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "produtos",
                keyColumn: "Id",
                keyValue: 4,
                column: "valor",
                value: 14.80m);

            migrationBuilder.UpdateData(
                table: "produtos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "descricao", "nome", "produto_caminho" },
                values: new object[] { "Batata Rústica com Alecrim", "Batata Rústica com Alecrim", "batata-rustica.jpg" });

            migrationBuilder.UpdateData(
                table: "produtos",
                keyColumn: "Id",
                keyValue: 6,
                column: "produto_caminho",
                value: "batata-frita-porcao.jpg");

            migrationBuilder.UpdateData(
                table: "produtos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "categoria", "descricao", "nome", "produto_caminho" },
                values: new object[] { "Tradicional", "Feijoada completa", "Feijoada", "feijoada.jpg" });

            migrationBuilder.UpdateData(
                table: "produtos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "descricao", "produto_caminho" },
                values: new object[] { "Pepsi Twist 600ml", "pepsi.jpg" });

            migrationBuilder.UpdateData(
                table: "produtos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "categoria", "descricao", "produto_caminho" },
                values: new object[] { "Tradicional", "Salpicão de frango", "salpicao.jpg" });

            migrationBuilder.UpdateData(
                table: "produtos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "categoria", "produto_caminho", "valor" },
                values: new object[] { "Tradicional", "torta-morango.jpg", 19.90m });

            migrationBuilder.UpdateData(
                table: "produtos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "descricao", "nome", "produto_caminho", "valor" },
                values: new object[] { "Cerveja Stella Artois Longneck - 375ml", "Cerveja Stella Artois Longneck", "stella.jpg", 19.90m });
        }
    }
}
