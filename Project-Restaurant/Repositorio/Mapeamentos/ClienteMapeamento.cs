using Microsoft.EntityFrameworkCore;
using Repositorio.Entidades;

namespace Repositorio.Mapeamentos
{
    internal class ClienteMapeamento : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("clientes");

            builder.HasKey(x => x.Id).HasName("id");

            builder.Property(x => x.Nome)
                .HasColumnType("VARCHAR")
                .HasMaxLength(40)
                .IsRequired()
                .HasColumnName("especie"); // NOT NULL

            builder.Property(x => x.Telefone)
                .HasColumnType("VARCHAR")


        }


    }
}
