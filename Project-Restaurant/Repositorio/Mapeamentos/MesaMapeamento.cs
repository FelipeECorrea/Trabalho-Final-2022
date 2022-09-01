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
               .HasColumnName("numeroMesa"); // NOT NULL

            builder.HasData(
                new Mesa
                {
                    Id = 1,
                    numeroMesa = 1
                    
                },
                new Mesa
                {
                    Id = 2,
                    numeroMesa = 2
                    
                },
                new Mesa
                {
                    Id = 3,
                    numeroMesa = 3

                }, 
                new Mesa
                {
                    Id = 4,
                    numeroMesa = 4

                },
                new Mesa
                {
                    Id = 5,
                    numeroMesa = 5

                },

                new Mesa
                {
                    Id = 2,
                    numeroMesa = 6
                }
               );
        }

    }
}
