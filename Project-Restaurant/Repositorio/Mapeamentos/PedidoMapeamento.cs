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
                .HasColumnName("id_cliente");//

            builder.Property(x => x.MesaId)
                .HasColumnType("TINYINT")
                .IsRequired()
                .HasColumnName("id_mesa");

            builder.Property(x => x.Observacao)
                .HasColumnType("VARCHAR")
                .HasMaxLength(150)
                .IsRequired()
                .HasColumnName("observacao");

            builder.Property(x => x.ProdutoId)
                .HasColumnType("TINYINT")
                .IsRequired()
                .HasColumnName("id_produto");

            builder.Property(x => x.Quantidade)
                .HasColumnType("TINYINT")
                .IsRequired()
                .HasColumnName("quantidade");

            // INNER JOIN 
            builder.HasOne(x => x.Cliente)
                .WithMany(x => x.Pedidos)
                .HasForeignKey(x => x.ClienteId)
                .IsRequired();

            // INNER JOIN
            //builder.HasOne(x => x.Cliente)
            //    .WithMany(x => x.Mesas)
            //    .HasForeignKey(x => x.MesaId)
            //    .IsRequired();

        }
    }
}
