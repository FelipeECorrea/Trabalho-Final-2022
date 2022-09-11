using Microsoft.Extensions.DependencyInjection;
using Servico.MapeamentoEntidades;
using Servico.MapeamentoViewModels;
using Servico.Servicos;

namespace Servico.InjecoesDependencia
{
    public static class ServicoExtensions
    {
        public static IServiceCollection AdicionarServicos(this IServiceCollection services)
        {
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IProdutoMapeamentoEntidade, ProdutoMapeamentoEntidade>();
            services.AddScoped<IProdutoViewModelMapeamentoViewModels, ProdutoViewModelMapeamentoViewModels>();
            
            services.AddScoped<IMesaService, MesaService>();
            services.AddScoped<IMesaMapeamentoEntidade, MesaMapeamentoEntidade>();
            services.AddScoped<IMesaViewModelMapeamentoViewModels, MesaViewModelMapeamentoViewModels>();

            services.AddScoped<IPedidoService, PedidoService>();
            services.AddScoped<IPedidoMapeamentoEntidade, PedidoMapeamentoEntidade>();
            services.AddScoped<IPedidoViewModelMapeamentoViewModels, PedidoViewModelMapeamentoViewModels>();

            return services;
        }

    }
}
