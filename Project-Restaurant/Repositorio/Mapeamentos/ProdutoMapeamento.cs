using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
               .HasColumnType("DECIMAL")
               .IsRequired()
               .HasColumnName("valor");

            builder.Property(x => x.Nome)
              .HasColumnType("VARCHAR")
              .HasMaxLength(40)
              .IsRequired()
              .HasColumnName("nome");

            builder.Property(x => x.Categoria)
               .HasColumnType("VARCHAR")
               .HasMaxLength(1000)
               .IsRequired()
               .HasColumnName("categoria");

            builder.Property(x => x.Descricao)
             .HasColumnType("VARCHAR")
             .HasMaxLength(200)
             .IsRequired()
             .HasColumnName("descricao");


            builder.Property(x => x.ProdutoCaminho)
               .HasColumnType("VARCHAR")
               .HasMaxLength(1000)
               .IsRequired()
               .HasColumnName("produto_caminho");

            builder.HasData(
               new Produto
               {
                   Id = 1,
                   Valor = 20,
                   Nome = "Yakissoba",
                   Categoria = "Massas",
                   Descricao = "Yakissoba de frango e legumes",
                   ProdutoCaminho = "favicon.ico"
               },
               new Produto
               {
                   Id = 2,
                   Valor = 6,
                   Nome = "Coca-cola 600ml",
                   Categoria = "Bebidas",
                   Descricao = "Coca-cola 600ml",
                   ProdutoCaminho = "favicon.ico"

               });
        }
    }
}
