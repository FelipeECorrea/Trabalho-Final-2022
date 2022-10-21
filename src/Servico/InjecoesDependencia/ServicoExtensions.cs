using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Aplicacao.Helpers;
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
            services.AddScoped<IClienteMapeamentoViewModel, ClienteViewModelMapeamentoViewModel>();

            services.AddScoped<IPedidoService, PedidoService>();
            services.AddScoped<IPedidoMapeamentoEntidade, PedidoMapeamentoEntidade>();
            services.AddScoped<IPedidoServiceViewModelMapeamentoViewModels, PedidoViewModelMapeamentoViewModels>();

            services.AddScoped<IProdutoPedidoService, ProdutoPedidoService>();
            services.AddScoped<IProdutoPedidoMapeamentoEntidade, ProdutoPedidoMapeamentoEntidade>();
            services.AddScoped<IProdutoPedidoViewModelMapeamentoViewModels, ProdutoPedidoViewModelMapeamentoViewModels>();
            
            services.AddScoped<IAdministradorService, AdministradorService>();
            services.AddScoped<IAdministradorMapeamentoEntidade, AdministradorMapeamentoEntidade>();
            services.AddScoped<IAdministradorViewModelMapeamentoViewModels, AdministradorViewModelMapeamentoViewModels>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped<ISessao, Sessao>();

            services.AddSession(o =>
            {
                o.Cookie.HttpOnly = true;
                o.Cookie.IsEssential = true;
            });

            return services;
        }

    }
}
