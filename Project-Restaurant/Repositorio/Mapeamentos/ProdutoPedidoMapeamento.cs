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

            builder.Property(x => x.ClienteId)
                .HasColumnType("INT")
                .IsRequired()
                .HasColumnName("cliente_id"); // NOT NULL

            builder.Property(x => x.SomaTotal)
                .HasColumnType("DECIMAL")
                .IsRequired()
                .HasColumnName("soma_total"); // NOT NULL

            builder.HasOne(x => x.Produto)
                .WithMany(x => x.ProdutosPedidos)
                .HasForeignKey(x => x.ProdutoId);

            builder.HasOne(x => x.Cliente)
                .WithMany(x => x.ProdutosPedidos)
                .HasForeignKey(x => x.ClienteId);
        }
    }
}
