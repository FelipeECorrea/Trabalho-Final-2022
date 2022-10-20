using Microsoft.EntityFrameworkCore;
using Repositorio.Entidades;
using Repositorio.Mapeamentos;

namespace Repositorio.BancoDados
{
    public class RestauranteContexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ProdutoPedido> ProdutosPedidos { get; set; }
        public DbSet<Administrador> Admisitradores { get; set; }
        //dotnet ef migrations add ModificarPrecisaoColunaValorTabelaProduto --project Repositorio --startup-project Aplicacao
        public RestauranteContexto(
         DbContextOptions<RestauranteContexto> options)
         : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
            * Documentação: https://docs.microsoft.com/pt-br/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli
            * Necessário instalar a ferramenta do dotnet ef core
            *      dotnet tool install --global dotnet-ef
            * 1ª etapa - Criar a entidade Raca.cs
            * 2ª etapa - Criar o mapemanto da entidade para tabela RacaMapeamento.cs
            * 3ª etapa - Registrar o mapeamento no próprio Contexto
            * 4ª etapa - Gerar a migration
            *      dotnet ef migrations add AdicionarMigration --project .\Repositorio --startup-project .\Aplicacao
            * 5ª etapa - A migration poderá ser aplicada de duas formas:
            *   - executar comando para aplicar a migration sem a
            *          necessidade de executar a aplicação
            *          dotnet ef database update --project Repositorio --startup-project .\Aplicacao
            *   - executar a aplicação irá aplicar a migration */

           // modelBuilder.Entity<Cliente>()
           //.HasIndex(p => new { p.Email })
           //.IsUnique(true);
            modelBuilder.ApplyConfiguration(new ClienteMapeamento());
            modelBuilder.ApplyConfiguration(new AdministradorMapeamento());
            modelBuilder.ApplyConfiguration(new ProdutoMapeamento());
            modelBuilder.ApplyConfiguration(new MesaMapeamento());
            modelBuilder.ApplyConfiguration(new PedidoMapeamento());
            modelBuilder.ApplyConfiguration(new ProdutoPedidoMapeamento());
        }
    }
}
