using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositorio.Migrations
{
    public partial class AdicionarMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    produto_caminho = table.Column<string>(type: "VARCHAR(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    telefone = table.Column<string>(type: "VARCHAR(11)", maxLength: 11, nullable: false),
                    cpf = table.Column<string>(type: "VARCHAR(11)", maxLength: 11, nullable: false),
                    email = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    senha = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    MesaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_clientes_mesas_MesaId",
                        column: x => x.MesaId,
                        principalTable: "mesas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_cliente = table.Column<int>(type: "INT", nullable: false),
                    id_produto = table.Column<int>(type: "INT", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_pedidos_produtos_id_produto",
                        column: x => x.id_produto,
                        principalTable: "produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutosPedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    PedidoId = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutosPedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutosPedidos_clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "clientes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProdutosPedidos_pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutosPedidos_produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "mesas",
                columns: new[] { "Id", "NumeroMesa", "statusMesa" },
                values: new object[,]
                {
                    { 1, (byte)1, (byte)1 },
                    { 2, (byte)2, (byte)1 },
                    { 3, (byte)3, (byte)1 },
                    { 4, (byte)4, (byte)1 },
                    { 5, (byte)5, (byte)1 },
                    { 6, (byte)6, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "produtos",
                columns: new[] { "Id", "categoria", "descricao", "nome", "produto_caminho", "valor" },
                values: new object[,]
                {
                    { 1, "Massas", "Yakissoba de frango e legumes", "Yakissoba", "favicon.ico", 20m },
                    { 2, "Bebidas", "Coca-cola 600ml", "Coca-cola 600ml", "favicon.ico", 6m }
                });

            migrationBuilder.InsertData(
                table: "pedidos",
                columns: new[] { "Id", "id_cliente", "id_mesa", "observacao", "id_produto" },
                values: new object[] { 1, 1, 1, "Bem quente", 1 });

            migrationBuilder.InsertData(
                table: "pedidos",
                columns: new[] { "Id", "id_cliente", "id_mesa", "observacao", "id_produto" },
                values: new object[] { 2, 2, 2, "Bem quente", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_clientes_email",
                table: "clientes",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_clientes_MesaId",
                table: "clientes",
                column: "MesaId");

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_id_cliente",
                table: "pedidos",
                column: "id_cliente");

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_id_mesa",
                table: "pedidos",
                column: "id_mesa");

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_id_produto",
                table: "pedidos",
                column: "id_produto");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutosPedidos_ClienteId",
                table: "ProdutosPedidos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutosPedidos_PedidoId",
                table: "ProdutosPedidos",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutosPedidos_ProdutoId",
                table: "ProdutosPedidos",
                column: "ProdutoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProdutosPedidos");

            migrationBuilder.DropTable(
                name: "pedidos");

            migrationBuilder.DropTable(
                name: "clientes");

            migrationBuilder.DropTable(
                name: "produtos");

            migrationBuilder.DropTable(
                name: "mesas");
        }
    }
}
