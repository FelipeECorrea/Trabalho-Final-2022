using Aplicacao.Helpers;
using Repositorio.Entidades;

namespace Aplicacao.Middlewares
{
    public class UserMiddleware
    {
        private readonly RequestDelegate _next;

        public UserMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext, ISessao sessao)
        {
            var area = httpContext.GetRouteData().Values["area"]?.ToString() ?? string.Empty;
            var action = httpContext.GetRouteData().Values["action"]?.ToString() ?? string.Empty;
            var controller = httpContext.GetRouteData().Values["controller"]?.ToString() ?? string.Empty;

            var client = sessao.BuscarSessaoDoUsuario<Cliente>();
            var administrador = sessao.BuscarSessaoDoUsuario<Administrador>();

            if (IsNotAuthenticatedAndRightAcessToArea(client, area, "Clientes") ||
               IsNotAuthenticatedAndRightAcessToArea(administrador, area, "Admin"))
            {
                httpContext.Response.Redirect("/login");
                return;
            }

            if (area == "Public" && controller == "Login" && action == "Sair")
            {
                await _next(httpContext);
            }

            if (IsAuthenticatedAndRightAccessToArea(client, area))
            {
                httpContext.Response.Redirect("/client");
            }

            if (IsAuthenticatedAndRightAccessToArea(administrador, area))
            {
                httpContext.Response.Redirect("/admin");
            }

            var usuarioLogado = sessao.BuscarSessaoDoUsuario<Cliente>();
            if (usuarioLogado != null)
            {
                httpContext.Items.Add("UsuarioNome", usuarioLogado.Nome);
            }

            var adminLogado = sessao.BuscarSessaoDoUsuario<Administrador>();
            if (adminLogado != null)
            {
                httpContext.Items.Add("AdminLogado", adminLogado.Nome);
            }

            await _next(httpContext);
        }
        private bool IsNotAuthenticatedAndRightAcessToArea(Usuario usuario, string area, string areaDesejada)
        {
            return usuario == null && area == areaDesejada;
        }

        private bool IsAuthenticatedAndRightAccessToArea(Usuario usuario, string area)
        {
            return usuario != null && area == "Public";
        }
    }
}
