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
        }
    }
}
