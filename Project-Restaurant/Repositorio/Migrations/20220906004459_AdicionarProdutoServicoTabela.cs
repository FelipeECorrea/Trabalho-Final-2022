using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositorio.Migrations
{
    public partial class AdicionarProdutoServicoTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mesa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroMesa = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    valor = table.Column<decimal>(type: "DECIMAL", nullable: false),
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
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MesaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Mesa_MesaId",
                        column: x => x.MesaId,
                        principalTable: "Mesa",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    MesaId = table.Column<int>(type: "int", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedido_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedido_Mesa_MesaId",
                        column: x => x.MesaId,
                        principalTable: "Mesa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "produtos_pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    produto_id = table.Column<int>(type: "INT", nullable: false),
                    pedido_id = table.Column<int>(type: "INT", nullable: false),
                    valor = table.Column<decimal>(type: "DECIMAL", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtos_pedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_produtos_pedidos_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_produtos_pedidos_Pedido_pedido_id",
                        column: x => x.pedido_id,
                        principalTable: "Pedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_produtos_pedidos_produtos_produto_id",
                        column: x => x.produto_id,
                        principalTable: "produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "produtos",
                columns: new[] { "Id", "categoria", "descricao", "nome", "produto_caminho", "valor" },
                values: new object[] { 1, "Massas", "Yakissoba de frango e legumes", "Yakissoba", "favicon.ico", 20m });

            migrationBuilder.InsertData(
                table: "produtos",
                columns: new[] { "Id", "categoria", "descricao", "nome", "produto_caminho", "valor" },
                values: new object[] { 2, "Bebidas", "Coca-cola 600ml", "Coca-cola 600ml", "favicon.ico", 6m });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_MesaId",
                table: "Cliente",
                column: "MesaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ClienteId",
                table: "Pedido",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_MesaId",
                table: "Pedido",
                column: "MesaId");

            migrationBuilder.CreateIndex(
                name: "IX_produtos_pedidos_ClienteId",
                table: "produtos_pedidos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_produtos_pedidos_pedido_id",
                table: "produtos_pedidos",
                column: "pedido_id");

            migrationBuilder.CreateIndex(
                name: "IX_produtos_pedidos_produto_id",
                table: "produtos_pedidos",
                column: "produto_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "produtos_pedidos");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "produtos");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Mesa");
        }
    }
}
