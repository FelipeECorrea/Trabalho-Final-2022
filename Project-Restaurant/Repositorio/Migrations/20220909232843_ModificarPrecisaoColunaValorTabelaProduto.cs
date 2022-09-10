using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositorio.Migrations
{
    public partial class ModificarPrecisaoColunaValorTabelaProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Mesa_MesaId",
                table: "Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Cliente_ClienteId",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Mesa_MesaId",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_produtos_pedidos_Cliente_ClienteId",
                table: "produtos_pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_produtos_pedidos_Pedido_pedido_id",
                table: "produtos_pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_produtos_pedidos_produtos_produto_id",
                table: "produtos_pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_produtos_pedidos",
                table: "produtos_pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pedido",
                table: "Pedido");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mesa",
                table: "Mesa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.RenameTable(
                name: "produtos_pedidos",
                newName: "ProdutosPedidos");

            migrationBuilder.RenameTable(
                name: "Pedido",
                newName: "pedidos");

            migrationBuilder.RenameTable(
                name: "Mesa",
                newName: "mesas");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "clientes");

            migrationBuilder.RenameColumn(
                name: "valor",
                table: "ProdutosPedidos",
                newName: "Valor");

            migrationBuilder.RenameColumn(
                name: "produto_id",
                table: "ProdutosPedidos",
                newName: "ProdutoId");

            migrationBuilder.RenameColumn(
                name: "pedido_id",
                table: "ProdutosPedidos",
                newName: "PedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_produtos_pedidos_produto_id",
                table: "ProdutosPedidos",
                newName: "IX_ProdutosPedidos_ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_produtos_pedidos_pedido_id",
                table: "ProdutosPedidos",
                newName: "IX_ProdutosPedidos_PedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_produtos_pedidos_ClienteId",
                table: "ProdutosPedidos",
                newName: "IX_ProdutosPedidos_ClienteId");

            migrationBuilder.RenameColumn(
                name: "Observacao",
                table: "pedidos",
                newName: "observacao");

            migrationBuilder.RenameColumn(
                name: "MesaId",
                table: "pedidos",
                newName: "id_mesa");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "pedidos",
                newName: "id_cliente");

            migrationBuilder.RenameIndex(
                name: "IX_Pedido_MesaId",
                table: "pedidos",
                newName: "IX_pedidos_id_mesa");

            migrationBuilder.RenameIndex(
                name: "IX_Pedido_ClienteId",
                table: "pedidos",
                newName: "IX_pedidos_id_cliente");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "mesas",
                newName: "statusMesa");

            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "clientes",
                newName: "telefone");

            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "clientes",
                newName: "senha");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "clientes",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "clientes",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "clientes",
                newName: "cpf");

            migrationBuilder.RenameIndex(
                name: "IX_Cliente_MesaId",
                table: "clientes",
                newName: "IX_clientes_MesaId");

            migrationBuilder.AlterColumn<decimal>(
                name: "valor",
                table: "produtos",
                type: "DECIMAL(5,2)",
                precision: 5,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL");

            migrationBuilder.AlterColumn<decimal>(
                name: "Valor",
                table: "ProdutosPedidos",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL");

            migrationBuilder.AlterColumn<int>(
                name: "ProdutoId",
                table: "ProdutosPedidos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.AlterColumn<int>(
                name: "PedidoId",
                table: "ProdutosPedidos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.AlterColumn<string>(
                name: "observacao",
                table: "pedidos",
                type: "VARCHAR(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "id_mesa",
                table: "pedidos",
                type: "INT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "id_cliente",
                table: "pedidos",
                type: "INT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "NumeroMesa",
                table: "mesas",
                type: "TINYINT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "statusMesa",
                table: "mesas",
                type: "TINYINT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "telefone",
                table: "clientes",
                type: "VARCHAR(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "senha",
                table: "clientes",
                type: "VARCHAR(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "clientes",
                type: "VARCHAR(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "clientes",
                type: "VARCHAR(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "cpf",
                table: "clientes",
                type: "VARCHAR(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProdutosPedidos",
                table: "ProdutosPedidos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pedidos",
                table: "pedidos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_mesas",
                table: "mesas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "id",
                table: "clientes",
                column: "Id");

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

            migrationBuilder.CreateIndex(
                name: "IX_clientes_email",
                table: "clientes",
                column: "email",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_clientes_mesas_MesaId",
                table: "clientes",
                column: "MesaId",
                principalTable: "mesas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_pedidos_clientes_id_cliente",
                table: "pedidos",
                column: "id_cliente",
                principalTable: "clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_pedidos_mesas_id_mesa",
                table: "pedidos",
                column: "id_mesa",
                principalTable: "mesas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutosPedidos_clientes_ClienteId",
                table: "ProdutosPedidos",
                column: "ClienteId",
                principalTable: "clientes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutosPedidos_pedidos_PedidoId",
                table: "ProdutosPedidos",
                column: "PedidoId",
                principalTable: "pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutosPedidos_produtos_ProdutoId",
                table: "ProdutosPedidos",
                column: "ProdutoId",
                principalTable: "produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clientes_mesas_MesaId",
                table: "clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_pedidos_clientes_id_cliente",
                table: "pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_pedidos_mesas_id_mesa",
                table: "pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_ProdutosPedidos_clientes_ClienteId",
                table: "ProdutosPedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_ProdutosPedidos_pedidos_PedidoId",
                table: "ProdutosPedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_ProdutosPedidos_produtos_ProdutoId",
                table: "ProdutosPedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProdutosPedidos",
                table: "ProdutosPedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pedidos",
                table: "pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_mesas",
                table: "mesas");

            migrationBuilder.DropPrimaryKey(
                name: "id",
                table: "clientes");

            migrationBuilder.DropIndex(
                name: "IX_clientes_email",
                table: "clientes");

            migrationBuilder.DeleteData(
                table: "mesas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "mesas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "mesas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "mesas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "mesas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "mesas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.RenameTable(
                name: "ProdutosPedidos",
                newName: "produtos_pedidos");

            migrationBuilder.RenameTable(
                name: "pedidos",
                newName: "Pedido");

            migrationBuilder.RenameTable(
                name: "mesas",
                newName: "Mesa");

            migrationBuilder.RenameTable(
                name: "clientes",
                newName: "Cliente");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "produtos_pedidos",
                newName: "valor");

            migrationBuilder.RenameColumn(
                name: "ProdutoId",
                table: "produtos_pedidos",
                newName: "produto_id");

            migrationBuilder.RenameColumn(
                name: "PedidoId",
                table: "produtos_pedidos",
                newName: "pedido_id");

            migrationBuilder.RenameIndex(
                name: "IX_ProdutosPedidos_ProdutoId",
                table: "produtos_pedidos",
                newName: "IX_produtos_pedidos_produto_id");

            migrationBuilder.RenameIndex(
                name: "IX_ProdutosPedidos_PedidoId",
                table: "produtos_pedidos",
                newName: "IX_produtos_pedidos_pedido_id");

            migrationBuilder.RenameIndex(
                name: "IX_ProdutosPedidos_ClienteId",
                table: "produtos_pedidos",
                newName: "IX_produtos_pedidos_ClienteId");

            migrationBuilder.RenameColumn(
                name: "observacao",
                table: "Pedido",
                newName: "Observacao");

            migrationBuilder.RenameColumn(
                name: "id_mesa",
                table: "Pedido",
                newName: "MesaId");

            migrationBuilder.RenameColumn(
                name: "id_cliente",
                table: "Pedido",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_pedidos_id_mesa",
                table: "Pedido",
                newName: "IX_Pedido_MesaId");

            migrationBuilder.RenameIndex(
                name: "IX_pedidos_id_cliente",
                table: "Pedido",
                newName: "IX_Pedido_ClienteId");

            migrationBuilder.RenameColumn(
                name: "statusMesa",
                table: "Mesa",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "telefone",
                table: "Cliente",
                newName: "Telefone");

            migrationBuilder.RenameColumn(
                name: "senha",
                table: "Cliente",
                newName: "Senha");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Cliente",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Cliente",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "Cliente",
                newName: "Cpf");

            migrationBuilder.RenameIndex(
                name: "IX_clientes_MesaId",
                table: "Cliente",
                newName: "IX_Cliente_MesaId");

            migrationBuilder.AlterColumn<decimal>(
                name: "valor",
                table: "produtos",
                type: "DECIMAL",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(5,2)",
                oldPrecision: 5,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "valor",
                table: "produtos_pedidos",
                type: "DECIMAL",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "produto_id",
                table: "produtos_pedidos",
                type: "INT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "pedido_id",
                table: "produtos_pedidos",
                type: "INT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Observacao",
                table: "Pedido",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<int>(
                name: "MesaId",
                table: "Pedido",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Pedido",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.AlterColumn<int>(
                name: "NumeroMesa",
                table: "Mesa",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "TINYINT");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Mesa",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "TINYINT");

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(11)",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(11)",
                oldMaxLength: 11);

            migrationBuilder.AddPrimaryKey(
                name: "PK_produtos_pedidos",
                table: "produtos_pedidos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pedido",
                table: "Pedido",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mesa",
                table: "Mesa",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Mesa_MesaId",
                table: "Cliente",
                column: "MesaId",
                principalTable: "Mesa",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Cliente_ClienteId",
                table: "Pedido",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Mesa_MesaId",
                table: "Pedido",
                column: "MesaId",
                principalTable: "Mesa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_produtos_pedidos_Cliente_ClienteId",
                table: "produtos_pedidos",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_produtos_pedidos_Pedido_pedido_id",
                table: "produtos_pedidos",
                column: "pedido_id",
                principalTable: "Pedido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_produtos_pedidos_produtos_produto_id",
                table: "produtos_pedidos",
                column: "produto_id",
                principalTable: "produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
