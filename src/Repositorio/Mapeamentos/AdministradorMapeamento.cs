using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repositorio.Entidades;
using Repositorio.Enums;

namespace Repositorio.Mapeamentos
{
    public class AdministradorMapeamento : IEntityTypeConfiguration<Administrador>
    {
        public void Configure(EntityTypeBuilder<Administrador> builder)
        {
            builder.ToTable("administrador");

            builder.HasKey(x => x.Id).HasName("id");

            builder.HasIndex(p => new { p.Email })
                .IsUnique(true);

            builder.Property(x => x.Nome)
                .HasColumnType("VARCHAR")
                .HasMaxLength(40)
                .IsRequired()
                .HasColumnName("nome"); // NOT NULL

            builder.Property(x => x.Telefone)
                .HasColumnType("VARCHAR")
                .HasMaxLength(11)
                .IsRequired()
                .HasColumnName("telefone");

            builder.Property(x => x.Cpf)
                .HasColumnType("VARCHAR")
                .HasMaxLength(11)
                .IsRequired()
                .HasColumnName("cpf");

            builder.Property(x => x.Email)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnName("email");

            builder.Property(x => x.Senha)
                .HasColumnType("VARCHAR")
                .HasMaxLength(20)
                .IsRequired()
            .HasColumnName("senha");

            builder.HasData(
              new Administrador
              {
                  Id = 1,
                  Nome = "ADM",
                  Telefone = "47991392902",
                  Cpf = "10437548902",
                  Email = "admin@admin.com",
                  Senha = "admin123",
              },
              new Administrador
              {
                  Id = 2,
                  Nome = "João",
                  Telefone = "47988278800",
                  Cpf = "10639142990",
                  Email = "joaomarti755@gmail.com",
                  Senha = "admin123",
              });
        }
    }
}
