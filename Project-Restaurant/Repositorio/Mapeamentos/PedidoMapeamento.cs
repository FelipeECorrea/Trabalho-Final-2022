using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repositorio.Entidades;

namespace Repositorio.Mapeamentos
{
    public class PedidoMapeamento : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("pedidos");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ClienteId)
                .HasColumnType("INT")
                .IsRequired()
                .HasColumnName("id_cliente");

            builder.Property(x => x.MesaId)
                .HasColumnType("INT")
                .IsRequired()
                .HasColumnName("id_mesa");

            builder.Property(x => x.ProdutoId)
                .HasColumnType("INT")
                .IsRequired()
                .HasColumnName("id_produto");

            builder.Property(x => x.Observacao)
                .HasColumnType("VARCHAR")
                .HasMaxLength(150)
                .IsRequired()
                .HasColumnName("observacao");

            // INNER JOIN 
            builder.HasOne(x => x.Cliente)
                .WithMany(x => x.Pedidos)
                .HasForeignKey(x => x.ClienteId);

            builder.HasOne(x => x.Mesa)
                .WithMany(x => x.Pedidos)
                .HasForeignKey(x => x.MesaId);

            builder.HasOne(x => x.Produto)
                .WithMany(x => x.Pedidos)
                .HasForeignKey(x => x.ProdutoId);

            builder.HasData(
               new Pedido
               {
                   Id = 1,
                   ClienteId = 1,
                   MesaId = 1,
                   ProdutoId = 1,
                   Observacao = "Bem quente"
               },
               new Pedido
               {
                   Id = 2,
                   ClienteId = 2,
                   MesaId = 2,
                   ProdutoId = 1,
                   Observacao = "Bem quente"
               });
        }
    }
}
