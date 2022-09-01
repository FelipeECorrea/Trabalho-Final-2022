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
                .HasColumnType("TINYINT")
                .IsRequired()
                .HasColumnName("id_cliente"); // NOT NULL

            builder.Property(x => x.MesaId)
                .HasColumnType("TINYINT")
                .IsRequired()
                .HasColumnName("id_mesa"); // NOT NULL

            builder.Property(x => x.Observacao)
                .HasColumnType("VARCHAR")
                .HasMaxLength(150)
                .IsRequired()
                .HasColumnName("observacao"); // NOT NULL

            builder.Property(x => x.ProdutoId)
                .HasColumnType("TINYINT")
                .IsRequired()
                .HasColumnName("id_produto"); // NOT NULL

            builder.Property(x => x.Quantidade)
                .HasColumnType("TINYINT")
                .IsRequired()
                .HasColumnName("quantidade"); // NOT NULL


            // INNER JOIN
            builder.HasOne(x => x.Cliente)
                .WithMany(x => x.Pedidos)
                .HasForeignKey(x => x.ClienteId)
                .IsRequired();

        }
    }
}
