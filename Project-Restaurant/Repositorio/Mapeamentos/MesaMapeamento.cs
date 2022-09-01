using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repositorio.Entidades;

namespace Repositorio.Mapeamentos
{
    public class MesaMapeamento : IEntityTypeConfiguration<Mesa>
    {
        public void Configure(EntityTypeBuilder<Mesa> builder)
        {
            builder.ToTable("mesas");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.NumeroMesa)
               .HasColumnType("TINYINT")
               .IsRequired()
               .HasColumnName("NumeroMesa");

            builder.HasData(
                new Mesa
                {
                    Id = 1,
                    NumeroMesa = 1                   
                },
                new Mesa
                {
                    Id = 2,
                    NumeroMesa = 2                   
                },
                new Mesa
                {
                    Id = 3,
                    NumeroMesa = 3
                }, 
                new Mesa
                {
                    Id = 4,
                    NumeroMesa = 4
                },
                new Mesa
                {
                    Id = 5,
                    NumeroMesa = 5
                },
                new Mesa
                {
                    Id = 6,
                    NumeroMesa = 6
                });
        }
    }
}
