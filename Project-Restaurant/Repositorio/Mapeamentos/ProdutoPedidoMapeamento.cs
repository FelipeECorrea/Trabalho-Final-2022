using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repositorio.Entidades;

namespace Repositorio.Mapeamentos
{
    public class ProdutoPedidoMapeamento : IEntityTypeConfiguration<ProdutoPedido>
    {
        public void Configure(EntityTypeBuilder<ProdutoPedido> builder)
        {
            builder.ToTable("produtos_pedidos");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.ProdutoId)
                .HasColumnType("INT")
                .IsRequired()
                .HasColumnName("produto_id"); // NOT NULL

            builder.Property(x => x.PedidoId)
                .HasColumnType("INT")
                .IsRequired()
                .HasColumnName("pedido_id"); // NOT NULL

            builder.Property(x => x.Valor)
                .HasColumnType("DECIMAL")
                .IsRequired()
                .HasColumnName("valor"); // NOT NULL

            builder.HasOne(x => x.Produto)
                .WithMany(x => x.ProdutosPedidos)
                .HasForeignKey(x => x.ProdutoId);

            builder.HasOne(x => x.Pedido)
                .WithMany(x => x.ProdutosPedidos)
                .HasForeignKey(x => x.PedidoId);
        }
    }
}
