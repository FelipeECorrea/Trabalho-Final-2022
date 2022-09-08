using Microsoft.EntityFrameworkCore;
using Repositorio.Entidades;
using Repositorio.Mapeamentos;
using System;

namespace Repositorio.BancoDados
{
    public class RestauranteContexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ProdutoPedido> ProdutosPedidos { get; set; }

        public RestauranteContexto(
         DbContextOptions<RestauranteContexto> options)
         : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Cliente>()
           .HasIndex(p => new { p.Email, p.Senha })
           .IsUnique(true);
            modelBuilder.ApplyConfiguration(new ClienteMapeamento());   
            modelBuilder.ApplyConfiguration(new ProdutoMapeamento());
            modelBuilder.ApplyConfiguration(new PedidoMapeamento());
            modelBuilder.ApplyConfiguration(new MesaMapeamento());
        }
    }
}