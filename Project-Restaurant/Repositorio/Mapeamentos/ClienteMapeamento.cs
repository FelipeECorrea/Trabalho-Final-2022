using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repositorio.Entidades;
using System.Reflection.Emit;


namespace Repositorio.Mapeamentos
{
    public class ClienteMapeamento : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("clientes");

            builder.HasKey(x => x.Id).HasName("id");

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

            //builder.HasData(
            //   new Cliente
            //   {
            //       Nome = "Cristyan",
            //       Telefone = "47991392902",
            //       Cpf = "10437548902",
            //       Email = "cristyanalexandrino.od@gmail.com",
            //       Senha = "admin123"

            //   });
        }
    }
}
