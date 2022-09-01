using Microsoft.EntityFrameworkCore;
using Repositorio.Entidades;

namespace Repositorio.Mapeamentos
{
    internal class ProdutoMapeamento : IEntityTypeConfiguration<Produto>
    {
    public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("produtos");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Valor)
               .HasColumnType("TINYINT")
               .IsRequired()
               .HasColumnName("valor");

            builder.Property(x => x.Nome)
              .HasColumnType("VARCHAR")
              .HasMaxLength(40)
              .IsRequired()
              .HasColumnName("nome");


        }
    }
}
