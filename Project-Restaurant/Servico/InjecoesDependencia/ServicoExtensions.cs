using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositorio.BancoDados;
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
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IClienteMapeamentoEntidade, ClienteMapeamentoEntidade>();
            services.AddScoped<IClienteViewModelMapeamentoViewModel, ClienteViewModelMapeamentoViewModel>();

            return services;
        }

    }
}
