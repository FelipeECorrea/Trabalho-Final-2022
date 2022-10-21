using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositorio.Migrations
{
    public partial class GerarEstruturaBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "administrador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    telefone = table.Column<string>(type: "VARCHAR(11)", maxLength: 11, nullable: false),
                    cpf = table.Column<string>(type: "VARCHAR(11)", maxLength: 11, nullable: false),
                    nome = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    email = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    senha = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_administrador", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    telefone = table.Column<string>(type: "VARCHAR(11)", maxLength: 11, nullable: false),
                    cpf = table.Column<string>(type: "VARCHAR(11)", maxLength: 11, nullable: false),
                    statusCliente = table.Column<byte>(type: "TINYINT", nullable: true),
                    autorizacao = table.Column<byte>(type: "TINYINT", nullable: true),
                    nome = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    email = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    senha = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mesas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroMesa = table.Column<byte>(type: "TINYINT", nullable: false),
                    statusMesa = table.Column<byte>(type: "TINYINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mesas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    valor = table.Column<decimal>(type: "DECIMAL(5,2)", precision: 5, scale: 2, nullable: false),
                    nome = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    categoria = table.Column<string>(type: "VARCHAR(1000)", maxLength: 1000, nullable: false),
                    descricao = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    produto_caminho = table.Column<string>(type: "VARCHAR(1000)", maxLength: 1000, nullable: false),
                    statusProduto = table.Column<byte>(type: "TINYINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_cliente = table.Column<int>(type: "INT", nullable: false),
                    id_mesa = table.Column<int>(type: "INT", nullable: false),
                    observacao = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pedidos_clientes_id_cliente",
                        column: x => x.id_cliente,
                        principalTable: "clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pedidos_mesas_id_mesa",
                        column: x => x.id_mesa,
                        principalTable: "mesas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "produtos_pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_produto = table.Column<int>(type: "INT", nullable: false),
                    pedido_id = table.Column<int>(type: "INT", nullable: false),
                    valor = table.Column<decimal>(type: "DECIMAL", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtos_pedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_produtos_pedidos_pedidos_pedido_id",
                        column: x => x.pedido_id,
                        principalTable: "pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_produtos_pedidos_produtos_id_produto",
                        column: x => x.id_produto,
                        principalTable: "produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "administrador",
                columns: new[] { "Id", "cpf", "email", "nome", "senha", "telefone" },
                values: new object[,]
                {
                    { 1, "10437548902", "admin@admin.com", "ADM", "admin123", "47991392902" },
                    { 2, "10639142990", "joaomarti755@gmail.com", "João", "admin123", "47988278800" }
                });

            migrationBuilder.InsertData(
                table: "clientes",
                columns: new[] { "Id", "autorizacao", "cpf", "email", "nome", "senha", "statusCliente", "telefone" },
                values: new object[,]
                {
                    { 1, (byte)0, "10437548902", "cristyanalexandrino.od@gmail.com", "Cristyan", "admin001", (byte)2, "47991392902" },
                    { 2, (byte)0, "10639142990", "pessoal@gmail.com", "Felipe", "admin002", (byte)3, "47988278800" },
                    { 3, (byte)0, "11073394999", "alan786k@gmail.com", "Alan", "admin003", (byte)2, "47996250612" },
                    { 4, (byte)0, "10687634507", "marina@gmail.com", "Marina", "admin004", (byte)2, "47991785490" },
                    { 5, (byte)0, "10167898534", "joão@gmail.com", "João", "admin005", (byte)2, "47999674309" }
                });

            migrationBuilder.InsertData(
                table: "mesas",
                columns: new[] { "Id", "NumeroMesa", "statusMesa" },
                values: new object[,]
                {
                    { 1, (byte)1, (byte)0 },
                    { 2, (byte)2, (byte)0 },
                    { 3, (byte)3, (byte)0 },
                    { 4, (byte)4, (byte)0 },
                    { 5, (byte)5, (byte)0 },
                    { 6, (byte)6, (byte)0 }
                });

            migrationBuilder.InsertData(
                table: "produtos",
                columns: new[] { "Id", "categoria", "descricao", "nome", "produto_caminho", "statusProduto", "valor" },
                values: new object[,]
                {
                    { 1, "Tradicionais", "X-Salada Tradicional da Casa", "X-Salada Tradicional", "X-Burguer.png", (byte)1, 19.50m },
                    { 2, "Massas", "Yakissoba Tradicional", "Yakissoba", "yakisoba.jpg", (byte)1, 21.63m },
                    { 3, "Sobremesas", "Pudim de Leite 400g", "Pudim de Leite", "pudim.jpg", (byte)1, 8.60m },
                    { 4, "Extras", "Batata Rústica com Alecrim", "Batata Rústica com Alecrim", "batata-rustica.jpg", (byte)1, 14.80m },
                    { 5, "Extras", "Batata Rústica com Alecrim", "Batata Rústica com Alecrim", "batata-rustica.jpg", (byte)1, 14.80m },
                    { 6, "Extras", "Batata Frita - Porção Grande", "Batata Frita Grande", "batata-frita-porcao.jpg", (byte)1, 25.90m },
                    { 7, "Tradicional", "Feijoada completa", "Feijoada", "feijoada.jpg", (byte)1, 28.90m },
                    { 8, "Bebidas", "Pepsi Twist 600ml", "Pepsi Twist 200ml", "pepsi.jpg", (byte)1, 6.00m },
                    { 9, "Tradicional", "Salpicão de frango", "Salpicão de Frango", "salpicao.jpg", (byte)1, 19.90m },
                    { 10, "Tradicional", "Torta de morango - Fatia", "Torta de Morango", "torta-morango.jpg", (byte)1, 19.90m },
                    { 11, "Bebidas", "Cerveja Stella Artois Longneck - 375ml", "Cerveja Stella Artois Longneck", "stella.jpg", (byte)1, 19.90m }
                });

            migrationBuilder.InsertData(
                table: "pedidos",
                columns: new[] { "Id", "id_cliente", "id_mesa", "observacao" },
                values: new object[] { 1, 1, 1, "Bem quente" });

            migrationBuilder.InsertData(
                table: "pedidos",
                columns: new[] { "Id", "id_cliente", "id_mesa", "observacao" },
                values: new object[] { 2, 2, 2, "Bem quente" });

            migrationBuilder.CreateIndex(
                name: "IX_administrador_email",
                table: "administrador",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_clientes_email",
                table: "clientes",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_id_cliente",
                table: "pedidos",
                column: "id_cliente");

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_id_mesa",
                table: "pedidos",
                column: "id_mesa");

            migrationBuilder.CreateIndex(
                name: "IX_produtos_pedidos_id_produto",
                table: "produtos_pedidos",
                column: "id_produto");

            migrationBuilder.CreateIndex(
                name: "IX_produtos_pedidos_pedido_id",
                table: "produtos_pedidos",
                column: "pedido_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "administrador");

            migrationBuilder.DropTable(
                name: "produtos_pedidos");

            migrationBuilder.DropTable(
                name: "pedidos");

            migrationBuilder.DropTable(
                name: "produtos");

            migrationBuilder.DropTable(
                name: "clientes");

            migrationBuilder.DropTable(
                name: "mesas");
        }
    }
}
