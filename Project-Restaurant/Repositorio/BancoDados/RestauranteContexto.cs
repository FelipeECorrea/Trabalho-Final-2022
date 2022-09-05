using Microsoft.EntityFrameworkCore;
using Repositorio.Entidades;
using Repositorio.Mapeamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.BancoDados
{
    public class RestauranteContexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        public RestauranteContexto(
         DbContextOptions<RestauranteContexto> options)
         : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMapeamento());
        }
            modelBuilder.ApplyConfiguration(new ProdutoMapeamento());

    }
}