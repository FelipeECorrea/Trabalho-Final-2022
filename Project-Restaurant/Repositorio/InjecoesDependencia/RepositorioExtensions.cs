using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositorio.BancoDados;
using Repositorio.Repositorios;

namespace Repositorio.InjecoesDependencia
{
    public static class RepositorioExtensions
    {
        public static IServiceCollection AdicionarRepositorios(this IServiceCollection services)
        {
            services.AddScoped<IClienteRepositorio, ClienteRepositorio>();
            services.AddScoped<IPedidoRepositorio, PedidoRepositorio>();
            services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
            services.AddScoped<IProdutoPedidoRepositorio, ProdutoPedidoRepositorio>();
            services.AddScoped<IMesaRepositorio, MesaRepositorio>();

            return services;
        }

        public static IServiceCollection AdicionarEntityFramework(
            this IServiceCollection services, ConfigurationManager configurationManager)
        {
            services.AddDbContext<RestauranteContexto>(options =>
                options.UseSqlServer(configurationManager.GetConnectionString("SqlServer")));

            return services;
        }
    }
}
